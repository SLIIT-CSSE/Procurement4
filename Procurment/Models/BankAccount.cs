using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Procurment.Models
{
    public class BankAccount
    {
        [Key]
        public string AccountId { get; set; }
        public string Bank { get; set; }
        public string AccountNo { get; set; }
    }
}