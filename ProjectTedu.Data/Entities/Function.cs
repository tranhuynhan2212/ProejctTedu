using ProjectTedu.Data.Enums;
using ProjectTedu.Data.Interfaces;
using ProjectTedu.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectTedu.Data.Entities
{
    [Table("Functions")]
    public class Function : DomainEntity<string>, ISwitchable, ISortable
    {
        public Function() { }

        public Function(string name, string url, string parentId, string iconCss, Status status, int sortOrder)
        {
            Name = name;
            URL = url;
            ParentId = parentId;
            IconCss = iconCss;
            Status = Status.Active;
            SortOrder = sortOrder;
        }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(256)]
        public string URL { get; set; }
        [Required]
        [StringLength(128)]
        public string ParentId { get; set; }
        public string IconCss { get; set; }
        public Status Status { get; set; }
        public int SortOrder { get; set; }
    }
}
