namespace WorkingWithEFCore
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }   

        public bool Discontinued { get; set; }

        // these two lines define the foreign key relationship
        // to the Categories table
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}