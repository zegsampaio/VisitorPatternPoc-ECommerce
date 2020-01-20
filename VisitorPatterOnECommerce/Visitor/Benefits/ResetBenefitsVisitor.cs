using VisitorPatterOnECommerce.Domain;

namespace VisitorPatterOnECommerce.Visitor.Benefits
{
    public class ResetBenefitsVisitor : IProductVisitor
    {
        public string Description => "Reset";

        public void Visit(Product product)
        {
            product.Benefits.Clear();
        }
    }
}
