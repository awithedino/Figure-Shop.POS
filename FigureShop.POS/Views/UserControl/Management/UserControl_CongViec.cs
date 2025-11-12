// ReSharper disable LocalizableElement
using FigureShop.POS.Data;
using FigureShop.POS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FigureShop.POS.Views.UserControl.Management;

public partial class UserControl_CongViec : System.Windows.Forms.UserControl
{
        private FigureShopDbContext context;
        private bool isAdding = false;
        
        private readonly string[] systemRoles = { "Admin", "Staff", "Customer" };

        public UserControl_CongViec()
        {
            InitializeComponent();
        }

        // Load event
        private void UserControl_CongViec_Load(object sender, EventArgs e)
        {
            context = new FigureShopDbContext();
            LoadData();
            ToggleMode(false);
        }

        // Helper
        
        private void LoadData(IQueryable<Role> query = null)
        {
            try
            {
                if (query == null)
                {
                    query = context.Roles.AsQueryable();
                }
                
                dgvCongViec.DataSource = query.OrderBy(r => r.Name).ToList();

                // Format Headers
                if (dgvCongViec.Columns.Count > 0)
                {
                    dgvCongViec.Columns["Name"].HeaderText = "Tên Công Việc";
                    dgvCongViec.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    
                    // Hide the 'Users' navigation property if it shows up
                    if (dgvCongViec.Columns.Contains("Users"))
                    {
                        dgvCongViec.Columns["Users"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ToggleMode(bool isAdding)
        {
            txtTenCV.Enabled = isAdding;
            btnLuu.Enabled = isAdding;
            btnBoQua.Enabled = isAdding;

            btnThem.Enabled = !isAdding;
            // btnSua is always disabled
            btnXoa.Enabled = !isAdding;
            btnReload.Enabled = !isAdding;
            btnTimKiem.Enabled = !isAdding;
            txtTimKiem.Enabled = !isAdding;
        }

        private void ClearFields()
        {
            txtTenCV.Text = "";
        }

        // Button events
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ToggleMode(true);
            ClearFields();
            txtTenCV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isAdding) return; 
            
            var newRoleName = txtTenCV.Text.Trim();
            if (string.IsNullOrWhiteSpace(newRoleName))
            {
                MessageBox.Show("Tên công việc không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenCV.Focus();
                return;
            }
            
            // Check if role already exists
            if (context.Roles.Any(r => r.Name.ToLower() == newRoleName.ToLower()))
            {
                MessageBox.Show("Tên công việc này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenCV.Focus();
                return;
            }

            try
            {
                var newRole = new Role { Name = newRoleName };
                context.Roles.Add(newRole);
                context.SaveChanges();
                
                MessageBox.Show("Thêm công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ToggleMode(false);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lưu thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCongViec.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một công việc để xoá.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var roleName = dgvCongViec.CurrentRow.Cells["Name"].Value.ToString();
            
            if (systemRoles.Contains(roleName))
            {
                MessageBox.Show($"Không thể xoá vai trò hệ thống '{roleName}'!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xoá công việc '{roleName}' không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var roleToDelete = context.Roles.Find(roleName);
                    if (roleToDelete != null)
                    {
                        context.Roles.Remove(roleToDelete);
                        context.SaveChanges();
                        LoadData();
                        ClearFields();
                    }
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Không thể xoá vai trò này. Có thể nó đang được gán cho một nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            isAdding = false;
            ToggleMode(false);
            ClearFields();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var searchText = txtTimKiem.Text.Trim().ToLower();
            
            var query = context.Roles
                .Where(r => r.Name.ToLower().Contains(searchText));
            
            LoadData(query);
        }

        // DataGridView
        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                var row = dgvCongViec.Rows[e.RowIndex];
                txtTenCV.Text = row.Cells["Name"].Value.ToString();
            }
        }

        // Cleanup
        protected override void OnHandleDestroyed(EventArgs e)
        {
            context?.Dispose();
            base.OnHandleDestroyed(e);
        }
    
}