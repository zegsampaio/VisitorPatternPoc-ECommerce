using VisitorPatterOnECommerce.Domain.Core;
using VisitorPatterOnECommerce.Domain.Model;

namespace VisitorPatterOnECommerce.Visitor.Domain.Services.Discount
{
    public class BlackFridayDiscountVisitor : IVisitor<Product>
    {
        public string Description => "Black Friday Discount";

        public void Visit(Product product)
        {
            var priceWithDiscount = product.Price * 0.55;
            product.AddPriceWithDiscount(priceWithDiscount);
        }
    }
}
