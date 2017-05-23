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
            ConfigureDbConnection();
            IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
        }

        private void ConfigureDbConnection()
        {

            // TODO: need do ?
            Configuration.DefaultNameOrConnectionString = "Server=localhost;User Id=root;Password=abc123;Database=mylearn";
        }
    }
}
