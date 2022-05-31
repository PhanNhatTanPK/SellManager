using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        int productId, amount, price;
        string productName, origin;

        public ProductDTO()
        {
            this.ProductName = productName;
            this.Origin = origin;
            this.Amount = amount;
            this.Price = price;
        }

        public int ProductId { get => productId; set => productId = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Price { get => price; set => price = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Origin { get => origin; set => origin = value; }
    }
}
