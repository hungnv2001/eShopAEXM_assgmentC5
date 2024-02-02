using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eShopAEXM.Data.Context
{
    public class eShopAEXMContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public eShopAEXMContext(DbContextOptions<eShopAEXMContext> options) : base(options)
        {
        }

        protected eShopAEXMContext()
        {
        }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<InvoiceItems> InvoiceItems { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsIMG> ProductsIMGs { get; set; }
        public DbSet<ProductVariants> ProductVariants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Size> Sizes { get; set; }
    }
}
