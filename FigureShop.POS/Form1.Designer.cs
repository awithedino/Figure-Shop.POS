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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        dgvShoppingCart = new System.Windows.Forms.DataGridView();
        panel1 = new System.Windows.Forms.Panel();
        btnAddSelectedToCart = new System.Windows.Forms.Button();
        btnSearch = new System.Windows.Forms.Button();
        txtSearch = new System.Windows.Forms.TextBox();
        dgvFigures = new System.Windows.Forms.DataGridView();
        lblTotalPrice = new System.Windows.Forms.Label();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).BeginInit();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvFigures).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
        tableLayoutPanel1.Controls.Add(dgvShoppingCart, 1, 1);
        tableLayoutPanel1.Controls.Add(panel1, 0, 0);
        tableLayoutPanel1.Controls.Add(dgvFigures, 0, 1);
        tableLayoutPanel1.Controls.Add(lblTotalPrice, 1, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1239, 716);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // dgvShoppingCart
        // 
        dgvShoppingCart.ColumnHeadersHeight = 29;
        dgvShoppingCart.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvShoppingCart.Location = new System.Drawing.Point(877, 81);
        dgvShoppingCart.Margin = new System.Windows.Forms.Padding(10);
        dgvShoppingCart.Name = "dgvShoppingCart";
        dgvShoppingCart.RowHeadersWidth = 51;
        dgvShoppingCart.Size = new System.Drawing.Size(352, 552);
        dgvShoppingCart.TabIndex = 4;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnAddSelectedToCart);
        panel1.Controls.Add(btnSearch);
        panel1.Controls.Add(txtSearch);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(861, 65);
        panel1.TabIndex = 1;
        // 
        // btnAddSelectedToCart
        // 
        btnAddSelectedToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right));
        btnAddSelectedToCart.AutoSize = true;
        btnAddSelectedToCart.Location = new System.Drawing.Point(783, 19);
        btnAddSelectedToCart.Name = "btnAddSelectedToCart";
        btnAddSelectedToCart.Size = new System.Drawing.Size(63, 30);
        btnAddSelectedToCart.TabIndex = 2;
        btnAddSelectedToCart.Text = "Add";
        btnAddSelectedToCart.UseVisualStyleBackColor = true;
        btnAddSelectedToCart.Click += btnAddSelectedToCart_Click;
        // 
        // btnSearch
        // 
        btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right));
        btnSearch.AutoSize = true;
        btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btnSearch.Location = new System.Drawing.Point(705, 19);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new System.Drawing.Size(63, 30);
        btnSearch.TabIndex = 1;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // txtSearch
        // 
        txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtSearch.Location = new System.Drawing.Point(15, 19);
        txtSearch.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(677, 27);
        txtSearch.TabIndex = 0;
        // 
        // dgvFigures
        // 
        dgvFigures.ColumnHeadersHeight = 29;
        dgvFigures.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvFigures.Location = new System.Drawing.Point(10, 81);
        dgvFigures.Margin = new System.Windows.Forms.Padding(10);
        dgvFigures.Name = "dgvFigures";
        dgvFigures.RowHeadersWidth = 51;
        dgvFigures.Size = new System.Drawing.Size(847, 552);
        dgvFigures.TabIndex = 2;
        // 
        // lblTotalPrice
        // 
        lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right));
        lblTotalPrice.Location = new System.Drawing.Point(1138, 643);
        lblTotalPrice.Name = "lblTotalPrice";
        lblTotalPrice.Size = new System.Drawing.Size(98, 73);
        lblTotalPrice.TabIndex = 5;
        lblTotalPrice.Text = "Total: $0.00";
        lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1239, 716);
        Controls.Add(tableLayoutPanel1);
        Text = "Form1";
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvFigures).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblTotalPrice;

    private System.Windows.Forms.DataGridView dgvShoppingCart;

    private System.Windows.Forms.DataGridView dgvFigures;

    private System.Windows.Forms.Button btnAddSelectedToCart;

    private System.Windows.Forms.Button btnSearch;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TextBox txtSearch;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}