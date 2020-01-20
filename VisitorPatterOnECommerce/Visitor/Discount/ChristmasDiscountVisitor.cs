﻿using VisitorPatterOnECommerce.Domain;

namespace VisitorPatterOnECommerce.Visitor
{
    public class ChristmasDiscountVisitor : IProductVisitor
    {
        public string Description => "Christmas Discount";

        public void Visit(Product product)
        {
            var priceWithDiscount = product.Price * 0.70;
            product.PriceWithDiscount = priceWithDiscount;
        }
    }
}
