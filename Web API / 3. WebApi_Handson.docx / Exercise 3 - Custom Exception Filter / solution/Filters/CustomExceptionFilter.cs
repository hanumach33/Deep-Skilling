using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeAPI.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        string path = "ErrorLog.txt";

        File.AppendAllText(
            path,
            $"[{DateTime.Now}] {context.Exception.Message}{Environment.NewLine}");

        context.Result = new ObjectResult(new
        {
            StatusCode = 500,
            Message = "Internal Server Error",
            Error = context.Exception.Message
        })
        {
            StatusCode = StatusCodes.Status500InternalServerError
        };

        context.ExceptionHandled = true;
    }
}
