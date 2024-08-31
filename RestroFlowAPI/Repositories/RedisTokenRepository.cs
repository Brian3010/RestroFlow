using RestroFlowAPI.Repositories.Interfaces;
using StackExchange.Redis;


/* redis table using hashes
 * 
 */
namespace RestroFlowAPI.Repositories
{
  public class RedisTokenRepository : IRedisTokenRepository
  {
    private readonly IDatabase _redisDb;
    private readonly ILogger<RedisTokenRepository> _logger;

    public RedisTokenRepository(IConnectionMultiplexer connectionMultiplexer, ILogger<RedisTokenRepository> logger) {
      _redisDb = connectionMultiplexer.GetDatabase();
      _logger = logger;
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
      var redisKeys = GetKeysByUserId(userId);
      RedisValue[] tokens = new RedisValue[redisKeys.Length];

      for (int i = 0; i < redisKeys.Length; i++) {
        tokens[i] = await _redisDb.StringGetAsync(redisKeys[i]);
      }

      return tokens;
    }

    public List<string> GetDeviceIdsByUserId(string userId) {
      var redisKeys = GetKeysByUserId(userId);
      var deviceIds = new List<string>();

      foreach (var key in redisKeys) {
        var parts = key.ToString().Split(":");
        //_logger.LogInformation($"deviceId: {parts[3]}");
        deviceIds.Add(parts[3]);

      }

      return deviceIds;
    }


    public async Task<bool> IsDeviceIdOrUserIdExist(string userId, string deviceId) {
      return await _redisDb.KeyExistsAsync(KEY(userId, deviceId));
    }

    public async Task<bool> IsRefreshTokenValid(string userId, string deviceId, string refreshToken) {
      var token = await GetRFTokenByDeviceId(userId, deviceId);
      return token != null && token == refreshToken;
    }

    public async Task RemoveAllRefeshToken(string userId) {
      var keys = GetKeysByUserId(userId);
      foreach (var key in keys) {
        await _redisDb.KeyDeleteAsync(key);
      }
    }

    public async Task RemoveRefreshToken(string userId, string deviceId) {
      string redisKey = KEY(userId, deviceId);
      // remove this will also remove deviceId and userId
      await _redisDb.KeyDeleteAsync(redisKey);
    }


    // Helper method to get all keys by userId
    private RedisKey[] GetKeysByUserId(string userId) {
      var server = _redisDb.Multiplexer.GetServer(_redisDb.Multiplexer.GetEndPoints()[0]);
      return server.Keys(pattern: $"user:{userId}:deviceId:*").ToArray();
    }


  }
}
