using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZ_Walks.api.Data;
using NZ_Walks.api.Models.Domain;
using NZ_Walks.api.Models.DTO;

namespace NZ_Walks.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public RegionsController(ApplicationDbContext db)
        {
            this._db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = _db.Regions.ToList();
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
        public IActionResult GetRegion([FromRoute] Guid id)
        {
            var region = //_db.Regions.Find(id);
                         //_db.Regions.FirstOrDefault(tmp=>tmp.Id == id);
                _db.Regions.Where(tmp => tmp.Id == id).FirstOrDefault();
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
        public IActionResult AddRegion([FromBody] RegionAddRequest regionAddRequest)
        {
            if(ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            var region = new Region()
            {
                Code = regionAddRequest.Code,
                Name = regionAddRequest.Name,
                RegionImageUrl = regionAddRequest.RegionImageUrl
            };
            _db.Regions.Add(region);
            _db.SaveChanges();
            var regionResponse = new RegionResponse()
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };
            return CreatedAtAction(nameof(GetRegion), new { id = region.Id }, regionResponse);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateRegion([FromRoute] Guid id, [FromBody] RegionUpdateRequest regionUpdateRequest)
        {
            if(ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            var region = _db.Regions.Find(id);
            if(region == null)
            {
                return NotFound();
            }
            region.RegionImageUrl = regionUpdateRequest.RegionImageUrl;
            region.Code = regionUpdateRequest.Code;
            region.Name = regionUpdateRequest.Name;
            _db.SaveChanges();
            var regionResponse = new RegionResponse()
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };
            return Ok(regionResponse);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteRegion([FromRoute] Guid id)
        {
            var region = _db.Regions.FirstOrDefault(tmp=>tmp.Id == id);
            if (region == null)
            {
                return NotFound();
            }
            _db.Regions.Remove(region);
            _db.SaveChanges();
            //return NoContent();
            return NoContent();
        }
    }
}
