namespace Expense_Management.Form_Menu
{
    partial class Chart_Menu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbUserName = new System.Windows.Forms.Label();
            this.summaryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.summaryChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserName.Image = global::Expense_Management.Properties.Resources.icons8_chart_70;
            this.lbUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUserName.Location = new System.Drawing.Point(20, 16);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(343, 69);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "Biểu đồ";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // summaryChart
            // 
            chartArea2.Name = "ChartArea1";
            this.summaryChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.summaryChart.Legends.Add(legend2);
            this.summaryChart.Location = new System.Drawing.Point(106, 112);
            this.summaryChart.Name = "summaryChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.summaryChart.Series.Add(series2);
            this.summaryChart.Size = new System.Drawing.Size(1041, 501);
            this.summaryChart.TabIndex = 5;
            this.summaryChart.Text = "chart1";
            // 
            // Chart_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.summaryChart);
            this.Controls.Add(this.lbUserName);
            this.Name = "Chart_Menu";
            this.Size = new System.Drawing.Size(1300, 650);
            this.Load += new System.EventHandler(this.Chart_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.summaryChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.DataVisualization.Charting.Chart summaryChart;
    }
}
