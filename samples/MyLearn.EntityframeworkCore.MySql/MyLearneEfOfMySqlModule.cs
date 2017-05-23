using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLearn.Common;
using System;

namespace MyLearn.EntityframeworkCore.MySql
{
    [DependsOn(typeof(MyLearnCommonModule))]
    public class MyLearneEfOfMySqlModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
        }
    }
}
