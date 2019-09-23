using ProjectTedu.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectTedu.Data.Entities
{
    [Table("Tags")]
    public class Tag:DomainEntity<string>
    {
        public Tag()
        {
            ProductTags = new List<ProductTag>();
        }
        [MaxLength(50)]
        [Required]
        public string Name { set; get; }
        [MaxLength(50)]
        [Required]
        public string Type { set; get; }
        public virtual ICollection<ProductTag> ProductTags { set; get; }
    }
}
