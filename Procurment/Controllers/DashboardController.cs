using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procurment.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult SiteManager()
        {
            return View();
        }
    }
}