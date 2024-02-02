using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopAEXM.Data.Entities
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "vui lòng nhập loại hàng")]
        public string Name { get; set; }

        public ICollection<Products>? Products { get; set; }
    }
}
