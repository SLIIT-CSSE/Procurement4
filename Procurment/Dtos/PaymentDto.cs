using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Procurment.Dtos
{
    public class PaymentDto
    {
        public string PaymentId { get; set; }
        
        public string OrderId { get; set; }
        public float TotalAmount { get; set; }
        public string AccountNo { get; set; }
        public string SupplierName { get; set; }
    }
}