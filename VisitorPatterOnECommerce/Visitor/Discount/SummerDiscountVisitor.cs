﻿using VisitorPatterOnECommerce.Domain;

namespace VisitorPatterOnECommerce.Visitor
{
    public class SummerDiscountVisitor : IVisitor
    {
        public string Description => "Summer Discount";

        public void Visit(Product product)
        {
            var priceWithDiscount = product.Price * 0.85;
            product.PriceWithDiscount = priceWithDiscount;
        }
    }
}