using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Procurment.Models
{
    public class Order
    {
        [Key]
        public string OrderId { get; set; }
        public string Sequential_Reference { get; set; }
        public string CompanyStatus { get; set; }
        public string SupplierStatus { get; set; }
        public float TotalAmount { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }



    }
}