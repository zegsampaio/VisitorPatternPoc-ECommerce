using VisitorPatterOnECommerce.Domain;

namespace VisitorPatterOnECommerce.Visitor
{
    public interface IVisitor
    {
        public string Description { get; }

        public void Visit(Product product);
    }
}
