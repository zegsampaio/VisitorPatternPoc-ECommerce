using VisitorPatterOnECommerce.Domain;

namespace VisitorPatterOnECommerce.Visitor
{
    public class BlackFridayDiscountVisitor : IProductVisitor
    {
        public string Description => "Black Friday Discount";

        public void Visit(Product product)
        {
            var priceWithDiscount = product.Price * 0.55;
            product.PriceWithDiscount = priceWithDiscount;
        }
    }
}
