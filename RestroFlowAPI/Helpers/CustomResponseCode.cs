using Microsoft.AspNetCore.Mvc;

namespace RestroFlowAPI.Helpers
{
  public static class CustomResponseCode
  {
    public static ObjectResult CreateResponse(string message, int statusCode) {
      return new ObjectResult(new { Message = message }) {
        StatusCode = statusCode
      };
    }
  }
}
