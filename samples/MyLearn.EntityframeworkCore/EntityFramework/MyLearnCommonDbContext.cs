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
        protected readonly String ConnectionString;
        public MyLearnCommonDbContext(DbContextOptions options) : base(options)
        {
            ConnectionString = IocManager.Instance.Resolve<IAbpStartupConfiguration>().DefaultNameOrConnectionString;
        }

        public virtual DbSet<PlmRole> Roles { get; set; }
    }
}
