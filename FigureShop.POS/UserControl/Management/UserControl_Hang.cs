// ReSharper disable LocalizableElement
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using FigureShop.POS.Models;

namespace FigureShop.POS
{
    public partial class UserControl_Hang : UserControl
    {
        private FigureShopDbContext context;
        private bool isAdding = false;

        public UserControl_Hang()
        {
            InitializeComponent();
        }
        
        private void UserControl_Hang_Load(object sender, EventArgs e)
        {
            context = new FigureShopDbContext();
            
            LoadData();
            ToggleMode(false);
            
            txtMaHang.ReadOnly = true;
            txtMaHang.Text = "Id sẽ được tạo tự động";
        }

        // Helper, separate functions
        private void LoadData()
        {
            try
            {
                var branches = context.Branches
                                    .Select(b => new { b.Id, b.Name }) 
                                    .ToList();
                
                dgvHang.DataSource = branches;

                if (dgvHang.Columns.Count > 0)
                {
                    dgvHang.Columns["Id"].HeaderText = "Mã Hãng";
                    dgvHang.Columns["Name"].HeaderText = "Tên Hãng";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ToggleMode(bool isEditing)
        {
            txtTenHang.Enabled = isEditing;
            
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
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            if (!isAdding)
            {
                txtMaHang.Text = "Id sẽ được tạo tự động";
            }
        }
        
        // Button click events
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ToggleMode(true); // Switch to "Edit" mode
            ClearFields();
            txtMaHang.Text = "[Tự động]";
            txtTenHang.Focus(); // Put the cursor in the "Name" box
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hãng để sửa.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            isAdding = false;
            ToggleMode(true);
            txtTenHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Tên hãng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenHang.Focus();
                return;
            }

            try
            {
                var adminId = context.Users.First(u => u.Email == "admin@figureshop.com").Id;

                if (isAdding)
                {
                    var newBranch = new Branch
                    {
                        Id = Guid.NewGuid(),
                        Name = txtTenHang.Text.Trim(),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        CreatedBy = adminId,
                        UpdatedBy = adminId
                    };
                    
                    context.Branches.Add(newBranch);
                    MessageBox.Show("Thêm hãng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Get the ID from the textbox
                    var branchId = Guid.Parse(txtMaHang.Text);
                    
                    // Find the existing branch in the database
                    var existingBranch = context.Branches.Find(branchId);
                    if (existingBranch != null)
                    {
                        existingBranch.Name = txtTenHang.Text.Trim();
                        existingBranch.UpdatedAt = DateTime.Now;
                        existingBranch.UpdatedBy = adminId; 
                        
                        MessageBox.Show("Cập nhật hãng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
                context.SaveChanges(); // Save changes to the database
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lưu thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            LoadData();       // Reload the grid
            ToggleMode(false); // Go back to "View" mode
            ClearFields();
            isAdding = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hãng để xoá.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID and Name from the selected row
            var branchId = (Guid)dgvHang.CurrentRow.Cells["Id"].Value;
            var branchName = dgvHang.CurrentRow.Cells["Name"].Value.ToString();

            // Confirmation dialog
            var result = MessageBox.Show($"Bạn có chắc chắn muốn xoá hãng '{branchName}' không? \nViệc này có thể ảnh hưởng đến các 'Figures' đang dùng hãng này.", 
                                         "Xác nhận xoá", 
                                         MessageBoxButtons.YesNo, 
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var branchToDelete = context.Branches.Find(branchId);
                    if (branchToDelete != null)
                    {
                        context.Branches.Remove(branchToDelete);
                        context.SaveChanges();
                        
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (DbUpdateException ex) 
                {
                    MessageBox.Show($"Không thể xoá hãng này. Đã có 'Figures' được gán cho hãng này. \nBạn phải xoá hoặc thay đổi các 'Figures' đó trước.", 
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ToggleMode(false); // Go back to "View" mode
            ClearFields();
            isAdding = false;
            
            // Restore textboxes to selected row data (if a row was selected)
            if (dgvHang.CurrentRow != null)
            {
                dgvHang_CellClick(dgvHang, new DataGridViewCellEventArgs(dgvHang.CurrentRow.Index, 0));
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                LoadData();
                return;
            }

            // Search by ID (as string) or Name
            var searchResult = context.Branches
                .Where(b => b.Id.ToString().Contains(searchText) || 
                            b.Name.ToLower().Contains(searchText))
                .Select(b => new { b.Id, b.Name })
                .ToList();
            
            dgvHang.DataSource = searchResult;
        }

        // DataGridViews only
        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                DataGridViewRow row = dgvHang.Rows[e.RowIndex];
                
                txtMaHang.Text = row.Cells["Id"].Value.ToString();
                txtTenHang.Text = row.Cells["Name"].Value.ToString();
            }
        }
        
        // Excel event
        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Exporting to Excel is more complex and usually requires
            // a third-party library like "EPPlus".
            MessageBox.Show("Chức năng Excel sẽ được thêm sau!", "Đang phát triển", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        // Cleanup
        protected override void OnHandleDestroyed(EventArgs e)
        {
            context?.Dispose();
            base.OnHandleDestroyed(e);
        }
    }
}