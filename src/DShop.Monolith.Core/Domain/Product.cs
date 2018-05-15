using System;

namespace DShop.Monolith.Core.Domain
{
    public class Product : AggregateRoot
    {
        public string Name { get; protected set; }
        public string Descirption { get; protected set; }
        public string Vendor { get; protected set; }
        public decimal Price { get; protected set; }

        public Product(Guid id, string name, string description, string vendor, decimal price)
            : base(id)
        {
            Vendor = vendor;
            SetName(name); 
            SetDescription(description);
            SetPrice(price);
        }

        public void SetName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new DShopException("Product name cannot be empty.");
            }
            Name = name;
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new DShopException("Product description cannot be empty.");
            }
            Descirption = description;
        }


        public void SetPrice(decimal price)
        {
            if (price <= 0)
            {
                throw new DShopException("Product price cannot be zero or negative.");
            }
            Price = price;
        }
    }
}