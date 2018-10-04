using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Procurment.Models;

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


    }
}