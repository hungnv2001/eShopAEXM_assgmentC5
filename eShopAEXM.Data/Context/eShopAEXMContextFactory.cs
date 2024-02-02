using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eShopAEXM.Data.Context
{
    internal class eShopAEXMContextFactory : IDesignTimeDbContextFactory<eShopAEXMContext>
    {
        public eShopAEXMContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionBuilder = new DbContextOptionsBuilder<eShopAEXMContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new eShopAEXMContext(optionBuilder.Options);
        }
    }
}
