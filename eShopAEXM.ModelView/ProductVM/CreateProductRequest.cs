using eShopAEXM.ModelView.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.ModelView.ProductVM
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "vui lòng nhập mô tả sản phẩm")]
        public string Description { get; set; }
        [Required(ErrorMessage = "vui lòng nhập giá  sản phẩm")]
        public double Price { get; set; }
        public Guid BrandID { get; set; }
        public Guid CateID { get; set; }
        [Required(ErrorMessage = "vui lòng nhập trạng thái sản phẩm")]
        public Status Status { get; set; }
        [DisplayName("Ảnh 1")]
        public string? Url1 { get; set; }
        [DisplayName("Ảnh 2")]
        public string? Url2 { get; set; }
        [DisplayName("Ảnh 3")]
        public string? Url3 { get; set; }
    }
}
