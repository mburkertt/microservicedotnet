using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.PersistenceLayer.Interfaces;
using api.PersistenceLayer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace api
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
            services.AddMvc();
            services.AddTransient<IPersistenceLayerService, PersistenceLayerService>();
            services.AddDbContext<PersonContext>();
            services.AddEntityFrameworkInMemoryDatabase().AddDbContext<PersonContext>();
            services.AddScoped<DbContext>(sp => sp.GetService<PersonContext>());
            var container = services.BuildServiceProvider(); //container is a global variable。
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
