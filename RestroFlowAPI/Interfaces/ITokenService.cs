using Microsoft.AspNetCore.Identity;

namespace RestroFlowAPI.Interfaces
{
  public interface ITokenService
  {
    string GenerateJwtToken(IdentityUser user, List<string> roles, int TTLInMinute);

    string GenerateRefreshToken();

  }
}
