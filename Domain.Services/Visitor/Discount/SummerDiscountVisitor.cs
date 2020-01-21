using VisitorPatterOnECommerce.Domain;
using VisitorPatterOnECommerce.Domain.Model;

namespace VisitorPatterOnECommerce.Visitor.Domain.Services.Discount
{
    public class SummerDiscountVisitor : IVisitor<Product>
    {
        public string Description => "Summer Discount";

        public void Visit(Product product)
        {
            var priceWithDiscount = product.Price * 0.85;
            product.AddPriceWithDiscount(priceWithDiscount);
        }
    }
}