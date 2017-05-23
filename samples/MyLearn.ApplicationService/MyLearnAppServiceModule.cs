using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLearn.Kernel;
using System;

namespace MyLearn.ApplicationService
{
    [DependsOn(typeof(MyLearnKernelModule))]
    public class MyLearnAppServiceModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
        }
    }
}
