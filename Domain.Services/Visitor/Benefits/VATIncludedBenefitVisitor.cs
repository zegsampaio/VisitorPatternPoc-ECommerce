using VisitorPatterOnECommerce.Domain;
using VisitorPatterOnECommerce.Domain.Model;

namespace VisitorPatterOnECommerce.Domain.Services.Visitor.Benefits
{
    public class VATIncludedBenefitVisitor : IVisitor<Product>
    {
        public string Description => "VAT Included";

        public void Visit(Product product)
        {
            product.Benefits.Add("vat-included");
        }
    }
}
