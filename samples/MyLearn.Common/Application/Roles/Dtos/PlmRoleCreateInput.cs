using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLearn.Common.Application.Roles.Dtos
{
    [Serializable]
    public class PlmRoleCreateInput : EntityDto<int>
    {
        [Required]
        [StringLength(20)]
        [RegularExpression("[a-z0-9A-Z_]{5,20}")]
        public string Name { get; set; }

        [StringLength(200)]
        public string Display { get; set; }
    }
}
