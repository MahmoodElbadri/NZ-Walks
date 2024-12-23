using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZ_Walks.api.Data;
using NZ_Walks.api.IRepositories;
using NZ_Walks.api.Models.Domain;
using NZ_Walks.api.Models.DTO;
using NZ_Walks.api.Repositories;

namespace NZ_Walks.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IRegionRepository _repo;

        public RegionsController(ApplicationDbContext db, IRegionRepository repo)
        {
            this._db = db;
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regions = await //_db.Regions.ToListAsync();
            _repo.GetAllRegionsAsync();
            var regionResponses = new List<RegionResponse>();
            foreach (var region in regions)
            {
                regionResponses.Add(new RegionResponse()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    RegionImageUrl = region.RegionImageUrl
                });
            }
            return Ok(regionResponses);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetRegion([FromRoute] Guid id)
        {
            var region = //_db.Regions.Find(id);
                         //_db.Regions.FirstOrDefault(tmp=>tmp.Id == id);
                         //await _db.Regions.Where(tmp => tmp.Id == id).FirstOrDefaultAsync();
               await _repo.GetRegionAsync(id);
            if (region == null)
            {
                return NotFound();
            }
            var regionResponse = new RegionResponse()
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };
            return Ok(regionResponse);
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion([FromBody] RegionAddRequest regionAddRequest)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            var region = new Region()
            {
                Code = regionAddRequest.Code,
                Name = regionAddRequest.Name,
                RegionImageUrl = regionAddRequest.RegionImageUrl
            };
            var createdRegion = await // _db.Regions.AddAsync(region);
                 _repo.CreateRegionAsync(region);
            var regionResponse = new RegionResponse()
            {
                Id = createdRegion.Id,
                Code = createdRegion.Code,
                Name = createdRegion.Name,
                RegionImageUrl = createdRegion.RegionImageUrl
            };
            return CreatedAtAction(nameof(GetRegion), new { id = region.Id }, regionResponse);
        }


        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateRegion([FromRoute] Guid id, [FromBody] RegionUpdateRequest regionUpdateRequest)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            var region = await _repo.GetRegionAsync(id); 

            if (region == null)
            {
                return NotFound();
            }

            region.Code = regionUpdateRequest.Code; 
            region.Name = regionUpdateRequest.Name;
            region.RegionImageUrl = regionUpdateRequest.RegionImageUrl;

            var updatedRegion = await _repo.UpdateRegionAsync(id, region); 

            var regionResponse = new RegionResponse
            {
                Id = updatedRegion!.Id,
                Code = updatedRegion.Code,
                Name = updatedRegion.Name,
                RegionImageUrl = updatedRegion.RegionImageUrl
            };

            return Ok(regionResponse);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteRegion([FromRoute] Guid id)
        {
            var region = await //_db.Regions.FirstOrDefaultAsync(tmp => tmp.Id == id);
                _repo.GetRegionAsync(id);
            if (region == null)
            {
                return NotFound();
            }
            //_db.Regions.Remove(region);
            //await _db.SaveChangesAsync();

            await _repo.DeleteRegionAsync(id);
            return NoContent();
        }
    }
}
