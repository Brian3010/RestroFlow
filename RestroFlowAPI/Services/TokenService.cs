using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using RestroFlowAPI.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace RestroFlowAPI.Services
{
  public class TokenService : ITokenService
  {
    private readonly IConfiguration _configuration;

    public TokenService(IConfiguration configuration) {
      _configuration = configuration;
    }

    public string GenerateJwtToken(IdentityUser user, List<string> roles) {
      // Create claims
      var claims = new List<Claim>();

      // Add a claim for the user's email
      claims.Add(new Claim(ClaimTypes.Email, user.Email));

      // Add a claim for each role the user belongs to
      foreach (var role in roles) {
        claims.Add(new Claim(ClaimTypes.Role, role));
      }

      // Generate a symmetric security key from the secret key
      var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SigningKey"]));

      // Create signing credentials using the security key and SHA-256 algorithm
      var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

      // Create the JWT token with issuer, audience, claims, expiration time, and signing credentials
      var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims,
        expires: DateTime.Now.AddMinutes(15),
        signingCredentials: credentials
        );

      // Serialize the token to a string and return it
      return new JwtSecurityTokenHandler().WriteToken(token);

    }
  }
}
