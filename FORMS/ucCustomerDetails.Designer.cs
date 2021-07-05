namespace MobileServiceCenter.FORMS
{
    partial class ucCustomerDetails
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
            this.LBLCustFullName = new System.Windows.Forms.Label();
            this.TXTCustFullName = new System.Windows.Forms.TextBox();
            this.TXTCustMobNo = new System.Windows.Forms.TextBox();
            this.LBLCustFirstName = new System.Windows.Forms.Label();
            this.TXTCustEmailID = new System.Windows.Forms.TextBox();
            this.LBLCustEmailID = new System.Windows.Forms.Label();
            this.TXTCustAddress = new System.Windows.Forms.TextBox();
            this.LBLCustAddress = new System.Windows.Forms.Label();
            this.TXTCustAdhar = new System.Windows.Forms.TextBox();
            this.LBLCustAdhar = new System.Windows.Forms.Label();
            this.LBLSelectEditDelete = new System.Windows.Forms.Label();
            this.CBSelectEditDelete = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.DGVCustReg = new System.Windows.Forms.DataGridView();
            this.LBLCustDetails = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReg)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLCustFullName
            // 
            this.LBLCustFullName.AutoSize = true;
            this.LBLCustFullName.BackColor = System.Drawing.Color.Transparent;
            this.LBLCustFullName.ForeColor = System.Drawing.Color.White;
            this.LBLCustFullName.Location = new System.Drawing.Point(87, 89);
            this.LBLCustFullName.Name = "LBLCustFullName";
            this.LBLCustFullName.Size = new System.Drawing.Size(105, 22);
            this.LBLCustFullName.TabIndex = 0;
            this.LBLCustFullName.Text = "Full Name :";
            // 
            // TXTCustFullName
            // 
            this.TXTCustFullName.Location = new System.Drawing.Point(198, 86);
            this.TXTCustFullName.Name = "TXTCustFullName";
            this.TXTCustFullName.Size = new System.Drawing.Size(272, 29);
            this.TXTCustFullName.TabIndex = 1;
            // 
            // TXTCustMobNo
            // 
            this.TXTCustMobNo.Location = new System.Drawing.Point(198, 121);
            this.TXTCustMobNo.Name = "TXTCustMobNo";
            this.TXTCustMobNo.Size = new System.Drawing.Size(272, 29);
            this.TXTCustMobNo.TabIndex = 3;
            // 
            // LBLCustFirstName
            // 
            this.LBLCustFirstName.AutoSize = true;
            this.LBLCustFirstName.BackColor = System.Drawing.Color.Transparent;
            this.LBLCustFirstName.ForeColor = System.Drawing.Color.White;
            this.LBLCustFirstName.Location = new System.Drawing.Point(87, 124);
            this.LBLCustFirstName.Name = "LBLCustFirstName";
            this.LBLCustFirstName.Size = new System.Drawing.Size(108, 22);
            this.LBLCustFirstName.TabIndex = 2;
            this.LBLCustFirstName.Text = "Mobile No. :";
            // 
            // TXTCustEmailID
            // 
            this.TXTCustEmailID.Location = new System.Drawing.Point(198, 156);
            this.TXTCustEmailID.Name = "TXTCustEmailID";
            this.TXTCustEmailID.Size = new System.Drawing.Size(272, 29);
            this.TXTCustEmailID.TabIndex = 5;
            this.TXTCustEmailID.TextChanged += new System.EventHandler(this.TXTCustEmailID_TextChanged);
            // 
            // LBLCustEmailID
            // 
            this.LBLCustEmailID.AutoSize = true;
            this.LBLCustEmailID.BackColor = System.Drawing.Color.Transparent;
            this.LBLCustEmailID.ForeColor = System.Drawing.Color.White;
            this.LBLCustEmailID.Location = new System.Drawing.Point(94, 159);
            this.LBLCustEmailID.Name = "LBLCustEmailID";
            this.LBLCustEmailID.Size = new System.Drawing.Size(98, 22);
            this.LBLCustEmailID.TabIndex = 4;
            this.LBLCustEmailID.Text = "Email ID :";
            // 
            // TXTCustAddress
            // 
            this.TXTCustAddress.Location = new System.Drawing.Point(198, 191);
            this.TXTCustAddress.Multiline = true;
            this.TXTCustAddress.Name = "TXTCustAddress";
            this.TXTCustAddress.Size = new System.Drawing.Size(272, 79);
            this.TXTCustAddress.TabIndex = 7;
            // 
            // LBLCustAddress
            // 
            this.LBLCustAddress.AutoSize = true;
            this.LBLCustAddress.BackColor = System.Drawing.Color.Transparent;
            this.LBLCustAddress.ForeColor = System.Drawing.Color.White;
            this.LBLCustAddress.Location = new System.Drawing.Point(108, 194);
            this.LBLCustAddress.Name = "LBLCustAddress";
            this.LBLCustAddress.Size = new System.Drawing.Size(84, 22);
            this.LBLCustAddress.TabIndex = 6;
            this.LBLCustAddress.Text = "Address :";
            // 
            // TXTCustAdhar
            // 
            this.TXTCustAdhar.Location = new System.Drawing.Point(198, 276);
            this.TXTCustAdhar.Name = "TXTCustAdhar";
            this.TXTCustAdhar.Size = new System.Drawing.Size(272, 29);
            this.TXTCustAdhar.TabIndex = 9;
            // 
            // LBLCustAdhar
            // 
            this.LBLCustAdhar.AutoSize = true;
            this.LBLCustAdhar.BackColor = System.Drawing.Color.Transparent;
            this.LBLCustAdhar.ForeColor = System.Drawing.Color.White;
            this.LBLCustAdhar.Location = new System.Drawing.Point(74, 279);
            this.LBLCustAdhar.Name = "LBLCustAdhar";
            this.LBLCustAdhar.Size = new System.Drawing.Size(118, 22);
            this.LBLCustAdhar.TabIndex = 8;
            this.LBLCustAdhar.Text = "Aadhaar No :";
            // 
            // LBLSelectEditDelete
            // 
            this.LBLSelectEditDelete.AutoSize = true;
            this.LBLSelectEditDelete.BackColor = System.Drawing.Color.Transparent;
            this.LBLSelectEditDelete.ForeColor = System.Drawing.Color.White;
            this.LBLSelectEditDelete.Location = new System.Drawing.Point(9, 53);
            this.LBLSelectEditDelete.Name = "LBLSelectEditDelete";
            this.LBLSelectEditDelete.Size = new System.Drawing.Size(183, 22);
            this.LBLSelectEditDelete.TabIndex = 10;
            this.LBLSelectEditDelete.Text = "Select to Edit/Delete :";
            // 
            // CBSelectEditDelete
            // 
            this.CBSelectEditDelete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBSelectEditDelete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBSelectEditDelete.FormattingEnabled = true;
            this.CBSelectEditDelete.Location = new System.Drawing.Point(198, 45);
            this.CBSelectEditDelete.Name = "CBSelectEditDelete";
            this.CBSelectEditDelete.Size = new System.Drawing.Size(272, 30);
            this.CBSelectEditDelete.TabIndex = 1;
            this.CBSelectEditDelete.SelectionChangeCommitted += new System.EventHandler(this.CBSelectEditDelete_SelectionChangeCommitted);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(156, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(282, 325);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(120, 40);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DGVCustReg
            // 
            this.DGVCustReg.AccessibleDescription = " ";
            this.DGVCustReg.AllowUserToAddRows = false;
            this.DGVCustReg.AllowUserToDeleteRows = false;
            this.DGVCustReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustReg.Location = new System.Drawing.Point(533, 50);
            this.DGVCustReg.Margin = new System.Windows.Forms.Padding(2);
            this.DGVCustReg.MultiSelect = false;
            this.DGVCustReg.Name = "DGVCustReg";
            this.DGVCustReg.ReadOnly = true;
            this.DGVCustReg.RowTemplate.Height = 24;
            this.DGVCustReg.Size = new System.Drawing.Size(694, 601);
            this.DGVCustReg.TabIndex = 55;
            this.DGVCustReg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustReg_CellClick);
            // 
            // LBLCustDetails
            // 
            this.LBLCustDetails.AutoSize = true;
            this.LBLCustDetails.BackColor = System.Drawing.Color.Transparent;
            this.LBLCustDetails.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCustDetails.ForeColor = System.Drawing.Color.White;
            this.LBLCustDetails.Location = new System.Drawing.Point(691, 7);
            this.LBLCustDetails.Name = "LBLCustDetails";
            this.LBLCustDetails.Size = new System.Drawing.Size(364, 51);
            this.LBLCustDetails.TabIndex = 56;
            this.LBLCustDetails.Text = "Customer Details";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(406, 325);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 40);
            this.BtnClear.TabIndex = 57;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ucCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LBLCustDetails);
            this.Controls.Add(this.DGVCustReg);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CBSelectEditDelete);
            this.Controls.Add(this.LBLSelectEditDelete);
            this.Controls.Add(this.TXTCustAdhar);
            this.Controls.Add(this.LBLCustAdhar);
            this.Controls.Add(this.TXTCustAddress);
            this.Controls.Add(this.LBLCustAddress);
            this.Controls.Add(this.TXTCustEmailID);
            this.Controls.Add(this.LBLCustEmailID);
            this.Controls.Add(this.TXTCustMobNo);
            this.Controls.Add(this.LBLCustFirstName);
            this.Controls.Add(this.TXTCustFullName);
            this.Controls.Add(this.LBLCustFullName);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Location = new System.Drawing.Point(2, 10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucCustomerDetails";
            this.Size = new System.Drawing.Size(1307, 688);
            this.Load += new System.EventHandler(this.ucCustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLCustFullName;
        private System.Windows.Forms.TextBox TXTCustFullName;
        private System.Windows.Forms.TextBox TXTCustMobNo;
        private System.Windows.Forms.Label LBLCustFirstName;
        private System.Windows.Forms.TextBox TXTCustEmailID;
        private System.Windows.Forms.Label LBLCustEmailID;
        private System.Windows.Forms.TextBox TXTCustAddress;
        private System.Windows.Forms.Label LBLCustAddress;
        private System.Windows.Forms.TextBox TXTCustAdhar;
        private System.Windows.Forms.Label LBLCustAdhar;
        private System.Windows.Forms.Label LBLSelectEditDelete;
        private System.Windows.Forms.ComboBox CBSelectEditDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView DGVCustReg;
        private System.Windows.Forms.Label LBLCustDetails;
        private System.Windows.Forms.Button BtnClear;
    }
}
