using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models
{
    public class Sale
    {
        public Sale(int id, string product, decimal price, DateTime saledate)
        {
            Id = id;
            Product = product;
            Price = price;
            SaleDate = saledate;
        }

        public int Id { get; set;  }

        [JsonProperty("Nome_Produto")]
        public string Product { get; set;  }

        public decimal Price { get; set;  }
        public DateTime SaleDate { get; set; }
        public decimal Discount { get; set; }
    }
}