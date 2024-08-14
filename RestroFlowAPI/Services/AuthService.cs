using Microsoft.AspNetCore.Identity;

namespace RestroFlowAPI.Services
{
  public class AuthService
  {
    private readonly IConfiguration _configuration;

    public AuthService(IConfiguration configuration) {
      _configuration = configuration;
    }

    public string GenerateJwtToken(IdentityUser user, List<IdentityRole> role) {

      return "";
    }
  }
}
