using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    public class CartItem
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public int Quantity { get; set; }
        public Guid ProductVariantID { get; set; }

        [ForeignKey("CustomerID")]
        public virtual AppUser? AppUsers { get; set; }
        [ForeignKey("ProductVariantID")]
        public virtual ProductVariants? ProductVariants { get; set; }
         
    }
}
