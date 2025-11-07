using System.ComponentModel;

namespace FigureShop.POS


{
    partial class UserControl_NhapHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxThongTinChung = new System.Windows.Forms.GroupBox();
            btnThemHoaDon = new System.Windows.Forms.Button();
            txtTongTien = new System.Windows.Forms.TextBox();
            lblTongTien = new System.Windows.Forms.Label();
            txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            lblTenNhaCungCap = new System.Windows.Forms.Label();
            cboMaNhaCungCap = new System.Windows.Forms.ComboBox();
            lblMaNhaCungCap = new System.Windows.Forms.Label();
            txtTenNhanVien = new System.Windows.Forms.TextBox();
            lblTenNhanVien = new System.Windows.Forms.Label();
            cboMaNhanVien = new System.Windows.Forms.ComboBox();
            lblMaNhanVien = new System.Windows.Forms.Label();
            dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            lblNgayNhap = new System.Windows.Forms.Label();
            txtMaHoaDonNhap = new System.Windows.Forms.TextBox();
            lblMaHoaDonNhap = new System.Windows.Forms.Label();
            groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            btnSuaSanPham = new System.Windows.Forms.Button();
            btnXoaSanPham = new System.Windows.Forms.Button();
            btnExcel = new System.Windows.Forms.Button();
            btnThemSanPham = new System.Windows.Forms.Button();
            txtDonGia = new System.Windows.Forms.TextBox();
            lblDonGia = new System.Windows.Forms.Label();
            txtGiamGia = new System.Windows.Forms.TextBox();
            lblGiamGia = new System.Windows.Forms.Label();
            txtThanhTien = new System.Windows.Forms.TextBox();
            lblThanhTien = new System.Windows.Forms.Label();
            txtTenSanPham = new System.Windows.Forms.TextBox();
            lblTenSanPham = new System.Windows.Forms.Label();
            txtSoLuong = new System.Windows.Forms.TextBox();
            lblSoLuong = new System.Windows.Forms.Label();
            cboMaSanPham = new System.Windows.Forms.ComboBox();
            lblMaSanPham = new System.Windows.Forms.Label();
            dgvChiTietNhap = new System.Windows.Forms.DataGridView();
            colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBoxThongTinChung.SuspendLayout();
            groupBoxThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietNhap).BeginInit();
            SuspendLayout();
            // 
            // groupBoxThongTinChung
            // 
            groupBoxThongTinChung.BackColor = System.Drawing.SystemColors.Control;
            groupBoxThongTinChung.Controls.Add(btnThemHoaDon);
            groupBoxThongTinChung.Controls.Add(txtTongTien);
            groupBoxThongTinChung.Controls.Add(lblTongTien);
            groupBoxThongTinChung.Controls.Add(txtTenNhaCungCap);
            groupBoxThongTinChung.Controls.Add(lblTenNhaCungCap);
            groupBoxThongTinChung.Controls.Add(cboMaNhaCungCap);
            groupBoxThongTinChung.Controls.Add(lblMaNhaCungCap);
            groupBoxThongTinChung.Controls.Add(txtTenNhanVien);
            groupBoxThongTinChung.Controls.Add(lblTenNhanVien);
            groupBoxThongTinChung.Controls.Add(cboMaNhanVien);
            groupBoxThongTinChung.Controls.Add(lblMaNhanVien);
            groupBoxThongTinChung.Controls.Add(dtpNgayNhap);
            groupBoxThongTinChung.Controls.Add(lblNgayNhap);
            groupBoxThongTinChung.Controls.Add(txtMaHoaDonNhap);
            groupBoxThongTinChung.Controls.Add(lblMaHoaDonNhap);
            groupBoxThongTinChung.Dock = System.Windows.Forms.DockStyle.Top;
            groupBoxThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            groupBoxThongTinChung.Location = new System.Drawing.Point(0, 0);
            groupBoxThongTinChung.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBoxThongTinChung.Name = "groupBoxThongTinChung";
            groupBoxThongTinChung.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBoxThongTinChung.Size = new System.Drawing.Size(1448, 236);
            groupBoxThongTinChung.TabIndex = 0;
            groupBoxThongTinChung.TabStop = false;
            groupBoxThongTinChung.Text = "Thông tin chung";
            // 
            // btnThemHoaDon
            // 
            btnThemHoaDon.BackColor = System.Drawing.Color.DodgerBlue;
            btnThemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnThemHoaDon.ForeColor = System.Drawing.Color.White;
            btnThemHoaDon.Location = new System.Drawing.Point(1060, 82);
            btnThemHoaDon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnThemHoaDon.Name = "btnThemHoaDon";
            btnThemHoaDon.Size = new System.Drawing.Size(202, 62);
            btnThemHoaDon.TabIndex = 14;
            btnThemHoaDon.Text = "Thêm Hoá Đơn";
            btnThemHoaDon.UseVisualStyleBackColor = false;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new System.Drawing.Point(668, 42);
            txtTongTien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new System.Drawing.Size(242, 28);
            txtTongTien.TabIndex = 13;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new System.Drawing.Point(538, 45);
            lblTongTien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new System.Drawing.Size(86, 22);
            lblTongTien.TabIndex = 12;
            lblTongTien.Text = "Tổng tiền";
            // 
            // txtTenNhaCungCap
            // 
            txtTenNhaCungCap.Location = new System.Drawing.Point(657, 157);
            txtTenNhaCungCap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            txtTenNhaCungCap.ReadOnly = true;
            txtTenNhaCungCap.Size = new System.Drawing.Size(242, 28);
            txtTenNhaCungCap.TabIndex = 11;
            // 
            // lblTenNhaCungCap
            // 
            lblTenNhaCungCap.AutoSize = true;
            lblTenNhaCungCap.Location = new System.Drawing.Point(538, 160);
            lblTenNhaCungCap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTenNhaCungCap.Name = "lblTenNhaCungCap";
            lblTenNhaCungCap.Size = new System.Drawing.Size(86, 22);
            lblTenNhaCungCap.TabIndex = 10;
            lblTenNhaCungCap.Text = "Tên NCC";
            // 
            // cboMaNhaCungCap
            // 
            cboMaNhaCungCap.FormattingEnabled = true;
            cboMaNhaCungCap.Location = new System.Drawing.Point(657, 99);
            cboMaNhaCungCap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cboMaNhaCungCap.Name = "cboMaNhaCungCap";
            cboMaNhaCungCap.Size = new System.Drawing.Size(242, 30);
            cboMaNhaCungCap.TabIndex = 9;
            // 
            // lblMaNhaCungCap
            // 
            lblMaNhaCungCap.AutoSize = true;
            lblMaNhaCungCap.Location = new System.Drawing.Point(538, 102);
            lblMaNhaCungCap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaNhaCungCap.Name = "lblMaNhaCungCap";
            lblMaNhaCungCap.Size = new System.Drawing.Size(78, 22);
            lblMaNhaCungCap.TabIndex = 8;
            lblMaNhaCungCap.Text = "Mã NCC";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new System.Drawing.Point(212, 157);
            txtTenNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new System.Drawing.Size(256, 28);
            txtTenNhanVien.TabIndex = 7;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Location = new System.Drawing.Point(38, 160);
            lblTenNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new System.Drawing.Size(131, 22);
            lblTenNhanVien.TabIndex = 6;
            lblTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new System.Drawing.Point(212, 99);
            cboMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new System.Drawing.Size(256, 30);
            cboMaNhanVien.TabIndex = 5;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Location = new System.Drawing.Point(38, 102);
            lblMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new System.Drawing.Size(123, 22);
            lblMaNhanVien.TabIndex = 4;
            lblMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new System.Drawing.Point(212, 40);
            dtpNgayNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new System.Drawing.Size(256, 28);
            dtpNgayNhap.TabIndex = 3;
            dtpNgayNhap.Value = new System.DateTime(2022, 11, 17, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Location = new System.Drawing.Point(38, 45);
            lblNgayNhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new System.Drawing.Size(97, 22);
            lblNgayNhap.TabIndex = 2;
            lblNgayNhap.Text = "Ngày nhập";
            // 
            // txtMaHoaDonNhap
            // 
            txtMaHoaDonNhap.Location = new System.Drawing.Point(1060, 42);
            txtMaHoaDonNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtMaHoaDonNhap.Name = "txtMaHoaDonNhap";
            txtMaHoaDonNhap.ReadOnly = true;
            txtMaHoaDonNhap.Size = new System.Drawing.Size(256, 28);
            txtMaHoaDonNhap.TabIndex = 1;
            txtMaHoaDonNhap.Text = "HDN171120220003";
            txtMaHoaDonNhap.Visible = false;
            // 
            // lblMaHoaDonNhap
            // 
            lblMaHoaDonNhap.AutoSize = true;
            lblMaHoaDonNhap.Location = new System.Drawing.Point(946, 45);
            lblMaHoaDonNhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaHoaDonNhap.Name = "lblMaHoaDonNhap";
            lblMaHoaDonNhap.Size = new System.Drawing.Size(78, 22);
            lblMaHoaDonNhap.TabIndex = 0;
            lblMaHoaDonNhap.Text = "Mã HĐN";
            lblMaHoaDonNhap.Visible = false;
            // 
            // groupBoxThongTinChiTiet
            // 
            groupBoxThongTinChiTiet.BackColor = System.Drawing.SystemColors.Control;
            groupBoxThongTinChiTiet.Controls.Add(btnSuaSanPham);
            groupBoxThongTinChiTiet.Controls.Add(btnXoaSanPham);
            groupBoxThongTinChiTiet.Controls.Add(btnExcel);
            groupBoxThongTinChiTiet.Controls.Add(btnThemSanPham);
            groupBoxThongTinChiTiet.Controls.Add(txtDonGia);
            groupBoxThongTinChiTiet.Controls.Add(lblDonGia);
            groupBoxThongTinChiTiet.Controls.Add(txtGiamGia);
            groupBoxThongTinChiTiet.Controls.Add(lblGiamGia);
            groupBoxThongTinChiTiet.Controls.Add(txtThanhTien);
            groupBoxThongTinChiTiet.Controls.Add(lblThanhTien);
            groupBoxThongTinChiTiet.Controls.Add(txtTenSanPham);
            groupBoxThongTinChiTiet.Controls.Add(lblTenSanPham);
            groupBoxThongTinChiTiet.Controls.Add(txtSoLuong);
            groupBoxThongTinChiTiet.Controls.Add(lblSoLuong);
            groupBoxThongTinChiTiet.Controls.Add(cboMaSanPham);
            groupBoxThongTinChiTiet.Controls.Add(lblMaSanPham);
            groupBoxThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            groupBoxThongTinChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            groupBoxThongTinChiTiet.Location = new System.Drawing.Point(0, 236);
            groupBoxThongTinChiTiet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            groupBoxThongTinChiTiet.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBoxThongTinChiTiet.Size = new System.Drawing.Size(1448, 281);
            groupBoxThongTinChiTiet.TabIndex = 1;
            groupBoxThongTinChiTiet.TabStop = false;
            groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // btnSuaSanPham
            // 
            btnSuaSanPham.BackColor = System.Drawing.Color.MidnightBlue;
            btnSuaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnSuaSanPham.ForeColor = System.Drawing.Color.White;
            btnSuaSanPham.Location = new System.Drawing.Point(1060, 174);
            btnSuaSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnSuaSanPham.Name = "btnSuaSanPham";
            btnSuaSanPham.Size = new System.Drawing.Size(202, 67);
            btnSuaSanPham.TabIndex = 17;
            btnSuaSanPham.Text = "Sửa Sản Phẩm";
            btnSuaSanPham.UseVisualStyleBackColor = false;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.BackColor = System.Drawing.Color.MidnightBlue;
            btnXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnXoaSanPham.ForeColor = System.Drawing.Color.White;
            btnXoaSanPham.Location = new System.Drawing.Point(1060, 95);
            btnXoaSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new System.Drawing.Size(202, 67);
            btnXoaSanPham.TabIndex = 16;
            btnXoaSanPham.Text = "Xoá Sản Phẩm";
            btnXoaSanPham.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnExcel.ForeColor = System.Drawing.Color.White;
            btnExcel.Location = new System.Drawing.Point(1297, 16);
            btnExcel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new System.Drawing.Size(135, 67);
            btnExcel.TabIndex = 15;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.BackColor = System.Drawing.Color.MidnightBlue;
            btnThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnThemSanPham.ForeColor = System.Drawing.Color.White;
            btnThemSanPham.Location = new System.Drawing.Point(1060, 16);
            btnThemSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new System.Drawing.Size(202, 67);
            btnThemSanPham.TabIndex = 14;
            btnThemSanPham.Text = "Thêm Sản Phẩm";
            btnThemSanPham.UseVisualStyleBackColor = false;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new System.Drawing.Point(668, 178);
            txtDonGia.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new System.Drawing.Size(242, 28);
            txtDonGia.TabIndex = 11;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new System.Drawing.Point(538, 181);
            lblDonGia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new System.Drawing.Size(72, 22);
            lblDonGia.TabIndex = 10;
            lblDonGia.Text = "Đơn giá";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new System.Drawing.Point(668, 40);
            txtGiamGia.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new System.Drawing.Size(242, 28);
            txtGiamGia.TabIndex = 9;
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new System.Drawing.Point(538, 43);
            lblGiamGia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new System.Drawing.Size(81, 22);
            lblGiamGia.TabIndex = 8;
            lblGiamGia.Text = "Giảm giá";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new System.Drawing.Point(212, 178);
            txtThanhTien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new System.Drawing.Size(256, 28);
            txtThanhTien.TabIndex = 7;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new System.Drawing.Point(38, 181);
            lblThanhTien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new System.Drawing.Size(103, 22);
            lblThanhTien.TabIndex = 6;
            lblThanhTien.Text = "Thành Tiền";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new System.Drawing.Point(212, 114);
            txtTenSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.ReadOnly = true;
            txtTenSanPham.Size = new System.Drawing.Size(256, 28);
            txtTenSanPham.TabIndex = 5;
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Location = new System.Drawing.Point(38, 110);
            lblTenSanPham.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new System.Drawing.Size(130, 22);
            lblTenSanPham.TabIndex = 4;
            lblTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new System.Drawing.Point(668, 114);
            txtSoLuong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new System.Drawing.Size(242, 28);
            txtSoLuong.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new System.Drawing.Point(537, 117);
            lblSoLuong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new System.Drawing.Size(87, 22);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số Lượng";
            // 
            // cboMaSanPham
            // 
            cboMaSanPham.FormattingEnabled = true;
            cboMaSanPham.Location = new System.Drawing.Point(212, 40);
            cboMaSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cboMaSanPham.Name = "cboMaSanPham";
            cboMaSanPham.Size = new System.Drawing.Size(256, 30);
            cboMaSanPham.TabIndex = 1;
            // 
            // lblMaSanPham
            // 
            lblMaSanPham.AutoSize = true;
            lblMaSanPham.Location = new System.Drawing.Point(38, 43);
            lblMaSanPham.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaSanPham.Name = "lblMaSanPham";
            lblMaSanPham.Size = new System.Drawing.Size(122, 22);
            lblMaSanPham.TabIndex = 0;
            lblMaSanPham.Text = "Mã Sản Phẩm";
            // 
            // dgvChiTietNhap
            // 
            dgvChiTietNhap.AllowUserToAddRows = false;
            dgvChiTietNhap.AllowUserToDeleteRows = false;
            dgvChiTietNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMaSP, colTenSP, colSoLuong, colDonGiaNhap, colGiamGia, colThanhTien });
            dgvChiTietNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvChiTietNhap.Location = new System.Drawing.Point(0, 517);
            dgvChiTietNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dgvChiTietNhap.Name = "dgvChiTietNhap";
            dgvChiTietNhap.ReadOnly = true;
            dgvChiTietNhap.RowHeadersWidth = 51;
            dgvChiTietNhap.Size = new System.Drawing.Size(1448, 346);
            dgvChiTietNhap.TabIndex = 2;
            // 
            // colMaSP
            // 
            colMaSP.HeaderText = "Mã SP";
            colMaSP.MinimumWidth = 6;
            colMaSP.Name = "colMaSP";
            colMaSP.ReadOnly = true;
            colMaSP.Width = 233;
            // 
            // colTenSP
            // 
            colTenSP.HeaderText = "Tên Sản Phẩm";
            colTenSP.MinimumWidth = 6;
            colTenSP.Name = "colTenSP";
            colTenSP.ReadOnly = true;
            colTenSP.Width = 232;
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số Lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            colSoLuong.Width = 233;
            // 
            // colDonGiaNhap
            // 
            colDonGiaNhap.HeaderText = "Đơn Giá Nhập";
            colDonGiaNhap.MinimumWidth = 6;
            colDonGiaNhap.Name = "colDonGiaNhap";
            colDonGiaNhap.ReadOnly = true;
            colDonGiaNhap.Width = 232;
            // 
            // colGiamGia
            // 
            colGiamGia.HeaderText = "Giảm Giá";
            colGiamGia.MinimumWidth = 6;
            colGiamGia.Name = "colGiamGia";
            colGiamGia.ReadOnly = true;
            colGiamGia.Width = 233;
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            colThanhTien.Width = 232;
            // 
            // UserControl_NhapHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            Controls.Add(dgvChiTietNhap);
            Controls.Add(groupBoxThongTinChiTiet);
            Controls.Add(groupBoxThongTinChung);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Size = new System.Drawing.Size(1448, 863);
            groupBoxThongTinChung.ResumeLayout(false);
            groupBoxThongTinChung.PerformLayout();
            groupBoxThongTinChiTiet.ResumeLayout(false);
            groupBoxThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinChung;
        private System.Windows.Forms.Label lblMaHoaDonNhap;
        private System.Windows.Forms.TextBox txtMaHoaDonNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.ComboBox cboMaNhaCungCap;
        private System.Windows.Forms.Label lblMaNhaCungCap;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.Label lblTenNhaCungCap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.ComboBox cboMaSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnSuaSanPham;
        private System.Windows.Forms.DataGridView dgvChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}
