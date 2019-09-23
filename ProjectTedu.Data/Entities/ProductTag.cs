using ProjectTedu.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectTedu.Data.Entities
{
    public class ProductTag:DomainEntity<int>
    {
        [StringLength(50)]
        [Column(TypeName="varchar")]
        public string ProductId { set; get; }
        public string TagId { set; get; }
        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
