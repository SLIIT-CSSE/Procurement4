using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Procurment.Models
{
    public class SupplierStatus
    {
        [Key]
        public string SuplierStatusId { get; set; }
        public Order Order { get; set; }
        public string OrderId { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
    }
}