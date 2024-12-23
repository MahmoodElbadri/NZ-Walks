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
    }
}
