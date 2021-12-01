using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment_12.Models;

namespace Assignment_12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private List<Product> products;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            products = new List<Product>();

            //add products to list
            products.Add(new Product { Id = 1, Name = "DeWalt", Description = "Cordless drill combo kit features 2 speed transmission", Price = 139.33M });
            products.Add(new Product { Id = 2, Name = "Clart Men's Boot", Description = "The finish or polish on these boots show marks which are not scratches", Price = 40.99M });
            products.Add(new Product { Id = 3, Name = "Invicta Men's Watch", Description = "Gold tone stainless steel case 48mm diameter x 12.5mm thick", Price = 50.55M });
            products.Add(new Product { Id = 4, Name = "Lark Ro Women Sweater", Description = "A classic silhouette and subtle ribbing highlight this Long Sleeve Tunic V-Neck Sweater", Price = 29.33M });
            products.Add(new Product { Id = 5, Name = "Buttoned Down Men's Shirt", Description = "Luxury Supima cotton with a lightweight finish", Price = 69.93M });
        }

        //From the home, return a list of products.. These are hardcoded.
        public IActionResult Index()
        {
            return View(products);
        }


        //Get Product details
        public IActionResult ProductDetail(int id)
        {
            Product product = products.Where(p => p.Id == id).FirstOrDefault();
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
