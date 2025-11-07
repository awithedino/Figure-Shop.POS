// Paste this code into your UserControl_SanPham.Designer.cs file

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
            this.dgvFigures = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSalePercent = new System.Windows.Forms.Label();
            this.numSalePercent = new System.Windows.Forms.NumericUpDown();
            this.lblSaleFrom = new System.Windows.Forms.Label();
            this.dtpSaleFrom = new System.Windows.Forms.DateTimePicker();
            this.lblSaleTo = new System.Windows.Forms.Label();
            this.dtpSaleTo = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.picFigure = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFigures)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.tlpInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalePercent)).BeginInit();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFigures
            // 
            this.dgvFigures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFigures.Location = new System.Drawing.Point(0, 300);
            this.dgvFigures.Name = "dgvFigures";
            this.dgvFigures.Size = new System.Drawing.Size(900, 300);
            this.dgvFigures.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelInputs);
            this.panelTop.Controls.Add(this.panelButtons);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.MinimumSize = new System.Drawing.Size(0, 300);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10);
            this.panelTop.Size = new System.Drawing.Size(900, 300);
            this.panelTop.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnTimKiem);
            this.panelButtons.Controls.Add(this.btnLamMoi);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(770, 10);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(120, 280);
            this.panelButtons.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(5, 129);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 35);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(5, 170);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(5, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(5, 47);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(5, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.tlpInputs);
            this.panelInputs.Controls.Add(this.panelImage);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputs.Location = new System.Drawing.Point(10, 10);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(760, 280);
            this.panelInputs.TabIndex = 0;
            // 
            // tlpInputs
            // 
            this.tlpInputs.ColumnCount = 4;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInputs.Controls.Add(this.lblTen, 0, 0);
            this.tlpInputs.Controls.Add(this.txtName, 1, 0);
            this.tlpInputs.Controls.Add(this.lblBranch, 0, 1);
            this.tlpInputs.Controls.Add(this.cmbBranch, 1, 1);
            this.tlpInputs.Controls.Add(this.lblCategory, 2, 1);
            this.tlpInputs.Controls.Add(this.cmbCategory, 3, 1);
            this.tlpInputs.Controls.Add(this.lblPrice, 0, 2);
            this.tlpInputs.Controls.Add(this.numPrice, 1, 2);
            this.tlpInputs.Controls.Add(this.lblQuantity, 2, 2);
            this.tlpInputs.Controls.Add(this.numQuantity, 3, 2);
            this.tlpInputs.Controls.Add(this.lblSalePercent, 0, 3);
            this.tlpInputs.Controls.Add(this.numSalePercent, 1, 3);
            this.tlpInputs.Controls.Add(this.lblSaleFrom, 0, 4);
            this.tlpInputs.Controls.Add(this.dtpSaleFrom, 1, 4);
            this.tlpInputs.Controls.Add(this.lblSaleTo, 2, 4);
            this.tlpInputs.Controls.Add(this.dtpSaleTo, 3, 4);
            this.tlpInputs.Controls.Add(this.lblDescription, 0, 5);
            this.tlpInputs.Controls.Add(this.txtDescription, 1, 5);
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInputs.Location = new System.Drawing.Point(170, 0);
            this.tlpInputs.Name = "tlpInputs";
            this.tlpInputs.RowCount = 6;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Size = new System.Drawing.Size(590, 280);
            this.tlpInputs.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTen.Location = new System.Drawing.Point(3, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(84, 35);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên Figure:";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.tlpInputs.SetColumnSpan(this.txtName, 3);
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(93, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(494, 23);
            this.txtName.TabIndex = 0;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBranch.Location = new System.Drawing.Point(3, 35);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(84, 35);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "Hãng (Branch):";
            this.lblBranch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBranch
            // 
            this.cmbBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(93, 41);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(199, 23);
            this.cmbBranch.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Location = new System.Drawing.Point(298, 35);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 35);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Thế Loại:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(388, 41);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(199, 23);
            this.cmbCategory.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(3, 70);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(84, 35);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Giá Bán:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numPrice
            // 
            this.numPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPrice.Location = new System.Drawing.Point(93, 76);
            this.numPrice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.numPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(199, 23);
            this.numPrice.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantity.Location = new System.Drawing.Point(298, 70);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(84, 35);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Số Lượng:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numQuantity
            // 
            this.numQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numQuantity.Location = new System.Drawing.Point(388, 76);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.numQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(199, 23);
            this.numQuantity.TabIndex = 4;
            // 
            // lblSalePercent
            // 
            this.lblSalePercent.AutoSize = true;
            this.lblSalePercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSalePercent.Location = new System.Drawing.Point(3, 105);
            this.lblSalePercent.Name = "lblSalePercent";
            this.lblSalePercent.Size = new System.Drawing.Size(84, 35);
            this.lblSalePercent.TabIndex = 10;
            this.lblSalePercent.Text = "Giảm Giá (%):";
            this.lblSalePercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numSalePercent
            // 
            this.numSalePercent.DecimalPlaces = 1;
            this.numSalePercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSalePercent.Location = new System.Drawing.Point(93, 111);
            this.numSalePercent.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.numSalePercent.Name = "numSalePercent";
            this.numSalePercent.Size = new System.Drawing.Size(199, 23);
            this.numSalePercent.TabIndex = 5;
            // 
            // lblSaleFrom
            // 
            this.lblSaleFrom.AutoSize = true;
            this.lblSaleFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaleFrom.Location = new System.Drawing.Point(3, 140);
            this.lblSaleFrom.Name = "lblSaleFrom";
            this.lblSaleFrom.Size = new System.Drawing.Size(84, 35);
            this.lblSaleFrom.TabIndex = 12;
            this.lblSaleFrom.Text = "Giảm Từ Ngày:";
            this.lblSaleFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpSaleFrom
            // 
            this.dtpSaleFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpSaleFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleFrom.Location = new System.Drawing.Point(93, 146);
            this.dtpSaleFrom.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.dtpSaleFrom.Name = "dtpSaleFrom";
            this.dtpSaleFrom.Size = new System.Drawing.Size(199, 23);
            this.dtpSaleFrom.TabIndex = 6;
            // 
            // lblSaleTo
            // 
            this.lblSaleTo.AutoSize = true;
            this.lblSaleTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaleTo.Location = new System.Drawing.Point(298, 140);
            this.lblSaleTo.Name = "lblSaleTo";
            this.lblSaleTo.Size = new System.Drawing.Size(84, 35);
            this.lblSaleTo.TabIndex = 14;
            this.lblSaleTo.Text = "Đến Ngày:";
            this.lblSaleTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpSaleTo
            // 
            this.dtpSaleTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpSaleTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleTo.Location = new System.Drawing.Point(388, 146);
            this.dtpSaleTo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.dtpSaleTo.Name = "dtpSaleTo";
            this.dtpSaleTo.Size = new System.Drawing.Size(199, 23);
            this.dtpSaleTo.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(3, 175);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDescription.Size = new System.Drawing.Size(84, 105);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Mô Tả:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescription
            // 
            this.tlpInputs.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(93, 178);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(494, 99);
            this.txtDescription.TabIndex = 8;
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.picFigure);
            this.panelImage.Controls.Add(this.btnBrowse);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(170, 280);
            this.panelImage.TabIndex = 0;
            // 
            // picFigure
            // 
            this.picFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFigure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFigure.Location = new System.Drawing.Point(3, 6);
            this.picFigure.Name = "picFigure";
            this.picFigure.Size = new System.Drawing.Size(164, 233);
            this.picFigure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFigure.TabIndex = 0;
            this.picFigure.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(3, 245);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(164, 32);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // UserControl_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFigures);
            this.Controls.Add(this.panelTop);
            this.Name = "UserControl_SanPham";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFigures)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelInputs.ResumeLayout(false);
            this.tlpInputs.ResumeLayout(false);
            this.tlpInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalePercent)).EndInit();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFigure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFigures;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
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