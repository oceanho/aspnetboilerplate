using System;
using System.Collections.Generic;
using System.Text;

using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLearn.Common.Authorization.Roles;

namespace MyLearn.EntityframeworkCore
{
    public abstract class MyLearnCommonDbContext : AbpDbContext
    {
        protected readonly String ConnectionString;
        public MyLearnCommonDbContext(DbContextOptions options) : base(options)
        {
            ConnectionString = "";
        }

        public virtual DbSet<PlmRole> Roles { get; set; }
    }
}
