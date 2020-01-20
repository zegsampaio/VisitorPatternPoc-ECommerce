using System;
using System.Text;
using VisitorPatterOnECommerce.Visitor;

namespace VisitorPatterOnECommerce.Domain
{
    public class Product
    {
        public Product(string description, string brand, double price)
        {
            Id = Guid.NewGuid();
            Description = description;
            Brand = brand;
            Price = price;
            PriceWithDiscount = price;
        }

        public Guid Id { get; }
        public DateTime CreateDate { get; }
        public string Description { get; }
        public string Brand { get; }
        public double Price { get; }
        public double PriceWithDiscount { get; internal set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Product ID {Id}")
                .AppendLine($"Description {Description}")
                .AppendLine($"Price {Price}")
                .AppendLine($"PriceWithDiscount {PriceWithDiscount}")
                .ToString();
        }
    }
}
