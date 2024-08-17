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
    private readonly ILogger<AuthController> _logger;

    public AuthController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ITokenService tokenService, ILogger<AuthController> logger) {
      _userManager = userManager;
      _roleManager = roleManager;
      _tokenService = tokenService;
      _logger = logger;
    }

    // POST: /api/Auth/register
    [HttpPost]
    [Route("register")]

    public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto) {
      //Todo: Check match password and confirmPassword


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
          return Ok("Registered succesffully");
        }
      }

      return BadRequest(identityResult.Errors);

    }


    // POST: /api/Auth/login
    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequest) {
      var user = await _userManager.FindByEmailAsync(loginRequest.UserName);



      if (user != null) {
        if (await _userManager.CheckPasswordAsync(user, loginRequest.Password)) {
          var userRoles = await _userManager.GetRolesAsync(user);

          //TODO: store RefreshToken in Cookie and database (redis or firebase)

          var jwtToken = _tokenService.GenerateJwtToken(user, userRoles.ToList());
          var response = new LoginRepponseDto() {
            Message = "Login Successfully",
            AccessToken = jwtToken,
            UserId = user.Id,
            UserName = user.UserName!,
            UserEmail = user.Email!
          };

          return Ok(response);
        }
      }


      return BadRequest("Username or password incorrect!");

    }


































  }
}
