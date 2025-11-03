using System.ComponentModel;

namespace FigureShop.POS

{
    partial class UserControl_TraCuuHoaDon
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
            panelTimKiem = new System.Windows.Forms.Panel();
            btnHienThiChiTiet = new System.Windows.Forms.Button();
            btnTimKiem = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            txtMaKhachHang = new System.Windows.Forms.TextBox();
            lblMaKhachHang = new System.Windows.Forms.Label();
            txtMaNhanVien = new System.Windows.Forms.TextBox();
            lblMaNhanVien = new System.Windows.Forms.Label();
            txtMaSanPham = new System.Windows.Forms.TextBox();
            lblMaSanPham = new System.Windows.Forms.Label();
            dgvHoaDon = new System.Windows.Forms.DataGridView();
            colSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panelTimKiem
            // 
            panelTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            panelTimKiem.Controls.Add(btnHienThiChiTiet);
            panelTimKiem.Controls.Add(btnTimKiem);
            panelTimKiem.Controls.Add(btnLamMoi);
            panelTimKiem.Controls.Add(txtMaKhachHang);
            panelTimKiem.Controls.Add(lblMaKhachHang);
            panelTimKiem.Controls.Add(txtMaNhanVien);
            panelTimKiem.Controls.Add(lblMaNhanVien);
            panelTimKiem.Controls.Add(txtMaSanPham);
            panelTimKiem.Controls.Add(lblMaSanPham);
            panelTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            panelTimKiem.Location = new System.Drawing.Point(0, 0);
            panelTimKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelTimKiem.Name = "panelTimKiem";
            panelTimKiem.Size = new System.Drawing.Size(1419, 250);
            panelTimKiem.TabIndex = 0;
            // 
            // btnHienThiChiTiet
            // 
            btnHienThiChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnHienThiChiTiet.Location = new System.Drawing.Point(595, 164);
            btnHienThiChiTiet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnHienThiChiTiet.Name = "btnHienThiChiTiet";
            btnHienThiChiTiet.Size = new System.Drawing.Size(178, 80);
            btnHienThiChiTiet.TabIndex = 8;
            btnHienThiChiTiet.Text = "Hiển Thị Chi Tiết\r\nHóa Đơn";
            btnHienThiChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnTimKiem.Location = new System.Drawing.Point(401, 164);
            btnTimKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(158, 46);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnLamMoi.Location = new System.Drawing.Point(401, 98);
            btnLamMoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(158, 46);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtMaKhachHang.Location = new System.Drawing.Point(200, 177);
            txtMaKhachHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new System.Drawing.Size(164, 30);
            txtMaKhachHang.TabIndex = 5;
            // 
            // lblMaKhachHang
            // 
            lblMaKhachHang.AutoSize = true;
            lblMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblMaKhachHang.Location = new System.Drawing.Point(28, 177);
            lblMaKhachHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaKhachHang.Name = "lblMaKhachHang";
            lblMaKhachHang.Size = new System.Drawing.Size(154, 25);
            lblMaKhachHang.TabIndex = 4;
            lblMaKhachHang.Text = "Mã Khách Hàng";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtMaNhanVien.Location = new System.Drawing.Point(200, 108);
            txtMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new System.Drawing.Size(164, 30);
            txtMaNhanVien.TabIndex = 3;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblMaNhanVien.Location = new System.Drawing.Point(28, 108);
            lblMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new System.Drawing.Size(137, 25);
            lblMaNhanVien.TabIndex = 2;
            lblMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtMaSanPham.Location = new System.Drawing.Point(200, 38);
            txtMaSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new System.Drawing.Size(164, 30);
            txtMaSanPham.TabIndex = 1;
            // 
            // lblMaSanPham
            // 
            lblMaSanPham.AutoSize = true;
            lblMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblMaSanPham.Location = new System.Drawing.Point(28, 38);
            lblMaSanPham.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMaSanPham.Name = "lblMaSanPham";
            lblMaSanPham.Size = new System.Drawing.Size(137, 25);
            lblMaSanPham.TabIndex = 0;
            lblMaSanPham.Text = "Mã Sản Phẩm";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeight = 29;
            dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colSoHD, colNgayBan, colTongTien, colMaNV, colMaKhach });
            dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvHoaDon.Location = new System.Drawing.Point(0, 250);
            dgvHoaDon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new System.Drawing.Size(1419, 599);
            dgvHoaDon.TabIndex = 1;
            // 
            // colSoHD
            // 
            colSoHD.HeaderText = "Số HĐ";
            colSoHD.MinimumWidth = 6;
            colSoHD.Name = "colSoHD";
            colSoHD.ReadOnly = true;
            colSoHD.Width = 273;
            // 
            // colNgayBan
            // 
            colNgayBan.HeaderText = "Ngày Bán";
            colNgayBan.MinimumWidth = 6;
            colNgayBan.Name = "colNgayBan";
            colNgayBan.ReadOnly = true;
            colNgayBan.Width = 273;
            // 
            // colTongTien
            // 
            colTongTien.HeaderText = "Tổng Tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            colTongTien.Width = 273;
            // 
            // colMaNV
            // 
            colMaNV.HeaderText = "Mã NV";
            colMaNV.MinimumWidth = 6;
            colMaNV.Name = "colMaNV";
            colMaNV.ReadOnly = true;
            colMaNV.Width = 273;
            // 
            // colMaKhach
            // 
            colMaKhach.HeaderText = "Mã Khách";
            colMaKhach.MinimumWidth = 6;
            colMaKhach.Name = "colMaKhach";
            colMaKhach.ReadOnly = true;
            colMaKhach.Width = 274;
            // 
            // UserControl_TraCuuHoaDon
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            Controls.Add(dgvHoaDon);
            Controls.Add(panelTimKiem);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Size = new System.Drawing.Size(1419, 849);
            panelTimKiem.ResumeLayout(false);
            panelTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnHienThiChiTiet;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhach;
    }
}
