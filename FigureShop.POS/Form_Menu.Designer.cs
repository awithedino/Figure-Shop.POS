using System.ComponentModel;

namespace FigureShop.POS;

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
        panel1 = new System.Windows.Forms.Panel();
        flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        btnBanHang = new System.Windows.Forms.Button();
        btnSanPham = new System.Windows.Forms.Button();
        btnNhanVien = new System.Windows.Forms.Button();
        btnKhachhang = new System.Windows.Forms.Button();
        btnNhapHang = new System.Windows.Forms.Button();
        btnNcc = new System.Windows.Forms.Button();
        btnCongViec = new System.Windows.Forms.Button();
        btnTheLoai = new System.Windows.Forms.Button();
        btnTyLe = new System.Windows.Forms.Button();
        btnChatLieu = new System.Windows.Forms.Button();
        btnSeries = new System.Windows.Forms.Button();
        btnDoiTuong = new System.Windows.Forms.Button();
        btnNoiSX = new System.Windows.Forms.Button();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        panel2 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
        panel1.Controls.Add(flowLayoutPanel1);
        panel1.Controls.Add(pictureBox1);
        panel1.Dock = System.Windows.Forms.DockStyle.Left;
        panel1.ForeColor = System.Drawing.Color.White;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(152, 894);
        panel1.TabIndex = 0;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(btnBanHang);
        flowLayoutPanel1.Controls.Add(btnSanPham);
        flowLayoutPanel1.Controls.Add(btnNhanVien);
        flowLayoutPanel1.Controls.Add(btnKhachhang);
        flowLayoutPanel1.Controls.Add(btnNhapHang);
        flowLayoutPanel1.Controls.Add(btnNcc);
        flowLayoutPanel1.Controls.Add(btnCongViec);
        flowLayoutPanel1.Controls.Add(btnTheLoai);
        flowLayoutPanel1.Controls.Add(btnTyLe);
        flowLayoutPanel1.Controls.Add(btnChatLieu);
        flowLayoutPanel1.Controls.Add(btnSeries);
        flowLayoutPanel1.Controls.Add(btnDoiTuong);
        flowLayoutPanel1.Controls.Add(btnNoiSX);
        flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
        flowLayoutPanel1.Location = new System.Drawing.Point(0, 152);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new System.Drawing.Size(152, 742);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // btnBanHang
        // 
        btnBanHang.ForeColor = System.Drawing.Color.Black;
        btnBanHang.Location = new System.Drawing.Point(3, 3);
        btnBanHang.Name = "btnBanHang";
        btnBanHang.Size = new System.Drawing.Size(145, 50);
        btnBanHang.TabIndex = 0;
        btnBanHang.Text = "Bán Hàng";
        btnBanHang.UseVisualStyleBackColor = true;
        // 
        // btnSanPham
        // 
        btnSanPham.Location = new System.Drawing.Point(3, 59);
        btnSanPham.Name = "btnSanPham";
        btnSanPham.Size = new System.Drawing.Size(145, 50);
        btnSanPham.TabIndex = 1;
        btnSanPham.Text = "Sản Phẩm";
        btnSanPham.UseVisualStyleBackColor = true;
        // 
        // btnNhanVien
        // 
        btnNhanVien.Location = new System.Drawing.Point(3, 115);
        btnNhanVien.Name = "btnNhanVien";
        btnNhanVien.Size = new System.Drawing.Size(145, 50);
        btnNhanVien.TabIndex = 2;
        btnNhanVien.Text = "Nhân Viên";
        btnNhanVien.UseVisualStyleBackColor = true;
        // 
        // btnKhachhang
        // 
        btnKhachhang.Location = new System.Drawing.Point(3, 171);
        btnKhachhang.Name = "btnKhachhang";
        btnKhachhang.Size = new System.Drawing.Size(145, 50);
        btnKhachhang.TabIndex = 3;
        btnKhachhang.Text = "Khách Hàng";
        btnKhachhang.UseVisualStyleBackColor = true;
        // 
        // btnNhapHang
        // 
        btnNhapHang.Location = new System.Drawing.Point(3, 227);
        btnNhapHang.Name = "btnNhapHang";
        btnNhapHang.Size = new System.Drawing.Size(145, 50);
        btnNhapHang.TabIndex = 4;
        btnNhapHang.Text = "Nhập Hàng";
        btnNhapHang.UseVisualStyleBackColor = true;
        // 
        // btnNcc
        // 
        btnNcc.Location = new System.Drawing.Point(3, 283);
        btnNcc.Name = "btnNcc";
        btnNcc.Size = new System.Drawing.Size(145, 50);
        btnNcc.TabIndex = 5;
        btnNcc.Text = "Nhà Cung Cấp";
        btnNcc.UseVisualStyleBackColor = true;
        // 
        // btnCongViec
        // 
        btnCongViec.Location = new System.Drawing.Point(3, 339);
        btnCongViec.Name = "btnCongViec";
        btnCongViec.Size = new System.Drawing.Size(145, 50);
        btnCongViec.TabIndex = 6;
        btnCongViec.Text = "Công Việc";
        btnCongViec.UseVisualStyleBackColor = true;
        // 
        // btnTheLoai
        // 
        btnTheLoai.Location = new System.Drawing.Point(3, 395);
        btnTheLoai.Name = "btnTheLoai";
        btnTheLoai.Size = new System.Drawing.Size(145, 50);
        btnTheLoai.TabIndex = 7;
        btnTheLoai.Text = "Thể Loại";
        btnTheLoai.UseVisualStyleBackColor = true;
        // 
        // btnTyLe
        // 
        btnTyLe.Location = new System.Drawing.Point(3, 451);
        btnTyLe.Name = "btnTyLe";
        btnTyLe.Size = new System.Drawing.Size(145, 50);
        btnTyLe.TabIndex = 8;
        btnTyLe.Text = "Tỷ Lệ";
        btnTyLe.UseVisualStyleBackColor = true;
        // 
        // btnChatLieu
        // 
        btnChatLieu.Location = new System.Drawing.Point(3, 507);
        btnChatLieu.Name = "btnChatLieu";
        btnChatLieu.Size = new System.Drawing.Size(145, 50);
        btnChatLieu.TabIndex = 9;
        btnChatLieu.Text = "Chất Liệu";
        btnChatLieu.UseVisualStyleBackColor = true;
        // 
        // btnSeries
        // 
        btnSeries.Location = new System.Drawing.Point(3, 563);
        btnSeries.Name = "btnSeries";
        btnSeries.Size = new System.Drawing.Size(145, 50);
        btnSeries.TabIndex = 10;
        btnSeries.Text = "Series";
        btnSeries.UseVisualStyleBackColor = true;
        // 
        // btnDoiTuong
        // 
        btnDoiTuong.Location = new System.Drawing.Point(3, 619);
        btnDoiTuong.Name = "btnDoiTuong";
        btnDoiTuong.Size = new System.Drawing.Size(145, 50);
        btnDoiTuong.TabIndex = 11;
        btnDoiTuong.Text = "Đối Tượng";
        btnDoiTuong.UseVisualStyleBackColor = true;
        // 
        // btnNoiSX
        // 
        btnNoiSX.Location = new System.Drawing.Point(3, 675);
        btnNoiSX.Name = "btnNoiSX";
        btnNoiSX.Size = new System.Drawing.Size(145, 50);
        btnNoiSX.TabIndex = 12;
        btnNoiSX.Text = "Nơi Sản Xuất";
        btnNoiSX.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = System.Drawing.SystemColors.Control;
        pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
        pictureBox1.Location = new System.Drawing.Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(152, 152);
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
        label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(330, 19);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(168, 54);
        label1.TabIndex = 0;
        label1.Text = "<TEXT>";
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.DodgerBlue;
        panel3.Controls.Add(dateTimePicker1);
        panel3.Controls.Add(label4);
        panel3.Controls.Add(label3);
        panel3.Controls.Add(label2);
        panel3.Dock = System.Windows.Forms.DockStyle.Top;
        panel3.ForeColor = System.Drawing.Color.White;
        panel3.Location = new System.Drawing.Point(152, 86);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(1306, 66);
        panel3.TabIndex = 2;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new System.Drawing.Point(995, 0);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(311, 27);
        dateTimePicker1.TabIndex = 4;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(6, 34);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(139, 23);
        label4.TabIndex = 2;
        label4.Text = "Quyền: <text>";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(259, 3);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(141, 23);
        label3.TabIndex = 1;
        label3.Text = "Email: <text>";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(6, 3);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(210, 23);
        label2.TabIndex = 0;
        label2.Text = "Xin chào: <text>";
        // 
        // Form_Menu
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1458, 894);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Margin = new System.Windows.Forms.Padding(2);
        Text = "Menu";
        panel1.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.Button btnDoiTuong;
    private System.Windows.Forms.Button btnNoiSX;

    private System.Windows.Forms.Button btnSeries;

    private System.Windows.Forms.Button btnChatLieu;

    private System.Windows.Forms.Button btnTheLoai;
    private System.Windows.Forms.Button btnTyLe;

    private System.Windows.Forms.Button btnCongViec;

    private System.Windows.Forms.Button btnNhapHang;
    private System.Windows.Forms.Button btnNcc;

    private System.Windows.Forms.Button btnKhachhang;

    private System.Windows.Forms.Button btnNhanVien;

    private System.Windows.Forms.Button btnSanPham;

    private System.Windows.Forms.Button btnBanHang;

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}