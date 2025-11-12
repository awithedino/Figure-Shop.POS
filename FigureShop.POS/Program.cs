using FigureShop.POS.Data;
using FigureShop.POS.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FigureShop.POS;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<FigureShopDbContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
            })
            .Build();
        
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<FigureShopDbContext>();
            context.Database.Migrate(); 
            
            DataSeeder.Initialize(context);
        }
        
        Application.Run(new Form_Menu());
    }
}