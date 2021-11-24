﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public enum ProductCategories
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set;}
        public string ProductImage { get; set; }
        public ProductCategories ProductCategory { get; set; }
    }
}
