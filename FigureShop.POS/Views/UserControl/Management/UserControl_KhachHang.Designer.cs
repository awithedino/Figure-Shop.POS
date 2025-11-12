using System.ComponentModel;

namespace FigureShop.POS.Views.UserControl.Management;

partial class UserControl_KhachHang
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
        groupBox2 = new System.Windows.Forms.GroupBox();
        cboGioiTinh = new System.Windows.Forms.ComboBox();
        txtDiaChi = new System.Windows.Forms.TextBox();
        txtSDT = new System.Windows.Forms.TextBox();
        txtMaKH = new System.Windows.Forms.TextBox();
        txtTenKH = new System.Windows.Forms.TextBox();
        dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
        groupBox5 = new System.Windows.Forms.GroupBox();
        btnExcel = new System.Windows.Forms.Button();
        btnReload = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        btnBoQua = new System.Windows.Forms.Button();
        btnSua = new System.Windows.Forms.Button();
        btnLuu = new System.Windows.Forms.Button();
        btnThem = new System.Windows.Forms.Button();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        splitter1 = new System.Windows.Forms.Splitter();
        groupBox3 = new System.Windows.Forms.GroupBox();
        dgvKhachHang = new System.Windows.Forms.DataGridView();
        groupBox6 = new System.Windows.Forms.GroupBox();
        btnTimKiem = new System.Windows.Forms.Button();
        txtSearch = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        groupBox2.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
        groupBox6.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(cboGioiTinh);
        groupBox2.Controls.Add(txtDiaChi);
        groupBox2.Controls.Add(txtSDT);
        groupBox2.Controls.Add(txtMaKH);
        groupBox2.Controls.Add(txtTenKH);
        groupBox2.Controls.Add(dtpNgaySinh);
        groupBox2.Controls.Add(groupBox5);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(splitter1);
        groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
        groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox2.Location = new System.Drawing.Point(0, 0);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(263, 733);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Thông tin khách hàng";
        // 
        // cboGioiTinh
        // 
        cboGioiTinh.FormattingEnabled = true;
        cboGioiTinh.Location = new System.Drawing.Point(89, 126);
        cboGioiTinh.Name = "cboGioiTinh";
        cboGioiTinh.Size = new System.Drawing.Size(148, 31);
        cboGioiTinh.TabIndex = 15;
        // 
        // txtDiaChi
        // 
        txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtDiaChi.Location = new System.Drawing.Point(89, 269);
        txtDiaChi.Multiline = true;
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new System.Drawing.Size(149, 112);
        txtDiaChi.TabIndex = 14;
        // 
        // txtSDT
        // 
        txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtSDT.Location = new System.Drawing.Point(89, 224);
        txtSDT.Name = "txtSDT";
        txtSDT.Size = new System.Drawing.Size(149, 27);
        txtSDT.TabIndex = 13;
        // 
        // txtMaKH
        // 
        txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMaKH.Location = new System.Drawing.Point(89, 37);
        txtMaKH.Name = "txtMaKH";
        txtMaKH.Size = new System.Drawing.Size(149, 27);
        txtMaKH.TabIndex = 12;
        // 
        // txtTenKH
        // 
        txtTenKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTenKH.Location = new System.Drawing.Point(89, 82);
        txtTenKH.Name = "txtTenKH";
        txtTenKH.Size = new System.Drawing.Size(149, 27);
        txtTenKH.TabIndex = 11;
        // 
        // dtpNgaySinh
        // 
        dtpNgaySinh.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpNgaySinh.Location = new System.Drawing.Point(89, 176);
        dtpNgaySinh.Name = "dtpNgaySinh";
        dtpNgaySinh.Size = new System.Drawing.Size(150, 27);
        dtpNgaySinh.TabIndex = 9;
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
        groupBox5.Location = new System.Drawing.Point(3, 442);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new System.Drawing.Size(241, 287);
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
        btnReload.Click += btnReload_Click;
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
        btnXoa.Click += btnXoa_Click;
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
        btnBoQua.Click += btnBoQua_Click;
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
        btnSua.Click += btnSua_Click;
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
        btnLuu.Click += btnLuu_Click;
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
        btnThem.Click += btnThem_Click;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(6, 272);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(77, 25);
        label7.TabIndex = 6;
        label7.Text = "Địa chỉ:";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(6, 227);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(77, 25);
        label6.TabIndex = 5;
        label6.Text = "SĐT:";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(6, 178);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(77, 25);
        label5.TabIndex = 4;
        label5.Text = "Ngày sinh:";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(6, 131);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(77, 25);
        label4.TabIndex = 3;
        label4.Text = "Giới tính:";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(6, 85);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(77, 25);
        label3.TabIndex = 2;
        label3.Text = "Tên KH:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(6, 40);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(77, 25);
        label2.TabIndex = 1;
        label2.Text = "Mã KH:";
        // 
        // splitter1
        // 
        splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitter1.Dock = System.Windows.Forms.DockStyle.Right;
        splitter1.Location = new System.Drawing.Point(250, 26);
        splitter1.Name = "splitter1";
        splitter1.Size = new System.Drawing.Size(10, 704);
        splitter1.TabIndex = 0;
        splitter1.TabStop = false;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(dgvKhachHang);
        groupBox3.Controls.Add(groupBox6);
        groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox3.Location = new System.Drawing.Point(263, 0);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(758, 733);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Tìm kiếm khách hàng";
        // 
        // dgvKhachHang
        // 
        dgvKhachHang.ColumnHeadersHeight = 29;
        dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvKhachHang.Location = new System.Drawing.Point(3, 128);
        dgvKhachHang.Name = "dgvKhachHang";
        dgvKhachHang.RowHeadersWidth = 51;
        dgvKhachHang.Size = new System.Drawing.Size(752, 602);
        dgvKhachHang.TabIndex = 1;
        dgvKhachHang.CellClick += dgvKhachHang_CellClick;
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(btnTimKiem);
        groupBox6.Controls.Add(txtSearch);
        groupBox6.Controls.Add(label9);
        groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
        groupBox6.Location = new System.Drawing.Point(3, 26);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new System.Drawing.Size(752, 102);
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
        btnTimKiem.Click += btnTimKiem_Click;
        // 
        // txtSearch
        // 
        txtSearch.Location = new System.Drawing.Point(253, 43);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(286, 30);
        txtSearch.TabIndex = 1;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(77, 46);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(170, 24);
        label9.TabIndex = 0;
        label9.Text = "Tên/Mã khách hàng:";
        // 
        // UserControl_KhachHang
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Size = new System.Drawing.Size(1021, 733);
        Load += UserControl_KhachHang_Load;
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
        groupBox6.ResumeLayout(false);
        groupBox6.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox cboGioiTinh;

    private System.Windows.Forms.TextBox txtTenKH;
    private System.Windows.Forms.TextBox txtMaKH;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.DataGridView dgvKhachHang;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.Button btnExcel;
    private System.Windows.Forms.Button btnReload;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnBoQua;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox2;

    #endregion
}
