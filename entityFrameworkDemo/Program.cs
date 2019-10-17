using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace entityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var addingProduct = new Product();
            addingProduct.ProductDescription = "MacBook Air";
            addingProduct.ProductUpc = "5524008365214";
            var newProductId = DB.AddProduct(addingProduct).ProductId;
            Console.WriteLine("Product added with id: " + newProductId);

            var addingCustomer = new Customer();
            addingCustomer.CustomerFirstName = "Brondeen";
            addingCustomer.CustomerLastName = "Weeds";
            var newCustomerId = DB.AddCustomer(addingCustomer).CustomerId;
            Console.WriteLine("Customer added with id: {0}", newCustomerId);

            var addingSale = new Sale();
            addingSale.ProductId = newProductId;
            addingSale.CustomerId = newCustomerId;
            addingSale.SaleDate = new DateTime(2019,6,15,7,15,0);
            var newSaleId = DB.AddSale(addingSale).SaleId;
            Console.WriteLine("Sale added with id: {0}", newSaleId);

            var updatingCustomer = new Customer();
            updatingCustomer.CustomerFirstName = "Brendan";
            updatingCustomer.CustomerLastName = "Wood";
            var updatedCustomer = DB.UpdateCustomer(newCustomerId,updatingCustomer);

            Console.WriteLine("Updated Customer {0}, FirstName: {1}, LastName: {2}", newCustomerId, updatedCustomer.CustomerFirstName, updatedCustomer.CustomerLastName);

            var sales = DB.GetSales().Where(sale => sale.ProductId == newProductId && sale.CustomerId == newCustomerId);

            foreach(Sale sale in sales)
            {
                Customer customer = DB.GetCustomer(sale.CustomerId);
                Product product = DB.GetProduct(sale.ProductId);

                Console.WriteLine("{0} {1} purchased a/n {2}",customer.CustomerFirstName,customer.CustomerLastName,product.ProductDescription);
            }

            //Yes I know I already have the ID I'm just assuming I didn't
            var deletedCustomerId = DB.DeleteCustomer(newCustomerId).CustomerId;
            Console.WriteLine("Customer {0} deleted.", deletedCustomerId);
        }
    }
}
