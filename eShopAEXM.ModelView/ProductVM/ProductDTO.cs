using eShopAEXM.ModelView.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eShopAEXM.ModelView.ProductVM
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "vui lòng nhập mô tả sản phẩm")]
        public string Description { get; set; }
        [Required(ErrorMessage = "vui lòng nhập giá  sản phẩm")]
        public double Price { get; set; }
        public Guid BrandID { get; set; }
        public string? BrandName { get; set; }

        public Guid CateID { get; set; }
        public string? CateName { get; set; }
        [Required(ErrorMessage = "vui lòng nhập trạng thái sản phẩm")]
        public Status Status { get; set; }
        [DisplayName("Ảnh")]
        public string? UrlIMG { get; set; }
    }
}
