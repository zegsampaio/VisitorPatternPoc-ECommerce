namespace VisitorPatterOnECommerce.Domain.Core
{
    public interface IVisitor<T>
    {
        public string Description { get; }

        public void Visit(T entity);
    }
}
