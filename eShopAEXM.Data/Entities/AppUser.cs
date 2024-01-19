using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Fullname { get; set; }
        public string Address { get; set; }

        
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
