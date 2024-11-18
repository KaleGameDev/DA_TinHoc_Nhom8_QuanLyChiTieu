using System;

namespace Expense_Management
{
    partial class Main_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddTransation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddNewTrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsChart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(48, 199);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1300, 650);
            this.panelMain.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHome,
            this.tsAddPlan,
            this.tsAddTransation,
            this.tsAddNewTrade,
            this.tsChart});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1382, 70);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsHome
            // 
            this.tsHome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsHome.ForeColor = System.Drawing.Color.White;
            this.tsHome.Image = global::Expense_Management.Properties.Resources.icons8_home_50;
            this.tsHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsHome.Name = "tsHome";
            this.tsHome.Size = new System.Drawing.Size(158, 70);
            this.tsHome.Text = "Trang Chủ";
            this.tsHome.Click += new System.EventHandler(this.tsHome_Click);
            // 
            // tsAddPlan
            // 
            this.tsAddPlan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsAddPlan.ForeColor = System.Drawing.Color.White;
            this.tsAddPlan.Image = global::Expense_Management.Properties.Resources.icons8_add_properties_50;
            this.tsAddPlan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddPlan.Name = "tsAddPlan";
            this.tsAddPlan.Size = new System.Drawing.Size(205, 70);
            this.tsAddPlan.Text = "Thêm Kế Hoạch";
            this.tsAddPlan.Click += new System.EventHandler(this.tsAddPlan_Click);
            // 
            // tsAddTransation
            // 
            this.tsAddTransation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsAddTransation.ForeColor = System.Drawing.Color.White;
            this.tsAddTransation.Image = global::Expense_Management.Properties.Resources.icons8_trade_50;
            this.tsAddTransation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddTransation.Name = "tsAddTransation";
            this.tsAddTransation.Size = new System.Drawing.Size(282, 70);
            this.tsAddTransation.Text = "Thêm Các Mục Giao Dịch";
            this.tsAddTransation.Click += new System.EventHandler(this.tsAddTransation_Click);
            // 
            // tsAddNewTrade
            // 
            this.tsAddNewTrade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsAddNewTrade.ForeColor = System.Drawing.Color.White;
            this.tsAddNewTrade.Image = global::Expense_Management.Properties.Resources.icons8_add_50;
            this.tsAddNewTrade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddNewTrade.Name = "tsAddNewTrade";
            this.tsAddNewTrade.Size = new System.Drawing.Size(229, 70);
            this.tsAddNewTrade.Text = "Tạo Giao Dịch Mới";
            this.tsAddNewTrade.Click += new System.EventHandler(this.tsAddExpenditure_Click);
            // 
            // tsChart
            // 
            this.tsChart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsChart.ForeColor = System.Drawing.Color.White;
            this.tsChart.Image = global::Expense_Management.Properties.Resources.icons8_chart_50;
            this.tsChart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsChart.Name = "tsChart";
            this.tsChart.Size = new System.Drawing.Size(223, 70);
            this.tsChart.Text = "Biểu Đồ Thống Kê";
            this.tsChart.Click += new System.EventHandler(this.tsChart_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 25;
            this.btnLogOut.BorderThickness = 1;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::Expense_Management.Properties.Resources.icons8_log_out_60;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogOut.Location = new System.Drawing.Point(1076, 93);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(261, 60);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.TextOffset = new System.Drawing.Point(20, 0);
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserName.Image = global::Expense_Management.Properties.Resources.icons8_sunflower_60;
            this.lbUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUserName.Location = new System.Drawing.Point(41, 93);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(500, 60);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUserName.Click += new System.EventHandler(this.userNamelb_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 903);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsAddPlan;
        private System.Windows.Forms.ToolStripMenuItem tsAddTransation;
        private System.Windows.Forms.ToolStripMenuItem tsAddNewTrade;
        private System.Windows.Forms.ToolStripMenuItem tsChart;
        private System.Windows.Forms.ToolStripMenuItem tsHome;
    }
}