using Procurment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Procurment.ViewModels
{
    public class CompletePaymentViewModel
    {
        //use all BankAccount,Order,Payment in one view
        public IEnumerable<BankAccount> BankAccounts { get; set; }
        public Order Order { get; set; }
        public Payment Payment { get; set; }
    }
}