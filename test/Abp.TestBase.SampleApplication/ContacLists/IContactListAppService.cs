using System.Collections.Generic;
using Abp.Application.Services;

namespace Abp.TestBase.SampleApplication.ContacLists
{
    public interface IContactListAppService : IPlmRoleAppService
    {
        void Test();

        List<ContactListDto> GetContactLists();
    }
}
