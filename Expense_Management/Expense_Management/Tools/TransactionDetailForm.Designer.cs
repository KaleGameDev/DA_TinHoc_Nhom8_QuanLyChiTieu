namespace Expense_Management.Tools
{
    partial class TransactionDetailForm
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
            this.lbDate = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNameTrans = new System.Windows.Forms.Label();
            this.btnXoaTrans = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDate.Location = new System.Drawing.Point(142, 156);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(285, 58);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Ngày Tạo Giao Dịch";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAmount
            // 
            this.lbAmount.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAmount.Location = new System.Drawing.Point(140, 214);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(285, 58);
            this.lbAmount.TabIndex = 1;
            this.lbAmount.Text = "Số Tiền";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbType
            // 
            this.lbType.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbType.Location = new System.Drawing.Point(140, 272);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(285, 58);
            this.lbType.TabIndex = 2;
            this.lbType.Text = "Loại Giao Dịch";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNote
            // 
            this.lbNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNote.Location = new System.Drawing.Point(30, 330);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(285, 58);
            this.lbNote.TabIndex = 3;
            this.lbNote.Text = "Chú thích";
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(142, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chi Tiết Giao Dịch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 58);
            this.label2.TabIndex = 7;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNameTrans
            // 
            this.lbNameTrans.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameTrans.Location = new System.Drawing.Point(28, 98);
            this.lbNameTrans.Name = "lbNameTrans";
            this.lbNameTrans.Size = new System.Drawing.Size(526, 58);
            this.lbNameTrans.TabIndex = 8;
            this.lbNameTrans.Text = "Tên Giao Dịch";
            this.lbNameTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoaTrans
            // 
            this.btnXoaTrans.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTrans.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTrans.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTrans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTrans.FillColor = System.Drawing.Color.Transparent;
            this.btnXoaTrans.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaTrans.ForeColor = System.Drawing.Color.White;
            this.btnXoaTrans.Image = global::Expense_Management.Properties.Resources.icons8_trash_60;
            this.btnXoaTrans.ImageSize = new System.Drawing.Size(60, 60);
            this.btnXoaTrans.Location = new System.Drawing.Point(494, 368);
            this.btnXoaTrans.Name = "btnXoaTrans";
            this.btnXoaTrans.Size = new System.Drawing.Size(70, 70);
            this.btnXoaTrans.TabIndex = 9;
            this.btnXoaTrans.Click += new System.EventHandler(this.btnXoaTrans_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Expense_Management.Properties.Resources.icons8_money_60;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(494, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(60, 60);
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Expense_Management.Properties.Resources.icons8_money_60;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(28, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(60, 60);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // TransactionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.btnXoaTrans);
            this.Controls.Add(this.lbNameTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbDate);
            this.Name = "TransactionDetailForm";
            this.Text = "TransactionDetailForm";
            this.Load += new System.EventHandler(this.TransactionDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNameTrans;
        private Guna.UI2.WinForms.Guna2Button btnXoaTrans;
    }
}