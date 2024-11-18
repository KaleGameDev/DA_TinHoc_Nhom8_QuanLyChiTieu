namespace Expense_Management.Form_Menu
{
    partial class Add_Transaction_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransationName = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdChi = new System.Windows.Forms.RadioButton();
            this.btnAddTransation = new Guna.UI2.WinForms.Guna2Button();
            this.listThu = new System.Windows.Forms.ListBox();
            this.listChi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdThu = new System.Windows.Forms.RadioButton();
            this.lbUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(50, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập mục bạn muốn tạo";
            // 
            // txtTransationName
            // 
            this.txtTransationName.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTransationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransationName.DefaultText = "";
            this.txtTransationName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTransationName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTransationName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransationName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransationName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransationName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTransationName.ForeColor = System.Drawing.Color.Black;
            this.txtTransationName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransationName.Location = new System.Drawing.Point(386, 140);
            this.txtTransationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTransationName.Name = "txtTransationName";
            this.txtTransationName.PasswordChar = '\0';
            this.txtTransationName.PlaceholderText = "";
            this.txtTransationName.SelectedText = "";
            this.txtTransationName.Size = new System.Drawing.Size(246, 39);
            this.txtTransationName.TabIndex = 7;
            // 
            // rdChi
            // 
            this.rdChi.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdChi.Image = global::Expense_Management.Properties.Resources.icons8_minus_50;
            this.rdChi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdChi.Location = new System.Drawing.Point(406, 220);
            this.rdChi.Name = "rdChi";
            this.rdChi.Size = new System.Drawing.Size(164, 66);
            this.rdChi.TabIndex = 11;
            this.rdChi.TabStop = true;
            this.rdChi.Text = "Chi";
            this.rdChi.UseVisualStyleBackColor = true;
            // 
            // btnAddTransation
            // 
            this.btnAddTransation.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAddTransation.BorderRadius = 25;
            this.btnAddTransation.BorderThickness = 3;
            this.btnAddTransation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTransation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTransation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTransation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTransation.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTransation.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddTransation.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddTransation.Image = global::Expense_Management.Properties.Resources.icons8_add_60;
            this.btnAddTransation.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAddTransation.Location = new System.Drawing.Point(363, 368);
            this.btnAddTransation.Name = "btnAddTransation";
            this.btnAddTransation.Size = new System.Drawing.Size(250, 82);
            this.btnAddTransation.TabIndex = 12;
            this.btnAddTransation.Text = "Thêm Mục";
            this.btnAddTransation.Click += new System.EventHandler(this.btnAddTransation_Click);
            // 
            // listThu
            // 
            this.listThu.FormattingEnabled = true;
            this.listThu.ItemHeight = 16;
            this.listThu.Location = new System.Drawing.Point(743, 164);
            this.listThu.Name = "listThu";
            this.listThu.Size = new System.Drawing.Size(226, 356);
            this.listThu.TabIndex = 13;
            // 
            // listChi
            // 
            this.listChi.FormattingEnabled = true;
            this.listChi.ItemHeight = 16;
            this.listChi.Location = new System.Drawing.Point(1027, 164);
            this.listChi.Name = "listChi";
            this.listChi.Size = new System.Drawing.Size(226, 356);
            this.listChi.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(740, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Danh sách mục thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(1022, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Danh sách mục chi";
            // 
            // rdThu
            // 
            this.rdThu.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdThu.Image = global::Expense_Management.Properties.Resources.icons8_plus_50;
            this.rdThu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdThu.Location = new System.Drawing.Point(179, 220);
            this.rdThu.Name = "rdThu";
            this.rdThu.Size = new System.Drawing.Size(164, 66);
            this.rdThu.TabIndex = 10;
            this.rdThu.TabStop = true;
            this.rdThu.Text = "Thu";
            this.rdThu.UseVisualStyleBackColor = true;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserName.Image = global::Expense_Management.Properties.Resources.icons8_transaction_70;
            this.lbUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUserName.Location = new System.Drawing.Point(48, 30);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(487, 72);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "Mục Giao Dịch";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_Transaction_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listChi);
            this.Controls.Add(this.listThu);
            this.Controls.Add(this.btnAddTransation);
            this.Controls.Add(this.rdChi);
            this.Controls.Add(this.rdThu);
            this.Controls.Add(this.txtTransationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUserName);
            this.Name = "Add_Transaction_Menu";
            this.Size = new System.Drawing.Size(1300, 650);
            this.Load += new System.EventHandler(this.Add_Transaction_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTransationName;
        private System.Windows.Forms.RadioButton rdThu;
        private System.Windows.Forms.RadioButton rdChi;
        private Guna.UI2.WinForms.Guna2Button btnAddTransation;
        private System.Windows.Forms.ListBox listThu;
        private System.Windows.Forms.ListBox listChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
