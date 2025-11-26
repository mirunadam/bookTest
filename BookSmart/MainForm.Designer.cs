using System.ComponentModel;

namespace BookSmart;

partial class MainForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        panelTop = new System.Windows.Forms.Panel();
        lblClock = new System.Windows.Forms.Label();
        labelTitle = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        panelNav = new System.Windows.Forms.Panel();
        buttonConfig = new System.Windows.Forms.Button();
        buttonReturn = new System.Windows.Forms.Button();
        buttonRent = new System.Windows.Forms.Button();
        buttonOrder = new System.Windows.Forms.Button();
        buttonSearch = new System.Windows.Forms.Button();
        tabControl1 = new System.Windows.Forms.TabControl();
        tabPage1 = new System.Windows.Forms.TabPage();
        panelMainCustomer = new System.Windows.Forms.Panel();
        tabPage2 = new System.Windows.Forms.TabPage();
        panelAdmin = new System.Windows.Forms.Panel();
        txtSearch = new System.Windows.Forms.TextBox();
        panelTop.SuspendLayout();
        panelNav.SuspendLayout();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        panelMainCustomer.SuspendLayout();
        tabPage2.SuspendLayout();
        SuspendLayout();
        // 
        // panelTop
        // 
        panelTop.BackColor = System.Drawing.Color.RosyBrown;
        panelTop.Controls.Add(lblClock);
        panelTop.Controls.Add(labelTitle);
        panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        panelTop.Location = new System.Drawing.Point(0, 0);
        panelTop.Name = "panelTop";
        panelTop.Size = new System.Drawing.Size(982, 70);
        panelTop.TabIndex = 0;
        panelTop.Paint += panel1_Paint;
        // 
        // lblClock
        // 
        lblClock.Dock = System.Windows.Forms.DockStyle.Right;
        lblClock.Font = new System.Drawing.Font("Segoe UI", 14F);
        lblClock.Location = new System.Drawing.Point(593, 0);
        lblClock.Name = "lblClock";
        lblClock.Size = new System.Drawing.Size(389, 70);
        lblClock.TabIndex = 1;
        lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        lblClock.Click += labelClock_Click;
        // 
        // labelTitle
        // 
        labelTitle.BackColor = System.Drawing.Color.RosyBrown;
        labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
        labelTitle.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        labelTitle.Location = new System.Drawing.Point(0, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        labelTitle.Size = new System.Drawing.Size(200, 70);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "BookSmart";
        labelTitle.Click += label1_Click;
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Tick += timer1_Tick;
        // 
        // panelNav
        // 
        panelNav.BackColor = System.Drawing.Color.RosyBrown;
        panelNav.Controls.Add(buttonConfig);
        panelNav.Controls.Add(buttonReturn);
        panelNav.Controls.Add(buttonRent);
        panelNav.Controls.Add(buttonOrder);
        panelNav.Controls.Add(buttonSearch);
        panelNav.Dock = System.Windows.Forms.DockStyle.Left;
        panelNav.Location = new System.Drawing.Point(0, 70);
        panelNav.Name = "panelNav";
        panelNav.Size = new System.Drawing.Size(200, 483);
        panelNav.TabIndex = 1;
        // 
        // buttonConfig
        // 
        buttonConfig.BackColor = System.Drawing.Color.MistyRose;
        buttonConfig.Dock = System.Windows.Forms.DockStyle.Top;
        buttonConfig.Font = new System.Drawing.Font("Sitka Heading", 13.200001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        buttonConfig.Location = new System.Drawing.Point(0, 200);
        buttonConfig.Name = "buttonConfig";
        buttonConfig.Size = new System.Drawing.Size(200, 50);
        buttonConfig.TabIndex = 4;
        buttonConfig.Text = "Config";
        buttonConfig.UseVisualStyleBackColor = false;
        buttonConfig.Click += button4_Click;
        // 
        // buttonReturn
        // 
        buttonReturn.BackColor = System.Drawing.Color.MistyRose;
        buttonReturn.Dock = System.Windows.Forms.DockStyle.Top;
        buttonReturn.Font = new System.Drawing.Font("Sitka Heading", 13.200001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        buttonReturn.Location = new System.Drawing.Point(0, 150);
        buttonReturn.Name = "buttonReturn";
        buttonReturn.Size = new System.Drawing.Size(200, 50);
        buttonReturn.TabIndex = 3;
        buttonReturn.Text = "Return";
        buttonReturn.UseVisualStyleBackColor = false;
        // 
        // buttonRent
        // 
        buttonRent.BackColor = System.Drawing.Color.MistyRose;
        buttonRent.Dock = System.Windows.Forms.DockStyle.Top;
        buttonRent.Font = new System.Drawing.Font("Sitka Heading", 13.200001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        buttonRent.Location = new System.Drawing.Point(0, 100);
        buttonRent.Name = "buttonRent";
        buttonRent.Size = new System.Drawing.Size(200, 50);
        buttonRent.TabIndex = 2;
        buttonRent.Text = "Rent";
        buttonRent.UseVisualStyleBackColor = false;
        buttonRent.Click += button2_Click;
        // 
        // buttonOrder
        // 
        buttonOrder.BackColor = System.Drawing.Color.MistyRose;
        buttonOrder.Dock = System.Windows.Forms.DockStyle.Top;
        buttonOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
        buttonOrder.Font = new System.Drawing.Font("Sitka Heading", 13.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        buttonOrder.Location = new System.Drawing.Point(0, 50);
        buttonOrder.Name = "buttonOrder";
        buttonOrder.Size = new System.Drawing.Size(200, 50);
        buttonOrder.TabIndex = 1;
        buttonOrder.Text = "Order";
        buttonOrder.UseVisualStyleBackColor = false;
        buttonOrder.Click += button1_Click_1;
        // 
        // buttonSearch
        // 
        buttonSearch.BackColor = System.Drawing.Color.MistyRose;
        buttonSearch.Dock = System.Windows.Forms.DockStyle.Top;
        buttonSearch.Font = new System.Drawing.Font("Sitka Heading", 13.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        buttonSearch.Location = new System.Drawing.Point(0, 0);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new System.Drawing.Size(200, 50);
        buttonSearch.TabIndex = 0;
        buttonSearch.Text = "Search";
        buttonSearch.UseVisualStyleBackColor = false;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new System.Drawing.Point(204, 73);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(778, 480);
        tabControl1.TabIndex = 2;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(panelMainCustomer);
        tabPage1.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        tabPage1.Location = new System.Drawing.Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(3);
        tabPage1.Size = new System.Drawing.Size(770, 447);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "CustomerTab";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // panelMainCustomer
        // 
        panelMainCustomer.Controls.Add(txtSearch);
        panelMainCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
        panelMainCustomer.Location = new System.Drawing.Point(3, 3);
        panelMainCustomer.Name = "panelMainCustomer";
        panelMainCustomer.Size = new System.Drawing.Size(764, 441);
        panelMainCustomer.TabIndex = 0;
        panelMainCustomer.Paint += panelMain_Paint;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(panelAdmin);
        tabPage2.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        tabPage2.Location = new System.Drawing.Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new System.Windows.Forms.Padding(3);
        tabPage2.Size = new System.Drawing.Size(770, 447);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "AdminTab";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // panelAdmin
        // 
        panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
        panelAdmin.Location = new System.Drawing.Point(3, 3);
        panelAdmin.Name = "panelAdmin";
        panelAdmin.Size = new System.Drawing.Size(764, 441);
        panelAdmin.TabIndex = 0;
        // 
        // txtSearch
        // 
        txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
        txtSearch.Location = new System.Drawing.Point(0, 0);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(764, 26);
        txtSearch.TabIndex = 0;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(982, 553);
        Controls.Add(tabControl1);
        Controls.Add(panelNav);
        Controls.Add(panelTop);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "BookSmart";
        Load += MainForm_Load;
        panelTop.ResumeLayout(false);
        panelNav.ResumeLayout(false);
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        panelMainCustomer.ResumeLayout(false);
        panelMainCustomer.PerformLayout();
        tabPage2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txtSearch;

    private System.Windows.Forms.Panel panelAdmin;

    private System.Windows.Forms.Panel panelMainCustomer;

    private System.Windows.Forms.Button buttonConfig;

    private System.Windows.Forms.Button buttonRent;
    private System.Windows.Forms.Button buttonReturn;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;

    private System.Windows.Forms.Button buttonOrder;

    private System.Windows.Forms.Button buttonSearch;

    private System.Windows.Forms.Panel panelNav;

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Label lblClock;

    private System.Windows.Forms.Label labelTitle;

    private System.Windows.Forms.Panel panelTop;

    #endregion
}