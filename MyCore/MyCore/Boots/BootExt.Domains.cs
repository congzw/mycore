using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MyCore
{
    public static class MyClass
    {
        public static void AddMyCors(this IServiceCollection services)
        {

        }
    }
    // public static class BootExt
    //{
    //    public static void AddMyCors(this IServiceCollection services)
    //    {
    //        services.AddCors(config =>
    //        {
    //            var corsPolicy = new CorsPolicy();
    //            corsPolicy.Headers.Add("*");
    //            corsPolicy.Methods.Add("*");
    //            //corsPolicy.Origins.Add("*");
    //            corsPolicy.IsOriginAllowed = host => { return true; };
    //            corsPolicy.SupportsCredentials = true;
    //            config.AddPolicy("policy", corsPolicy);
    //        });
    //    }

    //    public static void UseMyCors(this IApplicationBuilder app)
    //    {
    //        app.UseCors("policy");
    //    }
    //}
}
