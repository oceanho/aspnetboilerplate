using Abp.Application.Services;
using Abp.Authorization;
using MyLearn.Common.Application.Roles.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLearn.Common.Application.Roles
{
    public interface IPlmRoleAppService : IApplicationService
    {
        Task<PlmRoleCreateOutput> CreateRole(PlmRoleCreateInput input);
    }
}
