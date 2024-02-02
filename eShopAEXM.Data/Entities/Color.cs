﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.backEndApi.Entities
{
    [Table("Color")]   
    public class Color
    {
        [Key]   
        public Guid ID { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập tên màu")]
        public string Name { get; set; }
        public virtual ICollection<ProductVariants>? ProductVariants { get; set; }

    }
}
