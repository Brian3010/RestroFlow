using StackExchange.Redis;

namespace RestroFlowAPI.Interfaces
{
  public interface IRedisTokenService
  {
    // storing a refresh token associated with a specific userId and deviceId
    Task AddRFToken(string userId, string refreshToken, string deviceId);

    // retrieves all refresh tokens associated with a specific userId
    Task<RedisValue[]> GetRFTokensByUserId(string userId);

    // Retrieves the refresh token for a specific deviceId under a given userId. 
    Task<string?> GetRFTokenByDeviceId(string userId, string deviceId);

    public List<string> GetDeviceIdsByUserId(string userId);

    // checks whether a given refresh token is valid for a specific userId and deviceId.
    Task<bool> IsRefreshTokenValid(string userId, string deviceId, string refreshToken);

    // This function removes a specific refresh token for a given deviceId and userId
    Task RemoveRefreshToken(string userId, string deviceId);

    // removes all refresh tokens associated with a specific userId
    Task RemoveAllRefeshToken(string userId);

    // check if user's device already exist in the database
    Task<bool> IsDeviceIdOrUserIdExist(string userId, string deviceId);

  }
}
