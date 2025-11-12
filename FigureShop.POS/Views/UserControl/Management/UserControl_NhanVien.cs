// ReSharper disable LocalizableElement
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FigureShop.POS.Data;
using Microsoft.EntityFrameworkCore;
using FigureShop.POS.Data.Models; // Make sure this is your Models path

namespace FigureShop.POS.Views.UserControl.Management;

public partial class UserControl_NhanVien : System.Windows.Forms.UserControl
{
    private FigureShopDbContext context;
    private bool isAdding = false;
    private User loggedInUser; // For CreatedBy/UpdatedBy
    
    public UserControl_NhanVien()
    {
        InitializeComponent();
    }
    
    // Load event
    private void UserControl_NhanVien_Load(object sender, EventArgs e)
        {
            context = new FigureShopDbContext();
            
            // Get the admin user for tracking changes
            loggedInUser = context.Users.FirstOrDefault(u => u.Email == "admin@figureshop.com");
            
            LoadRolesComboBox();
            LoadGenderComboBox(); // Helper to fill "Nam", "Nữ"
            LoadData();
            
            ToggleMode(false);
            txtMaNV.ReadOnly = true;
        }

        // Helper
        private void LoadRolesComboBox()
        {
            // Define the roles this screen is allowed to manage
            var staffRoles = new[] { "Admin", "Staff" }; 
    
            var roles = context.Roles
                .Where(r => staffRoles.Contains(r.Name))
                .ToList();
            
            cboMaCV.DataSource = roles;
            cboMaCV.DisplayMember = "Name";
            cboMaCV.ValueMember = "Name"; 
            cboMaCV.SelectedItem = null;
        }
        
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
                var staffRoles = new[] { "Admin", "Staff" };
                
                if (query == null)
                {
                    query = context.Users.AsQueryable();
                }

                // This is the magic! Filter by role.
                var staff = query
                    .Include(u => u.RolesNames) // IMPORTANT: Load the Roles
                    .Where(u => u.RolesNames.Any(r => staffRoles.Contains(r.Name)))
                    .Select(u => new
                    {
                        u.Id,
                        u.FullName,
                        u.PhoneNumber,
                        u.Email,
                        RoleName = u.RolesNames.FirstOrDefault().Name // Get the first role name
                    })
                    .ToList();
                
                dgvNhanVien.DataSource = staff;
                
