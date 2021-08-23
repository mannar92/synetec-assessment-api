using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SynetecAssessmentApi.Persistence.Exceptions.CustomExceptions;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Persistence.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _log;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> log)
        {
            _log = log;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var ErrorMessage = "";

            if (exception is DbUpdateException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                ErrorMessage = "Database update error.";

                _log.LogError($"DbUpdateException: {exception.Message}");
            }
            else if (exception is InvalidOperationException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                ErrorMessage = "Invalid Operation.";

                _log.LogError($"InvalidOperationException: {exception.Message}");
            }
            else if (exception is SystemException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                ErrorMessage = "System Exception.";

                _log.LogError($"SystemException: {exception.Message}");
            }
            else if
            (
                exception is EmployeeNotFoundException
            )
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                ErrorMessage = exception.Message;

                _log.LogError($"EmployeeNotFoundException: {exception.Message}");
            }
            else
            {
                ErrorMessage = "General Exception.";
                _log.LogError($"GeneralException: {exception.Message}");
                ErrorMessage = exception.Message;
            }

            return context.Response.WriteAsync(new ErrorDetailsModel()
            {
                StatusCode = context.Response.StatusCode,
                Message = ErrorMessage
            }.ToString());
        }
    }
}
