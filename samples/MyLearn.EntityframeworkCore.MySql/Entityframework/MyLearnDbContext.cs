using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Abp.Dependency;

namespace MyLearn.EntityframeworkCore
{
    public class MyLearnDbContext : MyLearnCommonDbContext
    {        
        public MyLearnDbContext(DbContextOptions options) : base(options)
        {            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // MySql
            optionsBuilder.UseMySql(ConnectionString);
        }
    }
}
