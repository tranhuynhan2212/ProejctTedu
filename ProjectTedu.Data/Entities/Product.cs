using ProjectTedu.Data.Enums;
using ProjectTedu.Data.Interfaces;
using ProjectTedu.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectTedu.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        public Product()
        {
            ProductTags = new List<ProductTag>();
        }
        [StringLength(255)]
        [Required]
        public string Name { set; get; }
        [Required]
        public int CategoryId { set; get; }
        [StringLength(255)]
        public string Image { set; get; }
        [Required]
        [DefaultValue(0)]
        public decimal Price { set; get; }
        public decimal PromotionPrice { set; get; }
        [Required]
        public decimal OriginalPrice { set; get; }
        [StringLength(255)]
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool HotFlag{ set; get; }
        public int? ViewCount { set; get; }
        [StringLength(255)]
        public string Tags { set; get; }
        [StringLength(255)]
        public string Unit { set; get; }
        
        
        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string SeoPageTitle { set; get; }
        [Column(TypeName ="varchar")]
        [StringLength(255)]
        public string SeoAlias { set; get; }
        [StringLength(255)]
        public string SeoKeywords { set; get; }
        [StringLength(255)]
        public string SeoDescription { set; get; }
        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }

        public virtual ICollection<ProductTag> ProductTags { set; get; }
    }
}
