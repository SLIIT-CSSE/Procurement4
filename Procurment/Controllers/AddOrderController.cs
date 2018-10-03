using Procurment.Models;
using System.Data.Entity;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Procurment.ViewModels;

namespace Procurment.Controllers
{
    public class AddOrderController : Controller
    {
        private ApplicationDbContext _context;

        public AddOrderController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: AddOrder
        public ActionResult AddMyOrder()
        {
            return View();
        }

        public ActionResult AddNewItem()
        {
            var CategoryTypes = _context.Categories.ToList();
            var viewModel = new NewItemViewModel
            {
                Categories = CategoryTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult create(ConstructionItem constructionitem)
        {
            _context.ConstructionItems.Add(constructionitem);
            _context.SaveChanges();
            return RedirectToAction("AddNewItem", "AddOrder");
        }
    }
}