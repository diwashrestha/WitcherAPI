using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using WitcherAPI.Models;
using System;
using System.Reflection;
using System.IO;
using Microsoft.OpenApi.Models;

namespace WitcherAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
            {
                var connection = Configuration.GetConnectionString("WitcherDBProd");
                services.AddDbContext<WitcherDbContext>(options => options.UseSqlServer(connection));
                services.AddControllers();
            }
            else
            {
                var connection = Configuration.GetConnectionString("WitcherDatabase");
                services.AddDbContext<WitcherDbContext>(options => options.UseSqlServer(connection));
                services.AddControllers();
            }



            // Register the Swaager generator
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Witcher 3 API",
                    Description = "<img src=\"https://raw.githubusercontent.com/diwashrestha/WitcherAPI/master/witcherapi.png\" /> " +
                    "<br><br> The Witcher 3 API catalogs the characters, weapons, monsters,armors found in the world of the  <a href=\"https://thewitcher.com/en/witcher3\">The Witcher 3: Wild Hunt</a> Game. " +
                    "It is created as fun project to help users discover the world of witcher and consume data using the HTTP requests and interact with them.",
                    Contact = new OpenApiContact
                    {
                        Name = "Diwash Shrestha",
                        Url = new Uri("http://diwashrestha.com.np/"),
                    }
                });
                c.IncludeXmlComments(string.Format(@"bin\WitcherAPI.xml"));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as JSON endpoint.
            app.UseSwagger();


            // Enable middleware to serve swagger ui
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Witcher API");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
