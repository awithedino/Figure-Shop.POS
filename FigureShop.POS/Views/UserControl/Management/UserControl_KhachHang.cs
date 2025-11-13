// ReSharper disable LocalizableElement
using FigureShop.POS.Data;
using FigureShop.POS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FigureShop.POS.Views.UserControl.Management;

public partial class UserControl_KhachHang : System.Windows.Forms.UserControl
{
    private FigureShopDbContext context;
        private bool isAdding = false;
        private User loggedInUser;

        public UserControl_KhachHang()
        {
            InitializeComponent();
        }

        // Load event
        private void UserControl_KhachHang_Load(object sender, EventArgs e)
        {
            context = new FigureShopDbContext();
            
            // Get the admin user for tracking changes
            loggedInUser = context.Users.FirstOrDefault(u => u.Email == "admin@figureshop.com");
            
            LoadGenderComboBox();
            LoadData();
            
            ToggleMode(false);
            txtMaKH.ReadOnly = true;
        }

        // Helper functions
        private void LoadGenderComboBox()
        {
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Khác");
            cboGioiTinh.SelectedItem = null;
        }
        
        private void LoadData(IQueryable<User> query = null)
        {
            try
            {
                if (query == null)
                {
                    query = context.Users.AsQueryable();
                }

                // This is the magic! Filter by role.
                var customers = query
                    .Include(u => u.RolesNames) // IMPORTANT: Load the Roles
                    .Where(u => u.RolesNames.Any(r => r.Name == "Customer"))
                    .Select(u => new
                    {
                        u.Id,
                        u.FullName,
                        u.PhoneNumber,
                        u.Address
                    })
                    .ToList();
                
                dgvKhachHang.DataSource = customers;
                
                if (dgvKhachHang.Columns.Count > 0)
                {
                    dgvKhachHang.Columns["Id"].HeaderText = "Mã KH";
                    dgvKhachHang.Columns["FullName"].HeaderText = "Tên Khách Hàng";
                    dgvKhachHang.Columns["PhoneNumber"].HeaderText = "SĐT";
                    dgvKhachHang.Columns["Address"].HeaderText = "Địa Chỉ";
                    
                    dgvKhachHang.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvKhachHang.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ToggleMode(bool isEditing)
        {
            // Enable/Disable input fields
            txtMaKH.Enabled = isEditing;
            cboGioiTinh.Enabled = isEditing;
            dtpNgaySinh.Enabled = isEditing;
            txtSDT.Enabled = isEditing;
            txtDiaChi.Enabled = isEditing;

            // Enable/Disable buttons
            btnLuu.Enabled = isEditing;
            btnBoQua.Enabled = isEditing;
            
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnReload.Enabled = !isEditing;
            btnTimKiem.Enabled = !isEditing;
            txtSearch.Enabled = !isEditing;
        }

        private void ClearFields()
        {
            txtMaKH.Text = "Id sẽ được tạo tự động";
            txtTenKH.Text = "";
            cboGioiTinh.SelectedItem = null;
            dtpNgaySinh.Value = DateTime.Now;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        // Button events

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ToggleMode(true);
            ClearFields();
            txtMaKH.Text = "[Tự động]";
            txtTenKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            ToggleMode(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Find the "Customer" role to assign
                var customerRole = context.Roles.Find("Customer");
                if (customerRole == null)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy vai trò 'Customer' trong database!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (isAdding)
                {
                    // === ADD (CREATE) ===
                    var newUser = new User
                    {
                        Id = Guid.NewGuid(),
                        Email = null, // Email is optional!
                        Password = null, // Password is optional!
                        Status = "Active",
                        FullName = txtTenKH.Text.Trim(),
                        Gender = cboGioiTinh.SelectedItem?.ToString(),
                        Birthday = dtpNgaySinh.Value,
                        PhoneNumber = txtSDT.Text.Trim(),
                        Address = txtDiaChi.Text.Trim(),
                        CreatedAt = DateTime.Now,
                        CreatedBy = loggedInUser.Id,
                        UpdatedAt = DateTime.Now,
                        UpdatedBy = loggedInUser.Id,
                        RolesNames = new List<Role> { customerRole } // Auto-assign "Customer" role
                    };

                    context.Users.Add(newUser);
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var userId = Guid.Parse(txtMaKH.Text);
                    var userToUpdate = context.Users.Find(userId);
                    
                    if (userToUpdate != null)
                    {
                        // Update info
                        userToUpdate.FullName = txtTenKH.Text.Trim();
                        userToUpdate.Gender = cboGioiTinh.SelectedItem?.ToString();
                        userToUpdate.Birthday = dtpNgaySinh.Value;
                        userToUpdate.PhoneNumber = txtSDT.Text.Trim();
                        userToUpdate.Address = txtDiaChi.Text.Trim();
                        userToUpdate.UpdatedAt = DateTime.Now;
                        userToUpdate.UpdatedBy = loggedInUser.Id;
                        
                        MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lưu thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            LoadData();
            ToggleMode(false);
            ClearFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;

            var userId = (Guid)dgvKhachHang.CurrentRow.Cells["Id"].Value;
            var userName = dgvKhachHang.CurrentRow.Cells["FullName"].Value.ToString();
            
            if (MessageBox.Show($"Bạn có chắc chắn muốn xoá khách hàng '{userName}'?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var userToDelete = context.Users.Find(userId);
                    if (userToDelete != null)
                    {
                        // Check if customer has orders
                        if (context.Orders.Any(o => o.UserId == userId))
                        {
                            MessageBox.Show("Không thể xoá khách hàng này vì họ đã có hoá đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        context.Users.Remove(userToDelete);
                        context.SaveChanges();
                        LoadData();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xoá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ToggleMode(false);
            ClearFields();
            // Re-select the last row
            if (dgvKhachHang.CurrentRow != null)
            {
                dgvKhachHang_CellClick(dgvKhachHang, new DataGridViewCellEventArgs(0, dgvKhachHang.CurrentRow.Index));
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
            ClearFields();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.Trim().ToLower();
            
            var baseQuery = context.Users
                .Include(u => u.RolesNames)
                .Where(u => u.RolesNames.Any(r => r.Name == "Customer"));
            
            var filteredQuery = baseQuery
                .Where(u => u.FullName.ToLower().Contains(searchText) || 
                            u.Id.ToString().Contains(searchText) || 
                            u.PhoneNumber.Contains(searchText));
            
            LoadData(filteredQuery);
        }

        // DataGridView
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                var row = dgvKhachHang.Rows[e.RowIndex];
                var userId = (Guid)row.Cells["Id"].Value;
                
                var user = context.Users.Find(userId);
                if (user == null) return;
                
                txtMaKH.Text = user.Id.ToString();
                txtTenKH.Text = user.FullName;
                cboGioiTinh.SelectedItem = user.Gender;
                dtpNgaySinh.Value = user.Birthday ?? DateTime.Now;
                txtSDT.Text = user.PhoneNumber;
                txtDiaChi.Text = user.Address;
            }
        }
        
        // Cleanup
        protected override void OnHandleDestroyed(EventArgs e)
        {
            context?.Dispose();
            base.OnHandleDestroyed(e);
        }
}