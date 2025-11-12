// ReSharper disable LocalizableElement
using System.ComponentModel;
using FigureShop.POS.Models;
using FigureShop.POS.ViewModels;

namespace FigureShop.POS.Views.UserControl.Operations
{
    public partial class UserControl_BanHang : System.Windows.Forms.UserControl
    {
        private FigureShopDbContext context;
        private BindingList<CartItemViewModel> cart;

        private User loggedInUser;

        public UserControl_BanHang()
        {
            InitializeComponent();
        }

        // Load events
        private void UserControl_BanHang_Load(object sender, EventArgs e)
        {
            context = new FigureShopDbContext();
            
            // Get the logged-in user
            loggedInUser = context.Users.FirstOrDefault(u => u.Email == "admin@figureshop.com");

            // Setup the shopping cart
            cart = new BindingList<CartItemViewModel>();
            dgvGioHang.DataSource = cart; // <-- Bind the list to the grid
            
            // Load all ComboBoxes
            LoadComboBoxes();
            
            // Start a new, fresh bill
            StartNewBill();
        }

        // Helper
        private void LoadComboBoxes()
        {
            // Load Staff (Users)
            cboMaNhanVien.DataSource = context.Users.ToList(); // TODO: Filter by Role="Staff" later
            cboMaNhanVien.DisplayMember = "Email";
            cboMaNhanVien.ValueMember = "Id";

            // Load Customers (Users)
            cboKhachHang.DataSource = context.Users.ToList(); // TODO: Filter by Role="Customer" later
            cboKhachHang.DisplayMember = "Email";
            cboKhachHang.ValueMember = "Id";

            // Load Products (Figures)
            cboMaSanPham.DataSource = context.Figures.Where(f => f.Quantity > 0).ToList();
            cboMaSanPham.DisplayMember = "Name";
            cboMaSanPham.ValueMember = "Id";
            
            // Set to "blank" selection
            cboMaNhanVien.SelectedItem = null;
            cboKhachHang.SelectedItem = null;
            cboMaSanPham.SelectedItem = null;
            
            // Pre-select the logged-in staff member
            if (loggedInUser != null)
            {
                cboMaNhanVien.SelectedValue = loggedInUser.Id;
            }
        }
        
        private void StartNewBill()
        {
            // Generate a new, unique bill ID
            txtMaHoaDon.Text = $"HD-{DateTime.Now:yyyyMMdd}-{Guid.NewGuid().ToString().Substring(0, 4).ToUpper()}";
            dtpNgayBan.Value = DateTime.Now;
            
            // Clear the cart
            cart.Clear();
            
            // Clear customer/payment
            cboKhachHang.SelectedItem = null;
            txtKhachThanhToan.Text = "0";
            
            // Clear item selection
            ClearItemSelection();
            
            // Recalculate totals (which will be 0)
            UpdateBillTotal();
        }
        
        private void ClearItemSelection()
        {
            cboMaSanPham.SelectedItem = null;
            txtTenSanPham.Text = "";
            numSoLuong.Value = 1;
            lblGiaTriDonGia.Text = "0";
            lblGiaTriGiamGia.Text = "0";
            lblGiaTriThanhTien.Text = "0";
        }

        // Item selection

        private void cboMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When user picks a product, fill in its details
            if (cboMaSanPham.SelectedItem is Figure selectedFigure)
            {
                txtTenSanPham.Text = selectedFigure.Name;
                lblGiaTriDonGia.Text = selectedFigure.Price.ToString("N0"); // "N0" formats 150000 as "150,000"

                // Check for active sale
                double giamGia = 0;
                if (selectedFigure.SaleFrom <= DateTime.Now && selectedFigure.SaleTo >= DateTime.Now)
                {
                    giamGia = selectedFigure.Price * (selectedFigure.SalePercent / 100);
                }
                lblGiaTriGiamGia.Text = giamGia.ToString("N0");
                
                numSoLuong.Value = 1;
                UpdateItemTotal();
            }
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            UpdateItemTotal(); // Recalculate anytime the quantity changes
        }

        private void UpdateItemTotal()
        {
            // Calculate the total
            double.TryParse(lblGiaTriDonGia.Text.Replace(",", ""), out double donGia);
            double.TryParse(lblGiaTriGiamGia.Text.Replace(",", ""), out double giamGia);
            int soLuong = (int)numSoLuong.Value;
            
            double thanhTien = (donGia - giamGia) * soLuong;
            lblGiaTriThanhTien.Text = thanhTien.ToString("N0");
        }

