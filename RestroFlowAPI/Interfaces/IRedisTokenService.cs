namespace RestroFlowAPI.Interfaces
{
  public interface IRedisTokenService
  {
    Task SetRFToken(string key, string value, TimeSpan expiryTimeSpan);

    Task RemoveTokenbyUserId(string id);

    Task<string> GetRFTokenByUserId(string id);
  }
}
