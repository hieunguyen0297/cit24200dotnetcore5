using Packt.Shared;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Collections.Generic;

namespace WorkingWithRazorPage.Pages
{
    public class EmployeesModel : PageModel
    {
        private Northwind db;
        //using db page is loaded
        public EmployeesModel(Northwind dbContext)
        {
            db = dbContext;
        }

        //Store a list of employees;
        public IEnumerable<Employee> Employees { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Employees";
            Employees = db.Employees;
        }


    }
}