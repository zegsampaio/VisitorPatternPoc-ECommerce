using System;
using System.Collections.Generic;
using VisitorPatterOnECommerce.Domain;
using VisitorPatterOnECommerce.Visitor;

namespace VisitorPatterOnECommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product("Shoes","Guccy",999.00),
                new Product("Jeans","Prada",200.00),
                new Product("Shirt","Lacoste",789.90)
            };

            var discount = new ChristmasDiscountVisitor();

            products.ForEach(product => product.Accept(discount));

            Console.WriteLine($"Discount applied -> {discount.Description}\n");
            products.ForEach(product => Console.WriteLine(product));
        }
    }
}
