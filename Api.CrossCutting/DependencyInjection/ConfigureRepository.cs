using Api.Data.Context;
using Api.Domain.Interfaces;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddDbContext<MyContext>(
               options => options.UseSqlServer("Data Source=localhost;Database=DbVipSGS;User Id=sa;Password=1qazxsw23edc;Trusted_Connection=False;MultipleActiveResultSets=True")
               );
        }
    }
}
