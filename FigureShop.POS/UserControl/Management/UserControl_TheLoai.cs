// ReSharper disable LocalizableElement
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FigureShop.POS.Models;
using Microsoft.EntityFrameworkCore;

namespace FigureShop.POS;

public partial class UserControl_TheLoai : System.Windows.Forms.UserControl
{
    private FigureShopDbContext context;
    private bool isAdding = false;
    
    public UserControl_TheLoai()
    {
        InitializeComponent();
    }
    
    // Load
    private void UserControl_TheLoai_Load(object sender, EventArgs e)
    {
        context = new FigureShopDbContext();
        LoadData();
        ToggleMode(false);
        txtID.ReadOnly = true;
        txtID.Text = "ID sẽ được tạo tự động";
    }
    
    // Helper
    private void LoadData()
    {
        try
        {
            var categories = context.Categories
                .Select(c => new { c.Id, c.Name })
                .ToList();
            dgvTheLoai.DataSource = categories;
            
            if (dgvTheLoai.Columns.Count > 0)
            {
                dgvTheLoai.Columns["Id"].HeaderText = "Mã Thể Loại";
                dgvTheLoai.Columns["Name"].HeaderText = "Tên Thể Loại";

                if (dgvTheLoai.Columns.Contains("Name"))
                {
                    dgvTheLoai.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Không thể tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void ToggleMode(bool isEditing)
    {
        txtTheLoai.Enabled = isEditing;
        btnLuu.Enabled = isEditing;
        btnBoQua.Enabled = isEditing;
        btnThem.Enabled = !isEditing;
        btnSua.Enabled = !isEditing;
        btnXoa.Enabled = !isEditing;
        btnReload.Enabled = !isEditing;
        btnTimKiem.Enabled = !isEditing;
        txtTimKiem.Enabled = !isEditing;
    }

    private void ClearFields()
    {
        txtID.Text = "";
        txtTheLoai.Text = "";
        if (!isAdding) txtID.Text = "ID sẽ được tạo tự động";
    }
    
    // Button events
    private void btnThem_Click(object sender, EventArgs e)
    {
        isAdding = true;
        ToggleMode(true);
        ClearFields();
        txtID.Text = "[Tự động]";
        txtTheLoai.Focus();
    }
    
    private void btnSua_Click(object sender, EventArgs e)
    {
        if (dgvTheLoai.CurrentRow == null)
        {
            MessageBox.Show("Vui lòng chọn thể loại để sửa.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        isAdding = false;
        ToggleMode(true);
        txtTheLoai.Focus();
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTheLoai.Text))
        {
            MessageBox.Show("Tên thể loại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTheLoai.Focus();
            return;
        }

        try
        {
            var adminId = context.Users.First(u => u.Email == "admin@figureshop.com").Id;

            if (isAdding)
            {
                var newCategory = new Category
                {
                    Id = Guid.NewGuid(),
                    Name = txtTheLoai.Text.Trim(),
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now,
                    CreatedBy = adminId, UpdatedBy = adminId
                };
                context.Categories.Add(newCategory);
                MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var catId = Guid.Parse(txtID.Text);
                var category = context.Categories.Find(catId);
                if (category != null)
                {
                    category.Name = txtTheLoai.Text.Trim();
                    category.UpdatedAt = DateTime.Now;
                    category.UpdatedBy = adminId;
                    MessageBox.Show("Cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        isAdding = false;
    }
    
    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (dgvTheLoai.CurrentRow == null)
        {
            MessageBox.Show("Vui lòng chọn thể loại để xoá.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var catId = (Guid)dgvTheLoai.CurrentRow.Cells["Id"].Value;
        var catName = dgvTheLoai.CurrentRow.Cells["Name"].Value.ToString();

        if (MessageBox.Show($"Bạn có chắc chắn muốn xoá thể loại '{catName}' không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                var category = context.Categories.Find(catId);
                if (category != null)
                {
                    context.Categories.Remove(category);
                    context.SaveChanges();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Không thể xoá thể loại này vì đang có sản phẩm thuộc về nó.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnBoQua_Click(object sender, EventArgs e)
    {
        ToggleMode(false);
        ClearFields();
        isAdding = false;
        if (dgvTheLoai.CurrentRow != null)
            dgvTheLoai_CellClick(dgvTheLoai, new DataGridViewCellEventArgs(0, dgvTheLoai.CurrentRow.Index));
    }
    
    private void btnReload_Click(object sender, EventArgs e)
    {
        txtTimKiem.Text = "";
        LoadData();
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
        var searchText = txtTimKiem.Text.Trim().ToLower();
        if (string.IsNullOrEmpty(searchText))
        {
            LoadData();
            return;
        }
        var results = context.Categories
            .Where(c => c.Name.ToLower().Contains(searchText) || c.Id.ToString().Contains(searchText))
            .Select(c => new { c.Id, c.Name })
            .ToList();
        dgvTheLoai.DataSource = results;
    }

    private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !btnLuu.Enabled)
        {
            DataGridViewRow row = dgvTheLoai.Rows[e.RowIndex];
            txtID.Text = row.Cells["Id"].Value.ToString();
            txtTheLoai.Text = row.Cells["Name"].Value.ToString();
        }
    }

    // Don't forget to clean up the connection!
    protected override void OnHandleDestroyed(EventArgs e)
    {
        context?.Dispose();
        base.OnHandleDestroyed(e);
    }
}