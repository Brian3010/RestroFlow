using StackExchange.Redis;

namespace RestroFlowAPI.Interfaces
{
  public interface IRedisTokenService
  {
    Task SetRFToken(string key, string value, TimeSpan expiryTimeSpan);

    Task<bool> RemoveTokenbyUserId(string id, string refreshToken);

    Task<RedisValue[]> GetRFTokenByUserId(string id);
  }
}
