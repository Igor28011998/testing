using CRUD.Models;
using CRUD.Repositories;
using CRUD.Repositories.Abstracts;
using CRUD.Services;
using CRUD.Services.Abstracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CRUD
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IBookService, BookService>();

            services.AddDbContext<DatabaseContext>(opts =>
                opts.UseSqlServer("DefaultConnection"));
            services.AddTransient<DatabaseContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
