using InventarioConv.Borders.Repository.Produto;
using InventarioConv.Borders.UseCase.Produto;
using InventarioConv.Repository;
using InventarioConv.Repository.Produto;
using InventarioConv.UseCase.Produto;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace InventarioConv.Api
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
            services.AddScoped<ICriaProdutoUseCase, CriaProdutoUseCase>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IListaProdutosUseCase, ListaProdutosUseCase>();
            services.AddScoped<IEditaProdutoUseCase, EditaProdutoUseCase>();
            services.AddScoped<IRemoveProdutoUseCase, RemoveProdutoUseCase>();
            services.AddDbContext<Context>(
                    options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InventarioConv.Api", Version = "v1" });
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var filename = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                c.IncludeXmlComments(Path.Combine(basePath, filename));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "InventarioConv.Api v1"));

            }

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
