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
    [Table("Bills")]
    public class Bill : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Bill() { }
        public Bill(string customerName, string customerAddress, string customerMobile,string customerMessage,
            PaymentMethod paymentMethod,BillStatus billStatus,DateTime dateCreated,DateTime dateModified,Status status,string customerId)
        {
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMoblie = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }
        public Bill(int id,string customerName, string customerAddress, string customerMobile, string customerMessage,
            PaymentMethod paymentMethod, BillStatus billStatus, DateTime dateCreated, DateTime dateModified, Status status, string customerId)
        {
            Id = id;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMoblie = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }
        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerAddress { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerMoblie { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessage { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public BillStatus BillStatus { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        [DefaultValue(Status.Active)]
        public Status Status { get; set; } = Status.Active;
        [StringLength(450)]
        public string CustomerId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
