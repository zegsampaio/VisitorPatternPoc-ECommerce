using VisitorPatterOnECommerce.Domain.Model;
using VisitorPatterOnECommerce.Domain.Core;

namespace VisitorPatterOnECommerce.Domain.Services.Visitor.Benefits
{
    public class GucciFreeShippingBenefitVisitor : IVisitor<Product>
    {
        public string Description => "Free Shipping";

        public void Visit(Product product)
        {
            if(product.Brand == "Gucci")
            {
                product.Benefits.Add("Free-Shipping");
            }
        }
    }
}
