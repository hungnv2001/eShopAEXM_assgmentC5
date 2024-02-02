using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.backEndApi.Entities
{
    [Table("ProductsIMG")]   
    public class ProductsIMG
    {
        [Key]   
        public Guid ID { get; set; }
        [Required(ErrorMessage ="vui lòng nhập URL")] 
        public Guid? ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Products? Products { get; set; }
        [Required(ErrorMessage ="vui lòng nhập URL")]
        public string URL { get; set; }
        [Required(ErrorMessage = "vui lòng nhập Order")]
        public int Order { get; set; } //Thu tu sap xep
    }
}
