using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLearn.Common;
using System;

namespace MyLearn.EntityframeworkCore.SqlServer
{
    [DependsOn(typeof(MyLearnCommonModule))]
    public class MyLearneEfOfSqlServerModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
        }
    }
}
