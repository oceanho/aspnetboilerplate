using Abp.Authorization;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLearn.Common.Authorization.Provider
{
    public class MyLearnAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            var administrator = context.CreatePermission("Plm.Administration");
            
            var administratorRole = administrator.CreateChildPermission("Plm.Administration.RoleManager");
            administratorRole.CreateChildPermission("Plm.Administration.RoleManager.Create");
            administratorRole.CreateChildPermission("Plm.Administration.RoleManager.Update");
            administratorRole.CreateChildPermission("Plm.Administration.RoleManager.Delete");
        }
    }
}
