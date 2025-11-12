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
            txtTenHang = new System.Windows.Forms.TextBox();
            lblTenHang = new System.Windows.Forms.Label();
            cboMaHang = new System.Windows.Forms.ComboBox();
            lblMaHang = new System.Windows.Forms.Label();
            txtTenNhanVien = new System.Windows.Forms.TextBox();
            lblTenNhanVien = new System.Windows.Forms.Label();
            cboMaNhanVien = new System.Windows.Forms.ComboBox();
            lblMaNhanVien = new System.Windows.Forms.Label();
            dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            lblNgayNhap = new System.Windows.Forms.Label();
            txtMaHoaDonNhap = new System.Windows.Forms.TextBox();
            lblMaHoaDonNhap = new System.Windows.Forms.Label();
            groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            numSoLuong = new System.Windows.Forms.NumericUpDown();
            btnSuaSanPham = new System.Windows.Forms.Button();
            btnXoaSanPham = new System.Windows.Forms.Button();
            btnExcel = new System.Windows.Forms.Button();
            btnThemSanPham = new System.Windows.Forms.Button();
            txtDonGia = new System.Windows.Forms.TextBox();
            lblDonGia = new System.Windows.Forms.Label();
            txtThanhTien = new System.Windows.Forms.TextBox();
            lblThanhTien = new System.Windows.Forms.Label();
            txtTenSanPham = new System.Windows.Forms.TextBox();
            lblTenSanPham = new System.Windows.Forms.Label();
            lblSoLuong = new System.Windows.Forms.Label();
            cboMaSanPham = new System.Windows.Forms.ComboBox();
            lblMaSanPham = new System.Windows.Forms.Label();
            dgvNhapHang = new System.Windows.Forms.DataGridView();
            groupBoxThongTinChung.SuspendLayout();
            groupBoxThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhapHang).BeginInit();
            SuspendLayout();
            // 
            // groupBoxThongTinChung
            // 
            groupBoxThongTinChung.BackColor = System.Drawing.SystemColors.Control;
            groupBoxThongTinChung.Controls.Add(btnThemHoaDon);
            groupBoxThongTinChung.Controls.Add(txtTenHang);
            groupBoxThongTinChung.Controls.Add(lblTenHang);
            groupBoxThongTinChung.Controls.Add(cboMaHang);
            groupBoxThongTinChung.Controls.Add(lblMaHang);
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
            groupBoxThongTinChung.Size = new System.Drawing.Size(1358, 236);
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
            btnThemHoaDon.Location = new System.Drawing.Point(968, 80);
            btnThemHoaDon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnThemHoaDon.Name = "btnThemHoaDon";
            btnThemHoaDon.Size = new System.Drawing.Size(164, 62);
            btnThemHoaDon.TabIndex = 14;
            btnThemHoaDon.Text = "Thêm Hoá Đơn";
            btnThemHoaDon.UseVisualStyleBackColor = false;
            btnThemHoaDon.Click += btnThemHoaDon_Click;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new System.Drawing.Point(657, 157);
            txtTenHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.ReadOnly = true;
            txtTenHang.Size = new System.Drawing.Size(242, 24);
            txtTenHang.TabIndex = 11;
            // 
            // lblTenHang
            // 
            lblTenHang.AutoSize = true;
            lblTenHang.Location = new System.Drawing.Point(538, 160);
            lblTenHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new System.Drawing.Size(69, 18);
            lblTenHang.TabIndex = 10;
            lblTenHang.Text = "Tên hãng";
            // 
            // cboMaHang
            // 
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Location = new System.Drawing.Point(657, 99);
            cboMaHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new System.Drawing.Size(242, 26);
            cboMaHang.TabIndex = 9;
            cboMaHang.SelectedIndexChanged += cboMaHang_SelectedIndexChanged;
            // 
            // lblMaHang
            // 
            lblMaHang.AutoSize = true;
            lblMaHang.Location = new System.Drawing.Point(538, 102);
            lblMaHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new System.Drawing.Size(65, 18);
            lblMaHang.TabIndex = 8;
            lblMaHang.Text = "Mã hãng";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new System.Drawing.Point(212, 157);
            txtTenNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new System.Drawing.Size(256, 24);
            txtTenNhanVien.TabIndex = 7;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Location = new System.Drawing.Point(38, 160);
            lblTenNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new System.Drawing.Size(104, 18);
            lblTenNhanVien.TabIndex = 6;
            lblTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new System.Drawing.Point(212, 99);
            cboMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new System.Drawing.Size(256, 26);
            cboMaNhanVien.TabIndex = 5;
            cboMaNhanVien.SelectedIndexChanged += cboMaNhanVien_SelectedIndexChanged;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Location = new System.Drawing.Point(38, 102);
            lblMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new System.Drawing.Size(100, 18);
            lblMaNhanVien.TabIndex = 4;
            lblMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new System.Drawing.Point(212, 40);
            dtpNgayNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new System.Drawing.Size(256, 24);
            dtpNgayNhap.TabIndex = 3;
            dtpNgayNhap.Value = new System.DateTime(2022, 11, 17, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Location = new System.Drawing.Point(38, 45);
            lblNgayNhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new System.Drawing.Size(78, 18);
            lblNgayNhap.TabIndex = 2;
            lblNgayNhap.Text = "Ngày nhập";
            // 
            // txtMaHoaDonNhap
            // 
            txtMaHoaDonNhap.Location = new System.Drawing.Point(657, 37);
            txtMaHoaDonNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtMaHoaDonNhap.Name = "txtMaHoaDonNhap";
            txtMaHoaDonNhap.ReadOnly = true;
            txtMaHoaDonNhap.Size = new System.Drawing.Size(242, 24);
            txtMaHoaDonNhap.TabIndex = 1;
            txtMaHoaDonNhap.Text = "HDN171120220003";
            txtMaHoaDonNhap.Visible = false;
            // 
            // lblMaHoaDonNhap
            // 
            lblMaHoaDonNhap.AutoSize = true;
            lblMaHoaDonNhap.Location = new System.Drawing.Point(543, 40);
            lblMaHoaDonNhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaHoaDonNhap.Name = "lblMaHoaDonNhap";
            lblMaHoaDonNhap.Size = new System.Drawing.Size(66, 18);
            lblMaHoaDonNhap.TabIndex = 0;
            lblMaHoaDonNhap.Text = "Mã HĐN";
            lblMaHoaDonNhap.Visible = false;
            // 
            // groupBoxThongTinChiTiet
            // 
            groupBoxThongTinChiTiet.BackColor = System.Drawing.SystemColors.Control;
            groupBoxThongTinChiTiet.Controls.Add(numSoLuong);
            groupBoxThongTinChiTiet.Controls.Add(btnSuaSanPham);
            groupBoxThongTinChiTiet.Controls.Add(btnXoaSanPham);
            groupBoxThongTinChiTiet.Controls.Add(btnExcel);
            groupBoxThongTinChiTiet.Controls.Add(btnThemSanPham);
            groupBoxThongTinChiTiet.Controls.Add(txtDonGia);
            groupBoxThongTinChiTiet.Controls.Add(lblDonGia);
            groupBoxThongTinChiTiet.Controls.Add(txtThanhTien);
            groupBoxThongTinChiTiet.Controls.Add(lblThanhTien);
            groupBoxThongTinChiTiet.Controls.Add(txtTenSanPham);
            groupBoxThongTinChiTiet.Controls.Add(lblTenSanPham);
            groupBoxThongTinChiTiet.Controls.Add(lblSoLuong);
            groupBoxThongTinChiTiet.Controls.Add(cboMaSanPham);
            groupBoxThongTinChiTiet.Controls.Add(lblMaSanPham);
            groupBoxThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            groupBoxThongTinChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            groupBoxThongTinChiTiet.Location = new System.Drawing.Point(0, 236);
            groupBoxThongTinChiTiet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            groupBoxThongTinChiTiet.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBoxThongTinChiTiet.Size = new System.Drawing.Size(1358, 281);
            groupBoxThongTinChiTiet.TabIndex = 1;
            groupBoxThongTinChiTiet.TabStop = false;
            groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new System.Drawing.Point(668, 117);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new System.Drawing.Size(242, 24);
            numSoLuong.TabIndex = 18;
            numSoLuong.ValueChanged += numSoLuong_ValueChanged;
            // 
            // btnSuaSanPham
            // 
            btnSuaSanPham.BackColor = System.Drawing.Color.MidnightBlue;
            btnSuaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnSuaSanPham.ForeColor = System.Drawing.Color.White;
            btnSuaSanPham.Location = new System.Drawing.Point(968, 177);
            btnSuaSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnSuaSanPham.Name = "btnSuaSanPham";
            btnSuaSanPham.Size = new System.Drawing.Size(164, 67);
            btnSuaSanPham.TabIndex = 17;
            btnSuaSanPham.Text = "Sửa Sản Phẩm";
            btnSuaSanPham.UseVisualStyleBackColor = false;
            btnSuaSanPham.Click += btnSuaSanPham_Click;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.BackColor = System.Drawing.Color.MidnightBlue;
            btnXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnXoaSanPham.ForeColor = System.Drawing.Color.White;
            btnXoaSanPham.Location = new System.Drawing.Point(968, 98);
            btnXoaSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new System.Drawing.Size(164, 67);
            btnXoaSanPham.TabIndex = 16;
            btnXoaSanPham.Text = "Xoá Sản Phẩm";
            btnXoaSanPham.UseVisualStyleBackColor = false;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnExcel.ForeColor = System.Drawing.Color.White;
            btnExcel.Location = new System.Drawing.Point(1174, 19);
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
            btnThemSanPham.Location = new System.Drawing.Point(968, 19);
            btnThemSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new System.Drawing.Size(164, 67);
            btnThemSanPham.TabIndex = 14;
            btnThemSanPham.Text = "Thêm Sản Phẩm";
            btnThemSanPham.UseVisualStyleBackColor = false;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new System.Drawing.Point(668, 178);
            txtDonGia.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new System.Drawing.Size(242, 24);
            txtDonGia.TabIndex = 11;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new System.Drawing.Point(538, 181);
            lblDonGia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new System.Drawing.Size(59, 18);
            lblDonGia.TabIndex = 10;
            lblDonGia.Text = "Đơn giá";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new System.Drawing.Point(212, 178);
            txtThanhTien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new System.Drawing.Size(256, 24);
            txtThanhTien.TabIndex = 7;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new System.Drawing.Point(38, 181);
            lblThanhTien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new System.Drawing.Size(81, 18);
            lblThanhTien.TabIndex = 6;
            lblThanhTien.Text = "Thành Tiền";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new System.Drawing.Point(212, 114);
            txtTenSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.ReadOnly = true;
            txtTenSanPham.Size = new System.Drawing.Size(256, 24);
            txtTenSanPham.TabIndex = 5;
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Location = new System.Drawing.Point(38, 110);
            lblTenSanPham.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new System.Drawing.Size(106, 18);
            lblTenSanPham.TabIndex = 4;
            lblTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new System.Drawing.Point(537, 117);
            lblSoLuong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new System.Drawing.Size(72, 18);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số Lượng";
            // 
            // cboMaSanPham
            // 
            cboMaSanPham.FormattingEnabled = true;
            cboMaSanPham.Location = new System.Drawing.Point(212, 40);
            cboMaSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cboMaSanPham.Name = "cboMaSanPham";
            cboMaSanPham.Size = new System.Drawing.Size(256, 26);
            cboMaSanPham.TabIndex = 1;
            cboMaSanPham.SelectedIndexChanged += cboMaSanPham_SelectedIndexChanged;
            // 
            // lblMaSanPham
            // 
            lblMaSanPham.AutoSize = true;
            lblMaSanPham.Location = new System.Drawing.Point(38, 43);
            lblMaSanPham.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaSanPham.Name = "lblMaSanPham";
            lblMaSanPham.Size = new System.Drawing.Size(102, 18);
            lblMaSanPham.TabIndex = 0;
            lblMaSanPham.Text = "Mã Sản Phẩm";
            // 
            // dgvNhapHang
            // 
            dgvNhapHang.AllowUserToAddRows = false;
            dgvNhapHang.AllowUserToDeleteRows = false;
            dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvNhapHang.Location = new System.Drawing.Point(0, 517);
            dgvNhapHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dgvNhapHang.Name = "dgvNhapHang";
            dgvNhapHang.ReadOnly = true;
            dgvNhapHang.RowHeadersWidth = 51;
            dgvNhapHang.Size = new System.Drawing.Size(1358, 346);
            dgvNhapHang.TabIndex = 2;
            // 
            // UserControl_NhapHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            Controls.Add(dgvNhapHang);
            Controls.Add(groupBoxThongTinChiTiet);
            Controls.Add(groupBoxThongTinChung);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Size = new System.Drawing.Size(1358, 863);
            Load += UserControl_NhapHang_Load;
            groupBoxThongTinChung.ResumeLayout(false);
            groupBoxThongTinChung.PerformLayout();
            groupBoxThongTinChiTiet.ResumeLayout(false);
            groupBoxThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhapHang).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown numSoLuong;

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
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.ComboBox cboMaSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnSuaSanPham;
        private System.Windows.Forms.DataGridView dgvNhapHang;
    }
}
