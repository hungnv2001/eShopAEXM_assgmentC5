using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopAEXM.backEndApi.Entities
{
    [Table("InvoiceItems")]
    public class InvoiceItems
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? ProductID { get; set; }
        [ForeignKey("ProductID")]
        public ProductVariants? Products { get; set; }
        public Guid? InvoiceID { get; set; }
        [ForeignKey("InvoiceID")]
        public Invoices? Invoices { get; set; }
        [Required(ErrorMessage = "Phải nhập số lượng")]
        [Range(1, 1000)]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Phải nhập giá tiền")]
        public double Price { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }

    }
}
