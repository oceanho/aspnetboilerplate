using Abp.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.MultiTenancy;

namespace MyLearn.Common.Authorization.Fetures
{
    public class MyLearnPermissionManager : IPermissionManager
    {
        public IReadOnlyList<Permission> GetAllPermissions(bool tenancyFilter = true)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Permission> GetAllPermissions(MultiTenancySides multiTenancySides)
        {
            throw new NotImplementedException();
        }

        public Permission GetPermission(string name)
        {
            throw new NotImplementedException();
        }

        public Permission GetPermissionOrNull(string name)
        {
            throw new NotImplementedException();
        }
    }
}
