using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Procurment.Models
{
    public class Payment
    {
        [Key]
        public string PaymentId { get; set; }
        public Order Order { get; set; }
        public string OrderId { get; set; }
        public float TotalAmount { get; set; }
        public string AccountNo { get; set; }
    }
}