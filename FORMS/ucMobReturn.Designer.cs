namespace MobileServiceCenter.FORMS
{
    partial class ucMobReturn
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
            this.LBLTotalBillAmt = new System.Windows.Forms.Label();
            this.TXTTotalBillAmt = new System.Windows.Forms.TextBox();
            this.TXTMobRepairDesc = new System.Windows.Forms.TextBox();
            this.LBLMobRepairDesc = new System.Windows.Forms.Label();
            this.CBSelectMobile = new System.Windows.Forms.ComboBox();
            this.LBLSelectMobile = new System.Windows.Forms.Label();
            this.CBSelectCustomer = new System.Windows.Forms.ComboBox();
            this.LBLSelectCustomer = new System.Windows.Forms.Label();
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
            this.TXTMobProbDesc = new System.Windows.Forms.TextBox();
            this.LBLMobProbDesc = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblMobSubmit = new System.Windows.Forms.Label();
            this.CBMobSubmit = new System.Windows.Forms.ComboBox();
            this.CBMobileStatus = new System.Windows.Forms.ComboBox();
            this.LBLMobileStatus = new System.Windows.Forms.Label();
            this.LBLRepairDate = new System.Windows.Forms.Label();
            this.DTPRepairDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReg)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTotalBillAmt
            // 
            this.LBLTotalBillAmt.AutoSize = true;
            this.LBLTotalBillAmt.ForeColor = System.Drawing.Color.White;
            this.LBLTotalBillAmt.Location = new System.Drawing.Point(100, 608);
            this.LBLTotalBillAmt.Name = "LBLTotalBillAmt";
            this.LBLTotalBillAmt.Size = new System.Drawing.Size(99, 22);
            this.LBLTotalBillAmt.TabIndex = 47;
            this.LBLTotalBillAmt.Text = "Total Bill :";
            // 
            // TXTTotalBillAmt
            // 
            this.TXTTotalBillAmt.Location = new System.Drawing.Point(205, 605);
            this.TXTTotalBillAmt.Name = "TXTTotalBillAmt";
            this.TXTTotalBillAmt.ReadOnly = true;
            this.TXTTotalBillAmt.Size = new System.Drawing.Size(312, 29);
            this.TXTTotalBillAmt.TabIndex = 7;
            // 
            // TXTMobRepairDesc
            // 
            this.TXTMobRepairDesc.Location = new System.Drawing.Point(205, 494);
            this.TXTMobRepairDesc.Multiline = true;
            this.TXTMobRepairDesc.Name = "TXTMobRepairDesc";
            this.TXTMobRepairDesc.ReadOnly = true;
            this.TXTMobRepairDesc.Size = new System.Drawing.Size(312, 106);
            this.TXTMobRepairDesc.TabIndex = 6;
            // 
            // LBLMobRepairDesc
            // 
            this.LBLMobRepairDesc.AutoSize = true;
            this.LBLMobRepairDesc.ForeColor = System.Drawing.Color.White;
            this.LBLMobRepairDesc.Location = new System.Drawing.Point(25, 497);
            this.LBLMobRepairDesc.Name = "LBLMobRepairDesc";
            this.LBLMobRepairDesc.Size = new System.Drawing.Size(174, 22);
            this.LBLMobRepairDesc.TabIndex = 42;
            this.LBLMobRepairDesc.Text = "Repair Description :";
            // 
            // CBSelectMobile
            // 
            this.CBSelectMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBSelectMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBSelectMobile.FormattingEnabled = true;
            this.CBSelectMobile.Location = new System.Drawing.Point(205, 99);
            this.CBSelectMobile.Name = "CBSelectMobile";
            this.CBSelectMobile.Size = new System.Drawing.Size(312, 30);
            this.CBSelectMobile.TabIndex = 3;
            this.CBSelectMobile.SelectionChangeCommitted += new System.EventHandler(this.CBSelectMobile_SelectionChangeCommitted);
            // 
            // LBLSelectMobile
            // 
            this.LBLSelectMobile.AutoSize = true;
            this.LBLSelectMobile.ForeColor = System.Drawing.Color.White;
            this.LBLSelectMobile.Location = new System.Drawing.Point(72, 102);
            this.LBLSelectMobile.Name = "LBLSelectMobile";
            this.LBLSelectMobile.Size = new System.Drawing.Size(127, 22);
            this.LBLSelectMobile.TabIndex = 51;
            this.LBLSelectMobile.Text = "Select Mobile :";
            // 
            // CBSelectCustomer
            // 
            this.CBSelectCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBSelectCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBSelectCustomer.FormattingEnabled = true;
            this.CBSelectCustomer.Location = new System.Drawing.Point(205, 64);
            this.CBSelectCustomer.Name = "CBSelectCustomer";
            this.CBSelectCustomer.Size = new System.Drawing.Size(312, 30);
            this.CBSelectCustomer.TabIndex = 2;
            this.CBSelectCustomer.SelectionChangeCommitted += new System.EventHandler(this.CBSelectCustomer_SelectionChangeCommitted);
            // 
            // LBLSelectCustomer
            // 
            this.LBLSelectCustomer.AutoSize = true;
            this.LBLSelectCustomer.ForeColor = System.Drawing.Color.White;
            this.LBLSelectCustomer.Location = new System.Drawing.Point(53, 67);
            this.LBLSelectCustomer.Name = "LBLSelectCustomer";
            this.LBLSelectCustomer.Size = new System.Drawing.Size(146, 22);
            this.LBLSelectCustomer.TabIndex = 49;
            this.LBLSelectCustomer.Text = "Select Customer :";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(273, 643);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 40);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(148, 643);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(120, 40);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(21, 643);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 40);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Return";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LBLCustDetails
            // 
            this.LBLCustDetails.AutoSize = true;
            this.LBLCustDetails.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Underline);
            this.LBLCustDetails.ForeColor = System.Drawing.Color.White;
            this.LBLCustDetails.Location = new System.Drawing.Point(831, -3);
            this.LBLCustDetails.Name = "LBLCustDetails";
            this.LBLCustDetails.Size = new System.Drawing.Size(460, 35);
            this.LBLCustDetails.TabIndex = 62;
            this.LBLCustDetails.Text = "Customer Mobile Return Details";
            // 
            // DGVCustReg
            // 
            this.DGVCustReg.AccessibleDescription = " ";
            this.DGVCustReg.AllowUserToAddRows = false;
            this.DGVCustReg.AllowUserToDeleteRows = false;
            this.DGVCustReg.AllowUserToOrderColumns = true;
            this.DGVCustReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustReg.Location = new System.Drawing.Point(534, 27);
            this.DGVCustReg.Margin = new System.Windows.Forms.Padding(2);
            this.DGVCustReg.MultiSelect = false;
            this.DGVCustReg.Name = "DGVCustReg";
            this.DGVCustReg.ReadOnly = true;
            this.DGVCustReg.RowTemplate.Height = 24;
            this.DGVCustReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustReg.Size = new System.Drawing.Size(978, 607);
            this.DGVCustReg.TabIndex = 61;
            // 
            // CBMobSelectEditDelete
            // 
            this.CBMobSelectEditDelete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBMobSelectEditDelete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBMobSelectEditDelete.FormattingEnabled = true;
            this.CBMobSelectEditDelete.Location = new System.Drawing.Point(205, 27);
            this.CBMobSelectEditDelete.Name = "CBMobSelectEditDelete";
            this.CBMobSelectEditDelete.Size = new System.Drawing.Size(312, 30);
            this.CBMobSelectEditDelete.TabIndex = 1;
            this.CBMobSelectEditDelete.SelectionChangeCommitted += new System.EventHandler(this.CBMobSelectEditDelete_SelectionChangeCommitted);
            // 
            // LBLMobSelectEditDelete
            // 
            this.LBLMobSelectEditDelete.AutoSize = true;
            this.LBLMobSelectEditDelete.ForeColor = System.Drawing.Color.White;
            this.LBLMobSelectEditDelete.Location = new System.Drawing.Point(16, 30);
            this.LBLMobSelectEditDelete.Name = "LBLMobSelectEditDelete";
            this.LBLMobSelectEditDelete.Size = new System.Drawing.Size(183, 22);
            this.LBLMobSelectEditDelete.TabIndex = 64;
            this.LBLMobSelectEditDelete.Text = "Select to Edit/Delete :";
            // 
            // LBLMobIMEI2
            // 
            this.LBLMobIMEI2.AutoSize = true;
            this.LBLMobIMEI2.ForeColor = System.Drawing.Color.White;
            this.LBLMobIMEI2.Location = new System.Drawing.Point(118, 243);
            this.LBLMobIMEI2.Name = "LBLMobIMEI2";
            this.LBLMobIMEI2.Size = new System.Drawing.Size(81, 22);
            this.LBLMobIMEI2.TabIndex = 80;
            this.LBLMobIMEI2.Text = "IMEI 2 :";
            // 
            // TXTMobIMEI2
            // 
            this.TXTMobIMEI2.Location = new System.Drawing.Point(205, 240);
            this.TXTMobIMEI2.Name = "TXTMobIMEI2";
            this.TXTMobIMEI2.ReadOnly = true;
            this.TXTMobIMEI2.Size = new System.Drawing.Size(312, 29);
            this.TXTMobIMEI2.TabIndex = 79;
            // 
            // LBLMobIMEI1
            // 
            this.LBLMobIMEI1.AutoSize = true;
            this.LBLMobIMEI1.ForeColor = System.Drawing.Color.White;
            this.LBLMobIMEI1.Location = new System.Drawing.Point(118, 209);
            this.LBLMobIMEI1.Name = "LBLMobIMEI1";
            this.LBLMobIMEI1.Size = new System.Drawing.Size(81, 22);
            this.LBLMobIMEI1.TabIndex = 78;
            this.LBLMobIMEI1.Text = "IMEI 1 :";
            // 
            // TXTMobIMEI1
            // 
            this.TXTMobIMEI1.Location = new System.Drawing.Point(205, 206);
            this.TXTMobIMEI1.Name = "TXTMobIMEI1";
            this.TXTMobIMEI1.ReadOnly = true;
            this.TXTMobIMEI1.Size = new System.Drawing.Size(312, 29);
            this.TXTMobIMEI1.TabIndex = 77;
            // 
            // LBLMobVar
            // 
            this.LBLMobVar.AutoSize = true;
            this.LBLMobVar.ForeColor = System.Drawing.Color.White;
            this.LBLMobVar.Location = new System.Drawing.Point(57, 173);
            this.LBLMobVar.Name = "LBLMobVar";
            this.LBLMobVar.Size = new System.Drawing.Size(142, 22);
            this.LBLMobVar.TabIndex = 76;
            this.LBLMobVar.Text = "Mobile Varient :";
            // 
            // TXTMobVar
            // 
            this.TXTMobVar.Location = new System.Drawing.Point(205, 170);
            this.TXTMobVar.Name = "TXTMobVar";
            this.TXTMobVar.ReadOnly = true;
            this.TXTMobVar.Size = new System.Drawing.Size(312, 29);
            this.TXTMobVar.TabIndex = 75;
            // 
            // LBLMobCompany
            // 
            this.LBLMobCompany.AutoSize = true;
            this.LBLMobCompany.ForeColor = System.Drawing.Color.White;
            this.LBLMobCompany.Location = new System.Drawing.Point(45, 138);
            this.LBLMobCompany.Name = "LBLMobCompany";
            this.LBLMobCompany.Size = new System.Drawing.Size(154, 22);
            this.LBLMobCompany.TabIndex = 74;
            this.LBLMobCompany.Text = "Mobile Company :";
            // 
            // TXTMobCompany
            // 
            this.TXTMobCompany.Location = new System.Drawing.Point(205, 135);
            this.TXTMobCompany.Name = "TXTMobCompany";
            this.TXTMobCompany.ReadOnly = true;
            this.TXTMobCompany.Size = new System.Drawing.Size(312, 29);
            this.TXTMobCompany.TabIndex = 73;
            // 
            // TXTMobProbDesc
            // 
            this.TXTMobProbDesc.Location = new System.Drawing.Point(205, 311);
            this.TXTMobProbDesc.Multiline = true;
            this.TXTMobProbDesc.Name = "TXTMobProbDesc";
            this.TXTMobProbDesc.ReadOnly = true;
            this.TXTMobProbDesc.Size = new System.Drawing.Size(312, 106);
            this.TXTMobProbDesc.TabIndex = 82;
            // 
            // LBLMobProbDesc
            // 
            this.LBLMobProbDesc.AutoSize = true;
            this.LBLMobProbDesc.ForeColor = System.Drawing.Color.White;
            this.LBLMobProbDesc.Location = new System.Drawing.Point(12, 314);
            this.LBLMobProbDesc.Name = "LBLMobProbDesc";
            this.LBLMobProbDesc.Size = new System.Drawing.Size(187, 22);
            this.LBLMobProbDesc.TabIndex = 81;
            this.LBLMobProbDesc.Text = "Problem Description :";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(400, 643);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 40);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblMobSubmit
            // 
            this.LblMobSubmit.AutoSize = true;
            this.LblMobSubmit.ForeColor = System.Drawing.Color.White;
            this.LblMobSubmit.Location = new System.Drawing.Point(44, 278);
            this.LblMobSubmit.Name = "LblMobSubmit";
            this.LblMobSubmit.Size = new System.Drawing.Size(155, 22);
            this.LblMobSubmit.TabIndex = 66;
            this.LblMobSubmit.Text = "Mobile Submited :";
            // 
            // CBMobSubmit
            // 
            this.CBMobSubmit.FormattingEnabled = true;
            this.CBMobSubmit.Location = new System.Drawing.Point(205, 275);
            this.CBMobSubmit.Name = "CBMobSubmit";
            this.CBMobSubmit.Size = new System.Drawing.Size(312, 30);
            this.CBMobSubmit.TabIndex = 4;
            this.CBMobSubmit.SelectionChangeCommitted += new System.EventHandler(this.CBMobSubmit_SelectionChangeCommitted);
            // 
            // CBMobileStatus
            // 
            this.CBMobileStatus.FormattingEnabled = true;
            this.CBMobileStatus.Items.AddRange(new object[] {
            "--SELECT--",
            "Repair not possible",
            "Handset repaired but customer not pickup",
            "Handset delivered"});
            this.CBMobileStatus.Location = new System.Drawing.Point(205, 423);
            this.CBMobileStatus.Name = "CBMobileStatus";
            this.CBMobileStatus.Size = new System.Drawing.Size(312, 30);
            this.CBMobileStatus.TabIndex = 83;
            // 
            // LBLMobileStatus
            // 
            this.LBLMobileStatus.AutoSize = true;
            this.LBLMobileStatus.ForeColor = System.Drawing.Color.White;
            this.LBLMobileStatus.Location = new System.Drawing.Point(70, 426);
            this.LBLMobileStatus.Name = "LBLMobileStatus";
            this.LBLMobileStatus.Size = new System.Drawing.Size(129, 22);
            this.LBLMobileStatus.TabIndex = 84;
            this.LBLMobileStatus.Text = "Mobile Status :";
            // 
            // LBLRepairDate
            // 
            this.LBLRepairDate.AutoSize = true;
            this.LBLRepairDate.ForeColor = System.Drawing.Color.White;
            this.LBLRepairDate.Location = new System.Drawing.Point(61, 464);
            this.LBLRepairDate.Name = "LBLRepairDate";
            this.LBLRepairDate.Size = new System.Drawing.Size(136, 22);
            this.LBLRepairDate.TabIndex = 44;
            this.LBLRepairDate.Text = "Repaired Date :";
            // 
            // DTPRepairDate
            // 
            this.DTPRepairDate.CustomFormat = "dd-MMM-yyyy";
            this.DTPRepairDate.Enabled = false;
            this.DTPRepairDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPRepairDate.Location = new System.Drawing.Point(205, 459);
            this.DTPRepairDate.Name = "DTPRepairDate";
            this.DTPRepairDate.Size = new System.Drawing.Size(312, 29);
            this.DTPRepairDate.TabIndex = 5;
            // 
            // ucMobReturn
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
            this.Controls.Add(this.DTPRepairDate);
            this.Controls.Add(this.LBLRepairDate);
            this.Controls.Add(this.TXTMobRepairDesc);
            this.Controls.Add(this.LBLMobRepairDesc);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Location = new System.Drawing.Point(2, 10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucMobReturn";
            this.Size = new System.Drawing.Size(1532, 688);
            this.Load += new System.EventHandler(this.ucMobReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTotalBillAmt;
        private System.Windows.Forms.TextBox TXTTotalBillAmt;
        private System.Windows.Forms.TextBox TXTMobRepairDesc;
        private System.Windows.Forms.Label LBLMobRepairDesc;
        private System.Windows.Forms.ComboBox CBSelectMobile;
        private System.Windows.Forms.Label LBLSelectMobile;
        private System.Windows.Forms.ComboBox CBSelectCustomer;
        private System.Windows.Forms.Label LBLSelectCustomer;
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
        private System.Windows.Forms.TextBox TXTMobProbDesc;
        private System.Windows.Forms.Label LBLMobProbDesc;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblMobSubmit;
        private System.Windows.Forms.ComboBox CBMobSubmit;
        private System.Windows.Forms.ComboBox CBMobileStatus;
        private System.Windows.Forms.Label LBLMobileStatus;
        private System.Windows.Forms.Label LBLRepairDate;
        private System.Windows.Forms.DateTimePicker DTPRepairDate;
    }
}
