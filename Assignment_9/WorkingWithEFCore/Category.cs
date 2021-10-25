

using System.Collections.Generic;

namespace WorkingWithEFCore
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }    

        public string Description { get; set; } 

        // defines a navigation property for related rows
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            // to enable developers to add products to a Category we must
            // initialize the navigation property to an empty list
            this.Products = new List<Product>();
        }
    }
}