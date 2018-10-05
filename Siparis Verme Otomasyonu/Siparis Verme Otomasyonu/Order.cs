using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siparis_Verme_Otomasyonu
{
    public class Order
    {
        public string OrderName { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public int TrackingNumber { get; set; }
        public Shipper Shipper { get; set; }
        public Customer Customer { get; set; }
    }
}
