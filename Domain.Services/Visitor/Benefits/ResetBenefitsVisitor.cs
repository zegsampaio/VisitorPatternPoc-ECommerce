using VisitorPatterOnECommerce.Domain.Core;
using VisitorPatterOnECommerce.Domain.Model;

namespace VisitorPatterOnECommerce.Domain.Services.Visitor.Benefits
{
    public class ResetBenefitsVisitor : IVisitor<Product>
    {
        public string Description => "Reset";

        public void Visit(Product product)
        {
            product.Benefits.Clear();
        }
    }
}
