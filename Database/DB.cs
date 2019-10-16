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
            myDb.SaveChanges();

            return p;
        }
        
        public static Product DeleteProduct(int id)
        {
            Product product = myDb.Products.Find(id);
            myDb.Products.Remove(product);
            myDb.SaveChanges();
            return product;
        }

        public static IEnumerable<Customer> GetCustomers()
        {
            return myDb.Customers.ToList();
        }

        public static Customer GetCustomer(int id)
        {
            return myDb.Customers.Find(id);
        }

        public static Customer AddCustomer(Customer p)
        {
            myDb.Customers.Add(p);
            myDb.SaveChanges();

            return p;
        }

        public static Customer UpdateCustomer(int id, Customer p)
        {
            myDb.Customers.Find(id).CustomerFirstName = p.CustomerFirstName;
            myDb.Customers.Find(id).CustomerLastName = p.CustomerLastName;
            myDb.SaveChanges();

            return p;
        }

        public static Customer DeleteCustomer(int id)
        {
            Customer Customer = myDb.Customers.Find(id);
            myDb.Customers.Remove(Customer);
            myDb.SaveChanges();
            return Customer;
        }
    }
}
