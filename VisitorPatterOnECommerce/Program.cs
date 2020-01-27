using System;
using System.Collections.Generic;
using VisitorPatterOnECommerce.Domain.Model;
using VisitorPatterOnECommerce.Domain.Services.Visitor.Benefits;
using VisitorPatterOnECommerce.Visitor.Domain.Services.Discount;

namespace VisitorPatterOnECommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product("Shoes","Gucci",999.00),
                new Product("Jeans","Prada",200.00),
                new Product("Shirt","Lacoste",789.90)
            };

            var discount = new BlackFridayDiscountVisitor();
            products.ForEach(product => product.Accept(discount));

            var vatIncludedBenefit = new VATIncludedBenefitVisitor();
            products.ForEach(product => product.Accept(vatIncludedBenefit));

            var gucciFreeShipping = new GucciFreeShippingBenefitVisitor();
            products.ForEach(product => product.Accept(gucciFreeShipping));

            products.ForEach(product => Console.WriteLine(product));
        }
    }
}
