﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siparis_Verme_Otomasyonu
{
    public class Category
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}
