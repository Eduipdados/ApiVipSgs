using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VipSgs.Infrastructure.Context;
using VipSgs.Services.Services;
using VipSgs.Services.Interfaces;
using VipSgs.Infrastructure.Repository;
using VipSgs.Domain.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace VipSgs.CrossCutting.IoC
{
    [ExcludeFromCodeCoverage]
    public static class NativeCoreDependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            #region Repositorioes
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            #endregion

            #region Services
            services.AddScoped<IProdutoService, ProdutoService>();
            #endregion

            var connectionStrings = configuration.GetConnectionString("Connection");

            services.AddDbContext<DfDbContext>(options =>
                options.UseSqlServer(connectionStrings));
        }
    }
}
