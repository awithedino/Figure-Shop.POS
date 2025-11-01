using System.ComponentModel;

namespace FigureShop.POS;

partial class Form_BanHang
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
        panel1 = new System.Windows.Forms.Panel();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        grbTTChung = new System.Windows.Forms.GroupBox();
        txtHoaDon = new System.Windows.Forms.TextBox();
        cboMaNV = new System.Windows.Forms.ComboBox();
        label5 = new System.Windows.Forms.Label();
        txtTenNV = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        cboKhachHang = new System.Windows.Forms.ComboBox();
        label3 = new System.Windows.Forms.Label();
        dtpNgayBan = new System.Windows.Forms.DateTimePicker();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        splitter1 = new System.Windows.Forms.Splitter();
        grbTTChiTiet = new System.Windows.Forms.GroupBox();
        label15 = new System.Windows.Forms.Label();
        lblThanhTien = new System.Windows.Forms.Label();
        lbtDonGia = new System.Windows.Forms.Label();
        numericUpDownSL = new System.Windows.Forms.NumericUpDown();
        btnXoa = new System.Windows.Forms.Button();
        btnThem = new System.Windows.Forms.Button();
        label11 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        label6 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        lblTienThua = new System.Windows.Forms.Label();
        lblKhachTT = new System.Windows.Forms.Label();
        lblTongTien = new System.Windows.Forms.Label();
        label14 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        btnThanhToan = new System.Windows.Forms.Button();
        label13 = new System.Windows.Forms.Label();
        label12 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        grbTTChung.SuspendLayout();
        grbTTChiTiet.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownSL).BeginInit();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(dataGridView1);
        panel1.Controls.Add(grbTTChung);
        panel1.Dock = System.Windows.Forms.DockStyle.Left;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(707, 894);
        panel1.TabIndex = 0;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 34;
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView1.Location = new System.Drawing.Point(0, 295);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new System.Drawing.Size(707, 599);
        dataGridView1.TabIndex = 1;
        // 
        // grbTTChung
        // 
        grbTTChung.Controls.Add(txtHoaDon);
        grbTTChung.Controls.Add(cboMaNV);
        grbTTChung.Controls.Add(label5);
        grbTTChung.Controls.Add(txtTenNV);
        grbTTChung.Controls.Add(label4);
        grbTTChung.Controls.Add(cboKhachHang);
        grbTTChung.Controls.Add(label3);
        grbTTChung.Controls.Add(dtpNgayBan);
        grbTTChung.Controls.Add(label2);
        grbTTChung.Controls.Add(label1);
        grbTTChung.Dock = System.Windows.Forms.DockStyle.Top;
        grbTTChung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grbTTChung.Location = new System.Drawing.Point(0, 0);
        grbTTChung.Name = "grbTTChung";
        grbTTChung.Size = new System.Drawing.Size(707, 295);
        grbTTChung.TabIndex = 0;
        grbTTChung.TabStop = false;
        grbTTChung.Text = "Thông tin chung";
        // 
        // txtHoaDon
        // 
        txtHoaDon.Location = new System.Drawing.Point(12, 62);
        txtHoaDon.Name = "txtHoaDon";
        txtHoaDon.Size = new System.Drawing.Size(254, 31);
        txtHoaDon.TabIndex = 9;
        // 
        // cboMaNV
        // 
        cboMaNV.FormattingEnabled = true;
        cboMaNV.Location = new System.Drawing.Point(12, 227);
        cboMaNV.Name = "cboMaNV";
        cboMaNV.Size = new System.Drawing.Size(254, 33);
        cboMaNV.TabIndex = 8;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(359, 194);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(149, 23);
        label5.TabIndex = 7;
        label5.Text = "Tên Nhân Viên";
        // 
        // txtTenNV
        // 
        txtTenNV.Location = new System.Drawing.Point(359, 229);
        txtTenNV.Name = "txtTenNV";
        txtTenNV.Size = new System.Drawing.Size(321, 31);
        txtTenNV.TabIndex = 6;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(12, 194);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(146, 23);
        label4.TabIndex = 5;
        label4.Text = "Mã Nhân Viên";
        // 
        // cboKhachHang
        // 
        cboKhachHang.FormattingEnabled = true;
        cboKhachHang.Location = new System.Drawing.Point(359, 140);
        cboKhachHang.Name = "cboKhachHang";
        cboKhachHang.Size = new System.Drawing.Size(321, 33);
        cboKhachHang.TabIndex = 4;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(359, 98);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(121, 26);
        label3.TabIndex = 3;
        label3.Text = "Khách Hàng";
        // 
        // dtpNgayBan
        // 
        dtpNgayBan.CalendarFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpNgayBan.Location = new System.Drawing.Point(12, 140);
        dtpNgayBan.Name = "dtpNgayBan";
        dtpNgayBan.Size = new System.Drawing.Size(254, 31);
        dtpNgayBan.TabIndex = 2;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(12, 98);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 1;
        label2.Text = "Ngày bán";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(12, 27);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(138, 23);
        label1.TabIndex = 0;
        label1.Text = "Mã Hóa Đơn";
        // 
        // splitter1
        // 
        splitter1.BackColor = System.Drawing.Color.Black;
        splitter1.Location = new System.Drawing.Point(707, 0);
        splitter1.Name = "splitter1";
        splitter1.Size = new System.Drawing.Size(10, 894);
        splitter1.TabIndex = 1;
        splitter1.TabStop = false;
        // 
        // grbTTChiTiet
        // 
        grbTTChiTiet.Controls.Add(label15);
        grbTTChiTiet.Controls.Add(lblThanhTien);
        grbTTChiTiet.Controls.Add(lbtDonGia);
        grbTTChiTiet.Controls.Add(numericUpDownSL);
        grbTTChiTiet.Controls.Add(btnXoa);
        grbTTChiTiet.Controls.Add(btnThem);
        grbTTChiTiet.Controls.Add(label11);
        grbTTChiTiet.Controls.Add(label10);
        grbTTChiTiet.Controls.Add(label9);
        grbTTChiTiet.Controls.Add(label8);
        grbTTChiTiet.Controls.Add(label7);
        grbTTChiTiet.Controls.Add(comboBox1);
        grbTTChiTiet.Controls.Add(label6);
        grbTTChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
        grbTTChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grbTTChiTiet.Location = new System.Drawing.Point(717, 0);
        grbTTChiTiet.Name = "grbTTChiTiet";
        grbTTChiTiet.Size = new System.Drawing.Size(741, 586);
        grbTTChiTiet.TabIndex = 2;
        grbTTChiTiet.TabStop = false;
        grbTTChiTiet.Text = "Thông tin chi tiết";
        // 
        // label15
        // 
        label15.Location = new System.Drawing.Point(389, 343);
        label15.Name = "label15";
        label15.Size = new System.Drawing.Size(244, 23);
        label15.TabIndex = 13;
        label15.Text = "0";
        label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblThanhTien
        // 
        lblThanhTien.Location = new System.Drawing.Point(389, 406);
        lblThanhTien.Name = "lblThanhTien";
        lblThanhTien.Size = new System.Drawing.Size(244, 23);
        lblThanhTien.TabIndex = 12;
        lblThanhTien.Text = "0";
        lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lbtDonGia
        // 
        lbtDonGia.Location = new System.Drawing.Point(389, 279);
        lbtDonGia.Name = "lbtDonGia";
        lbtDonGia.Size = new System.Drawing.Size(244, 23);
        lbtDonGia.TabIndex = 10;
        lbtDonGia.Text = "0";
        lbtDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // numericUpDownSL
        // 
        numericUpDownSL.Location = new System.Drawing.Point(67, 276);
        numericUpDownSL.Name = "numericUpDownSL";
        numericUpDownSL.Size = new System.Drawing.Size(100, 31);
        numericUpDownSL.TabIndex = 9;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = System.Drawing.Color.Crimson;
        btnXoa.ForeColor = System.Drawing.Color.White;
        btnXoa.Location = new System.Drawing.Point(550, 516);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(138, 53);
        btnXoa.TabIndex = 8;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = false;
        // 
        // btnThem
        // 
        btnThem.BackColor = System.Drawing.Color.DodgerBlue;
        btnThem.ForeColor = System.Drawing.Color.White;
        btnThem.Location = new System.Drawing.Point(335, 516);
        btnThem.Name = "btnThem";
        btnThem.Size = new System.Drawing.Size(138, 53);
        btnThem.TabIndex = 7;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = false;
        // 
        // label11
        // 
        label11.Location = new System.Drawing.Point(67, 406);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(110, 23);
        label11.TabIndex = 6;
        label11.Text = "Thành tiền";
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(67, 339);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(100, 27);
        label10.TabIndex = 5;
        label10.Text = "Giảm giá";
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(389, 230);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(100, 30);
        label9.TabIndex = 4;
        label9.Text = "Đơn giá";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(67, 232);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(100, 30);
        label8.TabIndex = 3;
        label8.Text = "Số lượng";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(67, 170);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(145, 23);
        label7.TabIndex = 2;
        label7.Text = "Tên Sản Phẩm";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(67, 107);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(621, 33);
        comboBox1.TabIndex = 1;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(67, 45);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(145, 23);
        label6.TabIndex = 0;
        label6.Text = "Mã Sản Phẩm";
        // 
        // panel2
        // 
        panel2.Controls.Add(lblTienThua);
        panel2.Controls.Add(lblKhachTT);
        panel2.Controls.Add(lblTongTien);
        panel2.Controls.Add(label14);
        panel2.Controls.Add(button2);
        panel2.Controls.Add(btnThanhToan);
        panel2.Controls.Add(label13);
        panel2.Controls.Add(label12);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        panel2.Location = new System.Drawing.Point(717, 586);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(741, 308);
        panel2.TabIndex = 3;
        // 
        // lblTienThua
        // 
        lblTienThua.Location = new System.Drawing.Point(389, 166);
        lblTienThua.Name = "lblTienThua";
        lblTienThua.Size = new System.Drawing.Size(280, 31);
        lblTienThua.TabIndex = 9;
        lblTienThua.Text = "0";
        lblTienThua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblKhachTT
        // 
        lblKhachTT.Location = new System.Drawing.Point(389, 111);
        lblKhachTT.Name = "lblKhachTT";
        lblKhachTT.Size = new System.Drawing.Size(280, 23);
        lblKhachTT.TabIndex = 8;
        lblKhachTT.Text = "0";
        lblKhachTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTongTien
        // 
        lblTongTien.Location = new System.Drawing.Point(389, 50);
        lblTongTien.Name = "lblTongTien";
        lblTongTien.Size = new System.Drawing.Size(280, 23);
        lblTongTien.TabIndex = 7;
        lblTongTien.Text = "0";
        lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label14
        // 
        label14.Location = new System.Drawing.Point(67, 49);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(172, 23);
        label14.TabIndex = 6;
        label14.Text = "Tổng tiền";
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.Green;
        button2.ForeColor = System.Drawing.Color.White;
        button2.Location = new System.Drawing.Point(550, 239);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(119, 37);
        button2.TabIndex = 5;
        button2.Text = "Excel";
        button2.UseVisualStyleBackColor = false;
        // 
        // btnThanhToan
        // 
        btnThanhToan.BackColor = System.Drawing.Color.Lime;
        btnThanhToan.ForeColor = System.Drawing.Color.White;
        btnThanhToan.Location = new System.Drawing.Point(90, 239);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new System.Drawing.Size(279, 37);
        btnThanhToan.TabIndex = 4;
        btnThanhToan.Text = "Thanh Toán";
        btnThanhToan.UseVisualStyleBackColor = false;
        // 
        // label13
        // 
        label13.Location = new System.Drawing.Point(67, 169);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(182, 23);
        label13.TabIndex = 1;
        label13.Text = "Tiền thừa trả khách";
        // 
        // label12
        // 
        label12.Location = new System.Drawing.Point(67, 110);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(182, 23);
        label12.TabIndex = 0;
        label12.Text = "Khách thanh toán";
        // 
        // Form_BanHang
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1458, 894);
        Controls.Add(panel2);
        Controls.Add(grbTTChiTiet);
        Controls.Add(splitter1);
        Controls.Add(panel1);
        Text = "Form_BanHang";
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        grbTTChung.ResumeLayout(false);
        grbTTChung.PerformLayout();
        grbTTChiTiet.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDownSL).EndInit();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label15;

    private System.Windows.Forms.TextBox txtHoaDon;

    private System.Windows.Forms.Label lblThanhTien;

    private System.Windows.Forms.Label lblTongTien;

    private System.Windows.Forms.Label lbtDonGia;

    private System.Windows.Forms.Label lblTienThua;

    private System.Windows.Forms.Label lblKhachTT;

    private System.Windows.Forms.Label label14;

    private System.Windows.Forms.NumericUpDown numericUpDownSL;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button btnThanhToan;

    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;

    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnXoa;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.GroupBox grbTTChiTiet;

    private System.Windows.Forms.Splitter splitter1;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cboMaNV;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtTenNV;

    private System.Windows.Forms.ComboBox cboKhachHang;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.DateTimePicker dtpNgayBan;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.GroupBox grbTTChung;

    private System.Windows.Forms.Panel panel1;

    #endregion
}