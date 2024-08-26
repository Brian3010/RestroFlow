using RestroFlowAPI.Interfaces;

namespace RestroFlowAPI.Services
{
  public class CookiesManager : ICustomCookieManager
  {

    public bool CookieExists(HttpContext httpContext, string key) {
      return httpContext.Request.Cookies.ContainsKey(key);
    }

    public void DeleteCookie(HttpContext httpContext, string key) {
      httpContext.Response.Cookies.Delete(key);
    }

    public string? GetCookie(HttpContext httpContext, string key) {
      httpContext.Request.Cookies.TryGetValue(key, out string? value);
      return value;
    }

    public void SetCookie(HttpContext httpContext, string key, string value, int? expireTimeInMinutes = null, bool isHttpOnly = true, bool isSecure = true) {
      var cookieOptions = new CookieOptions {
        HttpOnly = isHttpOnly,
        Secure = isSecure,
        SameSite = SameSiteMode.Strict // Adjust as needed
      };

      if (expireTimeInMinutes.HasValue)
        cookieOptions.Expires = DateTime.UtcNow.AddMinutes(expireTimeInMinutes.Value);
      else
        cookieOptions.Expires = DateTime.Now.AddHours(1); // if no expireTime provided

      httpContext.Response.Cookies.Append(key, value, cookieOptions);
    }
  }
}
