using VisitorPatterOnECommerce.Domain;

namespace VisitorPatterOnECommerce.Visitor.Benefits
{
    public class GuccyFreeShippingBenefitVisitor : IProductVisitor
    {
        public string Description => "Free Shipping";

        public void Visit(Product product)
        {
            if(product.Brand == "Guccy")
            {
                product.Benefits.Add("Free-Shipping");
            }
        }
    }
}
