namespace MobileServiceCenter.FORMS
{
    partial class ucRepairStatus
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
            this.CBMobileStatus = new System.Windows.Forms.ComboBox();
            this.LBLMobileStatus = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TXTMobProbDesc = new System.Windows.Forms.TextBox();
            this.LBLMobProbDesc = new System.Windows.Forms.Label();
            this.LBLMobIMEI2 = new System.Windows.Forms.Label();
            this.TXTMobIMEI2 = new System.Windows.Forms.TextBox();
            this.LBLMobIMEI1 = new System.Windows.Forms.Label();
            this.TXTMobIMEI1 = new System.Windows.Forms.TextBox();
            this.LBLMobVar = new System.Windows.Forms.Label();
            this.TXTMobVar = new System.Windows.Forms.TextBox();
            this.LBLMobCompany = new System.Windows.Forms.Label();
            this.TXTMobCompany = new System.Windows.Forms.TextBox();
            this.CBMobSubmit = new System.Windows.Forms.ComboBox();
            this.LblMobSubmit = new System.Windows.Forms.Label();
            this.CBMobSelectEditDelete = new System.Windows.Forms.ComboBox();
            this.LBLMobSelectEditDelete = new System.Windows.Forms.Label();
            this.LBLCustDetails = new System.Windows.Forms.Label();
            this.DGVCustReg = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CBSelectMobile = new System.Windows.Forms.ComboBox();
            this.LBLSelectMobile = new System.Windows.Forms.Label();
            this.CBSelectCustomer = new System.Windows.Forms.ComboBox();
            this.LBLSelectCustomer = new System.Windows.Forms.Label();
            this.LBLTotalBillAmt = new System.Windows.Forms.Label();
            this.TXTTotalBillAmt = new System.Windows.Forms.TextBox();
            this.TXTMobRepairDesc = new System.Windows.Forms.TextBox();
            this.LBLMobRepairDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReg)).BeginInit();
            this.SuspendLayout();
            // 
            // CBMobileStatus
            // 
            this.CBMobileStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBMobileStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBMobileStatus.FormattingEnabled = true;
            this.CBMobileStatus.Items.AddRange(new object[] {
            "--SELECT--",
            "Repair not possible",
            "Work in progress or Pending"});
            this.CBMobileStatus.Location = new System.Drawing.Point(213, 446);
            this.CBMobileStatus.Name = "CBMobileStatus";
            this.CBMobileStatus.Size = new System.Drawing.Size(312, 30);
            this.CBMobileStatus.TabIndex = 115;
            // 
            // LBLMobileStatus
            // 
            this.LBLMobileStatus.AutoSize = true;
            this.LBLMobileStatus.ForeColor = System.Drawing.Color.White;
            this.LBLMobileStatus.Location = new System.Drawing.Point(78, 449);
            this.LBLMobileStatus.Name = "LBLMobileStatus";
            this.LBLMobileStatus.Size = new System.Drawing.Size(129, 22);
            this.LBLMobileStatus.TabIndex = 116;
            this.LBLMobileStatus.Text = "Mobile Status :";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(405, 640);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 40);
            this.BtnClear.TabIndex = 95;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TXTMobProbDesc
            // 
            this.TXTMobProbDesc.Location = new System.Drawing.Point(213, 334);
            this.TXTMobProbDesc.Multiline = true;
            this.TXTMobProbDesc.Name = "TXTMobProbDesc";
            this.TXTMobProbDesc.ReadOnly = true;
            this.TXTMobProbDesc.Size = new System.Drawing.Size(312, 106);
            this.TXTMobProbDesc.TabIndex = 114;
            // 
            // LBLMobProbDesc
            // 
            this.LBLMobProbDesc.AutoSize = true;
            this.LBLMobProbDesc.ForeColor = System.Drawing.Color.White;
            this.LBLMobProbDesc.Location = new System.Drawing.Point(20, 335);
            this.LBLMobProbDesc.Name = "LBLMobProbDesc";
            this.LBLMobProbDesc.Size = new System.Drawing.Size(187, 22);
            this.LBLMobProbDesc.TabIndex = 113;
            this.LBLMobProbDesc.Text = "Problem Description :";
            // 
            // LBLMobIMEI2
            // 
            this.LBLMobIMEI2.AutoSize = true;
            this.LBLMobIMEI2.ForeColor = System.Drawing.Color.White;
            this.LBLMobIMEI2.Location = new System.Drawing.Point(126, 266);
            this.LBLMobIMEI2.Name = "LBLMobIMEI2";
            this.LBLMobIMEI2.Size = new System.Drawing.Size(81, 22);
            this.LBLMobIMEI2.TabIndex = 112;
            this.LBLMobIMEI2.Text = "IMEI 2 :";
            // 
            // TXTMobIMEI2
            // 
            this.TXTMobIMEI2.Location = new System.Drawing.Point(213, 263);
            this.TXTMobIMEI2.Name = "TXTMobIMEI2";
            this.TXTMobIMEI2.ReadOnly = true;
            this.TXTMobIMEI2.Size = new System.Drawing.Size(312, 29);
            this.TXTMobIMEI2.TabIndex = 111;
            // 
            // LBLMobIMEI1
            // 
            this.LBLMobIMEI1.AutoSize = true;
            this.LBLMobIMEI1.ForeColor = System.Drawing.Color.White;
            this.LBLMobIMEI1.Location = new System.Drawing.Point(126, 232);
            this.LBLMobIMEI1.Name = "LBLMobIMEI1";
            this.LBLMobIMEI1.Size = new System.Drawing.Size(81, 22);
            this.LBLMobIMEI1.TabIndex = 110;
            this.LBLMobIMEI1.Text = "IMEI 1 :";
            // 
            // TXTMobIMEI1
            // 
            this.TXTMobIMEI1.Location = new System.Drawing.Point(213, 229);
            this.TXTMobIMEI1.Name = "TXTMobIMEI1";
            this.TXTMobIMEI1.ReadOnly = true;
            this.TXTMobIMEI1.Size = new System.Drawing.Size(312, 29);
            this.TXTMobIMEI1.TabIndex = 109;
            // 
            // LBLMobVar
            // 
            this.LBLMobVar.AutoSize = true;
            this.LBLMobVar.ForeColor = System.Drawing.Color.White;
            this.LBLMobVar.Location = new System.Drawing.Point(65, 196);
            this.LBLMobVar.Name = "LBLMobVar";
            this.LBLMobVar.Size = new System.Drawing.Size(142, 22);
            this.LBLMobVar.TabIndex = 108;
            this.LBLMobVar.Text = "Mobile Varient :";
            // 
            // TXTMobVar
            // 
            this.TXTMobVar.Location = new System.Drawing.Point(213, 193);
            this.TXTMobVar.Name = "TXTMobVar";
            this.TXTMobVar.ReadOnly = true;
            this.TXTMobVar.Size = new System.Drawing.Size(312, 29);
            this.TXTMobVar.TabIndex = 107;
            // 
            // LBLMobCompany
            // 
            this.LBLMobCompany.AutoSize = true;
            this.LBLMobCompany.ForeColor = System.Drawing.Color.White;
            this.LBLMobCompany.Location = new System.Drawing.Point(53, 161);
            this.LBLMobCompany.Name = "LBLMobCompany";
            this.LBLMobCompany.Size = new System.Drawing.Size(154, 22);
            this.LBLMobCompany.TabIndex = 106;
            this.LBLMobCompany.Text = "Mobile Company :";
            // 
            // TXTMobCompany
            // 
            this.TXTMobCompany.Location = new System.Drawing.Point(213, 158);
            this.TXTMobCompany.Name = "TXTMobCompany";
            this.TXTMobCompany.ReadOnly = true;
            this.TXTMobCompany.Size = new System.Drawing.Size(312, 29);
            this.TXTMobCompany.TabIndex = 105;
            // 
            // CBMobSubmit
            // 
            this.CBMobSubmit.FormattingEnabled = true;
            this.CBMobSubmit.Location = new System.Drawing.Point(213, 298);
            this.CBMobSubmit.Name = "CBMobSubmit";
            this.CBMobSubmit.Size = new System.Drawing.Size(312, 30);
            this.CBMobSubmit.TabIndex = 88;
            this.CBMobSubmit.SelectionChangeCommitted += new System.EventHandler(this.CBMobSubmit_SelectionChangeCommitted);
            // 
            // LblMobSubmit
            // 
            this.LblMobSubmit.AutoSize = true;
            this.LblMobSubmit.ForeColor = System.Drawing.Color.White;
            this.LblMobSubmit.Location = new System.Drawing.Point(52, 301);
            this.LblMobSubmit.Name = "LblMobSubmit";
            this.LblMobSubmit.Size = new System.Drawing.Size(155, 22);
            this.LblMobSubmit.TabIndex = 104;
            this.LblMobSubmit.Text = "Mobile Submited :";
            // 
            // CBMobSelectEditDelete
            // 
            this.CBMobSelectEditDelete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBMobSelectEditDelete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBMobSelectEditDelete.FormattingEnabled = true;
            this.CBMobSelectEditDelete.Location = new System.Drawing.Point(213, 50);
            this.CBMobSelectEditDelete.Name = "CBMobSelectEditDelete";
            this.CBMobSelectEditDelete.Size = new System.Drawing.Size(312, 30);
            this.CBMobSelectEditDelete.TabIndex = 85;
            this.CBMobSelectEditDelete.SelectionChangeCommitted += new System.EventHandler(this.CBMobSelectEditDelete_SelectionChangeCommitted);
            // 
            // LBLMobSelectEditDelete
            // 
            this.LBLMobSelectEditDelete.AutoSize = true;
            this.LBLMobSelectEditDelete.ForeColor = System.Drawing.Color.White;
            this.LBLMobSelectEditDelete.Location = new System.Drawing.Point(24, 53);
            this.LBLMobSelectEditDelete.Name = "LBLMobSelectEditDelete";
            this.LBLMobSelectEditDelete.Size = new System.Drawing.Size(183, 22);
            this.LBLMobSelectEditDelete.TabIndex = 103;
            this.LBLMobSelectEditDelete.Text = "Select to Edit/Delete :";
            // 
            // LBLCustDetails
            // 
            this.LBLCustDetails.AutoSize = true;
            this.LBLCustDetails.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCustDetails.ForeColor = System.Drawing.Color.White;
            this.LBLCustDetails.Location = new System.Drawing.Point(830, 10);
            this.LBLCustDetails.Name = "LBLCustDetails";
            this.LBLCustDetails.Size = new System.Drawing.Size(498, 51);
            this.LBLCustDetails.TabIndex = 102;
            this.LBLCustDetails.Text = "Customer Mobile Status";
            // 
            // DGVCustReg
            // 
            this.DGVCustReg.AccessibleDescription = " ";
            this.DGVCustReg.AllowUserToAddRows = false;
            this.DGVCustReg.AllowUserToDeleteRows = false;
            this.DGVCustReg.AllowUserToOrderColumns = true;
            this.DGVCustReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustReg.Location = new System.Drawing.Point(556, 49);
            this.DGVCustReg.Margin = new System.Windows.Forms.Padding(2);
            this.DGVCustReg.MultiSelect = false;
            this.DGVCustReg.Name = "DGVCustReg";
            this.DGVCustReg.ReadOnly = true;
            this.DGVCustReg.RowTemplate.Height = 24;
            this.DGVCustReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustReg.Size = new System.Drawing.Size(941, 573);
            this.DGVCustReg.TabIndex = 101;
            this.DGVCustReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustReg_CellContentClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(278, 639);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 40);
            this.BtnDelete.TabIndex = 94;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(153, 639);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(120, 40);
            this.BtnUpdate.TabIndex = 93;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(26, 639);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 40);
            this.BtnSave.TabIndex = 92;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CBSelectMobile
            // 
            this.CBSelectMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBSelectMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBSelectMobile.FormattingEnabled = true;
            this.CBSelectMobile.Location = new System.Drawing.Point(213, 122);
            this.CBSelectMobile.Name = "CBSelectMobile";
            this.CBSelectMobile.Size = new System.Drawing.Size(312, 30);
            this.CBSelectMobile.TabIndex = 87;
            this.CBSelectMobile.SelectionChangeCommitted += new System.EventHandler(this.CBSelectMobile_SelectionChangeCommitted);
            // 
            // LBLSelectMobile
            // 
            this.LBLSelectMobile.AutoSize = true;
            this.LBLSelectMobile.ForeColor = System.Drawing.Color.White;
            this.LBLSelectMobile.Location = new System.Drawing.Point(80, 125);
            this.LBLSelectMobile.Name = "LBLSelectMobile";
            this.LBLSelectMobile.Size = new System.Drawing.Size(127, 22);
            this.LBLSelectMobile.TabIndex = 100;
            this.LBLSelectMobile.Text = "Select Mobile :";
            // 
            // CBSelectCustomer
            // 
            this.CBSelectCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBSelectCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBSelectCustomer.FormattingEnabled = true;
            this.CBSelectCustomer.Location = new System.Drawing.Point(213, 87);
            this.CBSelectCustomer.Name = "CBSelectCustomer";
            this.CBSelectCustomer.Size = new System.Drawing.Size(312, 30);
            this.CBSelectCustomer.TabIndex = 86;
            this.CBSelectCustomer.SelectionChangeCommitted += new System.EventHandler(this.CBSelectCustomer_SelectionChangeCommitted);
            // 
            // LBLSelectCustomer
            // 
            this.LBLSelectCustomer.AutoSize = true;
            this.LBLSelectCustomer.ForeColor = System.Drawing.Color.White;
            this.LBLSelectCustomer.Location = new System.Drawing.Point(61, 90);
            this.LBLSelectCustomer.Name = "LBLSelectCustomer";
            this.LBLSelectCustomer.Size = new System.Drawing.Size(146, 22);
            this.LBLSelectCustomer.TabIndex = 99;
            this.LBLSelectCustomer.Text = "Select Customer :";
            // 
            // LBLTotalBillAmt
            // 
            this.LBLTotalBillAmt.AutoSize = true;
            this.LBLTotalBillAmt.ForeColor = System.Drawing.Color.White;
            this.LBLTotalBillAmt.Location = new System.Drawing.Point(108, 596);
            this.LBLTotalBillAmt.Name = "LBLTotalBillAmt";
            this.LBLTotalBillAmt.Size = new System.Drawing.Size(99, 22);
            this.LBLTotalBillAmt.TabIndex = 98;
            this.LBLTotalBillAmt.Text = "Total Bill :";
            // 
            // TXTTotalBillAmt
            // 
            this.TXTTotalBillAmt.Location = new System.Drawing.Point(213, 593);
            this.TXTTotalBillAmt.Name = "TXTTotalBillAmt";
            this.TXTTotalBillAmt.Size = new System.Drawing.Size(312, 29);
            this.TXTTotalBillAmt.TabIndex = 91;
            // 
            // TXTMobRepairDesc
            // 
            this.TXTMobRepairDesc.Location = new System.Drawing.Point(213, 482);
            this.TXTMobRepairDesc.Multiline = true;
            this.TXTMobRepairDesc.Name = "TXTMobRepairDesc";
            this.TXTMobRepairDesc.Size = new System.Drawing.Size(312, 106);
            this.TXTMobRepairDesc.TabIndex = 90;
            // 
            // LBLMobRepairDesc
            // 
            this.LBLMobRepairDesc.AutoSize = true;
            this.LBLMobRepairDesc.ForeColor = System.Drawing.Color.White;
            this.LBLMobRepairDesc.Location = new System.Drawing.Point(33, 485);
            this.LBLMobRepairDesc.Name = "LBLMobRepairDesc";
            this.LBLMobRepairDesc.Size = new System.Drawing.Size(174, 22);
            this.LBLMobRepairDesc.TabIndex = 96;
            this.LBLMobRepairDesc.Text = "Repair Description :";
            // 
            // ucRepairStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.CBMobileStatus);
            this.Controls.Add(this.LBLMobileStatus);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TXTMobProbDesc);
            this.Controls.Add(this.LBLMobProbDesc);
            this.Controls.Add(this.LBLMobIMEI2);
            this.Controls.Add(this.TXTMobIMEI2);
            this.Controls.Add(this.LBLMobIMEI1);
            this.Controls.Add(this.TXTMobIMEI1);
            this.Controls.Add(this.LBLMobVar);
            this.Controls.Add(this.TXTMobVar);
            this.Controls.Add(this.LBLMobCompany);
            this.Controls.Add(this.TXTMobCompany);
            this.Controls.Add(this.CBMobSubmit);
            this.Controls.Add(this.LblMobSubmit);
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
            this.Controls.Add(this.LBLTotalBillAmt);
            this.Controls.Add(this.TXTTotalBillAmt);
            this.Controls.Add(this.TXTMobRepairDesc);
            this.Controls.Add(this.LBLMobRepairDesc);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(2, 10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucRepairStatus";
            this.Size = new System.Drawing.Size(1532, 688);
            this.Load += new System.EventHandler(this.ucRepairStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBMobileStatus;
        private System.Windows.Forms.Label LBLMobileStatus;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TXTMobProbDesc;
        private System.Windows.Forms.Label LBLMobProbDesc;
        private System.Windows.Forms.Label LBLMobIMEI2;
        private System.Windows.Forms.TextBox TXTMobIMEI2;
        private System.Windows.Forms.Label LBLMobIMEI1;
        private System.Windows.Forms.TextBox TXTMobIMEI1;
        private System.Windows.Forms.Label LBLMobVar;
        private System.Windows.Forms.TextBox TXTMobVar;
        private System.Windows.Forms.Label LBLMobCompany;
        private System.Windows.Forms.TextBox TXTMobCompany;
        private System.Windows.Forms.ComboBox CBMobSubmit;
        private System.Windows.Forms.Label LblMobSubmit;
        private System.Windows.Forms.ComboBox CBMobSelectEditDelete;
        private System.Windows.Forms.Label LBLMobSelectEditDelete;
        private System.Windows.Forms.Label LBLCustDetails;
        private System.Windows.Forms.DataGridView DGVCustReg;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CBSelectMobile;
        private System.Windows.Forms.Label LBLSelectMobile;
        private System.Windows.Forms.ComboBox CBSelectCustomer;
        private System.Windows.Forms.Label LBLSelectCustomer;
        private System.Windows.Forms.Label LBLTotalBillAmt;
        private System.Windows.Forms.TextBox TXTTotalBillAmt;
        private System.Windows.Forms.TextBox TXTMobRepairDesc;
        private System.Windows.Forms.Label LBLMobRepairDesc;
    }
}
