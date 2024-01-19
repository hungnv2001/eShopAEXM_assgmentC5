using eShopAEXM.ModelView.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Status Status { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("ProductID")]
        public Products Products { get; set; }
        [ForeignKey("SizeID")]
        public Size Size { get; set; }
        [ForeignKey("ColorID")]
        public Color Color { get; set; }
    }
}
