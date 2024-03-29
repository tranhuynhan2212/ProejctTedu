﻿using ProjectTedu.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectTedu.Data.Entities
{
    [Table("AnnouncementUsers")]
    class AnnouncementUser :DomainEntity<int>
    {
       
        [StringLength(128)]
        [Required]
        public string AnnouncementId { get; set; }
        [StringLength(450)]
        [Required]
        public string UserId { get; set; }
        public bool? HasRead { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }
        [ForeignKey("AnnouncementId")]
        public virtual Announcement Announcement { get; set; }
    }
}
