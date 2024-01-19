using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    public class ProductVariants
    {
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public Guid SizeID { get; set; }
        public Guid ColorID { get; set; }
        public bool Status { get; set; }
        public int Quantity { get; set; }
    }
}
