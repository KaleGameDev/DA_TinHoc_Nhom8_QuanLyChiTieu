namespace Expense_Management.Form_Menu
{
    partial class Add_Plan_Menu
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
            this.txtAddPlanName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.listPlans = new System.Windows.Forms.ListBox();
            this.btnAddNewPlan = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddPlanName
            // 
            this.txtAddPlanName.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtAddPlanName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPlanName.DefaultText = "";
            this.txtAddPlanName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddPlanName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddPlanName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPlanName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPlanName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPlanName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAddPlanName.ForeColor = System.Drawing.Color.Black;
            this.txtAddPlanName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPlanName.Location = new System.Drawing.Point(414, 131);
            this.txtAddPlanName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddPlanName.Name = "txtAddPlanName";
            this.txtAddPlanName.PasswordChar = '\0';
            this.txtAddPlanName.PlaceholderText = "";
            this.txtAddPlanName.SelectedText = "";
            this.txtAddPlanName.Size = new System.Drawing.Size(229, 33);
            this.txtAddPlanName.TabIndex = 4;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtAddDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddDescription.DefaultText = "";
            this.txtAddDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddDescription.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddDescription.ForeColor = System.Drawing.Color.Black;
            this.txtAddDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddDescription.Location = new System.Drawing.Point(414, 215);
            this.txtAddDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.PasswordChar = '\0';
            this.txtAddDescription.PlaceholderText = "";
            this.txtAddDescription.SelectedText = "";
            this.txtAddDescription.Size = new System.Drawing.Size(229, 176);
            this.txtAddDescription.TabIndex = 5;
            // 
            // listPlans
            // 
            this.listPlans.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listPlans.FormattingEnabled = true;
            this.listPlans.HorizontalScrollbar = true;
            this.listPlans.IntegralHeight = false;
            this.listPlans.ItemHeight = 32;
            this.listPlans.Location = new System.Drawing.Point(730, 131);
            this.listPlans.Name = "listPlans";
            this.listPlans.Size = new System.Drawing.Size(483, 334);
            this.listPlans.TabIndex = 7;
            this.listPlans.SelectedIndexChanged += new System.EventHandler(this.listPlans_SelectedIndexChanged);
            // 
            // btnAddNewPlan
            // 
            this.btnAddNewPlan.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNewPlan.BorderRadius = 25;
            this.btnAddNewPlan.BorderThickness = 3;
            this.btnAddNewPlan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPlan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPlan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPlan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPlan.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewPlan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddNewPlan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNewPlan.Image = global::Expense_Management.Properties.Resources.icons8_add_60;
            this.btnAddNewPlan.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAddNewPlan.Location = new System.Drawing.Point(443, 427);
            this.btnAddNewPlan.Name = "btnAddNewPlan";
            this.btnAddNewPlan.Size = new System.Drawing.Size(200, 75);
            this.btnAddNewPlan.TabIndex = 6;
            this.btnAddNewPlan.Text = "Thêm";
            this.btnAddNewPlan.Click += new System.EventHandler(this.btnAddNewPlan_Click_2);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Image = global::Expense_Management.Properties.Resources.icons8_circle_70;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(31, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thêm mô tả chi tiết";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Image = global::Expense_Management.Properties.Resources.icons8_circle_70;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(31, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Kế Hoạch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserName.Image = global::Expense_Management.Properties.Resources.icons88_plan_70;
            this.lbUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUserName.Location = new System.Drawing.Point(28, 16);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(531, 75);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Thêm Kế Hoạch";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_Plan_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listPlans);
            this.Controls.Add(this.btnAddNewPlan);
            this.Controls.Add(this.txtAddDescription);
            this.Controls.Add(this.txtAddPlanName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUserName);
            this.Name = "Add_Plan_Menu";
            this.Size = new System.Drawing.Size(1300, 650);
            this.Load += new System.EventHandler(this.Add_Plan_Menu_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPlanName;
        private Guna.UI2.WinForms.Guna2TextBox txtAddDescription;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPlan;
        private System.Windows.Forms.ListBox listPlans;
    }
}
