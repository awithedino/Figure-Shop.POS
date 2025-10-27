namespace FigureShop.POS;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        splitContainerMain = new System.Windows.Forms.SplitContainer();
        dgvProducts = new System.Windows.Forms.DataGridView();
        panel1 = new System.Windows.Forms.Panel();
        cboCategoriesFilter = new System.Windows.Forms.ComboBox();
        btnSearch = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        txtSearch = new System.Windows.Forms.TextBox();
        groupBoxDetails = new System.Windows.Forms.GroupBox();
        txtPrice = new System.Windows.Forms.TextBox();
        txtDescription = new System.Windows.Forms.TextBox();
        txtProductName = new System.Windows.Forms.TextBox();
        cboCategoryDetail = new System.Windows.Forms.ComboBox();
        txtProductID = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        btnBrowseImage = new System.Windows.Forms.Button();
        picProductImage = new System.Windows.Forms.PictureBox();
        groupBoxFunctions = new System.Windows.Forms.GroupBox();
        btnCancel = new System.Windows.Forms.Button();
        btnDelete = new System.Windows.Forms.Button();
        btnSave = new System.Windows.Forms.Button();
        btnAddNew = new System.Windows.Forms.Button();
        txtStock = new System.Windows.Forms.TextBox();
        txtImagePath = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
        splitContainerMain.Panel1.SuspendLayout();
        splitContainerMain.Panel2.SuspendLayout();
        splitContainerMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        panel1.SuspendLayout();
        groupBoxDetails.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
        groupBoxFunctions.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1177, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStripMain";
        // 
        // splitContainerMain
        // 
        splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainerMain.Location = new System.Drawing.Point(0, 24);
        splitContainerMain.Name = "splitContainerMain";
        // 
        // splitContainerMain.Panel1
        // 
        splitContainerMain.Panel1.Controls.Add(dgvProducts);
        splitContainerMain.Panel1.Controls.Add(panel1);
        // 
        // splitContainerMain.Panel2
        // 
        splitContainerMain.Panel2.Controls.Add(groupBoxDetails);
        splitContainerMain.Panel2.Controls.Add(groupBoxFunctions);
        splitContainerMain.Size = new System.Drawing.Size(1177, 696);
        splitContainerMain.SplitterDistance = 406;
        splitContainerMain.TabIndex = 1;
        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToDeleteRows = false;
        dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.ColumnHeadersHeight = 34;
        dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvProducts.Location = new System.Drawing.Point(0, 214);
        dgvProducts.MultiSelect = false;
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersWidth = 62;
        dgvProducts.Size = new System.Drawing.Size(404, 480);
        dgvProducts.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.Controls.Add(cboCategoriesFilter);
        panel1.Controls.Add(btnSearch);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(txtSearch);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(404, 214);
        panel1.TabIndex = 0;
        // 
        // cboCategoriesFilter
        // 
        cboCategoriesFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboCategoriesFilter.FormattingEnabled = true;
        cboCategoriesFilter.Location = new System.Drawing.Point(148, 31);
        cboCategoriesFilter.Name = "cboCategoriesFilter";
        cboCategoriesFilter.Size = new System.Drawing.Size(263, 33);
        cboCategoriesFilter.TabIndex = 4;
        // 
        // btnSearch
        // 
        btnSearch.Location = new System.Drawing.Point(336, 99);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new System.Drawing.Size(75, 34);
        btnSearch.TabIndex = 3;
        btnSearch.Text = "Tìm";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(11, 102);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 2;
        label2.Text = "Tìm kiếm:";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(11, 34);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(148, 23);
        label1.TabIndex = 1;
        label1.Text = "Loại sản phẩm:";
        // 
        // txtSearch
        // 
        txtSearch.Location = new System.Drawing.Point(148, 99);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(168, 31);
        txtSearch.TabIndex = 0;
        txtSearch.TextChanged += textBox1_TextChanged;
        // 
        // groupBoxDetails
        // 
        groupBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupBoxDetails.Controls.Add(txtImagePath);
        groupBoxDetails.Controls.Add(txtStock);
        groupBoxDetails.Controls.Add(txtPrice);
        groupBoxDetails.Controls.Add(txtDescription);
        groupBoxDetails.Controls.Add(txtProductName);
        groupBoxDetails.Controls.Add(cboCategoryDetail);
        groupBoxDetails.Controls.Add(txtProductID);
        groupBoxDetails.Controls.Add(label9);
        groupBoxDetails.Controls.Add(label8);
        groupBoxDetails.Controls.Add(label7);
        groupBoxDetails.Controls.Add(label6);
        groupBoxDetails.Controls.Add(label5);
        groupBoxDetails.Controls.Add(label4);
        groupBoxDetails.Controls.Add(label3);
        groupBoxDetails.Controls.Add(btnBrowseImage);
        groupBoxDetails.Controls.Add(picProductImage);
        groupBoxDetails.Location = new System.Drawing.Point(0, 0);
        groupBoxDetails.Name = "groupBoxDetails";
        groupBoxDetails.Size = new System.Drawing.Size(765, 507);
        groupBoxDetails.TabIndex = 1;
        groupBoxDetails.TabStop = false;
        groupBoxDetails.Text = "Thông tin chi tiết sản phẩm";
        // 
        // txtPrice
        // 
        txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtPrice.Location = new System.Drawing.Point(180, 354);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new System.Drawing.Size(312, 31);
        txtPrice.TabIndex = 13;
        txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // txtDescription
        // 
        txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtDescription.Location = new System.Drawing.Point(180, 188);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtDescription.Size = new System.Drawing.Size(312, 126);
        txtDescription.TabIndex = 12;
        // 
        // txtProductName
        // 
        txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtProductName.Location = new System.Drawing.Point(180, 83);
        txtProductName.Name = "txtProductName";
        txtProductName.Size = new System.Drawing.Size(315, 31);
        txtProductName.TabIndex = 11;
        // 
        // cboCategoryDetail
        // 
        cboCategoryDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cboCategoryDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboCategoryDetail.FormattingEnabled = true;
        cboCategoryDetail.Location = new System.Drawing.Point(180, 131);
        cboCategoryDetail.Name = "cboCategoryDetail";
        cboCategoryDetail.Size = new System.Drawing.Size(312, 33);
        cboCategoryDetail.TabIndex = 10;
        cboCategoryDetail.SelectedIndexChanged += cboCategoryDetail_SelectedIndexChanged;
        // 
        // txtProductID
        // 
        txtProductID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtProductID.Location = new System.Drawing.Point(180, 34);
        txtProductID.Name = "txtProductID";
        txtProductID.ReadOnly = true;
        txtProductID.Size = new System.Drawing.Size(312, 31);
        txtProductID.TabIndex = 9;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(74, 454);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(66, 31);
        label9.TabIndex = 8;
        label9.Text = "Ảnh:";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(74, 405);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(100, 23);
        label8.TabIndex = 7;
        label8.Text = "Tồn kho:";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(74, 357);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(100, 23);
        label7.TabIndex = 6;
        label7.Text = "Giá bán:";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(74, 191);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(100, 23);
        label6.TabIndex = 5;
        label6.Text = "Mô tả:";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(74, 134);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(78, 38);
        label5.TabIndex = 4;
        label5.Text = "Loại SP:";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(74, 86);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 3;
        label4.Text = "Tên SP:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(86, 34);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(66, 30);
        label3.TabIndex = 2;
        label3.Text = "Mã SP:";
        // 
        // btnBrowseImage
        // 
        btnBrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBrowseImage.Location = new System.Drawing.Point(522, 224);
        btnBrowseImage.Name = "btnBrowseImage";
        btnBrowseImage.Size = new System.Drawing.Size(175, 34);
        btnBrowseImage.TabIndex = 1;
        btnBrowseImage.Text = "Chọn ảnh";
        btnBrowseImage.UseVisualStyleBackColor = true;
        // 
        // picProductImage
        // 
        picProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        picProductImage.Location = new System.Drawing.Point(522, 30);
        picProductImage.Name = "picProductImage";
        picProductImage.Size = new System.Drawing.Size(175, 175);
        picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picProductImage.TabIndex = 0;
        picProductImage.TabStop = false;
        // 
        // groupBoxFunctions
        // 
        groupBoxFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupBoxFunctions.Controls.Add(btnCancel);
        groupBoxFunctions.Controls.Add(btnDelete);
        groupBoxFunctions.Controls.Add(btnSave);
        groupBoxFunctions.Controls.Add(btnAddNew);
        groupBoxFunctions.Location = new System.Drawing.Point(0, 513);
        groupBoxFunctions.Name = "groupBoxFunctions";
        groupBoxFunctions.Size = new System.Drawing.Size(765, 182);
        groupBoxFunctions.TabIndex = 0;
        groupBoxFunctions.TabStop = false;
        groupBoxFunctions.Text = "Chức năng";
        // 
        // btnCancel
        // 
        btnCancel.Enabled = false;
        btnCancel.Location = new System.Drawing.Point(604, 83);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(102, 36);
        btnCancel.TabIndex = 3;
        btnCancel.Text = "&Hủy";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.Enabled = false;
        btnDelete.Location = new System.Drawing.Point(433, 83);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new System.Drawing.Size(102, 36);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "&Xóa";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Location = new System.Drawing.Point(270, 83);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(97, 36);
        btnSave.TabIndex = 1;
        btnSave.Text = "&Lưu";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // btnAddNew
        // 
        btnAddNew.Location = new System.Drawing.Point(112, 83);
        btnAddNew.Name = "btnAddNew";
        btnAddNew.Size = new System.Drawing.Size(97, 36);
        btnAddNew.TabIndex = 0;
        btnAddNew.Text = "&Thêm mới";
        btnAddNew.UseVisualStyleBackColor = true;
        // 
        // txtStock
        // 
        txtStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtStock.Location = new System.Drawing.Point(180, 402);
        txtStock.Name = "txtStock";
        txtStock.Size = new System.Drawing.Size(312, 31);
        txtStock.TabIndex = 14;
        txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // txtImagePath
        // 
        txtImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtImagePath.Location = new System.Drawing.Point(180, 451);
        txtImagePath.Name = "txtImagePath";
        txtImagePath.ReadOnly = true;
        txtImagePath.Size = new System.Drawing.Size(312, 31);
        txtImagePath.TabIndex = 15;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1177, 720);
        Controls.Add(splitContainerMain);
        Controls.Add(menuStrip1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(4);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Figure & Gundam Shop Management";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        splitContainerMain.Panel1.ResumeLayout(false);
        splitContainerMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
        splitContainerMain.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        groupBoxDetails.ResumeLayout(false);
        groupBoxDetails.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
        groupBoxFunctions.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtPrice;

    private System.Windows.Forms.TextBox txtImagePath;

    private System.Windows.Forms.TextBox txtStock;

    private System.Windows.Forms.TextBox txtDescription;

    private System.Windows.Forms.TextBox txtProductName;

    private System.Windows.Forms.ComboBox cboCategoryDetail;

    private System.Windows.Forms.TextBox txtProductID;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Button btnBrowseImage;

    private System.Windows.Forms.PictureBox picProductImage;

    private System.Windows.Forms.GroupBox groupBoxDetails;

    private System.Windows.Forms.Button btnAddNew;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnCancel;

    private System.Windows.Forms.GroupBox groupBoxFunctions;

    private System.Windows.Forms.ComboBox cboCategoriesFilter;

    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSearch;

    private System.Windows.Forms.DataGridView dgvProducts;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.SplitContainer splitContainerMain;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}