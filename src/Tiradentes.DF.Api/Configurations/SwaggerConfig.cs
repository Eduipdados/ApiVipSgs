using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Diagnostics.CodeAnalysis;
using VipSgs.Api.Extentions;

namespace VipSgs.Api.Configurations
{
    [ExcludeFromCodeCoverage]
    public static class SwaggerConfig
    {
        public static void SwaggerServiceConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(swg =>
            {
                swg.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Tiradentes - DIF",
                });
                swg.OperationFilter<AddRequiredHeaderParameter>();
            });
        }

        public static void SwaggerApplicationConfig(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Tiradentes - FIEF | API v1.0");
            });
        }
    }
}
