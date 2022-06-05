using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext (string[] args)
        {
            var connectionString = "Data Source=localhost;Database=DbVipSGS;User Id=sa;Password=1qazxsw23edc;Trusted_Connection=False;MultipleActiveResultSets=True";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
       
    }
}
