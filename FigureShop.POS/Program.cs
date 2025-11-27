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
            .AddJsonFile("appsettings.json", false, true);

        var configuration = builder.Build();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        var options = new DbContextOptionsBuilder<FigureShopDbContext>()
            .UseSqlServer(connectionString)
            .Options;

        using (var context = new FigureShopDbContext(options))
        {
            try
            {
                context.Database.Migrate();
                DataSeeder.Initialize(context);
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