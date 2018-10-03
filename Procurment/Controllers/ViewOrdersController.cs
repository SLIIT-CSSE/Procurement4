using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procurment.Controllers
{
    public class ViewOrdersController : Controller
    {
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
        public ActionResult SupPreviousorder()
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
    }
}