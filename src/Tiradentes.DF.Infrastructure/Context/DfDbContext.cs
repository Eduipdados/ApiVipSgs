﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VipSgs.Domain.Models;
using VipSgs.Infrastructure.Configurations;

namespace VipSgs.Infrastructure.Context
{
    public class DfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
       

        public DfDbContext() : base()
        {
        }
        public DfDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DfDbContext).Assembly);

            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
           
        }
    }
}
