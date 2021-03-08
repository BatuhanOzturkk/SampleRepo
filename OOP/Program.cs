using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Table";
            product1.CategoryId = 2;
            product1.UnitPrice = 35.00;
            product1.UnitsInStock = 2;

            Product product2 = new Product
            {
                ProductId = 2,
                ProductName = "Pencil",
                CategoryId = 3,
                UnitsInStock = 5,
                UnitPrice = 15
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product2);


        }
    }
}
