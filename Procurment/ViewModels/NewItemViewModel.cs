using Procurment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Procurment.ViewModels
{
    public class NewItemViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public ConstructionItem ConstructionItem { get; set; }


        public IEnumerable<ConstructionItem> ConstructionItems { get; set; }
        public Order Orders { get; set; }

    }
}