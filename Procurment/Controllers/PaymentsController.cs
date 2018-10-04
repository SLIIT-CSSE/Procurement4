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
        private ApplicationDbContext _context;

        public PaymentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: SuccessPayments
        public ViewResult SuccessfullPaymentList()
        {
            var successpayments = _context.Payments.ToList();
            return View(successpayments);
        }

        public ActionResult PaidItemDetails()
        {
            return View();
        }

        public ActionResult PendingPaymentsList()
        {
            return View();
        }

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