        // Cart management logic

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaSanPham.SelectedItem is not Figure selectedFigure)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int soLuong = (int)numSoLuong.Value;
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check stock!
            if (soLuong > selectedFigure.Quantity)
            {
                MessageBox.Show($"Không đủ hàng! Chỉ còn {selectedFigure.Quantity} sản phẩm trong kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if item is already in the cart
            var itemInCart = cart.FirstOrDefault(item => item.MaSP == selectedFigure.Id);
            
            double.TryParse(lblGiaTriDonGia.Text.Replace(",", ""), out double donGia);
            double.TryParse(lblGiaTriGiamGia.Text.Replace(",", ""), out double giamGia);

            if (itemInCart != null)
            {
                // Item exists: just update its quantity
                itemInCart.SoLuong += soLuong;
            }
            else
            {
                // Item is new: add it to the cart
                cart.Add(new CartItemViewModel
                {
                    MaSP = selectedFigure.Id,
                    TenSP = selectedFigure.Name,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    GiamGia = giamGia
                });
            }

            // Refresh the grid (to show new ThanhTien) and update total bill
            cart.ResetBindings(); 
            UpdateBillTotal();
            ClearItemSelection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trong giỏ hàng để xoá.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the item from the selected row and remove it from the cart
            var selectedItem = dgvGioHang.CurrentRow.DataBoundItem as CartItemViewModel;
            cart.Remove(selectedItem);
            
            UpdateBillTotal(); // Recalculate
        }

        // Bill total

        private void UpdateBillTotal()
        {
            // Calculate total by summing up ThanhTien from everything in the cart
            double tongCong = cart.Sum(item => item.ThanhTien);
            lblGiaTriTongCong.Text = tongCong.ToString("N0");
            
            UpdateChange();
        }

        private void txtKhachThanhToan_TextChanged(object sender, EventArgs e)
        {
            UpdateChange();
        }

        private void UpdateChange()
        {
            double.TryParse(lblGiaTriTongCong.Text.Replace(",", ""), out double tongCong);
            double.TryParse(txtKhachThanhToan.Text.Replace(",", ""), out double khachDua);

            double tienThua = khachDua - tongCong;
            lblGiaTriTienThua.Text = tienThua.ToString("N0");

            // Change color if not enough money
            lblGiaTriTienThua.ForeColor = tienThua < 0 ? Color.Red : Color.Green;
        }

        // Buttons
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMaNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double.TryParse(lblGiaTriTienThua.Text.Replace(",", ""), out double tienThua);
            if (tienThua < 0)
            {
                 MessageBox.Show("Khách chưa thanh toán đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }

            // === SAVE TO DATABASE ===
            try
            {
                double.TryParse(lblGiaTriTongCong.Text.Replace(",", ""), out double tongCong);
                double.TryParse(txtKhachThanhToan.Text.Replace(",", ""), out double khachDua);

                // Create the main Order
                var newOrder = new Order
                {
                    Id = Guid.NewGuid(),
                    UserId = (Guid)cboKhachHang.SelectedValue,
                    VoucherId = null, // TODO: Add voucher logic later
                    Status = "Completed",
                    TotalPrice = tongCong,
                    PaidPrice = khachDua,
                    PhoneNumber = "0900000000", // TODO: Get this from customer info
                    Address = "Tại quầy",  // TODO: Get this from customer info
                    CreatedAt = dtpNgayBan.Value,
                    CreatedBy = loggedInUser.Id,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = loggedInUser.Id
                };
                context.Orders.Add(newOrder);

                // Add all items from the cart to OrderFigures
                foreach (var item in cart)
                {
                    context.OrderFigures.Add(new OrderFigure
                    {
                        Id = Guid.NewGuid(),
                        OrderId = newOrder.Id,
                        FigureId = item.MaSP,
                        UserId = (Guid)cboKhachHang.SelectedValue,
                        Quantity = item.SoLuong,
                        Price = item.DonGia - item.GiamGia, // Save the final price per item
                        CreatedAt = DateTime.Now,
                        CreatedBy = loggedInUser.Id,
                        UpdatedAt = DateTime.Now,
                        UpdatedBy = loggedInUser.Id
                    });

                    // Update stock quantity
                    var figureInDb = context.Figures.Find(item.MaSP);
                    if (figureInDb != null)
                    {
                        figureInDb.Quantity -= item.SoLuong;
                    }
                }
                
                // Save everything in one transaction
                context.SaveChanges();
                
                MessageBox.Show("Thanh toán thành công! Đã lưu hoá đơn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Start a new bill
                StartNewBill();
                LoadComboBoxes(); // Refresh product list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lưu hoá đơn thất bại: {ex.Message}", "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            // This button should open a new Form
            // Form_ThemKhachHang addCustomerForm = new Form_ThemKhachHang();
            // if (addCustomerForm.ShowDialog() == DialogResult.OK)
            // {
            //    LoadComboBoxes(); // Refresh customer list
            // }
            MessageBox.Show("Chức năng này cần một Form 'Thêm Khách Hàng' mới!", "Đang phát triển", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Excel sẽ được thêm sau!", "Đang phát triển", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // === 7. CLEANUP ===
        protected override void OnHandleDestroyed(EventArgs e)
        {
            context?.Dispose();
            base.OnHandleDestroyed(e);
        }
    }
}