using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace WorkingWithEFCore
{
    class Program
    {

        static void Main(string[] args)
        {
            // GetItemsFromCategories();
            GetItemsFromProducts();
            // InsertIntoCategories(9, "This is the description for that the new category.");
            // InsertIntoProducts(78, 60M, 2);
        }

        //Get items from Categories order by CategoryName descending
        public static void GetItemsFromCategories()
        {
            using (var db = new Northwind())
            {
                IQueryable<Category> categories = db.Categories.OrderByDescending(category => category.CategoryName);

                //Print each category to the console
                Console.WriteLine("Query the Categories table and print out the first 10 items: ");

                foreach (Category c in categories)
                {

                    Console.WriteLine($"CategoryID: {c.CategoryID}, Category Name: {c.CategoryName}, Description: {c.Description}");
                }

            }
        }


        //Get items from Products order by ProductName descending
        public static void GetItemsFromProducts()
        {
            using (var db = new Northwind())
            {
                //Linq syntax to select products
                IQueryable<Product> products = (from p in db.Products orderby p.ProductName descending select p).Take(10);
                // IQueryable<Product> products = db.Products.Where(p => EF.Functions.Like(p.ProductName, "%na%"));

                //Print each category to the console
                Console.WriteLine("Query the Products table and print out the first 10 items: ");

                foreach (Product p in products)
                {
                    Console.WriteLine($"Product ID: {p.ProductID}, Product Name: {p.ProductName}, Product Price: ${p.UnitPrice}, Instock: {p.UnitsInStock}");
                }

            }
        }

        //Insert new record into the Categories table 
        public static int InsertIntoCategories(int categoryID, string description)
        {
            using (var db = new Northwind())
            {
                Console.WriteLine("Please enter a name for category: ");
                string name = Console.ReadLine();

                Category newCategory = new Category
                {
                    CategoryID = categoryID,
                    CategoryName = name,
                    Description = description
                };

                db.Categories.Add(newCategory);

                int affected = db.SaveChanges();

                return affected;
            }
        }



        //Insert new record into the Products table 
        public static int InsertIntoProducts(int productID, decimal? unitPrice, int categoryID)
        {

            using (var db = new Northwind())
            {

                Console.WriteLine("Enter a name for the product: ");
                string name = Console.ReadLine();

                //Create new product
                Product newProduct = new Product
                {
                    ProductID = productID,
                    ProductName = name,
                    UnitPrice = unitPrice,
                    CategoryID = categoryID

                };

                //Add product to the table
                db.Products.Add(newProduct);

                int affected = db.SaveChanges();

                return affected;

            }

        }

    }
}
