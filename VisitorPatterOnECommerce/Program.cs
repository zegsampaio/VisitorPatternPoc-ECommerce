using System;
using System.Collections.Generic;
using VisitorPatterOnECommerce.Domain;
using VisitorPatterOnECommerce.Visitor;
using VisitorPatterOnECommerce.Visitor.Benefits;

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

            var discount = new BlackFridayDiscountVisitor();
            products.ForEach(product => product.Accept(discount));

            var vatIncludedBenefit = new VATIncludedBenefitVisitor();
            products.ForEach(product => product.Accept(vatIncludedBenefit));

            var guccyFreeShipping = new GuccyFreeShippingBenefitVisitor();
            products.ForEach(product => product.Accept(guccyFreeShipping));

            products.ForEach(product => Console.WriteLine(product));
        }
    }
}
