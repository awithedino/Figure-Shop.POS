using System;
using System.Linq;
using System.Windows.Forms;
using FigureShop.POS.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FigureShop.POS;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Load += new EventHandler(Form1_Load);
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        await LoadFiguresAsync();
    }

    private async Task LoadFiguresAsync()
    {
        var connectionString = "Server=localhost;Database=FigureShopDb;User ID=sa;Password=P@ssw0rd123;MultipleActiveResultSets=true;TrustServerCertificate=True";
        
        var optionsBuilder = new DbContextOptionsBuilder<FigureShopDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        using (var context = new FigureShopDbContext(optionsBuilder.Options))
        {
            try
            {
                var figures = await context.Figures
                    .Include(f => f.Branch)
                    .Include(f => f.Category)
                    .ToListAsync();

                dgvFigures.DataSource = figures;

                dgvFigures.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading figures: {ex.Message}\n\n{ex.InnerException?.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}