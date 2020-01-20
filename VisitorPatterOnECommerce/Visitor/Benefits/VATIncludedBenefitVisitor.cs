using VisitorPatterOnECommerce.Domain;

namespace VisitorPatterOnECommerce.Visitor.Benefits
{
    public class VATIncludedBenefitVisitor : IProductVisitor
    {
        public string Description => "VAT Included";

        public void Visit(Product product)
        {
            product.Benefits.Add("vat-included");
        }
    }
}
