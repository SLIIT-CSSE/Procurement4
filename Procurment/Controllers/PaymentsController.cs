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
        public ActionResult PaidItemDetails()
        {
            return View();
        }

        // Pending payments list
        public ActionResult PendingPaymentsList()
        {
            return View();
        }

        // Complete pending payment
        public ActionResult PendingPaymentOrderDetails()
        {
            var bankAccounts = _context.BankAccounts.ToList();
            var viewModel = new CompletePaymentViewModel
            {
                BankAccounts = bankAccounts
            };
             
            return View(viewModel);
        }


    }
}