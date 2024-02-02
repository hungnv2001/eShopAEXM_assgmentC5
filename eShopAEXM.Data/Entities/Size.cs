using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopAEXM.backEndApi.Entities
{
    [Table("Size")]
    public class Size
    {
        [Key]
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên size")]
        public string Name { get; set; }

        public virtual ICollection<ProductVariants>? ProductVariants { get; set; }
    }
}
