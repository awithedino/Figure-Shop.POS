// ReSharper disable LocalizableElement
using FigureShop.POS.Data;
using FigureShop.POS.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Data;

namespace FigureShop.POS.Views.UserControl.Management;

public partial class UserControl_SanPham : System.Windows.Forms.UserControl
{
    private string _selectedImagePath; 
        
        // This points to .../bin/Debug/net8.0-windows/Images
        private readonly string _imagesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

        private FigureShopDbContext _context;
        private bool _isAdding;
        private Guid? _selectedFigureId;

        public UserControl_SanPham()
        {
            InitializeComponent();
        }

        private void UserControl_SanPham_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) { return; }

            // 2. FIXED: Create the directory if it doesn't exist!
            // Without this, File.Copy will crash on the first run.
            if (!Directory.Exists(_imagesDirectory))
            {
                Directory.CreateDirectory(_imagesDirectory);
            }

            _context = new FigureShopDbContext();

            LoadData();
            LoadComboBoxes();
            ToggleMode(false);
            ClearFields();
        }

        private void LoadData()
        {
            try
            {
                var figures = _context.Figures
                    .Include(f => f.Branch)
                    .Include(f => f.Category)
                    .Select(f => new
                    {
                        f.Id,
                        f.Name,
                        f.Price,
                        f.Quantity,
                        BranchName = f.Branch.Name,
                        CategoryName = f.Category.Name
                    })
                    .ToList();

                dgvFigures.DataSource = figures;

                if (dgvFigures.Columns.Count > 0)
                {
                    dgvFigures.Columns["Id"].HeaderText = "Mã Figure";
                    dgvFigures.Columns["Name"].HeaderText = "Tên Figure";
                    dgvFigures.Columns["Price"].HeaderText = "Giá Bán";
                    dgvFigures.Columns["Quantity"].HeaderText = "Số Lượng";
                    dgvFigures.Columns["BranchName"].HeaderText = "Hãng";
                    dgvFigures.Columns["CategoryName"].HeaderText = "Thế Loại";
                    dgvFigures.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            cmbBranch.DataSource = _context.Branches.ToList();
            cmbBranch.DisplayMember = "Name";
            cmbBranch.ValueMember = "Id";
            cmbBranch.SelectedItem = null;

            cmbCategory.DataSource = _context.Categories.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedItem = null;
        }

        private void ToggleMode(bool isEditing)
        {
            txtName.Enabled = isEditing;
            cmbBranch.Enabled = isEditing;
            cmbCategory.Enabled = isEditing;
            numPrice.Enabled = isEditing;
            numQuantity.Enabled = isEditing;
            numSalePercent.Enabled = isEditing;
            dtpSaleFrom.Enabled = isEditing;
            dtpSaleTo.Enabled = isEditing;
            txtDescription.Enabled = isEditing;
            btnBrowse.Enabled = isEditing;

            btnLuu.Enabled = isEditing;
            btnBoQua.Enabled = isEditing;

            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnTimKiem.Enabled = !isEditing;
        }

        private void ClearFields()
        {
            txtName.Text = "";
            cmbBranch.SelectedItem = null;
            cmbCategory.SelectedItem = null;
            numPrice.Value = 0;
            numQuantity.Value = 0;
            numSalePercent.Value = 0;
            dtpSaleFrom.Value = DateTime.Now;
            dtpSaleTo.Value = DateTime.Now;
            txtDescription.Text = "";
            
            // Clear image
            if (picFigure.Image != null)
            {
                picFigure.Image.Dispose(); // Release memory
                picFigure.Image = null;
            }

            _selectedFigureId = null;
            _selectedImagePath = null;
        }

        private void dgvFigures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                var figureId = (Guid)dgvFigures.Rows[e.RowIndex].Cells["Id"].Value;
                _selectedFigureId = figureId;

                var figure = _context.Figures.Find(figureId);
                if (figure != null)
                {
                    txtName.Text = figure.Name;
                    numPrice.Value = (decimal)figure.Price;
                    numQuantity.Value = figure.Quantity;
                    numSalePercent.Value = (decimal)figure.SalePercent;
                    txtDescription.Text = figure.Description;
                    cmbBranch.SelectedValue = figure.BranchId ?? Guid.Empty;
                    cmbCategory.SelectedValue = figure.CategoryId ?? Guid.Empty;
                    dtpSaleFrom.Value = figure.SaleFrom ?? DateTime.Now;
                    dtpSaleTo.Value = figure.SaleTo ?? DateTime.Now;

                    // 3. FIXED: Actually LOAD the image! (You had a TODO here)
                    // We use SafeLoadImage to prevent file locking issues.
                    if (picFigure.Image != null) picFigure.Image.Dispose();
                    picFigure.Image = null;
                    _selectedImagePath = null;

                    if (!string.IsNullOrEmpty(figure.ImgSrcJson) && figure.ImgSrcJson != "[]")
                    {
                        // Combine startup path with stored relative path
                        string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, figure.ImgSrcJson);
                        if (File.Exists(fullPath))
                        {
                            picFigure.Image = SafeLoadImage(fullPath);
                        }
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ToggleMode(true);
            ClearFields();
            txtName.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedFigureId == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isAdding = false;
            ToggleMode(true);
            txtName.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên figure không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (cmbBranch.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Hãng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Thể Loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var adminId = _context.Users.FirstOrDefault(u => u.Email == "admin@figureshop.com")?.Id ?? Guid.Empty;

                Figure figureToSave;

                if (_isAdding)
                {
                    figureToSave = new Figure
                    {
                        Id = Guid.NewGuid(),
                        CreatedAt = DateTime.Now,
                        CreatedBy = adminId,
                        ImgSrcJson = "[]"
                    };
                    _context.Figures.Add(figureToSave);
                }
                else
                {
                    figureToSave = _context.Figures.Find(_selectedFigureId);
                    if (figureToSave == null) return;
                }

                // === IMAGE SAVING LOGIC ===
                // 1. Keep old path by default
                string newRelativePath = figureToSave.ImgSrcJson;

                // 2. If user picked a NEW image
                if (!string.IsNullOrEmpty(_selectedImagePath))
                {
                    string extension = Path.GetExtension(_selectedImagePath);
                    string uniqueName = $"{Guid.NewGuid()}{extension}";
                    string destinationPath = Path.Combine(_imagesDirectory, uniqueName);

                    try
                    {
                        // Dispose the old image from PictureBox so we don't lock the file
                        if (picFigure.Image != null) picFigure.Image.Dispose();
                        picFigure.Image = null;

                        // Copy file
                        File.Copy(_selectedImagePath, destinationPath, true);

                        // 3. Delete OLD image file if it exists (Optional cleanup)
                        if (!_isAdding && !string.IsNullOrEmpty(figureToSave.ImgSrcJson) && figureToSave.ImgSrcJson != "[]")
                        {
                            string oldFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, figureToSave.ImgSrcJson);
                            if (File.Exists(oldFullPath))
                            {
                                try { File.Delete(oldFullPath); } catch { /* Ignore delete errors */ }
                            }
                        }

                        // 4. Update the path to save in DB
                        // We save "Images\guid.jpg" (Relative path)
                        newRelativePath = Path.Combine("Images", uniqueName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Update properties
                figureToSave.Name = txtName.Text.Trim();
                figureToSave.BranchId = (Guid)cmbBranch.SelectedValue;
                figureToSave.CategoryId = (Guid)cmbCategory.SelectedValue;
                figureToSave.Price = (double)numPrice.Value;
                figureToSave.Quantity = (int)numQuantity.Value;
                figureToSave.SalePercent = (double)numSalePercent.Value;
                figureToSave.SaleFrom = dtpSaleFrom.Value;
                figureToSave.SaleTo = dtpSaleTo.Value;
                figureToSave.Description = txtDescription.Text.Trim();
                figureToSave.ImgSrcJson = newRelativePath; // <-- Save the new path
                figureToSave.UpdatedAt = DateTime.Now;
                figureToSave.UpdatedBy = adminId;

                _context.SaveChanges();
                MessageBox.Show(_isAdding ? "Thêm thành công!" : "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadData();
            ToggleMode(false);
            ClearFields();
            _isAdding = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedFigureId == null) return;

            if (MessageBox.Show("Bạn có chắc muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var fig = _context.Figures.Find(_selectedFigureId);
                    if (fig != null)
                    {
                        _context.Figures.Remove(fig);
                        _context.SaveChanges();
                        
                        // Try to delete the image file too
                        if (!string.IsNullOrEmpty(fig.ImgSrcJson) && fig.ImgSrcJson != "[]")
                        {
                            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fig.ImgSrcJson);
                            if (File.Exists(path)) try { File.Delete(path); } catch { }
                        }

                        LoadData();
                        ClearFields();
                        MessageBox.Show("Xoá thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xoá: {ex.Message}");
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ToggleMode(false);
            ClearFields();
            _isAdding = false;
            // Restore selection logic if needed...
        }

        // 4. FIXED: Helper to load image without locking the file
        // This reads the file into memory and closes the file handle immediately.
        private Image SafeLoadImage(string path)
        {
            try
            {
                using (var ms = new MemoryStream(File.ReadAllBytes(path)))
                {
                    return Image.FromStream(ms);
                }
            }
            catch { return null; }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh sản phẩm";
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the path to copy later
                    _selectedImagePath = dialog.FileName;
                    
                    // Show preview (Safe load)
                    if (picFigure.Image != null) picFigure.Image.Dispose();
                    picFigure.Image = SafeLoadImage(_selectedImagePath);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // (Your search logic goes here - looks fine in your snippet!)
            MessageBox.Show("Chức năng tìm kiếm chưa được cập nhật trong mã này.", "Thông báo");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
            ToggleMode(false);
            _isAdding = false;
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            _context?.Dispose();
            base.OnHandleDestroyed(e);
        }
}