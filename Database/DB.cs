using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
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
            Product Product = myDb.Products.Find(id);
            myDb.Products.Find(id).ProductIsActive = false;
            myDb.SaveChanges();
            return Product;
        }
    

    public static IEnumerable<Customer> GetCustomers()
        {
            return myDb.Customers.ToList();
        }

        public static Customer GetCustomer(int id)
        {
            return myDb.Customers.Find(id);
        }

        public static Customer AddCustomer(Customer c)
        {
            myDb.Customers.Add(c);
            myDb.SaveChanges();

            return c;
        }

        public static Customer UpdateCustomer(int id, Customer c)
        {
            myDb.Customers.Find(id).CustomerFirstName = c.CustomerFirstName;
            myDb.Customers.Find(id).CustomerLastName = c.CustomerLastName;
            myDb.SaveChanges();

            return c;
        }

        public static Customer DeleteCustomer(int id)
        {
            Customer Customer = myDb.Customers.Find(id);
            myDb.Customers.Find(id).CustomerIsActive = false;
            myDb.SaveChanges();
            return Customer;
        }

        public static IEnumerable<Sale> GetSales()
        {
            return myDb.Sales.ToList();
        }

        public static Sale GetSale(int id)
        {
            return myDb.Sales.Find(id);
        }

        public static Sale AddSale(Sale s)
        {
            myDb.Sales.Add(s);
            myDb.SaveChanges();

            return s;
        }

        public static Sale UpdateSale(int id, Sale s)
        {
            myDb.Sales.Find(id).CustomerId = s.CustomerId;
            myDb.Sales.Find(id).ProductId = s.ProductId;
            myDb.Sales.Find(id).SaleDate = s.SaleDate;
            myDb.SaveChanges();

            return s;
        }

        public static Sale DeleteSale(int id)
        {
            Sale Sale = myDb.Sales.Find(id);
            myDb.Sales.Find(id).SaleIsActive = false;
            myDb.SaveChanges();
            return Sale;
        }
    }
}
