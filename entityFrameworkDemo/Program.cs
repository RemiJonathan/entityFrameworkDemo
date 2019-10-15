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
            var newId = DB.AddProduct(addingProduct).ProductId;
            Console.WriteLine("Product added with id: " + newId);



            var myProduct = Database.DB.GetProduct(1);
            Console.WriteLine(myProduct.ProductDescription.ToString());
        }
    }
}
