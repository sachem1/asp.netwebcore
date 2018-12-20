using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWeb.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate request)
        {
            _next = request;
        }
        public Task Invoke(HttpContext context)
        {
            if (context.Request.Host.Value.Contains("localhost"))
            {
                context.Response.Cookies.Append("auth", "123456789");
                
            }
            return _next.Invoke(context);
        }
    }
}
