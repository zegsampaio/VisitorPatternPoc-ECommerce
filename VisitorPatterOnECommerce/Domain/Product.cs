using System;
using System.Collections.Generic;
using System.Linq;
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
            Benefits = new List<string>();
        }

        public Guid Id { get; }
        public DateTime CreateDate { get; }
        public string Description { get; }
        public string Brand { get; }
        public double Price { get; }
        public double PriceWithDiscount { get; internal set; }
        public IList<string> Benefits { get; internal set; }

        public void Accept(IProductVisitor visitor)
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
                .AppendLine($"Benefits: {string.Join("; ", Benefits.ToArray())}")
                .ToString();
        }
    }
}
