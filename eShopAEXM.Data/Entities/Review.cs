using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopAEXM.Data.Entities
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? InvoiceItemID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá")]
        public int Rate { get; set; } //De kieu du lieu int co hop ly khg ?
        [Required(ErrorMessage = "Vui lòng nhập bình luận")]
        public string? Comment { get; set; }
        [ForeignKey("InvoiceItemID")]
        public virtual ICollection<InvoiceItems>? InvoiceItems { get; set; }
    }
}
