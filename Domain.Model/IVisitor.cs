namespace VisitorPatterOnECommerce.Domain.Model
{
    public interface IVisitor<T>
    {
        public string Description { get; }

        public void Visit(T entity);
    }
}