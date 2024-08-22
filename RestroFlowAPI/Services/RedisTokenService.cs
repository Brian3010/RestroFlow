using Microsoft.Extensions.Caching.Distributed;
using RestroFlowAPI.Interfaces;
using StackExchange.Redis;

namespace RestroFlowAPI.Services
{
  public class RedisTokenService : IRedisTokenService
  {
    //private readonly IDistributedCache _distributedCache; // use this for caching
    private readonly IDatabase _redisDb;

    public RedisTokenService(IDistributedCache distributedCache, IConnectionMultiplexer connectionMultiplexer) {
      //_distributedCache = distributedCache;
      _redisDb = connectionMultiplexer.GetDatabase();
    }


    public async Task<string> GetRFTokenByUserId(string id) {
      string key = $"userId-{id}";

      string? tokenValue = await _redisDb.StringGetAsync(key);
      if (string.IsNullOrEmpty(tokenValue)) {
        return "";
      }

      return tokenValue;
    }

    public Task RemoveTokenbyUserId(string id) {



      throw new NotImplementedException();
    }

    public Task SetRFToken(string key, string value, TimeSpan expiryTimeSpan) {

      //Validate the incoming refresh token.
      //If valid, generate a new refresh token.
      //Replace the old refresh token with the new one in Redis.
      //Return the new token to the client.
      //The old token is immediately invalidated, and only the new token can be used for future requests.'
      // Set new value will remove the old one


      throw new NotImplementedException();
    }
  }
}
