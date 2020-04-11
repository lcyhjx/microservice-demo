using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Polly;
using Ocelot.Cache.CacheManager;
using Microsoft.AspNetCore.Http;
using Ocelot.Administration;
using Ocelot.Provider.Consul;
//using Ocelot.Provider.Consul;
//using Ocelot.ConfigAuthLimitCache.DependencyInjection;
//using Ocelot.ConfigAuthLimitCache.Middleware;

namespace ocelot_gateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<FakeDepdendency>();

            services.AddOcelot()
                .AddConsul()
                .AddPolly()
                .AddCacheManager(x =>
                {                    
                    x.WithDictionaryHandle();
                })
                .AddSingletonDefinedAggregator<FakeDefinedAggregator>()
                //.AddDelegatingHandler<FakeHandler>();
                //.AddAdministration("/admin","secret")                                
                ;
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //注入中间件
            var configuration = new OcelotPipelineConfiguration
            {
                PreErrorResponderMiddleware = async (ctx, next) =>
                {
                    ctx.HttpContext.Request.Headers.Add("myreq", "ocelot-request");
                    await next.Invoke();
                }
            };
            app.UseOcelot(configuration).Wait();

            //app.UseOcelot().Wait();

           
        }
    }
}
