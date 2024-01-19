using eShopAEXM.ModelView.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    [Table("Invoices")]   
    public class Invoices
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Phải nhập địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }
        [Required(ErrorMessage = "Phải nhập giá giao hàng")]
        public double TransportPrice { get; set; } //Bo sung
        public double TotalPrice { get; set; }
        public Guid CustomerID {  get; set; }
        [Required(ErrorMessage = "Phải nhập trạng thái giao hàng")]
        public InvoiceStatus Status { get; set; }

        [ForeignKey("CustomerID")]
        public virtual AppUser User { get; set; }
    }
}
