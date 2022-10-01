using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //AddProduct(productManager);
            //UpdateProduct(productManager);
            //DeleteProduct(productManager);
            //ListProduct(productManager);
            ListProductDetails(productManager);
        }

        private static void ListProductDetails(ProductManager productManager)
        {
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
        }

        private static void DeleteProduct(ProductManager productManager)
        {
            productManager.Delete(new Product { ProductId = 79 });
        }

        private static void UpdateProduct(ProductManager productManager)
        {
            productManager.Update(new Product { ProductId = 79, ProductName = "şemsiye", CategoryId = 3, UnitPrice = 150, UnitsInStock = 15 });
        }

        private static void AddProduct(ProductManager productManager)
        {
            productManager.Add(new Product { ProductName = "kalem", CategoryId = 2, UnitPrice = 100, UnitsInStock = 10 });
        }

        private static void ListProduct(ProductManager productManager)
        {
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
