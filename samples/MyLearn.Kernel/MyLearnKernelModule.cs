using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLearn.EntityframeworkCore.MySql;
using System;

namespace MyLearn.Kernel
{
    [DependsOn(typeof(MyLearneEfOfMySqlModule))]
    public class MyLearnKernelModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
        }
    }
}
