using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FigureShop.POS.Data
{
    // This factory is ONLY used by the "dotnet ef" command line tool.
    // It tells the tool how to create the DbContext without running Program.cs.
    public class FigureShopDbContextFactory : IDesignTimeDbContextFactory<FigureShopDbContext>
    {
        public FigureShopDbContext CreateDbContext(string[] args)
        {
            // 1. Build the configuration to read appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // 2. Configure the DbContext options
            var builder = new DbContextOptionsBuilder<FigureShopDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseOracle(connectionString);

            // 3. Return the context
            return new FigureShopDbContext(builder.Options);
        }
    }
}