﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Procurment.Models;

namespace Procurment.Dtos
{
    public class OrderDto
    {
        public string OrderId { get; set; }
        public string Sequential_Reference { get; set; }
        public string CompanyStatus { get; set; }
        public string SupplierStatus { get; set; }
        public float TotalAmount { get; set; }
     
        public string UserId { get; set; }
        public string ItemName { get; set; }
        public int Quanity { get; set; }

        public DateTime Date { get; set; }
        public string Supplier { get; set; }

    }
}