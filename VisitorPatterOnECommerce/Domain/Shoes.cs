using System;
namespace VisitorPatterOnECommerce.Domain
{
    public class Shoes : Product
    {
        public Shoes(string description, string brand, double price)
            : base(description, brand, price)
        {
        }
    }
}
