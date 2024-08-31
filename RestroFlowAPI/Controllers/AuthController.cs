using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestroFlowAPI.DTOs;
using RestroFlowAPI.Helpers;
using RestroFlowAPI.Interfaces;
using RestroFlowAPI.Models.DTOs;
using RestroFlowAPI.Repositories.Interfaces;

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
    private readonly IRedisTokenRepository _redisTokenRepository;

    public AuthController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ITokenService tokenService, ILogger<AuthController> logger, ICustomCookieManager cookieManager, IRedisTokenRepository redisTokenRepository) {
      _userManager = userManager;
      _roleManager = roleManager;
      _tokenService = tokenService;
      _logger = logger;
      _cookieManager = cookieManager;
      _redisTokenRepository = redisTokenRepository;
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
          await _redisTokenRepository.AddRFToken(user.Id, refreshToken, deviceId);
          var tokens = await _redisTokenRepository.GetRFTokensByUserId(user.Id);
          _logger.LogInformation("tokens by userId-{0}: {1}", user.Id, tokens);

          // set Cookies for refreshToken, userId and deviceId 
          int COOKIE_EXPIRE_TIME = 10080; // 10080 = 1 week
          _cookieManager.SetCookie(HttpContext, "rfToken", refreshToken, COOKIE_EXPIRE_TIME); // 10080 = 1 week
          _cookieManager.SetCookie(HttpContext, "deviceId", deviceId, COOKIE_EXPIRE_TIME);
          _cookieManager.SetCookie(HttpContext, "userId", user.Id, COOKIE_EXPIRE_TIME, false);

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

    /*
       * Get refreshToken, deviceId, userId from cookies
       * check if refreshToken exist in RedisDB using deviceId and userId, if not return
       * if yes, create a new accessToken and refreshToken
       * save userId, deviceId and refreshToken in RedisDB
       * send accessToken back to client using LoginRepponseDto 
       * set refreshToken in httpOnly cookies
       */
    [HttpPost]
    [Route("refresh-token")]
    public async Task<IActionResult> RefreshAuthToken() {
      var deviceId = _cookieManager.GetCookie(HttpContext, "deviceId");
      var userId = _cookieManager.GetCookie(HttpContext, "userId");
      var refreshToken = _cookieManager.GetCookie(HttpContext, "rfToken");


      // redirect if either null
      if (userId == null || deviceId == null || refreshToken == null) return CustomResponseCode.CreateResponse("Redirect to /login", 302);

      if (!await _redisTokenRepository.IsDeviceIdOrUserIdExist(userId, deviceId))
        return CustomResponseCode.CreateResponse("userId or deviceId not found", 404);

      if (!await _redisTokenRepository.IsRefreshTokenValid(userId, deviceId, refreshToken))
        return CustomResponseCode.CreateResponse("refreshToken not exist in the database", 404);

      // Search user infor in the database
      var user = await _userManager.FindByIdAsync(userId);
      if (user == null) {
        return CustomResponseCode.CreateResponse("userId not exist in the database (SQL)", 404);
      }
      var userRoles = await _userManager.GetRolesAsync(user);

      // Create a new accessToken and refreshToken
      var newAccessToken = _tokenService.GenerateJwtToken(user, [.. userRoles]);
      var newRefreshToken = _tokenService.GenerateRefreshToken();

      // Add new refreshToken to Redis
      await _redisTokenRepository.AddRFToken(user.Id, newRefreshToken, deviceId);
      var tokens = await _redisTokenRepository.GetRFTokensByUserId(user.Id);
      _logger.LogInformation("tokens by userId-{0}: {1}", user.Id, tokens);

      //
      int COOKIE_EXPIRE_TIME = 10080; // 10080 = 1 week
      _cookieManager.SetCookie(HttpContext, "rfToken", newRefreshToken, COOKIE_EXPIRE_TIME);

      var response = new LoginRepponseDto() {
        Message = "Refresh token Successfully",
        AccessToken = newAccessToken,
        User = new UserDto { Id = user.Id, Email = user.Email, UserName = user.UserName }
      };

      return Ok(response);
    }


    /*
      * Detete user associated data in redis
      * clear cookies
      */





































  }
}
