using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopAEXM.Data.Entities
{
    [Table("Brands")]
    public class Brands
    {
        [Key]
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên thương hiệu")]
        public string Name { get; set; }
        public virtual ICollection<Products>? Products { get; set; }
    }
}
