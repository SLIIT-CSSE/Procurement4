using Procurment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procurment.Controllers
{
    public class ViewOrdersController : Controller
    {

        private ApplicationDbContext _context;

        public ViewOrdersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: ViewOrders
        public ActionResult ViewOrder()
        {
            return View();
        }

        public ActionResult ConsearchOrder()
        {
            return View();
        }
        public ActionResult OrderStatus()
        {
            return View();
        }
        public ActionResult ApprovedOrder()
        {
            return View();
        }
        public ActionResult RejectedOrder()
        {
            return View();
        }
        public ActionResult PendingOrder()
        {
            return View();
        }
        
        public ActionResult SupPendingorder()
        {
            return View();
        }
        public ActionResult SupRejectedorder()
        {
            return View();
        }
        public ActionResult SupplierOrder()
        {
            return View();
        }

        public ActionResult SiteManagerPreviousorder()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }

        public ActionResult SupPreviousorder()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }

        public ActionResult SiteManagerDeleteOrder()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }

        public ActionResult SiteManagerUpdateOrder()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }
    }
}