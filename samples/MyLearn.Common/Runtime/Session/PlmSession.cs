using Abp.Runtime.Session;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.MultiTenancy;
using Abp.Configuration.Startup;
using Abp.Runtime;
using Abp.Dependency;

namespace MyLearn.Common.Runtime.Session
{
    public class PlmSession : AbpSessionBase, IAbpSession, ISingletonDependency
    {
        public PlmSession(IMultiTenancyConfig multiTenancy, IAmbientScopeProvider<SessionOverride> sessionOverrideScopeProvider)
            : base(multiTenancy, sessionOverrideScopeProvider)
        {
        }

        public override long? UserId => throw new NotImplementedException();

        public override int? TenantId => throw new NotImplementedException();

        public override long? ImpersonatorUserId => throw new NotImplementedException();

        public override int? ImpersonatorTenantId => throw new NotImplementedException();
    }
}
