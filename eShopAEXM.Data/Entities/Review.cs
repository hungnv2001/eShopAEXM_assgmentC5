using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    public class Review
    {
        public Guid ID { get; set; }
        public Guid InvoiceItemID { get; set; }
        public int Rate { get; set; } //De kieu du lieu int co hop ly khg ?
        public string Comment { get; set; }
    }
}
