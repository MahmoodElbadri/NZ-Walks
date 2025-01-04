using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZ_Walks.api.IRepositories;
using NZ_Walks.api.Models.Domain;
using NZ_Walks.api.Models.DTO.WalkDTOs;

namespace NZ_Walks.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWalkRepository _repo;

        public WalksController(IMapper mapper, IWalkRepository _repo)
        {
            this._mapper = mapper;
            this._repo = _repo;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] WalkAddRequest walkAddRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Walk walk = _mapper.Map<Walk>(walkAddRequest);
            var createdWalk = await _repo.CreateAsync(walk);
            var walkResponse = _mapper.Map<WalkResponse>(createdWalk);
            return CreatedAtAction(nameof(GetWalk), new { id = createdWalk.Id }, walkResponse);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetWalk([FromRoute] Guid id)
        {
            if(id == Guid.Empty)
            {
                return BadRequest("Invalid Walk ID.");
            }
            var walk = await _repo.GetWalkAsync(id);
            if(walk == null)
            {
                return NotFound();
            }
            var walkResponse = _mapper.Map<WalkResponse>(walk);
            return Ok(walkResponse);
        }

        [HttpGet]
        public async Task <IActionResult> GetAll()
        {
            var walks = await _repo.GetAllAsync();
            var walkResponses = _mapper.Map<List<WalkResponse>>(walks);
            return Ok(walkResponses);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateWalk([FromRoute] Guid id, [FromBody] WalkUpdateRequest walkUpdateRequest)
        {
            var walk = _mapper.Map<Walk>(walkUpdateRequest);
            var updatedWalk = await _repo.UpdateAsync(id, walk);
            if(updatedWalk == null)
            {
                return NotFound();
            }
            var walkResponse = _mapper.Map<WalkResponse>(updatedWalk);
            return Ok(walkResponse);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteWalk([FromRoute] Guid id)
        {
            try
            {
                await _repo.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}
