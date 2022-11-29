using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksMVC.Data;
using BooksMVC.Servicios;

namespace BooksMVC
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
            //services.AddTransient<IServicio_API, Servicio_API>();

            //services.AddHttpClient("BackEnd", client=> {
            //    client.BaseAddress = new Uri("http://localhost:55843");
            //});
            services.AddTransient<IServicio_API, Servicio_API>();
            services.AddHttpClient("BackEnd",client=> {
                client.BaseAddress = new Uri("http://localhost:55843");
            });





            services.AddControllersWithViews();

            services.AddDbContext<BooksMVCContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("BooksMVCContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
