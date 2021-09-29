using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditChecklist_MicroService.Repository;
using AuditChecklist_MicroService.Repository.IRepository;
using AuditChecklist_MicroService.Provider;
using System.Reflection;
using System.IO;
using AuditChecklist_MicroService.Services;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using AuditSeverity_MicroService;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using AuditBenchmark_MicroService.Logger;

namespace AuditChecklist_MicroService
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
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer());
            //services.AddDbContext<ApplicationDbContext>
            //    (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.Configure<MyAppSettings>(Configuration.GetSection(MyAppSettings.SectionName));
            services.AddOptions();


            services.AddScoped<IAuditChecklistProvider, AuditChecklistProvider>();
            services.AddScoped<IAuditChecklistRepository, AuditChecklistRepository>();

            services.AddHttpClient();

            services.AddAutoMapper(typeof(AuditChecklistMappings));
 

            services.AddControllers();

            services.AddSingleton<ILoggerManager, LoggerManager>();

            services.AddCors();

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });
            services.AddVersionedApiExplorer(options => options.GroupNameFormat = "'v'VVV");

            //SWAGGER DOCUMENTATION
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            services.AddSwaggerGen();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();


            app.UseRouting();

            app.UseSwagger();
            //app.UseSwaggerUI(options => {
            //    options.SwaggerEndpoint("/swagger/AuditSeverityOpenApiSpec/swagger.json", "AuditSeverityApi");
            //    options.RoutePrefix = "";
            //});

            app.UseSwaggerUI(options => {
                foreach (var desc in provider.ApiVersionDescriptions)
                    options.SwaggerEndpoint($"/swagger/{desc.GroupName}/swagger.json",
                        desc.GroupName.ToUpperInvariant());
                //options.SwaggerEndpoint("/swagger/AuthorizationOpenApiSpec/swagger.json", "Authorization Api");
                options.RoutePrefix = "";
            });

            app.UseCors(x => x
       .AllowAnyOrigin()
       .AllowAnyMethod()
       );

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
