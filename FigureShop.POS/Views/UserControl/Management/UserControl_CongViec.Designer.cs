using System.ComponentModel;

namespace FigureShop.POS.Views.UserControl.Management;

partial class UserControl_CongViec
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
        groupBox2 = new System.Windows.Forms.GroupBox();
        txtTenCV = new System.Windows.Forms.TextBox();
        txtMaCV = new System.Windows.Forms.TextBox();
        groupBox5 = new System.Windows.Forms.GroupBox();
        btnExcel = new System.Windows.Forms.Button();
        btnReload = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        btnBoQua = new System.Windows.Forms.Button();
        btnSua = new System.Windows.Forms.Button();
        btnLuu = new System.Windows.Forms.Button();
        btnThem = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        splitter1 = new System.Windows.Forms.Splitter();
        groupBox3 = new System.Windows.Forms.GroupBox();
        dgvCongViec = new System.Windows.Forms.DataGridView();
        groupBox6 = new System.Windows.Forms.GroupBox();
        btnTimKiem = new System.Windows.Forms.Button();
        txtTimKiem = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCongViec).BeginInit();
        groupBox6.SuspendLayout();
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
        label1.Text = "Công việc";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txtTenCV);
        groupBox2.Controls.Add(txtMaCV);
        groupBox2.Controls.Add(groupBox5);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(splitter1);
        groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
        groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox2.Location = new System.Drawing.Point(0, 105);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(263, 628);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Thông tin công việc";
        // 
        // txtTenCV
        // 
        txtTenCV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTenCV.Location = new System.Drawing.Point(89, 71);
        txtTenCV.Name = "txtTenCV";
        txtTenCV.Size = new System.Drawing.Size(149, 27);
        txtTenCV.TabIndex = 11;
        // 
        // txtMaCV
        // 
        txtMaCV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMaCV.Location = new System.Drawing.Point(89, 37);
        txtMaCV.Name = "txtMaCV";
        txtMaCV.Size = new System.Drawing.Size(149, 27);
        txtMaCV.TabIndex = 12;
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
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(6, 74);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(77, 25);
        label3.TabIndex = 2;
        label3.Text = "Tên CV:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(6, 40);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(77, 25);
        label2.TabIndex = 1;
        label2.Text = "Mã CV:";
        // 
        // splitter1
        // 
        splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitter1.Dock = System.Windows.Forms.DockStyle.Right;
        splitter1.Location = new System.Drawing.Point(250, 26);
        splitter1.Name = "splitter1";
        splitter1.Size = new System.Drawing.Size(10, 599);
        splitter1.TabIndex = 0;
        splitter1.TabStop = false;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(dgvCongViec);
        groupBox3.Controls.Add(groupBox6);
        groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox3.Location = new System.Drawing.Point(263, 105);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(758, 628);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Tìm kiếm công việc";
        // 
        // dgvCongViec
        // 
        dgvCongViec.ColumnHeadersHeight = 29;
        dgvCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvCongViec.Location = new System.Drawing.Point(3, 128);
        dgvCongViec.Name = "dgvCongViec";
        dgvCongViec.RowHeadersWidth = 51;
        dgvCongViec.Size = new System.Drawing.Size(752, 497);
        dgvCongViec.TabIndex = 1;
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(btnTimKiem);
        groupBox6.Controls.Add(txtTimKiem);
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
        btnTimKiem.Location = new System.Drawing.Point(560, 43);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(96, 39);
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
        label9.Location = new System.Drawing.Point(52, 42);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(195, 31);
        label9.TabIndex = 0;
        label9.Text = "Tên/Mã công việc:";
        // 
        // UserControl_CongViec
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Margin = new System.Windows.Forms.Padding(4);
        Size = new System.Drawing.Size(1021, 733);
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCongViec).EndInit();
        groupBox6.ResumeLayout(false);
        groupBox6.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txtTenCV;
    private System.Windows.Forms.TextBox txtMaCV;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.DataGridView dgvCongViec;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.Button btnExcel;
    private System.Windows.Forms.Button btnReload;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnBoQua;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}
