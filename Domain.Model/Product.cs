using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPatterOnECommerce.Domain.Model
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
        public double PriceWithDiscount { get; private set; }
        public IList<string> Benefits { get; private set; }

        public void AddPriceWithDiscount(double priceWithDiscount)
        {
            if (priceWithDiscount <= 0) throw new ArgumentOutOfRangeException(nameof(priceWithDiscount), "must be greater than 0");
            if (priceWithDiscount > Price) throw new ArgumentOutOfRangeException(nameof(priceWithDiscount), "must be less than product Price");
            PriceWithDiscount = priceWithDiscount;
        }

        public void Accept(IVisitor<Product> visitor)
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
