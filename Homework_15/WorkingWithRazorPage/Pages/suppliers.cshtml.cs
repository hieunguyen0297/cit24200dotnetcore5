using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Packt.Shared;

namespace WorkingWithRazorPage.Pages
{
    public class SuppliersModel : PageModel
    {
        //Using database 
        private Northwind db;

        public SuppliersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }


        public IEnumerable<Supplier> Suppliers { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Suppliers";
            Suppliers = db.Suppliers;
        }
    }
}
