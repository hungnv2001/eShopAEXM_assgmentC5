using eShopAEXM.ModelView.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    [Table("ProductVariants")]   
    public class ProductVariants
    {
        [Key]   
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public Guid SizeID { get; set; }
        public Guid ColorID { get; set; }
        [Required(ErrorMessage ="vui lòng nhập trạng thái")]
        public Status Status { get; set; }
        [Range(1,1000)]
        [Required(ErrorMessage ="Vui lòng nhập số lượng")]
        public int Quantity { get; set; }

        [ForeignKey("ProductID")]
        public Products Products { get; set; }
        [ForeignKey("SizeID")]
        public Size Size { get; set; }
        [ForeignKey("ColorID")]
        public Color Color { get; set; }
    }
}
