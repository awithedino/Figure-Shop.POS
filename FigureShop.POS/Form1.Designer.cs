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
        dgvFigures = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvFigures).BeginInit();
        SuspendLayout();
        // 
        // dgvFigures
        // 
        dgvFigures.ColumnHeadersHeight = 29;
        dgvFigures.Location = new System.Drawing.Point(144, 109);
        dgvFigures.Name = "dgvFigures";
        dgvFigures.RowHeadersWidth = 51;
        dgvFigures.Size = new System.Drawing.Size(469, 297);
        dgvFigures.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(870, 582);
        Controls.Add(dgvFigures);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dgvFigures).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgvFigures;

    #endregion
}