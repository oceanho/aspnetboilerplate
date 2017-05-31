using Abp.Modules;
using MyLearn.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyLearn.Web.Api
{
    [DependsOn(typeof(MyLearnKernelModule))]
    public class MyLearnWebApiModule : AbpModule
    {
        public override void PreInitialize()
        {
        }
        public override void Initialize()
        {
        }

        public override void PostInitialize()
        {
        }
    }
}
