using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recipe_API.Dto.Authentication;
using Recipe_API.Dto.Common;

namespace Recipe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private UserManager<IdentityUser> _userManager;
        private IConfiguration _configuration;

        public AuthenticationController(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO dto)
        {
            var userExists = await _userManager.FindByNameAsync(dto.UserName);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseDTO
                {
                    Status = "Error",
                    Message = "User already exists!"
                });
            IdentityUser user = new()
            {
                Email = dto.UserName,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = dto.UserName
            };
            var result = await _userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseDTO
                {
                    Status = "Error",
                    Message = "User creation failed! Please check user details and try again."
                });
            return Ok(new ResponseDTO { 
                Status = "Success", 
                Message = "User created successfully!" 
                });
        }
    }
}
