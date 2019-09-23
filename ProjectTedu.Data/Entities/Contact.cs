using ProjectTedu.Data.Enums;
using ProjectTedu.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectTedu.Data.Entities
{
    [Table("ContactDetails")]
    public class Contact : DomainEntity<string>
    {
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        [StringLength(250)]
        public string Phone { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Website { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        public string Other { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public Status status { get; set; } 
    }
}
