using Abp.Application.Services;

namespace Abp.Web.Api.Tests.AppServices
{
    public interface IMyFirstAppService : IPlmRoleAppService
    {
        string GetStr(int i);

        [MyIgnoreApi]
        string GetStr2(int i);
    }
}