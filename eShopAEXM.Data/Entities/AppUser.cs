
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopAEXM.Data.Entities
{
    [Table("AppUser")]
    public class AppUser : IdentityUser<Guid>
    {
        [Required(ErrorMessage = "Vui lòng nhập tên user")]
        [DisplayName("Họ và Tên ")]

        public string Fullname { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        [DisplayName("Địa Chỉ")]
        public string Address { get; set; }


        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
