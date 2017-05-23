using Abp.Application.Services;
using Abp.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using MyLearn.Common.Application.Roles.Dtos;
using System.Threading.Tasks;

namespace MyLearn.Common.Application.Roles
{
    [AbpAuthorize]
    public class PlmRoleAppService : ApplicationService, IPlmRoleAppService
    {
        [AbpAuthorize("Plm.Administration.Role.Manager.Create")]
        public Task<PlmRoleCreateOutput> CreateRole(PlmRoleCreateInput input)
        {
            return Task.FromResult(new PlmRoleCreateOutput());
        }
    }
}
