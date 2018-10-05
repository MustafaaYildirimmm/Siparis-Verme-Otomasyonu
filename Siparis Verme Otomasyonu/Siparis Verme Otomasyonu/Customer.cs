using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siparis_Verme_Otomasyonu
{
    public class Customer
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsCompany { get; set; }
        public string CompanyName { get; set; }
    }
}
