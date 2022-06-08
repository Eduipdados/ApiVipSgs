using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using VipSgs.Api.Configurations;
using VipSgs.CrossCutting.IoC;

namespace VipSgs.Api
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        public IConfiguration _configuration { get; }

        public Startup(IWebHostEnvironment environment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();
            System.Console.WriteLine(environment.EnvironmentName);

            _configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencies(_configuration);
            services.ApiServiceConfig();
            services.AutoMapperServiceConfig();
            services.SwaggerServiceConfig();
            services.AddAuthentication();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var supportedCultures = new[] { new CultureInfo("pt-BR") };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(culture: "pt-BR", uiCulture: "pt-BR"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.SwaggerApplicationConfig();
            app.ApiApplicationConfig(env);
            
        }
    }
}
