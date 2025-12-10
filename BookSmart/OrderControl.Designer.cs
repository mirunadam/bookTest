using System.ComponentModel;

namespace BookSmart;

partial class OrderControl
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
        label1 = new System.Windows.Forms.Label();
        dataGridRentals = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridRentals).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(25, 16);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(245, 48);
        label1.TabIndex = 0;
        label1.Text = "All rental orders";
        label1.Click += label1_Click;
        // 
        // dataGridRentals
        // 
        dataGridRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridRentals.Location = new System.Drawing.Point(34, 60);
        dataGridRentals.Name = "dataGridRentals";
        dataGridRentals.RowHeadersWidth = 51;
        dataGridRentals.Size = new System.Drawing.Size(475, 427);
        dataGridRentals.TabIndex = 1;
        dataGridRentals.Text = "dataGridView1";
        // 
        // OrderControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(dataGridRentals);
        Controls.Add(label1);
        Size = new System.Drawing.Size(548, 518);
        ((System.ComponentModel.ISupportInitialize)dataGridRentals).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridRentals;

    private System.Windows.Forms.Label label1;

    #endregion
}