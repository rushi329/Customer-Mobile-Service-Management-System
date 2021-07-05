namespace MobileServiceCenter.FORMS
{
    partial class ucReports
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
            this.BtnUserReports = new System.Windows.Forms.Button();
            this.rvReports = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnCustReports = new System.Windows.Forms.Button();
            this.BtnCustMobReports = new System.Windows.Forms.Button();
            this.BtnCustMobSubReports = new System.Windows.Forms.Button();
            this.BtnCustMobReturnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUserReports
            // 
            this.BtnUserReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnUserReports.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.BtnUserReports.ForeColor = System.Drawing.Color.White;
            this.BtnUserReports.Location = new System.Drawing.Point(15, 14);
            this.BtnUserReports.Name = "BtnUserReports";
            this.BtnUserReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnUserReports.Size = new System.Drawing.Size(180, 75);
            this.BtnUserReports.TabIndex = 5;
            this.BtnUserReports.Text = "User\r\nReports";
            this.BtnUserReports.UseVisualStyleBackColor = false;
            this.BtnUserReports.Click += new System.EventHandler(this.BtnUserReports_Click);
            // 
            // rvReports
            // 
            this.rvReports.LocalReport.ReportEmbeddedResource = "MobileServiceCenter.Reports.rwUser.rdlc";
            this.rvReports.Location = new System.Drawing.Point(15, 121);
            this.rvReports.Name = "rvReports";
            this.rvReports.Size = new System.Drawing.Size(1495, 553);
            this.rvReports.TabIndex = 6;
            // 
            // BtnCustReports
            // 
            this.BtnCustReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnCustReports.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.BtnCustReports.ForeColor = System.Drawing.Color.White;
            this.BtnCustReports.Location = new System.Drawing.Point(201, 14);
            this.BtnCustReports.Name = "BtnCustReports";
            this.BtnCustReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCustReports.Size = new System.Drawing.Size(180, 75);
            this.BtnCustReports.TabIndex = 7;
            this.BtnCustReports.Text = "Customer Reports";
            this.BtnCustReports.UseVisualStyleBackColor = false;
            this.BtnCustReports.Click += new System.EventHandler(this.BtnCustReports_Click);
            // 
            // BtnCustMobReports
            // 
            this.BtnCustMobReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnCustMobReports.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.BtnCustMobReports.ForeColor = System.Drawing.Color.White;
            this.BtnCustMobReports.Location = new System.Drawing.Point(387, 14);
            this.BtnCustMobReports.Name = "BtnCustMobReports";
            this.BtnCustMobReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCustMobReports.Size = new System.Drawing.Size(180, 75);
            this.BtnCustMobReports.TabIndex = 8;
            this.BtnCustMobReports.Text = "Customer Mobile Reports";
            this.BtnCustMobReports.UseVisualStyleBackColor = false;
            this.BtnCustMobReports.Click += new System.EventHandler(this.BtnCustMobReports_Click);
            // 
            // BtnCustMobSubReports
            // 
            this.BtnCustMobSubReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnCustMobSubReports.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.BtnCustMobSubReports.ForeColor = System.Drawing.Color.White;
            this.BtnCustMobSubReports.Location = new System.Drawing.Point(573, 14);
            this.BtnCustMobSubReports.Name = "BtnCustMobSubReports";
            this.BtnCustMobSubReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCustMobSubReports.Size = new System.Drawing.Size(180, 75);
            this.BtnCustMobSubReports.TabIndex = 9;
            this.BtnCustMobSubReports.Text = "Mobile Submit Reports";
            this.BtnCustMobSubReports.UseVisualStyleBackColor = false;
            this.BtnCustMobSubReports.Click += new System.EventHandler(this.BtnCustMobSubReports_Click);
            // 
            // BtnCustMobReturnReports
            // 
            this.BtnCustMobReturnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnCustMobReturnReports.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.BtnCustMobReturnReports.ForeColor = System.Drawing.Color.White;
            this.BtnCustMobReturnReports.Location = new System.Drawing.Point(759, 14);
            this.BtnCustMobReturnReports.Name = "BtnCustMobReturnReports";
            this.BtnCustMobReturnReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCustMobReturnReports.Size = new System.Drawing.Size(180, 75);
            this.BtnCustMobReturnReports.TabIndex = 10;
            this.BtnCustMobReturnReports.Text = "Mobile Return Reports";
            this.BtnCustMobReturnReports.UseVisualStyleBackColor = false;
            this.BtnCustMobReturnReports.Click += new System.EventHandler(this.BtnCustMobReturnReports_Click);
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.BtnCustMobReturnReports);
            this.Controls.Add(this.BtnCustMobSubReports);
            this.Controls.Add(this.BtnCustMobReports);
            this.Controls.Add(this.BtnCustReports);
            this.Controls.Add(this.rvReports);
            this.Controls.Add(this.BtnUserReports);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(2, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1532, 688);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUserReports;
        private Microsoft.Reporting.WinForms.ReportViewer rvReports;
        private System.Windows.Forms.Button BtnCustReports;
        private System.Windows.Forms.Button BtnCustMobReports;
        private System.Windows.Forms.Button BtnCustMobSubReports;
        private System.Windows.Forms.Button BtnCustMobReturnReports;
    }
}
