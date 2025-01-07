using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NZ_Walks.api.Models.DTO.AuthDTOs;
using NZ_Walks.api.Models.DTO.RegionDTOs;

namespace NZ_Walks.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AuthController(UserManager<IdentityUser> userManager)
        {
            this._userManager = userManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody]RegisterAddRequest registerAddRequest)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerAddRequest.UserName,
                Email = registerAddRequest.UserName,
            };
            var identityResult = await _userManager.CreateAsync(identityUser,registerAddRequest.Password);
            if (identityResult.Succeeded)
            {
                if (registerAddRequest.Roles != null && registerAddRequest.Roles.Any())
                {
                    identityResult = await _userManager.AddToRolesAsync(identityUser, registerAddRequest.Roles);
                    if (identityResult.Succeeded)
                    {
                        return Ok("Registeration Done Successfully");
                    }
                }
            }
            return BadRequest("Something went wrong");
        }
    }
}
