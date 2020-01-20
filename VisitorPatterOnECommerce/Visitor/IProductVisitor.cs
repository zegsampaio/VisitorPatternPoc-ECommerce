using VisitorPatterOnECommerce.Domain;

namespace VisitorPatterOnECommerce.Visitor
{
    public interface IProductVisitor
    {
        public string Description { get; }

        public void Visit(Product product);
    }
}
