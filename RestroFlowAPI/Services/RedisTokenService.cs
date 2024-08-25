using RestroFlowAPI.Interfaces;
using StackExchange.Redis;


/* redis table
 * user123(key) {device1:token123, device2:token345}
 * user456(key) {device1:token121, device2:token345}
 * user789(key) {device1:token123, device2:token345}
 */
namespace RestroFlowAPI.Services
{
  public class RedisTokenService : IRedisTokenService
  {
    private readonly IDatabase _redisDb;

    public RedisTokenService(IConnectionMultiplexer connectionMultiplexer) {
      _redisDb = connectionMultiplexer.GetDatabase();
    }

    public async Task AddRFToken(string userId, string refreshToken, string deviceId) {
      // Combine deviceId and refreshToken into a single value
      string tokenData = $"{deviceId}:{refreshToken}";

      // Remove any existing token for the device if any
      await RemoveRefeshToken(userId, deviceId);

      // Add the new token to the Redis Set
      await _redisDb.SetAddAsync(userId, tokenData);
    }

    public async Task<string?> GetRFTokenByDeviceId(string userId, string deviceId) {
      var refreshTokens = await _redisDb.SetMembersAsync(userId);

      foreach (var token in refreshTokens) {
        var parts = token.ToString().Split(':');
        if (parts[0] == deviceId) {
          return parts[1];
        }
      }
      return null;
    }

    public async Task<RedisValue[]> GetRFTokensByUserId(string userId) {
      return await _redisDb.SetMembersAsync(userId);
    }

    public async Task<bool> IsRefreshTokenValid(string userId, string deviceId, string refreshToken) {
      var tokenData = $"{deviceId}:{refreshToken}";
      return await _redisDb.SetContainsAsync(userId, tokenData);
    }

    public async Task RemoveAllRefeshToken(string userId) {
      await _redisDb.KeyDeleteAsync(userId);
    }

    public async Task RemoveRefeshToken(string userId, string deviceId) {
      // get tokens by userId return {device1:token123, device2:token345}
      var refreshTokens = await _redisDb.SetMembersAsync(userId);

      // 
      foreach (var token in refreshTokens) {
        if (token.ToString().StartsWith($"{deviceId}:")) {
          await _redisDb.SetRemoveAsync(userId, token);
        }
      }
    }
  }
}
