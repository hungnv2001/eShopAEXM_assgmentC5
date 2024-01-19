using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    public class Invoices
    {
        public Guid Id { get; set; }
        public string ShippingAddress { get; set; }
        public double TotalPrice { get; set; }
        public Guid CustomerID {  get; set; }
        public bool Status { get; set; }
    }
}
