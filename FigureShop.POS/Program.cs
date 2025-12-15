using FigureShop.POS.Data;
using FigureShop.POS.Data.Models;
using FigureShop.POS.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FigureShop.POS;

internal static class Program
{
    public static User CurrentUser { get; set; }

    [STAThread]
    private static void Main()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        var configuration = builder.Build();
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        
        var options = new DbContextOptionsBuilder<FigureShopDbContext>()
            .UseOracle(connectionString) 
            .Options;

        using (var context = new FigureShopDbContext(options))
        {
            try
            {
                Console.WriteLine("Applying Migrations...");
                context.Database.Migrate();
                Console.WriteLine("Migrations Applied. Seeding Data...");
                
                DataSeeder.Initialize(context);
                Console.WriteLine("Data Seeded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi động database: {ex.Message}", "Lỗi nghiêm trọng", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }
        }

        ApplicationConfiguration.Initialize();

        using (var loginForm = new Form_Login())
        {
            if (loginForm.ShowDialog() == DialogResult.OK) Application.Run(new Form_Menu());
        }
    }
}