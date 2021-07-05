namespace MobileServiceCenter.FORMS
{
    partial class ForgotPassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAdminEmailID = new System.Windows.Forms.Label();
            this.TxtAdminEmailID = new System.Windows.Forms.TextBox();
            this.BTNSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblAdminEmailID);
            this.groupBox1.Controls.Add(this.TxtAdminEmailID);
            this.groupBox1.Controls.Add(this.BTNSave);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 299);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forgot Password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnLogin.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnLogin.Location = new System.Drawing.Point(211, 217);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(193, 44);
            this.BtnLogin.TabIndex = 28;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Enter your registered Email-ID";
            // 
            // LblAdminEmailID
            // 
            this.LblAdminEmailID.AutoSize = true;
            this.LblAdminEmailID.BackColor = System.Drawing.Color.Transparent;
            this.LblAdminEmailID.ForeColor = System.Drawing.Color.White;
            this.LblAdminEmailID.Location = new System.Drawing.Point(21, 110);
            this.LblAdminEmailID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdminEmailID.Name = "LblAdminEmailID";
            this.LblAdminEmailID.Size = new System.Drawing.Size(138, 29);
            this.LblAdminEmailID.TabIndex = 6;
            this.LblAdminEmailID.Text = "Email-ID :";
            // 
            // TxtAdminEmailID
            // 
            this.TxtAdminEmailID.Location = new System.Drawing.Point(26, 141);
            this.TxtAdminEmailID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdminEmailID.Name = "TxtAdminEmailID";
            this.TxtAdminEmailID.Size = new System.Drawing.Size(362, 36);
            this.TxtAdminEmailID.TabIndex = 7;
            // 
            // BTNSave
            // 
            this.BTNSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BTNSave.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.BTNSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNSave.Location = new System.Drawing.Point(14, 217);
            this.BTNSave.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(193, 44);
            this.BTNSave.TabIndex = 26;
            this.BTNSave.Text = "Submit";
            this.BTNSave.UseVisualStyleBackColor = false;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            this.BTNSave.MouseLeave += new System.EventHandler(this.BTNSave_MouseLeave);
            this.BTNSave.MouseHover += new System.EventHandler(this.BTNSave_MouseHover);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(439, 313);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPassword_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAdminEmailID;
        private System.Windows.Forms.TextBox TxtAdminEmailID;
        private System.Windows.Forms.Button BTNSave;
    }
}