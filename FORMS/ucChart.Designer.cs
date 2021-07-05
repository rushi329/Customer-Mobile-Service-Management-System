namespace MobileServiceCenter.FORMS
{
    partial class ucChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CBSearchBy = new System.Windows.Forms.ComboBox();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnTotalCust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
            // 
            // chartData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartData.Legends.Add(legend1);
            this.chartData.Location = new System.Drawing.Point(41, 116);
            this.chartData.Margin = new System.Windows.Forms.Padding(4);
            this.chartData.Name = "chartData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DATA";
            this.chartData.Series.Add(series1);
            this.chartData.Size = new System.Drawing.Size(1373, 543);
            this.chartData.TabIndex = 0;
            this.chartData.Text = "chart1";
            this.chartData.Click += new System.EventHandler(this.chartData_Click);
            // 
            // CBSearchBy
            // 
            this.CBSearchBy.FormattingEnabled = true;
            this.CBSearchBy.Items.AddRange(new object[] {
            "--SELECT--",
            "Monthly",
            "Yearly"});
            this.CBSearchBy.Location = new System.Drawing.Point(156, 42);
            this.CBSearchBy.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.CBSearchBy.Name = "CBSearchBy";
            this.CBSearchBy.Size = new System.Drawing.Size(271, 30);
            this.CBSearchBy.TabIndex = 3;
            this.CBSearchBy.Text = "--SELECT--";
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.ForeColor = System.Drawing.Color.White;
            this.LblSearchBy.Location = new System.Drawing.Point(74, 45);
            this.LblSearchBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(98, 22);
            this.LblSearchBy.TabIndex = 2;
            this.LblSearchBy.Text = "Search by :";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnSave.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(464, 19);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(180, 75);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Total Bill";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnTotalCust
            // 
            this.BtnTotalCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnTotalCust.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.BtnTotalCust.ForeColor = System.Drawing.Color.White;
            this.BtnTotalCust.Location = new System.Drawing.Point(668, 19);
            this.BtnTotalCust.Name = "BtnTotalCust";
            this.BtnTotalCust.Size = new System.Drawing.Size(180, 75);
            this.BtnTotalCust.TabIndex = 10;
            this.BtnTotalCust.Text = "Total Customers";
            this.BtnTotalCust.UseVisualStyleBackColor = false;
            this.BtnTotalCust.Click += new System.EventHandler(this.BtnTotalCust_Click);
            // 
            // ucChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.BtnTotalCust);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CBSearchBy);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.chartData);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(2, 10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucChart";
            this.Size = new System.Drawing.Size(1532, 688);
            this.Load += new System.EventHandler(this.ucChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.ComboBox CBSearchBy;
        private System.Windows.Forms.Label LblSearchBy;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnTotalCust;
    }
}
