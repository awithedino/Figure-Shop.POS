using System.ComponentModel;

namespace FigureShop.POS;

partial class Form_HienThiMatHang
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        splitter1 = new System.Windows.Forms.Splitter();
        panel4 = new System.Windows.Forms.Panel();
        panel2 = new System.Windows.Forms.Panel();
        panel10 = new System.Windows.Forms.Panel();
        cboTenNcc = new System.Windows.Forms.ComboBox();
        cboLoaiSP = new System.Windows.Forms.ComboBox();
        btnLoad = new System.Windows.Forms.Button();
        btnLamMoi = new System.Windows.Forms.Button();
        btnApDung = new System.Windows.Forms.Button();
        txttenSP = new System.Windows.Forms.TextBox();
        label11 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        panel9 = new System.Windows.Forms.Panel();
        txttenKhachHang = new System.Windows.Forms.TextBox();
        txtSDT = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        dgvHoaDon = new System.Windows.Forms.DataGridView();
        panel3 = new System.Windows.Forms.Panel();
        txtTienKhachTT = new System.Windows.Forms.TextBox();
        btnHuy = new System.Windows.Forms.Button();
        btnThanhToan = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        lblTongTien = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        panel5 = new System.Windows.Forms.Panel();
        flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        groupBox1 = new System.Windows.Forms.GroupBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        panel8 = new System.Windows.Forms.Panel();
        button2 = new System.Windows.Forms.Button();
        groupBoxSP1 = new System.Windows.Forms.GroupBox();
        pictureBoxSP1 = new System.Windows.Forms.PictureBox();
        panel7 = new System.Windows.Forms.Panel();
        button1 = new System.Windows.Forms.Button();
        groupBoxSP3 = new System.Windows.Forms.GroupBox();
        pictureBoxSP3 = new System.Windows.Forms.PictureBox();
        panel6 = new System.Windows.Forms.Panel();
        buttonbuy3 = new System.Windows.Forms.Button();
        panel4.SuspendLayout();
        panel2.SuspendLayout();
        panel10.SuspendLayout();
        panel9.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
        panel3.SuspendLayout();
        panel5.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel8.SuspendLayout();
        groupBoxSP1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxSP1).BeginInit();
        panel7.SuspendLayout();
        groupBoxSP3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxSP3).BeginInit();
        panel6.SuspendLayout();
        SuspendLayout();
        // 
        // splitter1
        // 
        splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        splitter1.Location = new System.Drawing.Point(0, 0);
        splitter1.Name = "splitter1";
        splitter1.Size = new System.Drawing.Size(10, 894);
        splitter1.TabIndex = 2;
        splitter1.TabStop = false;
        // 
        // panel4
        // 
        panel4.Controls.Add(panel2);
        panel4.Dock = System.Windows.Forms.DockStyle.Top;
        panel4.Location = new System.Drawing.Point(10, 0);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(1448, 222);
        panel4.TabIndex = 4;
        // 
        // panel2
        // 
        panel2.Controls.Add(panel10);
        panel2.Controls.Add(panel9);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(1448, 222);
        panel2.TabIndex = 6;
        // 
        // panel10
        // 
        panel10.Controls.Add(cboTenNcc);
        panel10.Controls.Add(cboLoaiSP);
        panel10.Controls.Add(btnLoad);
        panel10.Controls.Add(btnLamMoi);
        panel10.Controls.Add(btnApDung);
        panel10.Controls.Add(txttenSP);
        panel10.Controls.Add(label11);
        panel10.Controls.Add(label10);
        panel10.Controls.Add(label9);
        panel10.Controls.Add(label2);
        panel10.Dock = System.Windows.Forms.DockStyle.Fill;
        panel10.Location = new System.Drawing.Point(511, 0);
        panel10.Name = "panel10";
        panel10.Size = new System.Drawing.Size(937, 222);
        panel10.TabIndex = 1;
        // 
        // cboTenNcc
        // 
        cboTenNcc.FormattingEnabled = true;
        cboTenNcc.Location = new System.Drawing.Point(632, 104);
        cboTenNcc.Name = "cboTenNcc";
        cboTenNcc.Size = new System.Drawing.Size(224, 33);
        cboTenNcc.TabIndex = 10;
        // 
        // cboLoaiSP
        // 
        cboLoaiSP.FormattingEnabled = true;
        cboLoaiSP.Location = new System.Drawing.Point(363, 104);
        cboLoaiSP.Name = "cboLoaiSP";
        cboLoaiSP.Size = new System.Drawing.Size(210, 33);
        cboLoaiSP.TabIndex = 9;
        // 
        // btnLoad
        // 
        btnLoad.BackColor = System.Drawing.Color.DodgerBlue;
        btnLoad.ForeColor = System.Drawing.Color.White;
        btnLoad.Location = new System.Drawing.Point(757, 159);
        btnLoad.Name = "btnLoad";
        btnLoad.Size = new System.Drawing.Size(99, 39);
        btnLoad.TabIndex = 8;
        btnLoad.Text = "Load";
        btnLoad.UseVisualStyleBackColor = false;
        // 
        // btnLamMoi
        // 
        btnLamMoi.BackColor = System.Drawing.Color.DodgerBlue;
        btnLamMoi.ForeColor = System.Drawing.Color.White;
        btnLamMoi.Location = new System.Drawing.Point(209, 160);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(127, 40);
        btnLamMoi.TabIndex = 7;
        btnLamMoi.Text = "Làm Mới";
        btnLamMoi.UseVisualStyleBackColor = false;
        // 
        // btnApDung
        // 
        btnApDung.BackColor = System.Drawing.Color.DodgerBlue;
        btnApDung.ForeColor = System.Drawing.Color.White;
        btnApDung.Location = new System.Drawing.Point(54, 159);
        btnApDung.Name = "btnApDung";
        btnApDung.Size = new System.Drawing.Size(127, 40);
        btnApDung.TabIndex = 6;
        btnApDung.Text = "Áp Dụng";
        btnApDung.UseVisualStyleBackColor = false;
        // 
        // txttenSP
        // 
        txttenSP.Location = new System.Drawing.Point(54, 104);
        txttenSP.Name = "txttenSP";
        txttenSP.Size = new System.Drawing.Size(268, 31);
        txttenSP.TabIndex = 5;
        // 
        // label11
        // 
        label11.Location = new System.Drawing.Point(632, 67);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(164, 23);
        label11.TabIndex = 4;
        label11.Text = "Tên Nhà Cung Cấp";
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(363, 67);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(136, 23);
        label10.TabIndex = 3;
        label10.Text = "Loại Sản Phẩm";
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(54, 67);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(157, 23);
        label9.TabIndex = 2;
        label9.Text = "Tên/Mã Sản Phẩm";
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.Color.DodgerBlue;
        label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label2.Dock = System.Windows.Forms.DockStyle.Top;
        label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.White;
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(937, 58);
        label2.TabIndex = 1;
        label2.Text = "Thông tin khách hàng";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel9
        // 
        panel9.Controls.Add(txttenKhachHang);
        panel9.Controls.Add(txtSDT);
        panel9.Controls.Add(label8);
        panel9.Controls.Add(label7);
        panel9.Controls.Add(label1);
        panel9.Dock = System.Windows.Forms.DockStyle.Left;
        panel9.Location = new System.Drawing.Point(0, 0);
        panel9.Name = "panel9";
        panel9.Size = new System.Drawing.Size(511, 222);
        panel9.TabIndex = 0;
        // 
        // txttenKhachHang
        // 
        txttenKhachHang.Location = new System.Drawing.Point(158, 151);
        txttenKhachHang.Name = "txttenKhachHang";
        txttenKhachHang.Size = new System.Drawing.Size(333, 31);
        txttenKhachHang.TabIndex = 4;
        // 
        // txtSDT
        // 
        txtSDT.Location = new System.Drawing.Point(158, 85);
        txtSDT.Name = "txtSDT";
        txtSDT.Size = new System.Drawing.Size(333, 31);
        txtSDT.TabIndex = 3;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(6, 154);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(153, 23);
        label8.TabIndex = 2;
        label8.Text = "Tên Khách Hàng:";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(6, 88);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(132, 23);
        label7.TabIndex = 1;
        label7.Text = "Số Điện Thoại:";
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.DodgerBlue;
        label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label1.Dock = System.Windows.Forms.DockStyle.Top;
        label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(511, 58);
        label1.TabIndex = 0;
        label1.Text = "Thông tin khách hàng";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.Controls.Add(dgvHoaDon);
        panel1.Controls.Add(panel3);
        panel1.Controls.Add(label3);
        panel1.Dock = System.Windows.Forms.DockStyle.Left;
        panel1.Location = new System.Drawing.Point(10, 222);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(511, 672);
        panel1.TabIndex = 5;
        // 
        // dgvHoaDon
        // 
        dgvHoaDon.ColumnHeadersHeight = 34;
        dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvHoaDon.Location = new System.Drawing.Point(0, 72);
        dgvHoaDon.Name = "dgvHoaDon";
        dgvHoaDon.RowHeadersWidth = 62;
        dgvHoaDon.Size = new System.Drawing.Size(511, 440);
        dgvHoaDon.TabIndex = 2;
        // 
        // panel3
        // 
        panel3.Controls.Add(txtTienKhachTT);
        panel3.Controls.Add(btnHuy);
        panel3.Controls.Add(btnThanhToan);
        panel3.Controls.Add(btnXoa);
        panel3.Controls.Add(lblTongTien);
        panel3.Controls.Add(label6);
        panel3.Controls.Add(label5);
        panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel3.Location = new System.Drawing.Point(0, 512);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(511, 160);
        panel3.TabIndex = 1;
        // 
        // txtTienKhachTT
        // 
        txtTienKhachTT.Location = new System.Drawing.Point(227, 65);
        txtTienKhachTT.Name = "txtTienKhachTT";
        txtTienKhachTT.Size = new System.Drawing.Size(211, 31);
        txtTienKhachTT.TabIndex = 6;
        // 
        // btnHuy
        // 
        btnHuy.BackColor = System.Drawing.Color.DarkOrange;
        btnHuy.ForeColor = System.Drawing.Color.White;
        btnHuy.Location = new System.Drawing.Point(292, 108);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new System.Drawing.Size(128, 40);
        btnHuy.TabIndex = 5;
        btnHuy.Text = "Hủy";
        btnHuy.UseVisualStyleBackColor = false;
        // 
        // btnThanhToan
        // 
        btnThanhToan.BackColor = System.Drawing.Color.ForestGreen;
        btnThanhToan.ForeColor = System.Drawing.Color.White;
        btnThanhToan.Location = new System.Drawing.Point(45, 108);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new System.Drawing.Size(191, 40);
        btnThanhToan.TabIndex = 4;
        btnThanhToan.Text = "Thanh Toán";
        btnThanhToan.UseVisualStyleBackColor = false;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = System.Drawing.Color.Crimson;
        btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoa.ForeColor = System.Drawing.Color.White;
        btnXoa.Location = new System.Drawing.Point(420, 4);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(85, 48);
        btnXoa.TabIndex = 3;
        btnXoa.Text = "Xóa SP";
        btnXoa.UseVisualStyleBackColor = false;
        // 
        // lblTongTien
        // 
        lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongTien.ForeColor = System.Drawing.Color.Orange;
        lblTongTien.Location = new System.Drawing.Point(292, 16);
        lblTongTien.Name = "lblTongTien";
        lblTongTien.Size = new System.Drawing.Size(112, 23);
        lblTongTien.TabIndex = 2;
        lblTongTien.Text = "0";
        lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(45, 68);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(191, 37);
        label6.TabIndex = 1;
        label6.Text = "Tiền Khách Hàng Trả:";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(45, 16);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(148, 29);
        label5.TabIndex = 0;
        label5.Text = "Tổng Hóa Đơn:";
        // 
        // label3
        // 
        label3.BackColor = System.Drawing.Color.DodgerBlue;
        label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label3.Dock = System.Windows.Forms.DockStyle.Top;
        label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.White;
        label3.Location = new System.Drawing.Point(0, 0);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(511, 72);
        label3.TabIndex = 0;
        label3.Text = "Thông tin hóa đơn";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.BackColor = System.Drawing.Color.DodgerBlue;
        label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label4.Dock = System.Windows.Forms.DockStyle.Top;
        label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.White;
        label4.Location = new System.Drawing.Point(0, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(937, 72);
        label4.TabIndex = 6;
        label4.Text = "Danh sách sản phẩm";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel5
        // 
        panel5.Controls.Add(flowLayoutPanel1);
        panel5.Controls.Add(label4);
        panel5.Dock = System.Windows.Forms.DockStyle.Fill;
        panel5.Location = new System.Drawing.Point(521, 222);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(937, 672);
        panel5.TabIndex = 6;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(groupBox1);
        flowLayoutPanel1.Controls.Add(groupBoxSP1);
        flowLayoutPanel1.Controls.Add(groupBoxSP3);
        flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        flowLayoutPanel1.Location = new System.Drawing.Point(0, 72);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new System.Drawing.Size(937, 600);
        flowLayoutPanel1.TabIndex = 7;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Controls.Add(panel8);
        groupBox1.Location = new System.Drawing.Point(3, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(255, 300);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "One Piece DXF The Grandline Series - Monkey D. Luffy";
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
        pictureBox1.Location = new System.Drawing.Point(3, 55);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(249, 188);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // panel8
        // 
        panel8.Controls.Add(button2);
        panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel8.Location = new System.Drawing.Point(3, 243);
        panel8.Name = "panel8";
        panel8.Size = new System.Drawing.Size(249, 54);
        panel8.TabIndex = 0;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(74, 3);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(101, 48);
        button2.TabIndex = 0;
        button2.Text = "Mua";
        button2.UseVisualStyleBackColor = true;
        // 
        // groupBoxSP1
        // 
        groupBoxSP1.Controls.Add(pictureBoxSP1);
        groupBoxSP1.Controls.Add(panel7);
        groupBoxSP1.Location = new System.Drawing.Point(264, 3);
        groupBoxSP1.Name = "groupBoxSP1";
        groupBoxSP1.Size = new System.Drawing.Size(255, 300);
        groupBoxSP1.TabIndex = 1;
        groupBoxSP1.TabStop = false;
        groupBoxSP1.Text = "RG 1/144 RX-93 v Gundam (Nu Gundam)";
        // 
        // pictureBoxSP1
        // 
        pictureBoxSP1.Dock = System.Windows.Forms.DockStyle.Bottom;
        pictureBoxSP1.Location = new System.Drawing.Point(3, 55);
        pictureBoxSP1.Name = "pictureBoxSP1";
        pictureBoxSP1.Size = new System.Drawing.Size(249, 188);
        pictureBoxSP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBoxSP1.TabIndex = 1;
        pictureBoxSP1.TabStop = false;
        // 
        // panel7
        // 
        panel7.Controls.Add(button1);
        panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel7.Location = new System.Drawing.Point(3, 243);
        panel7.Name = "panel7";
        panel7.Size = new System.Drawing.Size(249, 54);
        panel7.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(74, 3);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(101, 48);
        button1.TabIndex = 0;
        button1.Text = "Mua";
        button1.UseVisualStyleBackColor = true;
        // 
        // groupBoxSP3
        // 
        groupBoxSP3.Controls.Add(pictureBoxSP3);
        groupBoxSP3.Controls.Add(panel6);
        groupBoxSP3.Location = new System.Drawing.Point(525, 3);
        groupBoxSP3.Name = "groupBoxSP3";
        groupBoxSP3.Size = new System.Drawing.Size(255, 300);
        groupBoxSP3.TabIndex = 0;
        groupBoxSP3.TabStop = false;
        groupBoxSP3.Text = "1/7 Scale Figure - Makima (Chainsaw Man)";
        // 
        // pictureBoxSP3
        // 
        pictureBoxSP3.Dock = System.Windows.Forms.DockStyle.Bottom;
        pictureBoxSP3.Location = new System.Drawing.Point(3, 55);
        pictureBoxSP3.Name = "pictureBoxSP3";
        pictureBoxSP3.Size = new System.Drawing.Size(249, 188);
        pictureBoxSP3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBoxSP3.TabIndex = 1;
        pictureBoxSP3.TabStop = false;
        // 
        // panel6
        // 
        panel6.Controls.Add(buttonbuy3);
        panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel6.Location = new System.Drawing.Point(3, 243);
        panel6.Name = "panel6";
        panel6.Size = new System.Drawing.Size(249, 54);
        panel6.TabIndex = 0;
        // 
        // buttonbuy3
        // 
        buttonbuy3.Location = new System.Drawing.Point(74, 3);
        buttonbuy3.Name = "buttonbuy3";
        buttonbuy3.Size = new System.Drawing.Size(101, 48);
        buttonbuy3.TabIndex = 0;
        buttonbuy3.Text = "Mua";
        buttonbuy3.UseVisualStyleBackColor = true;
        // 
        // Form_HienThiMatHang
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1458, 894);
        Controls.Add(panel5);
        Controls.Add(panel1);
        Controls.Add(panel4);
        Controls.Add(splitter1);
        Text = "Form_HienThiMatHang";
        panel4.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel10.ResumeLayout(false);
        panel10.PerformLayout();
        panel9.ResumeLayout(false);
        panel9.PerformLayout();
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel5.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel8.ResumeLayout(false);
        groupBoxSP1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxSP1).EndInit();
        panel7.ResumeLayout(false);
        groupBoxSP3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxSP3).EndInit();
        panel6.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.TextBox txttenKhachHang;
    private System.Windows.Forms.Button btnApDung;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.ComboBox cboLoaiSP;
    private System.Windows.Forms.ComboBox cboTenNcc;

    private System.Windows.Forms.TextBox txttenSP;

    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel8;

    private System.Windows.Forms.GroupBox groupBoxSP3;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.PictureBox pictureBoxSP1;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Button buttonbuy3;
    private System.Windows.Forms.PictureBox pictureBoxSP3;

    private System.Windows.Forms.Panel panel6;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel10;

    private System.Windows.Forms.Panel panel9;

    private System.Windows.Forms.GroupBox groupBoxSP1;
    private System.Windows.Forms.Button btnbuy1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    private System.Windows.Forms.Panel panel5;

    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.TextBox txtTienKhachTT;

    private System.Windows.Forms.Label lblTongTien;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnThanhToan;
    private System.Windows.Forms.Button btnHuy;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.DataGridView dgvHoaDon;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Splitter splitter1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}