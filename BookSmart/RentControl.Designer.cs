using System.ComponentModel;

namespace BookSmart;

partial class RentControl
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
        label2 = new System.Windows.Forms.Label();
        txtBookId = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        txtCustomer = new System.Windows.Forms.TextBox();
        btnRent = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.Location = new System.Drawing.Point(21, 18);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(531, 36);
        label1.TabIndex = 0;
        label1.Text = "Rent Book";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(26, 71);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(90, 36);
        label2.TabIndex = 1;
        label2.Text = "Book ID: \r\n";
        // 
        // txtBookId
        // 
        txtBookId.Location = new System.Drawing.Point(133, 68);
        txtBookId.Name = "txtBookId";
        txtBookId.Size = new System.Drawing.Size(143, 27);
        txtBookId.TabIndex = 2;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(26, 125);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(90, 29);
        label3.TabIndex = 3;
        label3.Text = "Customer: ";
        // 
        // txtCustomer
        // 
        txtCustomer.Location = new System.Drawing.Point(133, 122);
        txtCustomer.Name = "txtCustomer";
        txtCustomer.Size = new System.Drawing.Size(143, 27);
        txtCustomer.TabIndex = 4;
        // 
        // btnRent
        // 
        btnRent.Location = new System.Drawing.Point(261, 198);
        btnRent.Name = "btnRent";
        btnRent.Size = new System.Drawing.Size(108, 28);
        btnRent.TabIndex = 5;
        btnRent.Text = "Rent\r\n";
        btnRent.UseVisualStyleBackColor = true;
        // 
        // RentControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(btnRent);
        Controls.Add(txtCustomer);
        Controls.Add(label3);
        Controls.Add(txtBookId);
        Controls.Add(label2);
        Controls.Add(label1);
        Size = new System.Drawing.Size(596, 595);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCustomer;
    private System.Windows.Forms.Button btnRent;

    private System.Windows.Forms.TextBox txtBookId;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}