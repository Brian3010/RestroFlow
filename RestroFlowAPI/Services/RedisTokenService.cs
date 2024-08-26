using RestroFlowAPI.Interfaces;
using StackExchange.Redis;


/* redis table using hashes
 * 
 */
namespace RestroFlowAPI.Services
{
  public class RedisTokenService : IRedisTokenService
  {
    private readonly IDatabase _redisDb;

    public RedisTokenService(IConnectionMultiplexer connectionMultiplexer) {
      _redisDb = connectionMultiplexer.GetDatabase();
    }

    private string KEY(string userId, string deviceId) => $"user:{userId}:deviceId:{deviceId}";

    public async Task AddRFToken(string userId, string refreshToken, string deviceId) {

      int expirationInSeconds = (int)TimeSpan.FromDays(1).TotalSeconds;
      //int expirationInSeconds = (int)TimeSpan.FromSeconds(10).TotalSeconds;

      await _redisDb.StringSetAsync(KEY(userId, deviceId), refreshToken, TimeSpan.FromSeconds(expirationInSeconds));
    }

    public async Task<string?> GetRFTokenByDeviceId(string userId, string deviceId) {
      return await _redisDb.StringGetAsync(KEY(userId, deviceId));
    }

    public async Task<RedisValue[]> GetRFTokensByUserId(string userId) {
      var redisKeys = await GetKeysByUserId(userId);
      RedisValue[] tokens = new RedisValue[redisKeys.Length];

      for (int i = 0; i < redisKeys.Length; i++) {
        tokens[i] = await _redisDb.StringGetAsync(redisKeys[i]);
      }

      return tokens;
    }


    public async Task<bool> IsDeviceIdExist(string userId, string deviceId) {
      return await _redisDb.KeyExistsAsync(KEY(userId, deviceId));
    }

    public async Task<bool> IsRefreshTokenValid(string userId, string deviceId, string refreshToken) {
      var token = await GetRFTokenByDeviceId(userId, deviceId);
      return token != null && token == refreshToken;
    }

    public async Task RemoveAllRefeshToken(string userId) {
      var keys = await GetKeysByUserId(userId);
      foreach (var key in keys) {
        await _redisDb.KeyDeleteAsync(key);
      }
    }

    public async Task RemoveRefeshToken(string userId, string deviceId) {
      string redisKey = KEY(userId, deviceId);
      await _redisDb.KeyDeleteAsync(redisKey);
    }

    // Helper method to get all keys by userId
    private async Task<RedisKey[]> GetKeysByUserId(string userId) {
      var server = _redisDb.Multiplexer.GetServer(_redisDb.Multiplexer.GetEndPoints()[0]);
      return server.Keys(pattern: $"user:{userId}:deviceId:*").ToArray();
    }
  }
}
