using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZ_Walks.api.CustomActionFilter;
using NZ_Walks.api.Data;
using NZ_Walks.api.IRepositories;
using NZ_Walks.api.Models.Domain;
using NZ_Walks.api.Models.DTO.RegionDTOs;
using NZ_Walks.api.Repositories;
using System.Text.Json;

namespace NZ_Walks.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class RegionsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IRegionRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<RegionsController> _logger;

        public RegionsController(ApplicationDbContext db, IRegionRepository repo, IMapper _mapper,ILogger<RegionsController>logger)
        {
            this._db = db;
            _repo = repo;
            this._mapper = _mapper;
            this._logger = logger;
        }

        [HttpGet]
        //[Authorize(Roles = "User, Admin")]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Getting all regions");
            var regions = await //_db.Regions.ToListAsync();
            _repo.GetAllRegionsAsync();
            /*var regionResponses = new List<RegionResponse>();
            foreach (var region in regions)
            {
                regionResponses.Add(new RegionResponse()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    RegionImageUrl = region.RegionImageUrl
                });
            }*/

            var regionResponses = _mapper.Map<List<RegionResponse>>(regions);
            _logger.LogInformation($"Returning all regions{JsonSerializer.Serialize(regionResponses)}");
            return Ok(regionResponses);
        }

        [HttpGet("{id:guid}")]
        [Authorize(Roles = "User, Admin")]
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
            /* //var regionResponse = new RegionResponse()
             //{
             //    Id = region.Id,
             //    Code = region.Code,
             //    Name = region.Name,
             //    RegionImageUrl = region.RegionImageUrl
             //};*/

            var regionResponse = _mapper.Map<RegionResponse>(region);
            return Ok(regionResponse);
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddRegion([FromBody] RegionAddRequest regionAddRequest)
        {
            /*var region = new Region()
{
Code = regionAddRequest.Code,
Name = regionAddRequest.Name,
RegionImageUrl = regionAddRequest.RegionImageUrl
};*/

            var region = _mapper.Map<Region>(regionAddRequest);
            var createdRegion = await // _db.Regions.AddAsync(region);
                 _repo.CreateRegionAsync(region);
            /* var regionResponse = new RegionResponse()
             {
                 Id = createdRegion.Id,
                 Code = createdRegion.Code,
                 Name = createdRegion.Name,
                 RegionImageUrl = createdRegion.RegionImageUrl
             };*/

            var regionResponse = _mapper.Map<RegionResponse>(createdRegion);
            return CreatedAtAction(nameof(GetRegion), new { id = region.Id }, regionResponse);
        }


        [HttpPut("{id:guid}")]
        [Authorize(Roles = "Admin")]
        [ValidateModel]
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

            /*var regionResponse = new RegionResponse
            {
                Id = updatedRegion!.Id,
                Code = updatedRegion.Code,
                Name = updatedRegion.Name,
                RegionImageUrl = updatedRegion.RegionImageUrl
            };*/

            var regionResponse = _mapper.Map<RegionResponse>(updatedRegion);

            return Ok(regionResponse);
        }

        [HttpDelete("{id:guid}")]
        [Authorize(Roles = "Admin")]
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
