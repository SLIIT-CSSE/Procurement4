using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Procurment.Models;

namespace Procurment.Controllers
{
    public class SearchOrdersController : Controller
    {
        private ApplicationDbContext _context;

        public SearchOrdersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: ViewdepartentOrders
        public ViewResult SearchDeptOrder()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }
        // GET: ViewdepartentOrders
        public ViewResult DeptRejectOrders()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }
        public ViewResult DeptApprovedOrders()
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
    }
}