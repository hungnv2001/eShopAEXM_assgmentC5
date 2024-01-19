using eShopAEXM.ModelView.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    public class Products
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public Guid BrandID { get; set; }
        public Guid CateID { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<ProductVariants> ProductVariants { get; set; }
        [ForeignKey("CateID")]
        public virtual Category Category { get; set; }
        [ForeignKey("BrandID")]
        public virtual Brands Brands { get; set; }
    }
}
