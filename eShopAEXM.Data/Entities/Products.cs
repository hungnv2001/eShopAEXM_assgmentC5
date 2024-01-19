using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    public class Products
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Guid BrandID { get; set; }
        public Guid CateID { get; set; }
        public bool Status { get; set; }
    }
}
