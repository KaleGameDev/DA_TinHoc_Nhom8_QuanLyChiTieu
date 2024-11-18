namespace Expense_Management.Form_Menu
{
    partial class Home_Menu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbChoosePlan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chartHomeMenu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbNhanXet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartHomeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChoosePlan
            // 
            this.cbChoosePlan.BackColor = System.Drawing.Color.Transparent;
            this.cbChoosePlan.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cbChoosePlan.BorderThickness = 2;
            this.cbChoosePlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChoosePlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoosePlan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChoosePlan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChoosePlan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChoosePlan.ForeColor = System.Drawing.Color.Black;
            this.cbChoosePlan.ItemHeight = 30;
            this.cbChoosePlan.Location = new System.Drawing.Point(984, 55);
            this.cbChoosePlan.Name = "cbChoosePlan";
            this.cbChoosePlan.Size = new System.Drawing.Size(266, 36);
            this.cbChoosePlan.TabIndex = 5;
            this.cbChoosePlan.SelectedIndexChanged += new System.EventHandler(this.cbChoosePlan_SelectedIndexChanged_1);
            // 
            // chartHomeMenu
            // 
            this.chartHomeMenu.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chartHomeMenu.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartHomeMenu.Legends.Add(legend5);
            this.chartHomeMenu.Location = new System.Drawing.Point(439, 127);
            this.chartHomeMenu.Name = "chartHomeMenu";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartHomeMenu.Series.Add(series5);
            this.chartHomeMenu.Size = new System.Drawing.Size(761, 432);
            this.chartHomeMenu.TabIndex = 6;
            this.chartHomeMenu.Text = "chart1";
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalExpense.Location = new System.Drawing.Point(130, 340);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(344, 44);
            this.lblTotalExpense.TabIndex = 8;
            this.lblTotalExpense.Text = "Tổng Chi";
            this.lblTotalExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalIncome.Location = new System.Drawing.Point(130, 231);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(344, 44);
            this.lblTotalIncome.TabIndex = 7;
            this.lblTotalIncome.Text = "Tổng Thu";
            this.lblTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Expense_Management.Properties.Resources.icons8_decrease_70;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(31, 298);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(70, 70);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox2.TabIndex = 10;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Expense_Management.Properties.Resources.icons8_increase_70;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(31, 188);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(70, 70);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserName.Image = global::Expense_Management.Properties.Resources.icons8_plan_70;
            this.lbUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUserName.Location = new System.Drawing.Point(44, 25);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(623, 86);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "     Các Kế Hoạch Bạn Đã Tạo Đây";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNhanXet
            // 
            this.lbNhanXet.AutoSize = true;
            this.lbNhanXet.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNhanXet.Location = new System.Drawing.Point(346, 579);
            this.lbNhanXet.Name = "lbNhanXet";
            this.lbNhanXet.Size = new System.Drawing.Size(494, 27);
            this.lbNhanXet.TabIndex = 11;
            this.lbNhanXet.Text = "Nhận xét kế hoạch chi tiêu hiện tại của bạn";
            // 
            // Home_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNhanXet);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblTotalExpense);
            this.Controls.Add(this.lblTotalIncome);
            this.Controls.Add(this.chartHomeMenu);
            this.Controls.Add(this.cbChoosePlan);
            this.Controls.Add(this.lbUserName);
            this.Name = "Home_Menu";
            this.Size = new System.Drawing.Size(1300, 650);
            this.Load += new System.EventHandler(this.Home_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartHomeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private Guna.UI2.WinForms.Guna2ComboBox cbChoosePlan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHomeMenu;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTotalExpense;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label lbNhanXet;
    }
}
