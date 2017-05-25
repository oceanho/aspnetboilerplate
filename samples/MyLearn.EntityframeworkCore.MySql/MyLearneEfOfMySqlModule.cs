using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.DependencyInjection;
using MyLearn.Common;
using System;

namespace MyLearn.EntityframeworkCore.MySql
{
    [DependsOn(typeof(MyLearnCommonModule))]
    public class MyLearneEfOfMySqlModule : AbpModule
    {
        public override void Initialize()
        {
            var services = new ServiceCollection();
            services.AddEntityFrameworkMySql();
            IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
        }
    }
}
