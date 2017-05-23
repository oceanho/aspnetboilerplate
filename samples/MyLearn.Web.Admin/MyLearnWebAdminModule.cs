using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLearn.ApplicationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLearn.Web.Admin
{
    [DependsOn(typeof(MyLearnAppServiceModule))]
    public class MyLearnWebAdminModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
        }
    }
}
