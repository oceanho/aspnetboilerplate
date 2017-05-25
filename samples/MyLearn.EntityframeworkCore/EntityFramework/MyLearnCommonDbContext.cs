using System;
using System.Collections.Generic;
using System.Text;

using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLearn.Common.Authorization.Roles;
using Abp.Dependency;
using Abp.Configuration.Startup;

namespace MyLearn.EntityframeworkCore
{
    public abstract class MyLearnCommonDbContext : AbpDbContext
    {
        public MyLearnCommonDbContext(DbContextOptions options) : base(options)
        {
        }
        public String ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<PlmRole>().ToTable("", "scheme");
        }
        public virtual DbSet<PlmRole> Roles { get; set; }
    }
}
