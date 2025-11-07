using System.ComponentModel;

namespace FigureShop.POS;

partial class UserControl_NhanVien
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBox1 = new System.Windows.Forms.GroupBox();
        label1 = new System.Windows.Forms.Label();
        groupBox3 = new System.Windows.Forms.GroupBox();
        dgvNhanVien = new System.Windows.Forms.DataGridView();
        groupBox6 = new System.Windows.Forms.GroupBox();
        btnTimKiem = new System.Windows.Forms.Button();
        txtTimKiem = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        splitter1 = new System.Windows.Forms.Splitter();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        groupBox4 = new System.Windows.Forms.GroupBox();
        groupBox5 = new System.Windows.Forms.GroupBox();
        btnExcel = new System.Windows.Forms.Button();
        btnReload = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        btnBoQua = new System.Windows.Forms.Button();
        btnSua = new System.Windows.Forms.Button();
        btnLuu = new System.Windows.Forms.Button();
        btnThem = new System.Windows.Forms.Button();
        dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
        txtGioiTinh = new System.Windows.Forms.TextBox();
        txtTenNV = new System.Windows.Forms.TextBox();
        txtMaNV = new System.Windows.Forms.TextBox();
        txtSDT = new System.Windows.Forms.TextBox();
        txtDiaChi = new System.Windows.Forms.TextBox();
        txtMaCV = new System.Windows.Forms.TextBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        groupBox1.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
        groupBox6.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        groupBox1.Location = new System.Drawing.Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(1021, 105);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(3, 23);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(1015, 79);
        label1.TabIndex = 0;
        label1.Text = "Nhân viên";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(dgvNhanVien);
        groupBox3.Controls.Add(groupBox6);
        groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox3.Location = new System.Drawing.Point(284, 105);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(737, 628);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Tìm kiếm nhân viên";
        // 
        // dgvNhanVien
        // 
        dgvNhanVien.ColumnHeadersHeight = 29;
        dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvNhanVien.Location = new System.Drawing.Point(3, 128);
        dgvNhanVien.Name = "dgvNhanVien";
        dgvNhanVien.RowHeadersWidth = 51;
        dgvNhanVien.Size = new System.Drawing.Size(731, 497);
        dgvNhanVien.TabIndex = 1;
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(btnTimKiem);
        groupBox6.Controls.Add(txtTimKiem);
        groupBox6.Controls.Add(label9);
        groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
        groupBox6.Location = new System.Drawing.Point(3, 26);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new System.Drawing.Size(731, 102);
        groupBox6.TabIndex = 0;
        groupBox6.TabStop = false;
        // 
        // btnTimKiem
        // 
        btnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.ForeColor = System.Drawing.Color.White;
        btnTimKiem.Location = new System.Drawing.Point(561, 44);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(96, 29);
        btnTimKiem.TabIndex = 2;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Location = new System.Drawing.Point(253, 43);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new System.Drawing.Size(286, 30);
        txtTimKiem.TabIndex = 1;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(77, 46);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(159, 24);
        label9.TabIndex = 0;
        label9.Text = "Tên/Mã nhân viên:";
        // 
        // splitter1
        // 
        splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitter1.Dock = System.Windows.Forms.DockStyle.Right;
        splitter1.Location = new System.Drawing.Point(271, 26);
        splitter1.Name = "splitter1";
        splitter1.Size = new System.Drawing.Size(10, 599);
        splitter1.TabIndex = 0;
        splitter1.TabStop = false;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(6, 40);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(90, 25);
        label2.TabIndex = 1;
        label2.Text = "Mã NV:";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(6, 74);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(90, 25);
        label3.TabIndex = 2;
        label3.Text = "Tên NV:";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(6, 109);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(90, 25);
        label4.TabIndex = 3;
        label4.Text = "Giới tính:";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(6, 145);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(90, 25);
        label5.TabIndex = 4;
        label5.Text = "Ngày sinh:";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(6, 185);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(90, 25);
        label6.TabIndex = 5;
        label6.Text = "SĐT:";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(6, 220);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(90, 25);
        label7.TabIndex = 6;
        label7.Text = "Địa chỉ:";
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(6, 300);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(77, 25);
        label8.TabIndex = 7;
        label8.Text = "Mã CV:";
        // 
        // groupBox4
        // 
        groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        groupBox4.Location = new System.Drawing.Point(0, 650);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new System.Drawing.Size(257, 272);
        groupBox4.TabIndex = 3;
        groupBox4.TabStop = false;
        groupBox4.Text = "groupBox4";
        // 
        // groupBox5
        // 
        groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        groupBox5.Controls.Add(btnExcel);
        groupBox5.Controls.Add(btnReload);
        groupBox5.Controls.Add(btnXoa);
        groupBox5.Controls.Add(btnBoQua);
        groupBox5.Controls.Add(btnSua);
        groupBox5.Controls.Add(btnLuu);
        groupBox5.Controls.Add(btnThem);
        groupBox5.Location = new System.Drawing.Point(3, 337);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new System.Drawing.Size(265, 287);
        groupBox5.TabIndex = 8;
        groupBox5.TabStop = false;
        groupBox5.Text = "Công cụ";
        // 
        // btnExcel
        // 
        btnExcel.BackColor = System.Drawing.Color.SeaGreen;
        btnExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnExcel.ForeColor = System.Drawing.Color.Transparent;
        btnExcel.Location = new System.Drawing.Point(151, 196);
        btnExcel.Name = "btnExcel";
        btnExcel.Size = new System.Drawing.Size(68, 33);
        btnExcel.TabIndex = 6;
        btnExcel.Text = "Excel";
        btnExcel.UseVisualStyleBackColor = false;
        // 
        // btnReload
        // 
        btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnReload.Location = new System.Drawing.Point(151, 146);
        btnReload.Name = "btnReload";
        btnReload.Size = new System.Drawing.Size(68, 33);
        btnReload.TabIndex = 5;
        btnReload.Text = "Reload";
        btnReload.UseVisualStyleBackColor = true;
        // 
        // btnXoa
        // 
        btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoa.Location = new System.Drawing.Point(25, 146);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(68, 33);
        btnXoa.TabIndex = 4;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        // 
        // btnBoQua
        // 
        btnBoQua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnBoQua.Location = new System.Drawing.Point(151, 96);
        btnBoQua.Name = "btnBoQua";
        btnBoQua.Size = new System.Drawing.Size(68, 33);
        btnBoQua.TabIndex = 3;
        btnBoQua.Text = "Bỏ qua";
        btnBoQua.UseVisualStyleBackColor = true;
        // 
        // btnSua
        // 
        btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSua.Location = new System.Drawing.Point(25, 96);
        btnSua.Name = "btnSua";
        btnSua.Size = new System.Drawing.Size(68, 33);
        btnSua.TabIndex = 2;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        // 
        // btnLuu
        // 
        btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLuu.Location = new System.Drawing.Point(151, 45);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new System.Drawing.Size(68, 33);
        btnLuu.TabIndex = 1;
        btnLuu.Text = "Lưu";
        btnLuu.UseVisualStyleBackColor = true;
        // 
        // btnThem
        // 
        btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThem.Location = new System.Drawing.Point(25, 45);
        btnThem.Name = "btnThem";
        btnThem.Size = new System.Drawing.Size(68, 33);
        btnThem.TabIndex = 0;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        // 
        // dtpNgaySinh
        // 
        dtpNgaySinh.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpNgaySinh.Location = new System.Drawing.Point(108, 143);
        dtpNgaySinh.Name = "dtpNgaySinh";
        dtpNgaySinh.Size = new System.Drawing.Size(150, 27);
        dtpNgaySinh.TabIndex = 9;
        // 
        // txtGioiTinh
        // 
        txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtGioiTinh.Location = new System.Drawing.Point(108, 106);
        txtGioiTinh.Name = "txtGioiTinh";
        txtGioiTinh.Size = new System.Drawing.Size(149, 27);
        txtGioiTinh.TabIndex = 10;
        // 
        // txtTenNV
        // 
        txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTenNV.Location = new System.Drawing.Point(108, 71);
        txtTenNV.Name = "txtTenNV";
        txtTenNV.Size = new System.Drawing.Size(149, 27);
        txtTenNV.TabIndex = 11;
        // 
        // txtMaNV
        // 
        txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMaNV.Location = new System.Drawing.Point(108, 37);
        txtMaNV.Name = "txtMaNV";
        txtMaNV.Size = new System.Drawing.Size(149, 27);
        txtMaNV.TabIndex = 12;
        // 
        // txtSDT
        // 
        txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtSDT.Location = new System.Drawing.Point(108, 182);
        txtSDT.Name = "txtSDT";
        txtSDT.Size = new System.Drawing.Size(149, 27);
        txtSDT.TabIndex = 13;
        // 
        // txtDiaChi
        // 
        txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtDiaChi.Location = new System.Drawing.Point(108, 217);
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new System.Drawing.Size(149, 27);
        txtDiaChi.TabIndex = 14;
        // 
        // txtMaCV
        // 
        txtMaCV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMaCV.Location = new System.Drawing.Point(108, 297);
        txtMaCV.Name = "txtMaCV";
        txtMaCV.Size = new System.Drawing.Size(149, 27);
        txtMaCV.TabIndex = 15;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txtMaCV);
        groupBox2.Controls.Add(txtDiaChi);
        groupBox2.Controls.Add(txtSDT);
        groupBox2.Controls.Add(txtMaNV);
        groupBox2.Controls.Add(txtTenNV);
        groupBox2.Controls.Add(txtGioiTinh);
        groupBox2.Controls.Add(dtpNgaySinh);
        groupBox2.Controls.Add(groupBox5);
        groupBox2.Controls.Add(groupBox4);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(splitter1);
        groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
        groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox2.Location = new System.Drawing.Point(0, 105);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(284, 628);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Thông tin nhân viên";
        // 
        // UserControl_NhanVien
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Size = new System.Drawing.Size(1021, 733);
        groupBox1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
        groupBox6.ResumeLayout(false);
        groupBox6.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnBoQua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnReload;
    private System.Windows.Forms.Button btnExcel;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.TextBox txtGioiTinh;
    private System.Windows.Forms.TextBox txtTenNV;
    private System.Windows.Forms.TextBox txtMaNV;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.TextBox txtMaCV;
    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.Button btnTimKiem;

    private System.Windows.Forms.TextBox txtTimKiem;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.DataGridView dgvNhanVien;

    private System.Windows.Forms.GroupBox groupBox6;

    private System.Windows.Forms.GroupBox groupBox3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}