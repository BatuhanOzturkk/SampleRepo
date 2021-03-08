using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "Added");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Updated");
        }
    }
}
