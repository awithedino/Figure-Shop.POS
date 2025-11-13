using FigureShop.POS.Data;
using Microsoft.EntityFrameworkCore;

namespace FigureShop.POS.Views;

public partial class Form_Login : Form
{
    private readonly FigureShopDbContext _context;

    public Form_Login()
    {
        InitializeComponent();
        _context = new FigureShopDbContext(); // Uses the safe OnConfiguring
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var email = txtEmail.Text.Trim();
        var password = txtPassword.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Vui lòng nhập email và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Find the user by email
            var user = _context.Users
                .Include(u => u.RolesNames) // IMPORTANT: We must load the roles!
                .FirstOrDefault(u => u.Email == email);

            // 1. Check if user exists
            if (user == null)
            {
                MessageBox.Show("Email không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Check password
            if (user.Password != password)
            {
                // Note: This is a simple text check. In a real app, you'd hash the password!
                MessageBox.Show("Sai mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Check if user is Staff or Admin
            bool isStaffOrAdmin = user.RolesNames.Any(r => r.Name == "Admin" || r.Name == "Staff");
            if (!isStaffOrAdmin)
            {
                MessageBox.Show("Bạn không có quyền đăng nhập vào hệ thống POS.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // === SUCCESS! ===
            Program.CurrentUser = user; // Store the logged-in user globally
            this.DialogResult = DialogResult.OK; // Tell Program.cs it was successful
            this.Close(); // Close this login form
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi kết nối database: {ex.Message}", "Lỗi nghiêm trọng", MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    // Cleanup
    protected override void OnHandleDestroyed(EventArgs e)
    {
        _context?.Dispose();
        base.OnHandleDestroyed(e);
    }
}