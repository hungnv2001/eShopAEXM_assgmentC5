using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    public class InvoiceItems
    {
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }
        public Guid InvoiceID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
