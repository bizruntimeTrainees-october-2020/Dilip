using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeOnASP
{
    class startupcs
    {
        public void ConfigurationServices(IServiceCollection service)
        {

        }
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
              endpoints.MapGet("/",  async context =>
                {
                    await context.Response.WriteAsync("hello from biz run time");

                });
            });
        }

        private Task asyc(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
