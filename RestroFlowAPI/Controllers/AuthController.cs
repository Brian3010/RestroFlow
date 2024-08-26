using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestroFlowAPI.DTOs;
using RestroFlowAPI.Helpers;
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
    private readonly ICustomCookieManager _cookieManager;
    private readonly IRedisTokenService _redisTokenService;

    public AuthController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ITokenService tokenService, ILogger<AuthController> logger, ICustomCookieManager cookieManager, IRedisTokenService redisTokenService) {
      _userManager = userManager;
      _roleManager = roleManager;
      _tokenService = tokenService;
      _logger = logger;
      _cookieManager = cookieManager;
      _redisTokenService = redisTokenService;
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
      if (registerRequestDto.Roles == null || registerRequestDto.Roles.Length == 0) {

        foreach (string role in registerRequestDto.Roles!) {
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



      // Check if user exist
      if (user != null) {
        // if no deviceId exist, create a new one
        string? deviceId = _cookieManager.GetCookie(HttpContext, "deviceId");
        deviceId ??= Guid.NewGuid().ToString();

        // Check password
        if (await _userManager.CheckPasswordAsync(user, loginRequest.Password)) {
          var userRoles = await _userManager.GetRolesAsync(user);

          var accessToken = _tokenService.GenerateJwtToken(user, userRoles.ToList());
          var refreshToken = _tokenService.GenerateRefreshToken();
          _logger.LogInformation("refreshToken: {RefreshToken}", refreshToken);

          /* save refreshToken to the database*/
          //await _redisTokenService.RemoveAllRefeshToken(user.Id); 
          await _redisTokenService.AddRFToken(user.Id, refreshToken, deviceId);
          var tokens = await _redisTokenService.GetRFTokensByUserId(user.Id);
          _logger.LogInformation("tokens by userId-{user.Id}: {Tokens}", user.Id, tokens);

          // set Cookies for refreshToken and deviceId
          int COOKIE_EXPIRE_TIME = 10080; // 10080 = 1 week
          _cookieManager.SetCookie(HttpContext, "RefreshToken", refreshToken, COOKIE_EXPIRE_TIME); // 10080 = 1 week
          _cookieManager.SetCookie(HttpContext, "deviceId", deviceId, COOKIE_EXPIRE_TIME);
          var response = new LoginRepponseDto() {
            Message = "Login Successfully",
            AccessToken = accessToken,
            User = new UserDto { Id = user.Id, Email = user.Email, UserName = user.UserName }
          };

          return Ok(response);

        }
      }


      return BadRequest("Username or password incorrect!");

    }



    [HttpPost]
    [Route("refresh-token")]
    public async Task<IActionResult> RefreshAuthToken([FromBody] RFTokenRequestDto refreshTokenBody) {
      var userId = refreshTokenBody.userId;
      var deviceId = _cookieManager.GetCookie(HttpContext, "deviceId");
      // redirect if either null
      if (userId == null || deviceId == null) return CustomResponseCode.CreateResponse("Redirect to /login", 302);

      // check refreshToken exist in redis DB
      // if exist, create a new accessToken and refreshToken
      // accessToken sent back as response
      // refreshToken set in httpOnly Cookie

      return Ok(new { userId, deviceId });
    }



































  }
}
