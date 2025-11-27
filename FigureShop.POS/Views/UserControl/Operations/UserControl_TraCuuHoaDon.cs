// ReSharper disable LocalizableElement

using System.Diagnostics;
using ClosedXML.Excel;
using FigureShop.POS.Data;
using FigureShop.POS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FigureShop.POS.Views.UserControl.Operations;

public partial class UserControl_TraCuuHoaDon : System.Windows.Forms.UserControl
{
    private FigureShopDbContext context;

    public UserControl_TraCuuHoaDon()
    {
        InitializeComponent();
    }

    // Load event
    private void UserControl_TraCuuHoaDon_Load(object sender, EventArgs e)
    {
        context = new FigureShopDbContext();
        LoadComboBoxes();
        LoadData();
    }

    // Helper
    private void LoadComboBoxes()
    {
        // Load Customers into cboMaNV
        var staffList = context.Users.Select(u => new { u.Id, Display = u.Email }).ToList();
        cboMaNV.DataSource = staffList;
        cboMaNV.DisplayMember = "Display";
        cboMaNV.ValueMember = "Id";
        cboMaNV.SelectedItem = null;

        // Load Customers into cboMaKH
        var customerList = context.Users.Select(u => new { u.Id, Display = u.Email }).ToList();
        cboMaKH.DataSource = customerList;
        cboMaKH.DisplayMember = "Display";
        cboMaKH.ValueMember = "Id";
        cboMaKH.SelectedItem = null; // Start blank
    }

    private void LoadData(IQueryable<Order> query = null)
    {
        try
        {
            // If no filter provided, get all orders
            if (query == null) query = context.Orders.AsQueryable();

            // Join/Select data for the grid
            var displayData = query
                .Include(o => o.User) // Include Customer info
                .OrderByDescending(o => o.CreatedAt)
                .Select(o => new
                {
                    SoHD = o.Id,
                    NgayBan = o.CreatedAt,
                    TongTien = o.TotalPrice,
                    // Try to show names/emails instead of just IDs
                    MaNV = o.CreatedBy,
                    MaKhach = o.User.Email
                })
                .ToList();

            dgvHoaDon.DataSource = displayData;

            // Format Columns
            if (dgvHoaDon.Columns.Count > 0)
            {
                dgvHoaDon.Columns["SoHD"].HeaderText = "Số Hóa Đơn";
                dgvHoaDon.Columns["NgayBan"].HeaderText = "Ngày Bán";
                dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
                dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0"; // Currency format
                dgvHoaDon.Columns["MaNV"].HeaderText = "Người Tạo (Staff ID)";
                dgvHoaDon.Columns["MaKhach"].HeaderText = "Khách Hàng";

                dgvHoaDon.Columns["SoHD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvHoaDon.Columns["MaKhach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearFields()
    {
        txtMaSanPham.Text = "";
        cboMaNV.SelectedItem = null;
        cboMaKH.SelectedItem = null;
    }

    // Button event
    private void btnTimKiem_Click(object sender, EventArgs e)
    {
        try
        {
            var query = context.Orders.AsQueryable();

            // Filter by Staff (ComboBox)
            if (cboMaNV.SelectedValue != null)
            {
                var staffId = (Guid)cboMaNV.SelectedValue;
                query = query.Where(o => o.CreatedBy == staffId);
            }

            // Filter by Customer (ComboBox)
            if (cboMaKH.SelectedValue != null)
            {
                var customerId = (Guid)cboMaKH.SelectedValue;
                query = query.Where(o => o.UserId == customerId);
            }

            // Filter by Product ID
            if (!string.IsNullOrWhiteSpace(txtMaSanPham.Text))
            {
                if (Guid.TryParse(txtMaSanPham.Text.Trim(), out var figureId))
                {
                    // Check the OrderFigures table for this ID
                    query = query.Where(o => o.OrderFigures.Any(of => of.FigureId == figureId));
                }
                else
                {
                    MessageBox.Show("Mã Sản Phẩm phải là một ID hợp lệ (Guid)!", "Lỗi định dạng", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            LoadData(query);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        ClearFields();
        LoadData(); // Reload all
    }

    private void btnHienThiChiTiet_Click(object sender, EventArgs e)
    {
        // Check if a row is selected
        if (dgvHoaDon.CurrentRow == null)
        {
            MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Chưa chọn", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        // Get the Order ID
        var orderId = (Guid)dgvHoaDon.CurrentRow.Cells["SoHD"].Value;

        // Show Details
        var details = context.OrderFigures
            .Where(of => of.OrderId == orderId)
            .Include(of => of.Figure)
            .Select(of => $"- {of.Figure.Name} (SL: {of.Quantity})")
            .ToList();

        var message = $"Chi tiết hóa đơn {orderId}:\n\n" + string.Join("\n", details);
        MessageBox.Show(message, "Chi Tiết Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // Cleanup
    protected override void OnHandleDestroyed(EventArgs e)
    {
        context?.Dispose();
        base.OnHandleDestroyed(e);
    }

    private void btnExcel_Click(object sender, EventArgs e)
    {
        if (dgvHoaDon.Rows.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu để xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 2. Ask user where to save
        using (var sfd = new SaveFileDialog())
        {
            sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
            sfd.Title = "Xuất danh sách hoá đơn";
            sfd.FileName = $"DanhSachHoaDon_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Danh Sách Hoá Đơn");
                        for (var i = 0; i < dgvHoaDon.Columns.Count; i++)
                        {
                            // Use the HeaderText (e.g., "Mã Hoá Đơn") for a nice title
                            worksheet.Cell(1, i + 1).Value = dgvHoaDon.Columns[i].HeaderText;

                            // Make the header bold and gray background
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                            worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                        }

                        // 4. Data Rows
                        for (var i = 0; i < dgvHoaDon.Rows.Count; i++)
                        for (var j = 0; j < dgvHoaDon.Columns.Count; j++)
                        {
                            // Get the value from the grid cell
                            var cellValue = dgvHoaDon.Rows[i].Cells[j].Value;

                            // Write to Excel (row i+2 because header is row 1)
                            worksheet.Cell(i + 2, j + 1).Value = cellValue?.ToString() ?? "";
                        }

                        // 5. Formatting
                        worksheet.Columns().AdjustToContents(); // Auto-fit columns
                        workbook.SaveAs(sfd.FileName);
                    }

                    // 6. Success & Open
                    if (MessageBox.Show("Xuất file thành công! Bạn có muốn mở file không?", "Thông báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                        DialogResult.Yes) Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }
    }
}