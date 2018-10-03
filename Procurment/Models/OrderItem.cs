using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Procurment.Models
{
    public class OrderItem
    {
        [Key]
        public string OrderItemId { get; set; }
        public Order Order { get; set; }
        public string OrderId { get; set; }
        public ConstructionItem ConstructionItem { get; set; }
        public string ConstructionItemId { get; set; }
        public int quantity { get; set; }

    }
}