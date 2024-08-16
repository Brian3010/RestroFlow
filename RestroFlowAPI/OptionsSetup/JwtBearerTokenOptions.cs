using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace RestroFlowAPI.OptionsSetup
{
  public class JwtBearerTokenOptions : IConfigureNamedOptions<JwtBearerOptions>
  {
    private readonly IConfiguration _configuration;

    public JwtBearerTokenOptions(IConfiguration configuration) {
      _configuration = configuration;

    }

    public void Configure(string? name, JwtBearerOptions options) {
      var key = _configuration["Jwt:SigningKey"];
      options.TokenValidationParameters = new TokenValidationParameters {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = _configuration["Jwt:Issuer"],
        ValidAudience = _configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
      };
    }

    public void Configure(JwtBearerOptions options) => Configure(Options.DefaultName, options);
  }
}
