using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Apple";
            product1.ProductPrice = 10.75;
            product1.ProductDescription = "Sweet Apple";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Watermelon";
            product2.ProductPrice = 80;
            product2.ProductDescription = "No Explanation";

            Product[] productArray = new Product[] { product1, product2 };
            foreach (var product in productArray)
            {
                Console.WriteLine(product.ProductDescription + " " + product.ProductName);
            }

            BasketManager basketManager = new BasketManager();
            basketManager.AddProduct(product2);
            Console.WriteLine("-------------"); 
            basketManager.AddProduct2("Cherry", "no explanation", 15.785);

        }
    }
}
