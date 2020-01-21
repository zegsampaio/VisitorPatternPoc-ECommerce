using VisitorPatterOnECommerce.Domain.Core;
using VisitorPatterOnECommerce.Domain.Model;

namespace VisitorPatterOnECommerce.Visitor.Domain.Services.Discount
{
    public class ChristmasDiscountVisitor : IVisitor<Product>
    {
        public string Description => "Christmas Discount";

        public void Visit(Product product)
        {
            var priceWithDiscount = product.Price * 0.70;
            product.AddPriceWithDiscount(priceWithDiscount);
        }
    }
}
