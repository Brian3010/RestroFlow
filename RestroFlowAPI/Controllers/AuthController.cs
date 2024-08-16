using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestroFlowAPI.Interfaces;
using RestroFlowAPI.Models.DTOs;

namespace RestroFlowAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ITokenService _tokenService;

    public AuthController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ITokenService tokenService) {
      _userManager = userManager;
      _roleManager = roleManager;
      _tokenService = tokenService;
    }

    // POST: /api/Auth/register
    [HttpPost]
    [Route("register")]

    public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto) {

      var identityUser = new IdentityUser() {
        UserName = registerRequestDto.UserName,
        Email = registerRequestDto.UserName
      };

      // Check if role exist
      if (registerRequestDto.Roles != null || registerRequestDto.Roles.Count() == 0) {

        foreach (string role in registerRequestDto.Roles) {
          if (!await _roleManager.RoleExistsAsync(role)) {
            return BadRequest($"Role '{role}' does not exist.");
          }
        }
      }

      // Register user
      var identityResult = await _userManager.CreateAsync(identityUser, registerRequestDto.Password);

      if (identityResult.Succeeded) {
        // Add roles to user
        identityResult = await _userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);
        if (identityResult.Succeeded) {
          // generate Token
          var jwtToken = _tokenService.GenerateJwtToken(identityUser, registerRequestDto.Roles.ToList());

          var response = new LoginRepponseDto() {
            JwtToken = jwtToken,
            Message = "Succesffully Register"
          };

          return Ok(response);
        }
      }



      return BadRequest(identityResult.Errors);

    }

    //[HttpPost]
    //[Route("login")]
    //public Task<IActionResult> Login([FromBody] LoginRequestDto) {



    //}


































  }
}
