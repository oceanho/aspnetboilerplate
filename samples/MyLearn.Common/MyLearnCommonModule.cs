using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLearn.Common.Authorization.Provider;
using System;
using System.Reflection;

namespace MyLearn.Common
{
    public class MyLearnCommonModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyLearnAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
        }

        public override void PostInitialize()
        {
        }

        public override void Shutdown()
        {
        }

        public override Assembly[] GetAdditionalAssemblies()
        {
            return base.GetAdditionalAssemblies();
        }
    }
}
