using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class BasketManager
    {
        public void AddProduct(Product product)
        {
            Console.WriteLine("Added" + " " + product.ProductName);
        }

        public void AddProduct2(string productName, string productDescription, double productPrice)
        {
            Console.WriteLine("Added " + productName);
        }
    }
}
