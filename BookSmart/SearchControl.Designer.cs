using System.ComponentModel;

namespace BookSmart;

partial class SearchControl
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
        txtSearch = new System.Windows.Forms.TextBox();
        btnSearch = new System.Windows.Forms.Button();
        dataGridBooks = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridBooks).BeginInit();
        SuspendLayout();
        // 
        // txtSearch
        // 
        txtSearch.Location = new System.Drawing.Point(3, 18);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(584, 27);
        txtSearch.TabIndex = 0;
        // 
        // btnSearch
        // 
        btnSearch.Location = new System.Drawing.Point(593, 15);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new System.Drawing.Size(91, 33);
        btnSearch.TabIndex = 1;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // dataGridBooks
        // 
        dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridBooks.Location = new System.Drawing.Point(11, 61);
        dataGridBooks.Name = "dataGridBooks";
        dataGridBooks.RowHeadersWidth = 51;
        dataGridBooks.Size = new System.Drawing.Size(660, 523);
        dataGridBooks.TabIndex = 2;
        dataGridBooks.Text = "dataGridView1";
        // 
        // SearchControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(dataGridBooks);
        Controls.Add(btnSearch);
        Controls.Add(txtSearch);
        Size = new System.Drawing.Size(690, 598);
        ((System.ComponentModel.ISupportInitialize)dataGridBooks).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView dataGridBooks;

    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnSearch;

    #endregion
}