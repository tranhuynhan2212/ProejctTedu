using ProjectTedu.Data.Enums;
using ProjectTedu.Data.Interfaces;
using ProjectTedu.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectTedu.Data.Entities
{
    public class Advertistment : DomainEntity<int>, ISwitchable, ISortable
    {
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        [StringLength(250)]
        public string Url { get; set; }
        [StringLength(20)]
        public string Positionid { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int SortOrder { get; set; }

        public virtual AdvertistmentPosition AdvertistmentPosition { get; set; }
    }
}
