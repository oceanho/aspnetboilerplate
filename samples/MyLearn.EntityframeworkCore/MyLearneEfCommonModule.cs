﻿using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLearn.Common;
using System;

namespace MyLearn.EntityframeworkCore.Common
{
    [DependsOn(typeof(MyLearnCommonModule))]
    public class MyLearneEfCommonModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
        }
    }
}
