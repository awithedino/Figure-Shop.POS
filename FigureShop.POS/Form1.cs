using System;
using System.Collections.Generic;
using System.ComponentModel; // For BindingList
using System.Linq;
using System.Windows.Forms;
// using FigureShop.POS.Models; // Uncomment if your Models namespace is correct
// using Microsoft.EntityFrameworkCore; // Uncomment if needed later

namespace FigureShop.POS
{
    public partial class Form1 : Form
    {
        // --- MenuStrip variables ---
        private MenuStrip menuStripMain;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        // --- End MenuStrip variables ---


        // private BindingList<CartItem> shoppingCartItems = new BindingList<CartItem>(); // Uncomment later

        public Form1()
        {
            InitializeComponent(); // Initializes controls defined in the Designer (if any)

            InitializeCustomMenuStrip(); // Add the MenuStrip programmatically

            // this.Load += new EventHandler(Form1_Load); // Uncomment later

            // Set up the shopping cart DataGridView (Uncomment later)
            // dgvShoppingCart.AutoGenerateColumns = true;
            // dgvShoppingCart.DataSource = shoppingCartItems;
            // ... (rest of cart setup)
        }

        // --- Method to initialize the MenuStrip ---
        private void InitializeCustomMenuStrip()
        {
            // Create MenuStrip main object
            menuStripMain = new MenuStrip();
            menuStripMain.Name = "menuStripMain";

            // Create "User" menu
            userToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Text = "&User";

            // Create "Login" sub-item
            loginToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Text = "&Login";
            loginToolStripMenuItem.Click += LoginToolStripMenuItem_Click; // Assign event handler

            // Create "Logout" sub-item
            logoutToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Text = "&Logout";
            logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click; // Assign event handler
            logoutToolStripMenuItem.Enabled = false; // Initially disabled

            // Add Login/Logout to User menu
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                loginToolStripMenuItem,
                logoutToolStripMenuItem
            });

            // Create "Manage" menu
            manageToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Text = "&Manage";

            // Create "Products" sub-item
            productsToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Text = "&Products";
            productsToolStripMenuItem.Click += ProductsToolStripMenuItem_Click; // Assign event handler

            // Create "Categories" sub-item
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Text = "&Categories";
            categoriesToolStripMenuItem.Click += CategoriesToolStripMenuItem_Click; // Assign event handler

            // Create "Orders" sub-item
            ordersToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Text = "&Orders";
            ordersToolStripMenuItem.Click += OrdersToolStripMenuItem_Click; // Assign event handler

            // Add sub-items to Manage menu
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                productsToolStripMenuItem,
                categoriesToolStripMenuItem,
                ordersToolStripMenuItem
            });

            // Create "Help" menu
            helpToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Text = "&Help";

            // Create "About" sub-item
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click; // Assign event handler

            // Add About to Help menu
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                aboutToolStripMenuItem
            });

            // Add top-level menus to the MenuStrip
            menuStripMain.Items.AddRange(new ToolStripItem[] {
                userToolStripMenuItem,
                manageToolStripMenuItem,
                helpToolStripMenuItem
            });

            // Add the MenuStrip to the Form's controls and set it as the MainMenuStrip
            this.Controls.Add(menuStripMain);
            this.MainMenuStrip = menuStripMain;

            // Optional: Ensure it docks correctly if other controls are docked Top
            // menuStripMain.Dock = DockStyle.Top; // Usually handles automatically
            // this.Controls.SetChildIndex(menuStripMain, 0); // Bring to front if needed
        }
        // --- End Method to initialize the MenuStrip ---


        // --- Placeholder Event Handlers for Menu Items ---
        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Clicked!");
            // TODO: Implement login logic
            // loginToolStripMenuItem.Enabled = false;
            // logoutToolStripMenuItem.Enabled = true;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Clicked!");
            // TODO: Implement logout logic
            // loginToolStripMenuItem.Enabled = true;
            // logoutToolStripMenuItem.Enabled = false;
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Products Clicked!");
            // TODO: Open Product Management Form or Panel
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Categories Clicked!");
            // TODO: Open Category Management Form or Panel
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Orders Clicked!");
            // TODO: Open Order Management Form or Panel
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Figure & Gundam Shop POS\nVersion 1.0", "About");
        }
        // --- End Placeholder Event Handlers ---


        // --- Existing commented-out code ---
        // private async void Form1_Load(object sender, EventArgs e) { ... }
        // private async Task LoadFiguresAsync(string? searchTerm = null) { ... }
        // private async void btnSearch_Click(object sender, EventArgs e) { ... } // Note: Duplicates btnSearch_Click below
        // private void btnAddSelectedToCart_Click(object sender, EventArgs e) { ... } // Note: Duplicates btnAddSelectedToCart_Click below
        // private void UpdateTotalPrice() { ... }
        // --- End Existing commented-out code ---


        // --- Your existing empty event handlers ---
        public void btnAddSelectedToCart_Click(object sender, EventArgs e)
        {
            // TODO: Implement Add to Cart logic (perhaps uncomment the version above)
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: Implement Search logic (perhaps uncomment the async version above)
        }
        // --- End Your existing empty event handlers ---

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void cboCategoryDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    } // End Form1 class
} // End namespace