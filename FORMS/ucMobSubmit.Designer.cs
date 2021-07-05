namespace MobileServiceCenter.FORMS
{
    partial class ucMobSubmit
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
            this.TXTMobProbDesc = new System.Windows.Forms.TextBox();
            this.LBLMobProbDesc = new System.Windows.Forms.Label();
            this.DTPMobSubDate = new System.Windows.Forms.DateTimePicker();
            this.LBLMobSubDate = new System.Windows.Forms.Label();
            this.CBSelectCustomer = new System.Windows.Forms.ComboBox();
            this.LBLSelectCustomer = new System.Windows.Forms.Label();
            this.CBSelectMobile = new System.Windows.Forms.ComboBox();
            this.LBLSelectMobile = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LBLCustDetails = new System.Windows.Forms.Label();
            this.DGVCustReg = new System.Windows.Forms.DataGridView();
            this.CBMobSelectEditDelete = new System.Windows.Forms.ComboBox();
            this.LBLMobSelectEditDelete = new System.Windows.Forms.Label();
            this.LBLMobIMEI2 = new System.Windows.Forms.Label();
            this.TXTMobIMEI2 = new System.Windows.Forms.TextBox();
            this.LBLMobIMEI1 = new System.Windows.Forms.Label();
            this.TXTMobIMEI1 = new System.Windows.Forms.TextBox();
            this.LBLMobVar = new System.Windows.Forms.Label();
            this.TXTMobVar = new System.Windows.Forms.TextBox();
            this.LBLMobCompany = new System.Windows.Forms.Label();
            this.TXTMobCompany = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReg)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTMobProbDesc
            // 
            this.TXTMobProbDesc.Location = new System.Drawing.Point(207, 334);
            this.TXTMobProbDesc.Multiline = true;
            this.TXTMobProbDesc.Name = "TXTMobProbDesc";
            this.TXTMobProbDesc.Size = new System.Drawing.Size(312, 106);
            this.TXTMobProbDesc.TabIndex = 5;
            // 
            // LBLMobProbDesc
            // 
            this.LBLMobProbDesc.ForeColor = System.Drawing.Color.White;
            this.LBLMobProbDesc.Location = new System.Drawing.Point(12, 337);
            this.LBLMobProbDesc.Name = "LBLMobProbDesc";
            this.LBLMobProbDesc.Size = new System.Drawing.Size(189, 22);
            this.LBLMobProbDesc.TabIndex = 34;
            this.LBLMobProbDesc.Text = "Problem Description :";
            // 
            // DTPMobSubDate
            // 
            this.DTPMobSubDate.CustomFormat = "dd-MMM-yyyy";
            this.DTPMobSubDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPMobSubDate.Location = new System.Drawing.Point(207, 299);
            this.DTPMobSubDate.Name = "DTPMobSubDate";
            this.DTPMobSubDate.Size = new System.Drawing.Size(312, 29);
            this.DTPMobSubDate.TabIndex = 4;
            // 
            // LBLMobSubDate
            // 
            this.LBLMobSubDate.ForeColor = System.Drawing.Color.White;
            this.LBLMobSubDate.Location = new System.Drawing.Point(81, 304);
            this.LBLMobSubDate.Name = "LBLMobSubDate";
            this.LBLMobSubDate.Size = new System.Drawing.Size(120, 22);
            this.LBLMobSubDate.TabIndex = 32;
            this.LBLMobSubDate.Text = "Submit Date :";
            // 
            // CBSelectCustomer
            // 
            this.CBSelectCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBSelectCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBSelectCustomer.FormattingEnabled = true;
            this.CBSelectCustomer.Location = new System.Drawing.Point(207, 87);
            this.CBSelectCustomer.Name = "CBSelectCustomer";
            this.CBSelectCustomer.Size = new System.Drawing.Size(312, 30);
            this.CBSelectCustomer.TabIndex = 2;
            this.CBSelectCustomer.SelectionChangeCommitted += new System.EventHandler(this.CBSelectCustomer_SelectionChangeCommitted);
            // 
            // LBLSelectCustomer
            // 
            this.LBLSelectCustomer.ForeColor = System.Drawing.Color.White;
            this.LBLSelectCustomer.Location = new System.Drawing.Point(53, 90);
            this.LBLSelectCustomer.Name = "LBLSelectCustomer";
            this.LBLSelectCustomer.Size = new System.Drawing.Size(148, 22);
            this.LBLSelectCustomer.TabIndex = 43;
            this.LBLSelectCustomer.Text = "Select Customer :";
            // 
            // CBSelectMobile
            // 
            this.CBSelectMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBSelectMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBSelectMobile.FormattingEnabled = true;
            this.CBSelectMobile.Location = new System.Drawing.Point(207, 123);
            this.CBSelectMobile.Name = "CBSelectMobile";
            this.CBSelectMobile.Size = new System.Drawing.Size(312, 30);
            this.CBSelectMobile.TabIndex = 3;
            this.CBSelectMobile.SelectionChangeCommitted += new System.EventHandler(this.CBSelectMobile_SelectionChangeCommitted);
            // 
            // LBLSelectMobile
            // 
            this.LBLSelectMobile.ForeColor = System.Drawing.Color.White;
            this.LBLSelectMobile.Location = new System.Drawing.Point(73, 126);
            this.LBLSelectMobile.Name = "LBLSelectMobile";
            this.LBLSelectMobile.Size = new System.Drawing.Size(128, 22);
            this.LBLSelectMobile.TabIndex = 45;
            this.LBLSelectMobile.Text = "Select Mobile :";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(273, 475);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 40);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(147, 475);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(120, 40);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(21, 475);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 40);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LBLCustDetails
            // 
            this.LBLCustDetails.AutoSize = true;
            this.LBLCustDetails.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCustDetails.ForeColor = System.Drawing.Color.White;
            this.LBLCustDetails.Location = new System.Drawing.Point(861, 5);
            this.LBLCustDetails.Name = "LBLCustDetails";
            this.LBLCustDetails.Size = new System.Drawing.Size(521, 51);
            this.LBLCustDetails.TabIndex = 60;
            this.LBLCustDetails.Text = "Customer Mobile Submit";
            // 
            // DGVCustReg
            // 
            this.DGVCustReg.AccessibleDescription = " ";
            this.DGVCustReg.AllowUserToAddRows = false;
            this.DGVCustReg.AllowUserToDeleteRows = false;
            this.DGVCustReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustReg.Location = new System.Drawing.Point(541, 49);
            this.DGVCustReg.Margin = new System.Windows.Forms.Padding(2);
            this.DGVCustReg.MultiSelect = false;
            this.DGVCustReg.Name = "DGVCustReg";
            this.DGVCustReg.ReadOnly = true;
            this.DGVCustReg.RowTemplate.Height = 24;
            this.DGVCustReg.Size = new System.Drawing.Size(978, 598);
            this.DGVCustReg.TabIndex = 59;
            // 
            // CBMobSelectEditDelete
            // 
            this.CBMobSelectEditDelete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBMobSelectEditDelete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBMobSelectEditDelete.FormattingEnabled = true;
            this.CBMobSelectEditDelete.Location = new System.Drawing.Point(207, 51);
            this.CBMobSelectEditDelete.Name = "CBMobSelectEditDelete";
            this.CBMobSelectEditDelete.Size = new System.Drawing.Size(312, 30);
            this.CBMobSelectEditDelete.TabIndex = 1;
            this.CBMobSelectEditDelete.SelectionChangeCommitted += new System.EventHandler(this.CBMobSelectEditDelete_SelectionChangeCommitted);
            // 
            // LBLMobSelectEditDelete
            // 
            this.LBLMobSelectEditDelete.ForeColor = System.Drawing.Color.White;
            this.LBLMobSelectEditDelete.Location = new System.Drawing.Point(17, 54);
            this.LBLMobSelectEditDelete.Name = "LBLMobSelectEditDelete";
            this.LBLMobSelectEditDelete.Size = new System.Drawing.Size(184, 22);
            this.LBLMobSelectEditDelete.TabIndex = 62;
            this.LBLMobSelectEditDelete.Text = "Select to Edit/Delete :";
            // 
            // LBLMobIMEI2
            // 
            this.LBLMobIMEI2.AutoSize = true;
            this.LBLMobIMEI2.ForeColor = System.Drawing.Color.White;
            this.LBLMobIMEI2.Location = new System.Drawing.Point(120, 267);
            this.LBLMobIMEI2.Name = "LBLMobIMEI2";
            this.LBLMobIMEI2.Size = new System.Drawing.Size(81, 22);
            this.LBLMobIMEI2.TabIndex = 72;
            this.LBLMobIMEI2.Text = "IMEI 2 :";
            // 
            // TXTMobIMEI2
            // 
            this.TXTMobIMEI2.Location = new System.Drawing.Point(207, 264);
            this.TXTMobIMEI2.Name = "TXTMobIMEI2";
            this.TXTMobIMEI2.ReadOnly = true;
            this.TXTMobIMEI2.Size = new System.Drawing.Size(312, 29);
            this.TXTMobIMEI2.TabIndex = 71;
            // 
            // LBLMobIMEI1
            // 
            this.LBLMobIMEI1.AutoSize = true;
            this.LBLMobIMEI1.ForeColor = System.Drawing.Color.White;
            this.LBLMobIMEI1.Location = new System.Drawing.Point(120, 232);
            this.LBLMobIMEI1.Name = "LBLMobIMEI1";
            this.LBLMobIMEI1.Size = new System.Drawing.Size(81, 22);
            this.LBLMobIMEI1.TabIndex = 70;
            this.LBLMobIMEI1.Text = "IMEI 1 :";
            // 
            // TXTMobIMEI1
            // 
            this.TXTMobIMEI1.Location = new System.Drawing.Point(207, 229);
            this.TXTMobIMEI1.Name = "TXTMobIMEI1";
            this.TXTMobIMEI1.ReadOnly = true;
            this.TXTMobIMEI1.Size = new System.Drawing.Size(312, 29);
            this.TXTMobIMEI1.TabIndex = 69;
            // 
            // LBLMobVar
            // 
            this.LBLMobVar.ForeColor = System.Drawing.Color.White;
            this.LBLMobVar.Location = new System.Drawing.Point(58, 197);
            this.LBLMobVar.Name = "LBLMobVar";
            this.LBLMobVar.Size = new System.Drawing.Size(143, 22);
            this.LBLMobVar.TabIndex = 68;
            this.LBLMobVar.Text = "Mobile Varient :";
            // 
            // TXTMobVar
            // 
            this.TXTMobVar.Location = new System.Drawing.Point(207, 194);
            this.TXTMobVar.Name = "TXTMobVar";
            this.TXTMobVar.ReadOnly = true;
            this.TXTMobVar.Size = new System.Drawing.Size(312, 29);
            this.TXTMobVar.TabIndex = 67;
            // 
            // LBLMobCompany
            // 
            this.LBLMobCompany.ForeColor = System.Drawing.Color.White;
            this.LBLMobCompany.Location = new System.Drawing.Point(46, 162);
            this.LBLMobCompany.Name = "LBLMobCompany";
            this.LBLMobCompany.Size = new System.Drawing.Size(155, 22);
            this.LBLMobCompany.TabIndex = 64;
            this.LBLMobCompany.Text = "Mobile Company :";
            // 
            // TXTMobCompany
            // 
            this.TXTMobCompany.Location = new System.Drawing.Point(207, 159);
            this.TXTMobCompany.Name = "TXTMobCompany";
            this.TXTMobCompany.ReadOnly = true;
            this.TXTMobCompany.Size = new System.Drawing.Size(312, 29);
            this.TXTMobCompany.TabIndex = 63;
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(399, 475);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 40);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ucMobSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LBLMobIMEI2);
            this.Controls.Add(this.TXTMobIMEI2);
            this.Controls.Add(this.LBLMobIMEI1);
            this.Controls.Add(this.TXTMobIMEI1);
            this.Controls.Add(this.LBLMobVar);
            this.Controls.Add(this.TXTMobVar);
            this.Controls.Add(this.LBLMobCompany);
            this.Controls.Add(this.TXTMobCompany);
            this.Controls.Add(this.CBMobSelectEditDelete);
            this.Controls.Add(this.LBLMobSelectEditDelete);
            this.Controls.Add(this.LBLCustDetails);
            this.Controls.Add(this.DGVCustReg);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CBSelectMobile);
            this.Controls.Add(this.LBLSelectMobile);
            this.Controls.Add(this.CBSelectCustomer);
            this.Controls.Add(this.LBLSelectCustomer);
            this.Controls.Add(this.TXTMobProbDesc);
            this.Controls.Add(this.LBLMobProbDesc);
            this.Controls.Add(this.DTPMobSubDate);
            this.Controls.Add(this.LBLMobSubDate);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Location = new System.Drawing.Point(2, 10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucMobSubmit";
            this.Size = new System.Drawing.Size(1532, 688);
            this.Load += new System.EventHandler(this.ucMobSubmit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTMobProbDesc;
        private System.Windows.Forms.Label LBLMobProbDesc;
        private System.Windows.Forms.DateTimePicker DTPMobSubDate;
        private System.Windows.Forms.Label LBLMobSubDate;
        private System.Windows.Forms.ComboBox CBSelectCustomer;
        private System.Windows.Forms.Label LBLSelectCustomer;
        private System.Windows.Forms.ComboBox CBSelectMobile;
        private System.Windows.Forms.Label LBLSelectMobile;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LBLCustDetails;
        private System.Windows.Forms.DataGridView DGVCustReg;
        private System.Windows.Forms.ComboBox CBMobSelectEditDelete;
        private System.Windows.Forms.Label LBLMobSelectEditDelete;
        private System.Windows.Forms.Label LBLMobIMEI2;
        private System.Windows.Forms.TextBox TXTMobIMEI2;
        private System.Windows.Forms.Label LBLMobIMEI1;
        private System.Windows.Forms.TextBox TXTMobIMEI1;
        private System.Windows.Forms.Label LBLMobVar;
        private System.Windows.Forms.TextBox TXTMobVar;
        private System.Windows.Forms.Label LBLMobCompany;
        private System.Windows.Forms.TextBox TXTMobCompany;
        private System.Windows.Forms.Button BtnClear;
    }
}
