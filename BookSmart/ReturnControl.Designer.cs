using System.ComponentModel;

namespace BookSmart;

partial class ReturnControl
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
        txtRentalId = new System.Windows.Forms.TextBox();
        btnReturn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.Location = new System.Drawing.Point(45, 17);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(249, 56);
        label1.TabIndex = 0;
        label1.Text = "Return Book";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(47, 100);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(99, 26);
        label2.TabIndex = 1;
        label2.Text = "Rental ID: ";
        // 
        // txtRentalId
        // 
        txtRentalId.Location = new System.Drawing.Point(131, 97);
        txtRentalId.Name = "txtRentalId";
        txtRentalId.Size = new System.Drawing.Size(117, 27);
        txtRentalId.TabIndex = 2;
        // 
        // btnReturn
        // 
        btnReturn.Location = new System.Drawing.Point(206, 161);
        btnReturn.Name = "btnReturn";
        btnReturn.Size = new System.Drawing.Size(87, 30);
        btnReturn.TabIndex = 3;
        btnReturn.Text = "button1";
        btnReturn.UseVisualStyleBackColor = true;
        // 
        // ReturnControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(btnReturn);
        Controls.Add(txtRentalId);
        Controls.Add(label2);
        Controls.Add(label1);
        Size = new System.Drawing.Size(578, 558);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtRentalId;
    private System.Windows.Forms.Button btnReturn;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}