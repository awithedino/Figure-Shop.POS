// ReSharper disable LocalizableElement
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using FigureShop.POS.Data;
using FigureShop.POS.Data.Models;
using FigureShop.POS.ViewModels;

namespace FigureShop.POS.Views.UserControl.Operations
{
    public partial class UserControl_NhapHang : System.Windows.Forms.UserControl
    {
        private FigureShopDbContext context;
        private User loggedInUser;
        
        // This list is bound to the DataGridView.
        private BindingList<ImportItemViewModel> importList;

        public UserControl_NhapHang()
        {
            InitializeComponent();
        }

        // Load event
        private void UserControl_NhapHang_Load(object sender, EventArgs e)
        {
            context = new FigureShopDbContext();
            
            // Get the logged-in user (hard-coded for now)
            loggedInUser = context.Users.FirstOrDefault(u => u.Email == "admin@figureshop.com");

            // Setup the grid
            importList = new BindingList<ImportItemViewModel>();
            dgvNhapHang.DataSource = importList;
            
            if (dgvNhapHang.Columns.Count > 0)
            {
                dgvNhapHang.Columns["MaSP"].HeaderText = "Mã SP";
                dgvNhapHang.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
                dgvNhapHang.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgvNhapHang.Columns["DonGiaNhap"].HeaderText = "Đơn Giá Nhập";
                dgvNhapHang.Columns["ThanhTien"].HeaderText = "Thành Tiền";

                // Optional: Make the Name column fill the extra space
                dgvNhapHang.Columns["TenSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            LoadComboBoxes();
            StartNewImportBill();
            
            txtDonGia.TextChanged += (s, ev) => UpdateThanhTien();
            numSoLuong.ValueChanged += (s, ev) => UpdateThanhTien();
        }

        // Helper
        private void LoadComboBoxes()
        {
            // === Load Staff (Users with 'Admin' or 'Staff' role) ===
            var staffRoles = new[] { "Admin", "Staff" };
            var staffList = context.Users
                .Include(u => u.RolesNames) // Join with the Roles table
                .Where(u => u.RolesNames.Any(r => staffRoles.Contains(r.Name)))
                .ToList();
        
            cboTenNhanVien.DataSource = staffList;
            cboTenNhanVien.DisplayMember = "FullName"; // <-- CHANGED
            cboTenNhanVien.ValueMember = "Id";

            // === Load Brands (Hãng) ===
            cboTenHang.DataSource = context.Branches.ToList();
            cboTenHang.DisplayMember = "Name"; // <-- CHANGED
            cboTenHang.ValueMember = "Id";
    
            // === Load Products (Figures) ===
            cboTenSanPham.DataSource = context.Figures.ToList();
            cboTenSanPham.DisplayMember = "Name"; // <-- CHANGED
            cboTenSanPham.ValueMember = "Id";
            
            if (loggedInUser != null)
            {
                cboTenNhanVien.SelectedValue = loggedInUser.Id;
            }
    
            cboTenHang.SelectedItem = null;
            cboTenSanPham.SelectedItem = null;
        }

        private void StartNewImportBill()
        {
            txtMaHoaDonNhap.Text = $"NH-{DateTime.Now:yyyyMMdd}-{Guid.NewGuid().ToString().Substring(0, 4).ToUpper()}";
            dtpNgayNhap.Value = DateTime.Now;
            importList.Clear();
            ClearItemFields();
        }

        private void ClearItemFields()
        {
            cboTenSanPham.SelectedItem = null;
            numSoLuong.Value = 1;
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
        }
        
        private void UpdateThanhTien()
        {
            // Get the quantity
            int.TryParse(numSoLuong.Value.ToString(), out int soLuong);
    
            // Get the cost price
            // .Replace(",", "") is important in case you type "10,000"
            double.TryParse(txtDonGia.Text.Replace(",", ""), out double donGia);

            // Calculate and set the total
            double thanhTien = soLuong * donGia;
            txtThanhTien.Text = thanhTien.ToString("N0"); // "N0" formats it nicely
        }

        // Combo Box event

        
        // Updated frame
        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            UpdateThanhTien();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            UpdateThanhTien();
        }

        // Detailed button
        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (cboTenSanPham.SelectedItem is not Figure selectedFigure)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int.TryParse(numSoLuong.Value.ToString(), out int soLuong);
            double.TryParse(txtDonGia.Text.Replace(",", ""), out double donGia);

            if (soLuong <= 0)
            {
                 MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }

            // Check if item is already in the list
            var itemInList = importList.FirstOrDefault(item => item.MaSP == selectedFigure.Id);
            if (itemInList != null)
            {
                // Update existing item
                itemInList.SoLuong += soLuong;
                itemInList.DonGiaNhap = donGia; // Update price
            }
            else
            {
                // Add new item to the list
                importList.Add(new ImportItemViewModel
                {
                    MaSP = selectedFigure.Id,
                    TenSP = selectedFigure.Name,
                    SoLuong = soLuong,
                    DonGiaNhap = donGia
                });
            }
            
            importList.ResetBindings(); // Refresh the grid
            ClearItemFields();
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvNhapHang.CurrentRow == null) return;
            
            var selectedItem = dgvNhapHang.CurrentRow.DataBoundItem as ImportItemViewModel;
            importList.Remove(selectedItem);
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            // Move item from grid back to controls
            if (dgvNhapHang.CurrentRow == null) return;
            
            var selectedItem = dgvNhapHang.CurrentRow.DataBoundItem as ImportItemViewModel;
            
            // Move data back up
            cboTenSanPham.SelectedValue = selectedItem.MaSP;
            numSoLuong.Value = selectedItem.SoLuong;
            txtDonGia.Text = selectedItem.DonGiaNhap.ToString("N0");
            
            // Remove from list 
            importList.Remove(selectedItem);
        }

        // Save button
        
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            if (importList.Count == 0)
            {
                MessageBox.Show("Hoá đơn nhập hàng trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Warning
            // The code below ONLY updates the stock quantity.
            // It does NOT save the cost price (Đơn Giá Nhập) because
            // your 'Figures' table has no 'GiaNhap' column.
            
            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn lưu hoá đơn này?\n" +
                $"Việc này sẽ CỘNG THÊM số lượng vào kho.\n\n" +
                $"(Lưu ý: 'Đơn giá nhập' sẽ không được lưu.)", 
                "Xác nhận nhập kho", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            try
            {
                foreach (var item in importList)
                {
                    var figureToUpdate = context.Figures.Find(item.MaSP);
                    if (figureToUpdate != null)
                    {
                        figureToUpdate.Quantity += item.SoLuong;
                    }
                }
                
                context.SaveChanges();
                
                MessageBox.Show("Nhập kho thành công!\nĐã cập nhật số lượng sản phẩm.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                StartNewImportBill();
                LoadComboBoxes(); // Reload products to get new stock
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lưu thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        protected override void OnHandleDestroyed(EventArgs e)
        {
            context?.Dispose();
            base.OnHandleDestroyed(e);
        }
    }
}