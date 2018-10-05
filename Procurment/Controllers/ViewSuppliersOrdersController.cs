using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Procurment.Models;

namespace Procurment.Controllers
{
    public class ViewSuppliersOrdersController : Controller
    {
        private ApplicationDbContext _context;

        public ViewSuppliersOrdersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: ViewSuppliersOrders
        public ViewResult viewOrders()
        {
            var orders = _context.Orders.ToList();
               
            return View(orders);
        }

        public ActionResult Details(String id)
        {
            var order = _context.Orders.SingleOrDefault(o => o.OrderId == id);
            if (order == null)
                return HttpNotFound();
            return View(order);    
        }

        public ViewResult viewApproved()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }

        public ViewResult viewReject()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }


    }
}