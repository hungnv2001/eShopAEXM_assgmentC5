using eShopAEXM.ModelView.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.backEndApi.Entities
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="vui lòng nhập tên sản phẩm")]
        public string Name { get; set; }
        [Required(ErrorMessage = "vui lòng nhập mô tả sản phẩm")]
        public string Description { get; set; }
        [Required(ErrorMessage = "vui lòng nhập giá  sản phẩm")]
        public double Price { get; set; }
        public Guid BrandID { get; set; }
        public Guid CateID { get; set; }
        [Required(ErrorMessage = "vui lòng nhập trạng thái sản phẩm")]
        public Status Status { get; set; }

        public virtual ICollection<ProductVariants>? ProductVariants { get; set; }
        public virtual ICollection<ProductsIMG>? ProductsIMGs { get; set; }
        [ForeignKey("CateID")]
        public virtual Category? Category { get; set; }
        [ForeignKey("BrandID")]
        public virtual Brands? Brands { get; set; }
    }
}
