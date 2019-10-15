using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DB
    {
        private static Demo1Entities myDb = new Demo1Entities();
        public static IEnumerable<Product> GetProducts()
        {
            return myDb.Products.ToList();
        }

        public static Product GetProduct(int id)
        {
            return myDb.Products.Find(id);
        }

        public static Product AddProduct(Product p)
        {
            myDb.Products.Add(p);
            myDb.SaveChanges();

            return p;
        }

        public static Product UpdateProduct(int id, Product p)
        {
            myDb.Products.Find(id).ProductDescription = p.ProductDescription;
            myDb.Products.Find(id).ProductUpc = p.ProductUpc;

            return p;
        }
    }
}
