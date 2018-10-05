using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Procurment.Models;
using Procurment.ViewModels;

namespace Procurment.Controllers
{
    public class PaymentsController : Controller
    {
        //access to DB
        private ApplicationDbContext _context;

        public PaymentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // Successfully completed payments list interface
        public ViewResult SuccessfullPaymentList()
        {
            var successpayments = _context.Payments.ToList();
            return View(successpayments);
        }

        // Successfully paid order details
        public ActionResult PaidItemDetails(string id)
        {
            var successpayment = _context.Payments.SingleOrDefault(s => s.OrderId == id);

            if(successpayment == null)
                return HttpNotFound();

            return View(successpayment);
        }

        // Pending payments list
        public ViewResult PendingPaymentsList()
        {
            var pendingPayments = _context.Orders.ToList();
            return View(pendingPayments);
        }

        // Complete pending payment
        public ActionResult PendingPaymentOrderDetails(string id)
        {
            //to load all bank account details to drop down
            var bankAccounts = _context.BankAccounts.ToList();
            var viewModel = new CompletePaymentViewModel
            {
                BankAccounts = bankAccounts
            };

            //load relevent details in order tble to ui
            var pendingPayment = _context.Orders.SingleOrDefault(p => p.OrderId == id);
            if(pendingPayment == null)
                return HttpNotFound();

            return View(pendingPayment);
        }

        public ActionResult PendingPaymentOrderItems()
        {
            return View();
        }


    }
}