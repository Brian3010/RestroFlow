using System.Net;

namespace RestroFlowAPI.Middlewares
{
  public class ExceptionHandlerMiddleware
  {
    private readonly ILogger<ExceptionHandlerMiddleware> _logger;
    private readonly RequestDelegate _next;

    public ExceptionHandlerMiddleware(ILogger<ExceptionHandlerMiddleware> logger, RequestDelegate next) {
      _logger = logger;
      _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext) {
      try {
        // wrap the httpContext in the try
        await _next(httpContext);
      } catch (Exception e) {
        // Log exception
        _logger.LogError(e, e.Message);

        // Return custom error response
        httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        httpContext.Response.ContentType = "application/json";

        var error = new {
          ErrorMessage = "Something went wrong! contact backend developer (me) :)"
        };

        await httpContext.Response.WriteAsJsonAsync(error);
      }
    }
  }
}
