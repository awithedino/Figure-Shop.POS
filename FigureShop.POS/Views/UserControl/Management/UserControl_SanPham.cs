// ReSharper disable LocalizableElement

using FigureShop.POS.Data;
using FigureShop.POS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FigureShop.POS.Views.UserControl.Management
{
    public partial class UserControl_SanPham : System.Windows.Forms.UserControl
    {
        private FigureShopDbContext context;
        private bool isAdding = false;
        private Guid? selectedFigureId = null; // Tracks which figure is selected
        private string selectedImagePath = null; // Tracks the path of a new image

        public UserControl_SanPham()
        {
            InitializeComponent();
        }

        // Load event
        private void UserControl_SanPham_Load(object sender, EventArgs e)
        {
            context = new FigureShopDbContext();
            
            LoadData();         // Fill the DataGridView
            LoadComboBoxes();   // Fill the dropdowns
            
            ToggleMode(false);    // Set to "View" mode
            ClearFields();
        }

        // Helper functions
        private void LoadData()
        {
            try
            {
                // We use Include() to get the Branch and Category names
                var figures = context.Figures
                    .Include(f => f.Branch)
                    .Include(f => f.Category)
                    .Select(f => new
                    {
                        f.Id,
                        f.Name,
                        f.Price,
                        f.Quantity,
                        BranchName = f.Branch.Name, // Get the name from the related table
                        CategoryName = f.Category.Name // Get the name
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadComboBoxes()
        {
            // Load Branches
            cmbBranch.DataSource = context.Branches.ToList();
            cmbBranch.DisplayMember = "Name";
            cmbBranch.ValueMember = "Id";
            cmbBranch.SelectedItem = null; // Start blank

            // Load Categories
            cmbCategory.DataSource = context.Categories.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedItem = null; // Start blank
        }
        
        private void ToggleMode(bool isEditing)
        {
            // Enable/Disable input controls
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
            
            // Enable/Disable buttons
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
            picFigure.Image = null; // Clear the image
            
            selectedFigureId = null;
            selectedImagePath = null;
        }

        // DataGridViews
        private void dgvFigures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                // Get the ID from the clicked row
                var figureId = (Guid)dgvFigures.Rows[e.RowIndex].Cells["Id"].Value;
                selectedFigureId = figureId;

                // Load the FULL figure object from the database
                var figure = context.Figures.Find(figureId);
                if (figure != null)
                {
                    // Populate all the fields
                    txtName.Text = figure.Name;
                    numPrice.Value = (decimal)figure.Price;
                    numQuantity.Value = figure.Quantity;
                    numSalePercent.Value = (decimal)figure.SalePercent;
                    txtDescription.Text = figure.Description;

                    // Set ComboBoxes
                    cmbBranch.SelectedValue = figure.BranchId ?? Guid.Empty;
                    cmbCategory.SelectedValue = figure.CategoryId ?? Guid.Empty;

                    // Handle nullable dates
                    dtpSaleFrom.Value = figure.SaleFrom ?? DateTime.Now;
                    dtpSaleTo.Value = figure.SaleTo ?? DateTime.Now;

                    // Clear old image and selected path
                    picFigure.Image = null;
                    selectedImagePath = null;
                    // TODO: Load image from figure.ImgSrcJson
                    // This part is complex as it requires parsing the JSON
                    // and loading a file from a path.
                }
            }
        }
        
        // Button click events
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ToggleMode(true);
            ClearFields();
            txtName.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedFigureId == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            isAdding = false;
            ToggleMode(true);
            txtName.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên figure không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (cmbBranch.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một Hãng (Branch).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBranch.Focus();
                return;
            }
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một Thế Loại (Category).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return;
            }

            try
            {
                var adminId = context.Users.First(u => u.Email == "admin@figureshop.com").Id;

                Figure figureToSave;

                if (isAdding)
                {
                    // === ADD (CREATE) ===
                    figureToSave = new Figure
                    {
                        Id = Guid.NewGuid(), // Create a new ID
                        CreatedAt = DateTime.Now,
                        CreatedBy = adminId
                    };
                    context.Figures.Add(figureToSave);
                }
                else
                {
                    figureToSave = context.Figures.Find(selectedFigureId);
                    if (figureToSave == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                
                figureToSave.Name = txtName.Text.Trim();
                figureToSave.BranchId = (Guid)cmbBranch.SelectedValue;
                figureToSave.CategoryId = (Guid)cmbCategory.SelectedValue;
                figureToSave.Price = (double)numPrice.Value;
                figureToSave.Quantity = (int)numQuantity.Value;
                figureToSave.SalePercent = (double)numSalePercent.Value;
                figureToSave.SaleFrom = dtpSaleFrom.Value;
                figureToSave.SaleTo = dtpSaleTo.Value;
                figureToSave.Description = txtDescription.Text.Trim();
                
                // TODO: Image saving logic
                // if (!string.IsNullOrEmpty(selectedImagePath))
                // {
                //    ... copy file to a "images" folder
                //    ... update figureToSave.ImgSrcJson
                // }

                figureToSave.UpdatedAt = DateTime.Now;
                figureToSave.UpdatedBy = adminId;
                
                context.SaveChanges();
                MessageBox.Show(isAdding ? "Thêm sản phẩm thành công!" : "Cập nhật sản phẩm thành công!", 
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (selectedFigureId == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xoá.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var figureName = txtName.Text;
            var result = MessageBox.Show($"Bạn có chắc chắn muốn xoá sản phẩm '{figureName}' không?", 
                                         "Xác nhận xoá", 
                                         MessageBoxButtons.YesNo, 
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var figureToDelete = context.Figures.Find(selectedFigureId);
                    if (figureToDelete != null)
                    {
                        context.Figures.Remove(figureToDelete);
                        context.SaveChanges();
                        
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (DbUpdateException ex) 
                {
                    MessageBox.Show("Không thể xoá sản phẩm này. Có thể nó đang được sử dụng trong một đơn hàng.", 
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
            

            if (selectedFigureId != null)
            {
                foreach (DataGridViewRow row in dgvFigures.Rows)
                {
                    if ((Guid)row.Cells["Id"].Value == selectedFigureId)
                    {
                        dgvFigures_CellClick(dgvFigures, new DataGridViewCellEventArgs(0, row.Index));
                        break;
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh sản phẩm";
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = dialog.FileName;
                    picFigure.Image = new Bitmap(dialog.FileName);
                }
            }
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Get the text from your NEW search box
            var searchText = txtTimKiem.Text.Trim().ToLower();

            // Load all figures if the search box is empty
            if (string.IsNullOrEmpty(searchText))
            {
                LoadData(); // This is your existing function to load everything
                return;
            }

            try
            {
                // Find matching figures
                var results = context.Figures
                    .Include(f => f.Branch)   // Don't forget Includes!
                    .Include(f => f.Category) // Or the names will be blank
                    .Where(f => f.Name.ToLower().Contains(searchText) || 
                                f.Branch.Name.ToLower().Contains(searchText) || // Bonus: search by branch!
                                f.Category.Name.ToLower().Contains(searchText)) // Bonus: search by category!
                    .Select(f => new // Select the same anonymous type as your LoadData()
                    {
                        f.Id,
                        f.Name,
                        f.Price,
                        f.Quantity,
                        BranchName = f.Branch.Name,
                        CategoryName = f.Category.Name
                    })
                    .ToList();

                // 4. Show the results
                dgvFigures.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
            ToggleMode(false);
            isAdding = false;
        }

        // Cleanup
        protected override void OnHandleDestroyed(EventArgs e)
        {
            context?.Dispose();
            base.OnHandleDestroyed(e);
        }
    }
}