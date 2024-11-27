namespace RestroFlowAPI.Interfaces
{
  public interface ICustomCookieManager
  {
    /// <param name="key">The key of the cookie.</param>
    /// <param name="value">The value of the cookie.</param>
    /// <param name="expireTimeInMinutes">The expiration time in minutes. If null, a default value is used.</param>
    /// <param name="isHttpOnly">Indicates whether the cookie should be HttpOnly.</param>
    /// <param name="isSecure">Indicates whether the cookie should be Secure (sent over HTTPS only).</param>
    void SetCookie(HttpContext httpContext, string key, string value, int? expireTimeInMinutes = null, bool isHttpOnly = true, bool isSecure = true);

    /// <param name="key">The key of the cookie.</param>
    /// <returns>The value of the cookie if it exists, otherwise null.</returns>
    string? GetCookie(HttpContext httpContext, string key);

    /// <param name="key">The key of the cookie to delete.</param>
    void DeleteCookie(HttpContext httpContext, string key);

    /// <param name="key">The key of the cookie.</param>
    /// <returns>True if the cookie exists, otherwise false.</returns>
    bool CookieExists(HttpContext httpContext, string key);

    void DeleteCookiesByName(HttpContext httpContext, List<string> cookieNames);

    void DeactivateCookiesByName(HttpContext httpContext, List<string> cookieNames);

  }
}
