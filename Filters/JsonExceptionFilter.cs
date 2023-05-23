using LandonAPI2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using System.Runtime.CompilerServices;

namespace LandonAPI2.Filters
{
    public class JsonExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _env;
        public JsonExceptionFilter(IHostEnvironment env)
        {
            _env = env;
        }
        public void OnException(ExceptionContext context)
        {
            
            var error = new ApiError();
            if(_env.IsDevelopment())
            {
                error.Message = context.Exception.Message;
                error.Detail = context.Exception.StackTrace;
            }
            else
            {
                error.Message = "Server error Occured";
                error.Detail += context.Exception.Message;
            }
            

            context.Result = new ObjectResult(error)
            {
                StatusCode = 500
            };
        }
    }
}
