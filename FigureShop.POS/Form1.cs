using System;
using System.Collections.Generic;
using System.ComponentModel; // For BindingList
using System.Linq;
using System.Windows.Forms;
using FigureShop.POS.Models;
using Microsoft.EntityFrameworkCore;

namespace FigureShop.POS
{
    public partial class Form1 : Form
    {
        private BindingList<CartItem> shoppingCartItems = new BindingList<CartItem>();

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);

            // Set up the shopping cart DataGridView
            dgvShoppingCart.AutoGenerateColumns = true; // Let it generate columns from CartItem properties
            dgvShoppingCart.DataSource = shoppingCartItems;

            // Optional: Customize shopping cart columns
            dgvShoppingCart.Columns["FigureId"]!.Visible = false; // Hide the ID column
            dgvShoppingCart.Columns["FigureName"]!.HeaderText = "Product";
            dgvShoppingCart.Columns["UnitPrice"]!.HeaderText = "Price";
            dgvShoppingCart.Columns["Quantity"]!.HeaderText = "Qty";
            dgvShoppingCart.Columns["TotalPrice"]!.HeaderText = "Subtotal";
            dgvShoppingCart.Columns["TotalPrice"]!.DefaultCellStyle.Format = "C"; // Currency format
            dgvShoppingCart.Columns["UnitPrice"]!.DefaultCellStyle.Format = "C"; // Currency format
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadFiguresAsync();
            UpdateTotalPrice();
        }

        private async Task LoadFiguresAsync(string? searchTerm = null)
        {
            var connectionString = "Server=localhost;Database=FigureShopDb;User ID=sa;Password=P@ssw0rd123;MultipleActiveResultSets=true;TrustServerCertificate=True";

            var optionsBuilder = new DbContextOptionsBuilder<FigureShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            using (var context = new FigureShopDbContext(optionsBuilder.Options))
            {
                try
                {
                    IQueryable<Figure> query = context.Figures
                                                        .Include(f => f.Branch)
                                                        .Include(f => f.Category);

                    // Apply search term if provided
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query = query.Where(f => f.Name.Contains(searchTerm) ||
                                                 f.Description.Contains(searchTerm)); // Or other fields
                    }

                    var figures = await query.ToListAsync();

                    // This makes sure the DataGridView reflects changes
                    dgvFigures.DataSource = null; // Unbind first
                    dgvFigures.DataSource = figures;

                    dgvFigures.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading figures: {ex.Message}\n\n{ex.InnerException?.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the Search button
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            await LoadFiguresAsync(searchTerm);
        }

        // Event handler for the Add to Cart button
        private void btnAddSelectedToCart_Click(object sender, EventArgs e)
        {
            if (dgvFigures.SelectedRows.Count > 0)
            {
                // Get the first selected row (assuming one item at a time for simplicity)
                var selectedRow = dgvFigures.SelectedRows[0];
                var selectedFigure = selectedRow.DataBoundItem as Figure;

                if (selectedFigure != null)
                {
                    // Check if item is already in cart
                    var existingCartItem = shoppingCartItems.FirstOrDefault(item => item.FigureId == selectedFigure.Id);

                    if (existingCartItem != null)
                    {
                        // Increment quantity if already in cart
                        existingCartItem.Quantity++;
                    }
                    else
                    {
                        // Add new item to cart
                        var newCartItem = new CartItem
                        {
                            FigureId = selectedFigure.Id,
                            FigureName = selectedFigure.Name,
                            UnitPrice = selectedFigure.Price, // Consider sale price here if applicable
                            Quantity = 1
                        };
                        shoppingCartItems.Add(newCartItem);
                    }
                    UpdateTotalPrice();
                }
            }
            else
            {
                MessageBox.Show("Please select a figure to add to the cart.", "No Figure Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Method to update the total price label
        private void UpdateTotalPrice()
        {
            double total = shoppingCartItems.Sum(item => item.TotalPrice);
            lblTotalPrice.Text = $"Total: {total:C}"; // Format as currency
        }
        
    }
}