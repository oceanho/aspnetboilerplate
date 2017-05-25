using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLearn.Common.Authorization.Roles
{
    [Table("PlmRole")]
    public class PlmRole : CreationAuditedEntity
    {
    }
}
