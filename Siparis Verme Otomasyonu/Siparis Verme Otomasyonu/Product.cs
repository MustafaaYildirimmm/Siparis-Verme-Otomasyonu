using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siparis_Verme_Otomasyonu
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public Category categoryName { get; set; }

        public override string ToString()
        {
            return this.ProductName;
        }
    }
}
