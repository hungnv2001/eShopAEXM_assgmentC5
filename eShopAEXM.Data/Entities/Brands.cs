﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    public class Brands
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
