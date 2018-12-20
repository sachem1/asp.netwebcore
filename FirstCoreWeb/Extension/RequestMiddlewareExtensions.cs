using FirstCoreWeb.Middleware;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWeb.Extension
{
    public static class RequestMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestExceptionMiddle(this IApplicationBuilder builder)
        {

            
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
