// Paste this code into your UserControl_SanPham.Designer.cs file
// THIS IS THE CORRECTED VERSION (Nov 8, 2025)

namespace FigureShop.POS 
{
    partial class UserControl_SanPham
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
            panelTop = new System.Windows.Forms.Panel();
            panelInputs = new System.Windows.Forms.Panel();
            tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            lblTen = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblBranch = new System.Windows.Forms.Label();
            cmbBranch = new System.Windows.Forms.ComboBox();
            lblCategory = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            lblPrice = new System.Windows.Forms.Label();
            numPrice = new System.Windows.Forms.NumericUpDown();
            lblQuantity = new System.Windows.Forms.Label();
            numQuantity = new System.Windows.Forms.NumericUpDown();
            lblSalePercent = new System.Windows.Forms.Label();
            numSalePercent = new System.Windows.Forms.NumericUpDown();
            lblSaleFrom = new System.Windows.Forms.Label();
            dtpSaleFrom = new System.Windows.Forms.DateTimePicker();
            lblSaleTo = new System.Windows.Forms.Label();
            dtpSaleTo = new System.Windows.Forms.DateTimePicker();
            lblDescription = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            panelImage = new System.Windows.Forms.Panel();
            picFigure = new System.Windows.Forms.PictureBox();
            btnBrowse = new System.Windows.Forms.Button();
            panelButtons = new System.Windows.Forms.Panel();
            btnBoQua = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            dgvFigures = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnTimKiem = new System.Windows.Forms.Button();
            panelTop.SuspendLayout();
            panelInputs.SuspendLayout();
            tlpInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalePercent).BeginInit();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFigure).BeginInit();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFigures).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panelInputs);
            panelTop.Controls.Add(panelButtons);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelTop.MinimumSize = new System.Drawing.Size(0, 400);
            panelTop.Name = "panelTop";
            panelTop.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            panelTop.Size = new System.Drawing.Size(1029, 417);
            panelTop.TabIndex = 0;
            // 
            // panelInputs
            // 
            panelInputs.Controls.Add(tlpInputs);
            panelInputs.Controls.Add(panelImage);
            panelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            panelInputs.Location = new System.Drawing.Point(11, 13);
            panelInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new System.Drawing.Size(870, 391);
            panelInputs.TabIndex = 0;
            // 
            // tlpInputs
            // 
            tlpInputs.ColumnCount = 4;
            tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpInputs.Controls.Add(lblTen, 0, 0);
            tlpInputs.Controls.Add(txtName, 1, 0);
            tlpInputs.Controls.Add(lblBranch, 0, 1);
            tlpInputs.Controls.Add(cmbBranch, 1, 1);
            tlpInputs.Controls.Add(lblCategory, 2, 1);
            tlpInputs.Controls.Add(cmbCategory, 3, 1);
            tlpInputs.Controls.Add(lblPrice, 0, 2);
            tlpInputs.Controls.Add(numPrice, 1, 2);
            tlpInputs.Controls.Add(lblQuantity, 2, 2);
            tlpInputs.Controls.Add(numQuantity, 3, 2);
            tlpInputs.Controls.Add(lblSalePercent, 0, 3);
            tlpInputs.Controls.Add(numSalePercent, 1, 3);
            tlpInputs.Controls.Add(lblSaleFrom, 0, 4);
            tlpInputs.Controls.Add(dtpSaleFrom, 1, 4);
            tlpInputs.Controls.Add(lblSaleTo, 2, 4);
            tlpInputs.Controls.Add(dtpSaleTo, 3, 4);
            tlpInputs.Controls.Add(lblDescription, 0, 5);
            tlpInputs.Controls.Add(txtDescription, 1, 5);
            tlpInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpInputs.Location = new System.Drawing.Point(194, 0);
            tlpInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlpInputs.Name = "tlpInputs";
            tlpInputs.RowCount = 7;
            tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpInputs.Size = new System.Drawing.Size(676, 391);
            tlpInputs.TabIndex = 1;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTen.Location = new System.Drawing.Point(3, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new System.Drawing.Size(97, 47);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên Figure:";
            lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            tlpInputs.SetColumnSpan(txtName, 3);
            txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            txtName.Location = new System.Drawing.Point(106, 8);
            txtName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(567, 27);
            txtName.TabIndex = 0;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            lblBranch.Location = new System.Drawing.Point(3, 47);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new System.Drawing.Size(97, 47);
            lblBranch.TabIndex = 2;
            lblBranch.Text = "Hãng (Branch):";
            lblBranch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBranch
            // 
            cmbBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new System.Drawing.Point(106, 55);
            cmbBranch.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new System.Drawing.Size(229, 28);
            cmbBranch.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            lblCategory.Location = new System.Drawing.Point(341, 47);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(97, 47);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Thế Loại:";
            lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(444, 55);
            cmbCategory.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(229, 28);
            cmbCategory.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            lblPrice.Location = new System.Drawing.Point(3, 94);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(97, 47);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Giá Bán:";
            lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numPrice
            // 
            numPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            numPrice.Location = new System.Drawing.Point(106, 102);
            numPrice.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            numPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new System.Drawing.Size(229, 27);
            numPrice.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            lblQuantity.Location = new System.Drawing.Point(341, 94);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(97, 47);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số Lượng:";
            lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numQuantity
            // 
            numQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            numQuantity.Location = new System.Drawing.Point(444, 102);
            numQuantity.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            numQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new System.Drawing.Size(229, 27);
            numQuantity.TabIndex = 4;
            // 
            // lblSalePercent
            // 
            lblSalePercent.AutoSize = true;
            lblSalePercent.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSalePercent.Location = new System.Drawing.Point(3, 141);
            lblSalePercent.Name = "lblSalePercent";
            lblSalePercent.Size = new System.Drawing.Size(97, 47);
            lblSalePercent.TabIndex = 10;
            lblSalePercent.Text = "Giảm Giá (%):";
            lblSalePercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numSalePercent
            // 
            numSalePercent.DecimalPlaces = 1;
            numSalePercent.Dock = System.Windows.Forms.DockStyle.Fill;
            numSalePercent.Location = new System.Drawing.Point(106, 149);
            numSalePercent.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            numSalePercent.Name = "numSalePercent";
            numSalePercent.Size = new System.Drawing.Size(229, 27);
            numSalePercent.TabIndex = 5;
            // 
            // lblSaleFrom
            // 
            lblSaleFrom.AutoSize = true;
            lblSaleFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSaleFrom.Location = new System.Drawing.Point(3, 188);
            lblSaleFrom.Name = "lblSaleFrom";
            lblSaleFrom.Size = new System.Drawing.Size(97, 47);
            lblSaleFrom.TabIndex = 12;
            lblSaleFrom.Text = "Giảm Từ Ngày:";
            lblSaleFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpSaleFrom
            // 
            dtpSaleFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            dtpSaleFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpSaleFrom.Location = new System.Drawing.Point(106, 196);
            dtpSaleFrom.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            dtpSaleFrom.Name = "dtpSaleFrom";
            dtpSaleFrom.Size = new System.Drawing.Size(229, 27);
            dtpSaleFrom.TabIndex = 6;
            // 
            // lblSaleTo
            // 
            lblSaleTo.AutoSize = true;
            lblSaleTo.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSaleTo.Location = new System.Drawing.Point(341, 188);
            lblSaleTo.Name = "lblSaleTo";
            lblSaleTo.Size = new System.Drawing.Size(97, 47);
            lblSaleTo.TabIndex = 14;
            lblSaleTo.Text = "Đến Ngày:";
            lblSaleTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpSaleTo
            // 
            dtpSaleTo.Dock = System.Windows.Forms.DockStyle.Fill;
            dtpSaleTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpSaleTo.Location = new System.Drawing.Point(444, 196);
            dtpSaleTo.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            dtpSaleTo.Name = "dtpSaleTo";
            dtpSaleTo.Size = new System.Drawing.Size(229, 27);
            dtpSaleTo.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDescription.Location = new System.Drawing.Point(3, 235);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            lblDescription.Size = new System.Drawing.Size(97, 136);
            lblDescription.TabIndex = 16;
            lblDescription.Text = "Mô Tả:";
            lblDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescription
            // 
            tlpInputs.SetColumnSpan(txtDescription, 3);
            txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDescription.Location = new System.Drawing.Point(106, 239);
            txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Size = new System.Drawing.Size(567, 128);
            txtDescription.TabIndex = 8;
            // 
            // panelImage
            // 
            panelImage.Controls.Add(picFigure);
            panelImage.Controls.Add(btnBrowse);
            panelImage.Dock = System.Windows.Forms.DockStyle.Left;
            panelImage.Location = new System.Drawing.Point(0, 0);
            panelImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelImage.Name = "panelImage";
            panelImage.Size = new System.Drawing.Size(194, 391);
            panelImage.TabIndex = 0;
            // 
            // picFigure
            // 
            picFigure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            picFigure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picFigure.Location = new System.Drawing.Point(3, 8);
            picFigure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picFigure.Name = "picFigure";
            picFigure.Size = new System.Drawing.Size(187, 336);
            picFigure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picFigure.TabIndex = 0;
            picFigure.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            btnBrowse.Location = new System.Drawing.Point(3, 345);
            btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(187, 43);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnBoQua);
            panelButtons.Controls.Add(btnLuu);
            panelButtons.Controls.Add(btnLamMoi);
            panelButtons.Controls.Add(btnXoa);
            panelButtons.Controls.Add(btnSua);
            panelButtons.Controls.Add(btnThem);
            panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            panelButtons.Location = new System.Drawing.Point(881, 13);
            panelButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new System.Drawing.Size(137, 391);
            panelButtons.TabIndex = 1;
            // 
            // btnBoQua
            // 
            btnBoQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            btnBoQua.Location = new System.Drawing.Point(6, 228);
            btnBoQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new System.Drawing.Size(126, 47);
            btnBoQua.TabIndex = 4;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            btnLuu.Location = new System.Drawing.Point(6, 173);
            btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(126, 47);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            btnLamMoi.Location = new System.Drawing.Point(6, 283);
            btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(126, 47);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            btnXoa.Location = new System.Drawing.Point(6, 118);
            btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(126, 47);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            btnSua.Location = new System.Drawing.Point(6, 63);
            btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(126, 47);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            btnThem.Location = new System.Drawing.Point(6, 8);
            btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(126, 47);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvFigures
            // 
            dgvFigures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvFigures.Location = new System.Drawing.Point(0, 457);
            dgvFigures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvFigures.Name = "dgvFigures";
            dgvFigures.RowHeadersWidth = 51;
            dgvFigures.Size = new System.Drawing.Size(1029, 343);
            dgvFigures.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnTimKiem);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 417);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1029, 40);
            panel1.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            txtTimKiem.Location = new System.Drawing.Point(229, 7);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(471, 27);
            txtTimKiem.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnTimKiem.Location = new System.Drawing.Point(743, 7);
            btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(87, 28);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // UserControl_SanPham
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgvFigures);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Size = new System.Drawing.Size(1029, 800);
            Load += UserControl_SanPham_Load;
            panelTop.ResumeLayout(false);
            panelInputs.ResumeLayout(false);
            tlpInputs.ResumeLayout(false);
            tlpInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalePercent).EndInit();
            panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFigure).EndInit();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFigures).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.DataGridView dgvFigures;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblSalePercent;
        private System.Windows.Forms.NumericUpDown numSalePercent;
        private System.Windows.Forms.Label lblSaleFrom;
        private System.Windows.Forms.DateTimePicker dtpSaleFrom;
        private System.Windows.Forms.Label lblSaleTo;
        private System.Windows.Forms.DateTimePicker dtpSaleTo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox picFigure;
        private System.Windows.Forms.Button btnBrowse;
    }
}