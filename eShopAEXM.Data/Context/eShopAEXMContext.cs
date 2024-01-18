using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Data.Context
{
    public class eShopAEXMContext : IdentityDbContext
    {
        public eShopAEXMContext(DbContextOptions options) : base(options)
        {
        }

        protected eShopAEXMContext()
        {
        }
    }
}
