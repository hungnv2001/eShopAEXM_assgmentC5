using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace eShopAEXM.ModelView.ProductVM
{
    public class ProductDetailsVM
    {
        public Guid Id { get; set; }
        public string Name { get; set;}
        public double Price { get; set;}
        public string Description { get; set;}
        public List<Size> Sizes { get; set; }
        public List<Color> Colors{ get; set; }
        public List<string> Imgs { get; set; }
    }
}