                // Format Headers
                if (dgvNhanVien.Columns.Count > 0)
                {
                    dgvNhanVien.Columns["Id"].HeaderText = "Mã NV";
                    dgvNhanVien.Columns["FullName"].HeaderText = "Tên NV";
                    dgvNhanVien.Columns["PhoneNumber"].HeaderText = "SĐT";
                    dgvNhanVien.Columns["Email"].HeaderText = "Email";
                    dgvNhanVien.Columns["RoleName"].HeaderText = "Chức Vụ";
                    
                    dgvNhanVien.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvNhanVien.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            txtTenNV.Enabled = isEditing;
            cboGioiTinh.Enabled = isEditing;
            dtpNgaySinh.Enabled = isEditing;
            txtSDT.Enabled = isEditing;
            txtDiaChi.Enabled = isEditing;
            cboMaCV.Enabled = isEditing;
            txtEmail.Enabled = isEditing;
            txtPassword.Enabled = isEditing;

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
            txtMaNV.Text = "Id sẽ được tạo tự động";
            txtTenNV.Text = "";
            cboGioiTinh.SelectedItem = null;
            dtpNgaySinh.Value = DateTime.Now;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            cboMaCV.SelectedItem = null;
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        // Button
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ToggleMode(true);
            ClearFields();
            txtMaNV.Text = "[Tự động]";
            txtTenNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            ToggleMode(true);
            txtEmail.Enabled = false; // Don't let them edit the Email (it's a key)
            txtPassword.Text = "********"; // Hide password
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // === VALIDATION ===
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || 
                (isAdding && string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                MessageBox.Show("Tên, Email, và Mật khẩu (khi thêm mới) không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboMaCV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Chức vụ (Mã CV) cho nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (isAdding)
                {
                    // === ADD (CREATE) ===
                    // Check if email already exists
                    if (context.Users.Any(u => u.Email == txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Email này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    var newUser = new User
                    {
                        Id = Guid.NewGuid(),
                        Email = txtEmail.Text.Trim(),
                        Password = txtPassword.Text, // TODO: You should HASH this!
                        Status = "Active",
                        FullName = txtTenNV.Text.Trim(),
                        Gender = cboGioiTinh.SelectedItem?.ToString(),
                        Birthday = dtpNgaySinh.Value,
                        PhoneNumber = txtSDT.Text.Trim(),
                        Address = txtDiaChi.Text.Trim(),
                        CreatedAt = DateTime.Now,
                        CreatedBy = loggedInUser.Id,
                        UpdatedAt = DateTime.Now,
                        UpdatedBy = loggedInUser.Id,
                        RolesNames = new List<Role>() // Initialize the list
                    };

                    // Add the selected role
                    var selectedRoleName = cboMaCV.SelectedValue.ToString();
                    var role = context.Roles.Find(selectedRoleName);
                    if (role != null) newUser.RolesNames.Add(role);

                    context.Users.Add(newUser);
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // === EDIT (UPDATE) ===
                    var userId = Guid.Parse(txtMaNV.Text);
                    var userToUpdate = context.Users.Include(u => u.RolesNames).FirstOrDefault(u => u.Id == userId);
                    
                    if (userToUpdate != null)
                    {
                        // Update info
                        userToUpdate.FullName = txtTenNV.Text.Trim();
                        userToUpdate.Gender = cboGioiTinh.SelectedItem?.ToString();
                        userToUpdate.Birthday = dtpNgaySinh.Value;
                        userToUpdate.PhoneNumber = txtSDT.Text.Trim();
                        userToUpdate.Address = txtDiaChi.Text.Trim();
                        userToUpdate.UpdatedAt = DateTime.Now;
                        userToUpdate.UpdatedBy = loggedInUser.Id;
                        
                        // Update password ONLY if they typed a new one
                        if (txtPassword.Text != "********")
                        {
                            userToUpdate.Password = txtPassword.Text; // TODO: Hash this!
                        }

                        // Update the role
                        userToUpdate.RolesNames.Clear();
                        var selectedRoleName = cboMaCV.SelectedValue.ToString();
                        var role = context.Roles.Find(selectedRoleName);
                        if (role != null) userToUpdate.RolesNames.Add(role);
                        
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvNhanVien.CurrentRow == null) return;

            var userId = (Guid)dgvNhanVien.CurrentRow.Cells["Id"].Value;
            var userName = dgvNhanVien.CurrentRow.Cells["FullName"].Value.ToString();
            
            if (MessageBox.Show($"Bạn có chắc chắn muốn xoá nhân viên '{userName}'?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var userToDelete = context.Users.Find(userId);
                    if (userToDelete != null)
                    {
                        if (userToDelete.Id == loggedInUser.Id)
                        {
                             MessageBox.Show("Bạn không thể xoá chính mình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvNhanVien.CurrentRow != null)
            {
                dgvNhanVien_CellClick(dgvNhanVien, new DataGridViewCellEventArgs(0, dgvNhanVien.CurrentRow.Index));
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
            
            var baseQuery = context.Users.AsQueryable();
            var filteredQuery = baseQuery
                .Where(u => u.FullName.ToLower().Contains(searchText) || 
                            u.Id.ToString().Contains(searchText) || 
                            u.Email.ToLower().Contains(searchText));
            
            LoadData(filteredQuery);
        }

        // DataGridView
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                var row = dgvNhanVien.Rows[e.RowIndex];
                var userId = (Guid)row.Cells["Id"].Value;

                // We must query the DB again to get ALL fields
                var user = context.Users.Include(u => u.RolesNames).FirstOrDefault(u => u.Id == userId);
                if (user == null) return;
                
                txtMaNV.Text = user.Id.ToString();
                txtTenNV.Text = user.FullName;
                cboGioiTinh.SelectedItem = user.Gender;
                dtpNgaySinh.Value = user.Birthday ?? DateTime.Now;
                txtSDT.Text = user.PhoneNumber;
                txtDiaChi.Text = user.Address;
                txtEmail.Text = user.Email;
                txtPassword.Text = "********";
                
                // Set the role combobox
                cboMaCV.SelectedValue = user.RolesNames.FirstOrDefault()?.Name;
            }
        }
        
        // Cleanup
        protected override void OnHandleDestroyed(EventArgs e)
        {
            context?.Dispose();
            base.OnHandleDestroyed(e);
        }
    
}