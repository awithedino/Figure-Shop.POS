using System.ComponentModel;

namespace FigureShop.POS.Views;

partial class Form_Menu
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
        panel1 = new System.Windows.Forms.Panel();
        flpMenu = new System.Windows.Forms.FlowLayoutPanel();
        btnQuanLy = new System.Windows.Forms.Button();
        flpManagementSubmenu = new System.Windows.Forms.FlowLayoutPanel();
        btnSanPham = new System.Windows.Forms.Button();
        btnKhachHang = new System.Windows.Forms.Button();
        btnHang = new System.Windows.Forms.Button();
        btnTheLoai = new System.Windows.Forms.Button();
        btnNhanVien = new System.Windows.Forms.Button();
        btnCongViec = new System.Windows.Forms.Button();
        btnNghiepVu = new System.Windows.Forms.Button();
        flpOperationsSubmenu = new System.Windows.Forms.FlowLayoutPanel();
        btnBanHang = new System.Windows.Forms.Button();
        btnNhapHang = new System.Windows.Forms.Button();
        btnHoaDon = new System.Windows.Forms.Button();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        panel2 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        lblQuyen = new System.Windows.Forms.Label();
        lblXinChao = new System.Windows.Forms.Label();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        panelMainContent = new System.Windows.Forms.Panel();
        panel1.SuspendLayout();
        flpMenu.SuspendLayout();
        flpManagementSubmenu.SuspendLayout();
        flpOperationsSubmenu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
        panel1.Controls.Add(flpMenu);
        panel1.Controls.Add(pictureBox1);
        panel1.Dock = System.Windows.Forms.DockStyle.Left;
        panel1.ForeColor = System.Drawing.Color.White;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(152, 894);
        panel1.TabIndex = 0;
        // 
        // flpMenu
        // 
        flpMenu.BackColor = System.Drawing.Color.Transparent;
        flpMenu.Controls.Add(btnQuanLy);
        flpMenu.Controls.Add(flpManagementSubmenu);
        flpMenu.Controls.Add(btnNghiepVu);
        flpMenu.Controls.Add(flpOperationsSubmenu);
        flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
        flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        flpMenu.ForeColor = System.Drawing.Color.Black;
        flpMenu.Location = new System.Drawing.Point(0, 152);
        flpMenu.Name = "flpMenu";
        flpMenu.Size = new System.Drawing.Size(152, 742);
        flpMenu.TabIndex = 1;
        flpMenu.WrapContents = false;
        // 
        // btnQuanLy
        // 
        btnQuanLy.BackColor = System.Drawing.Color.DodgerBlue;
        btnQuanLy.FlatAppearance.BorderSize = 0;
        btnQuanLy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnQuanLy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnQuanLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnQuanLy.ForeColor = System.Drawing.Color.White;
        btnQuanLy.Location = new System.Drawing.Point(0, 0);
        btnQuanLy.Margin = new System.Windows.Forms.Padding(0);
        btnQuanLy.Name = "btnQuanLy";
        btnQuanLy.Size = new System.Drawing.Size(152, 44);
        btnQuanLy.TabIndex = 0;
        btnQuanLy.Text = "📁 Quản lý";
        btnQuanLy.UseVisualStyleBackColor = false;
        btnQuanLy.Click += btnQuanLy_Click;
        // 
        // flpManagementSubmenu
        // 
        flpManagementSubmenu.AutoSize = true;
        flpManagementSubmenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        flpManagementSubmenu.BackColor = System.Drawing.Color.DodgerBlue;
        flpManagementSubmenu.Controls.Add(btnSanPham);
        flpManagementSubmenu.Controls.Add(btnKhachHang);
        flpManagementSubmenu.Controls.Add(btnHang);
        flpManagementSubmenu.Controls.Add(btnTheLoai);
        flpManagementSubmenu.Controls.Add(btnNhanVien);
        flpManagementSubmenu.Controls.Add(btnCongViec);
        flpManagementSubmenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        flpManagementSubmenu.Location = new System.Drawing.Point(3, 47);
        flpManagementSubmenu.Name = "flpManagementSubmenu";
        flpManagementSubmenu.Size = new System.Drawing.Size(152, 306);
        flpManagementSubmenu.TabIndex = 1;
        flpManagementSubmenu.Visible = false;
        flpManagementSubmenu.WrapContents = false;
        // 
        // btnSanPham
        // 
        btnSanPham.FlatAppearance.BorderSize = 0;
        btnSanPham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSanPham.ForeColor = System.Drawing.Color.White;
        btnSanPham.Location = new System.Drawing.Point(3, 3);
        btnSanPham.Name = "btnSanPham";
        btnSanPham.Size = new System.Drawing.Size(146, 45);
        btnSanPham.TabIndex = 0;
        btnSanPham.Text = "Sản Phẩm";
        btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnSanPham.UseVisualStyleBackColor = true;
        btnSanPham.Click += btnSanPham_Click;
        // 
        // btnKhachHang
        // 
        btnKhachHang.FlatAppearance.BorderSize = 0;
        btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnKhachHang.ForeColor = System.Drawing.Color.White;
        btnKhachHang.Location = new System.Drawing.Point(3, 54);
        btnKhachHang.Name = "btnKhachHang";
        btnKhachHang.Size = new System.Drawing.Size(146, 45);
        btnKhachHang.TabIndex = 4;
        btnKhachHang.Text = "Khách Hàng";
        btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnKhachHang.UseVisualStyleBackColor = true;
        btnKhachHang.Click += btnKhachHang_Click;
        // 
        // btnHang
        // 
        btnHang.FlatAppearance.BorderSize = 0;
        btnHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnHang.ForeColor = System.Drawing.Color.White;
        btnHang.Location = new System.Drawing.Point(3, 105);
        btnHang.Name = "btnHang";
        btnHang.Size = new System.Drawing.Size(146, 45);
        btnHang.TabIndex = 3;
        btnHang.Text = "Hãng";
        btnHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnHang.UseVisualStyleBackColor = true;
        btnHang.Click += btnHang_Click;
        // 
        // btnTheLoai
        // 
        btnTheLoai.FlatAppearance.BorderSize = 0;
        btnTheLoai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnTheLoai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTheLoai.ForeColor = System.Drawing.Color.White;
        btnTheLoai.Location = new System.Drawing.Point(3, 156);
        btnTheLoai.Name = "btnTheLoai";
        btnTheLoai.Size = new System.Drawing.Size(146, 45);
        btnTheLoai.TabIndex = 5;
        btnTheLoai.Text = "Danh Mục";
        btnTheLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnTheLoai.UseVisualStyleBackColor = true;
        btnTheLoai.Click += btnTheLoai_Click;
        // 
        // btnNhanVien
        // 
        btnNhanVien.FlatAppearance.BorderSize = 0;
        btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnNhanVien.ForeColor = System.Drawing.Color.White;
        btnNhanVien.Location = new System.Drawing.Point(3, 207);
        btnNhanVien.Name = "btnNhanVien";
        btnNhanVien.Size = new System.Drawing.Size(146, 45);
        btnNhanVien.TabIndex = 1;
        btnNhanVien.Text = "Nhân Viên";
        btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnNhanVien.UseVisualStyleBackColor = true;
        btnNhanVien.Click += btnNhanVien_Click;
        // 
        // btnCongViec
        // 
        btnCongViec.FlatAppearance.BorderSize = 0;
        btnCongViec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnCongViec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnCongViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCongViec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCongViec.ForeColor = System.Drawing.Color.White;
        btnCongViec.Location = new System.Drawing.Point(3, 258);
        btnCongViec.Name = "btnCongViec";
        btnCongViec.Size = new System.Drawing.Size(146, 45);
        btnCongViec.TabIndex = 6;
        btnCongViec.Text = "Công Việc";
        btnCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnCongViec.UseVisualStyleBackColor = true;
        btnCongViec.Click += btnCongViec_Click;
        // 
        // btnNghiepVu
        // 
        btnNghiepVu.BackColor = System.Drawing.Color.DodgerBlue;
        btnNghiepVu.FlatAppearance.BorderSize = 0;
        btnNghiepVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnNghiepVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnNghiepVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNghiepVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnNghiepVu.ForeColor = System.Drawing.Color.White;
        btnNghiepVu.Location = new System.Drawing.Point(0, 356);
        btnNghiepVu.Margin = new System.Windows.Forms.Padding(0);
        btnNghiepVu.Name = "btnNghiepVu";
        btnNghiepVu.Size = new System.Drawing.Size(152, 44);
        btnNghiepVu.TabIndex = 2;
        btnNghiepVu.Text = "⚙️ Nghiệp Vụ";
        btnNghiepVu.UseVisualStyleBackColor = false;
        btnNghiepVu.Click += btnNghiepVu_Click;
        // 
        // flpOperationsSubmenu
        // 
        flpOperationsSubmenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        flpOperationsSubmenu.BackColor = System.Drawing.Color.DodgerBlue;
        flpOperationsSubmenu.Controls.Add(btnBanHang);
        flpOperationsSubmenu.Controls.Add(btnNhapHang);
        flpOperationsSubmenu.Controls.Add(btnHoaDon);
        flpOperationsSubmenu.Location = new System.Drawing.Point(3, 403);
        flpOperationsSubmenu.Name = "flpOperationsSubmenu";
        flpOperationsSubmenu.Size = new System.Drawing.Size(152, 135);
        flpOperationsSubmenu.TabIndex = 3;
        flpOperationsSubmenu.Visible = false;
        // 
        // btnBanHang
        // 
        btnBanHang.BackColor = System.Drawing.Color.DodgerBlue;
        btnBanHang.FlatAppearance.BorderSize = 0;
        btnBanHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnBanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBanHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnBanHang.ForeColor = System.Drawing.Color.White;
        btnBanHang.Location = new System.Drawing.Point(0, 0);
        btnBanHang.Margin = new System.Windows.Forms.Padding(0);
        btnBanHang.Name = "btnBanHang";
        btnBanHang.Size = new System.Drawing.Size(146, 45);
        btnBanHang.TabIndex = 2;
        btnBanHang.Text = "Bán Hàng";
        btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnBanHang.UseVisualStyleBackColor = false;
        btnBanHang.Click += btnBanHang_Click;
        // 
        // btnNhapHang
        // 
        btnNhapHang.BackColor = System.Drawing.Color.DodgerBlue;
        btnNhapHang.FlatAppearance.BorderSize = 0;
        btnNhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnNhapHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNhapHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnNhapHang.ForeColor = System.Drawing.Color.White;
        btnNhapHang.Location = new System.Drawing.Point(0, 45);
        btnNhapHang.Margin = new System.Windows.Forms.Padding(0);
        btnNhapHang.Name = "btnNhapHang";
        btnNhapHang.Size = new System.Drawing.Size(146, 45);
        btnNhapHang.TabIndex = 3;
        btnNhapHang.Text = "Nhập Hàng";
        btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnNhapHang.UseVisualStyleBackColor = false;
        btnNhapHang.Click += btnNhapHang_Click;
        // 
        // btnHoaDon
        // 
        btnHoaDon.BackColor = System.Drawing.Color.DodgerBlue;
        btnHoaDon.FlatAppearance.BorderSize = 0;
        btnHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
        btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
        btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnHoaDon.ForeColor = System.Drawing.Color.White;
        btnHoaDon.Location = new System.Drawing.Point(0, 90);
        btnHoaDon.Margin = new System.Windows.Forms.Padding(0);
        btnHoaDon.Name = "btnHoaDon";
        btnHoaDon.Size = new System.Drawing.Size(146, 45);
        btnHoaDon.TabIndex = 4;
        btnHoaDon.Text = "Hóa Đơn";
        btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        btnHoaDon.UseVisualStyleBackColor = false;
        btnHoaDon.Click += btnHoaDon_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = System.Drawing.SystemColors.Control;
        pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(152, 152);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.DodgerBlue;
        panel2.Controls.Add(label1);
        panel2.Dock = System.Windows.Forms.DockStyle.Top;
        panel2.ForeColor = System.Drawing.Color.White;
        panel2.Location = new System.Drawing.Point(152, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(1306, 86);
        panel2.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 19.800001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(524, 18);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(294, 54);
        label1.TabIndex = 0;
        label1.Text = "<text>";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.DodgerBlue;
        panel3.Controls.Add(lblQuyen);
        panel3.Controls.Add(lblXinChao);
        panel3.Controls.Add(dateTimePicker1);
        panel3.Dock = System.Windows.Forms.DockStyle.Top;
        panel3.ForeColor = System.Drawing.Color.White;
        panel3.Location = new System.Drawing.Point(152, 86);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(1306, 66);
        panel3.TabIndex = 2;
        // 
        // lblQuyen
        // 
        lblQuyen.Location = new System.Drawing.Point(6, 34);
        lblQuyen.Name = "lblQuyen";
        lblQuyen.Size = new System.Drawing.Size(139, 23);
        lblQuyen.TabIndex = 2;
        lblQuyen.Text = "Quyền: <text>";
        // 
        // lblXinChao
        // 
        lblXinChao.Location = new System.Drawing.Point(6, 3);
        lblXinChao.Name = "lblXinChao";
        lblXinChao.Size = new System.Drawing.Size(210, 23);
        lblXinChao.TabIndex = 0;
        lblXinChao.Text = "Xin chào: <text>";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        dateTimePicker1.Enabled = false;
        dateTimePicker1.Location = new System.Drawing.Point(995, 0);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(311, 27);
        dateTimePicker1.TabIndex = 4;
        // 
        // panelMainContent
        // 
        panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
        panelMainContent.Location = new System.Drawing.Point(152, 152);
        panelMainContent.Name = "panelMainContent";
        panelMainContent.Size = new System.Drawing.Size(1306, 742);
        panelMainContent.TabIndex = 3;
        // 
        // Form_Menu
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1458, 894);
        Controls.Add(panelMainContent);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Margin = new System.Windows.Forms.Padding(2);
        Text = "Menu";
        Load += Form_Menu_Load;
        panel1.ResumeLayout(false);
        flpMenu.ResumeLayout(false);
        flpMenu.PerformLayout();
        flpManagementSubmenu.ResumeLayout(false);
        flpOperationsSubmenu.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnNhapHang;
    private System.Windows.Forms.Button btnHoaDon;

    private System.Windows.Forms.Button btnBanHang;

    private System.Windows.Forms.FlowLayoutPanel flpOperationsSubmenu;

    private System.Windows.Forms.Button btnNghiepVu;

    private System.Windows.Forms.Button btnCongViec;

    private System.Windows.Forms.Button btnTheLoai;

    private System.Windows.Forms.Button btnKhachHang;

    private System.Windows.Forms.Button btnHang;

    private System.Windows.Forms.Button btnNhanVien;

    private System.Windows.Forms.Button btnSanPham;

    private System.Windows.Forms.FlowLayoutPanel flpManagementSubmenu;


    private System.Windows.Forms.Button btnQuanLy;

    private System.Windows.Forms.Panel panelMainContent;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblXinChao;
    private System.Windows.Forms.Label lblQuyen;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.FlowLayoutPanel flpMenu;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}