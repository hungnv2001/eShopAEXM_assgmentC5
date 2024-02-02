using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopAEXM.Data.Entities
{
    [Table("CartItem")]
    public class CartItem
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? CustomerID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số lượng")]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        public Guid? ProductVariantID { get; set; }

        [ForeignKey("CustomerID")]
        public virtual AppUser? AppUsers { get; set; }
        [ForeignKey("ProductVariantID")]
        public virtual ProductVariants? ProductVariants { get; set; }

    }
}
