using Application.Exceptions;
using Newtonsoft.Json;
using System.Net;
using WebApi.Errors;

namespace WebApi.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IHostEnvironment _environment;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, IHostEnvironment environment, ILogger<ExceptionMiddleware> _logger)
        {
            _next = next;
            _environment = environment;
            this._logger = _logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                _logger.LogInformation("Se ejecutó un endpoint");
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ocurrió un error en el invoke: {ex.Message}");
                context.Response.ContentType = "Application/json";
                var statusCode = (int) HttpStatusCode.InternalServerError;
                var result = string.Empty;
                switch (ex) 
                {
                    case NotFoundException notFoundException:
                        statusCode = (int) HttpStatusCode.NotFound;
                        break;
                    case ValidationException validationException:
                        statusCode = (int)HttpStatusCode.BadRequest;
                        var validationJson= JsonConvert.SerializeObject(validationException.Errors);
                        result = JsonConvert.SerializeObject(new CodeErrorException(statusCode, ex.Message, validationJson));
                        break;
                    case BadRequestException badRequestException:
                        statusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    default:
                        statusCode= (int) HttpStatusCode.InternalServerError; 
                        break;
                }

                context.Response.StatusCode = statusCode;
                if (_environment.IsProduction())
                {
                    if (string.IsNullOrEmpty(result))
                    {
                        result = JsonConvert.SerializeObject(new CodeErrorException(statusCode, ex.Message, ex.StackTrace));
                    }
                }
                else
                {
                    result = JsonConvert.SerializeObject(new { CodeErrorException = result, exception = ex });
                }
                await context.Response.WriteAsync(result);
            }
        }
    }
}
