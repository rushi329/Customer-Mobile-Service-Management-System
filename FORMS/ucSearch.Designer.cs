namespace MobileServiceCenter.FORMS
{
    partial class ucSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSearch));
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.CBSearchBy = new System.Windows.Forms.ComboBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.DGVSearch = new System.Windows.Forms.DataGridView();
            this.PBSearch = new System.Windows.Forms.PictureBox();
            this.CBSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.ForeColor = System.Drawing.Color.White;
            this.LblSearchBy.Location = new System.Drawing.Point(11, 28);
            this.LblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(98, 22);
            this.LblSearchBy.TabIndex = 0;
            this.LblSearchBy.Text = "Search by :";
            // 
            // CBSearchBy
            // 
            this.CBSearchBy.FormattingEnabled = true;
            this.CBSearchBy.Items.AddRange(new object[] {
            "--SELECT--",
            "Name",
            "Mobile No.",
            "Work in progress or Pending",
            "Repair not possible",
            "Handset repaired but customer not pickup",
            "Handset delivered"});
            this.CBSearchBy.Location = new System.Drawing.Point(98, 23);
            this.CBSearchBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBSearchBy.Name = "CBSearchBy";
            this.CBSearchBy.Size = new System.Drawing.Size(198, 30);
            this.CBSearchBy.TabIndex = 1;
            this.CBSearchBy.Text = "--SELECT--";
            this.CBSearchBy.SelectedIndexChanged += new System.EventHandler(this.CBSearchBy_SelectedIndexChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.ForeColor = System.Drawing.Color.White;
            this.LblSearch.Location = new System.Drawing.Point(397, 28);
            this.LblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(75, 22);
            this.LblSearch.TabIndex = 4;
            this.LblSearch.Text = "Search :";
            // 
            // DGVSearch
            // 
            this.DGVSearch.AllowUserToAddRows = false;
            this.DGVSearch.AllowUserToDeleteRows = false;
            this.DGVSearch.AllowUserToOrderColumns = true;
            this.DGVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSearch.Location = new System.Drawing.Point(15, 76);
            this.DGVSearch.MultiSelect = false;
            this.DGVSearch.Name = "DGVSearch";
            this.DGVSearch.ReadOnly = true;
            this.DGVSearch.RowTemplate.Height = 24;
            this.DGVSearch.Size = new System.Drawing.Size(1469, 598);
            this.DGVSearch.TabIndex = 5;
            // 
            // PBSearch
            // 
            this.PBSearch.BackColor = System.Drawing.Color.Transparent;
            this.PBSearch.Image = ((System.Drawing.Image)(resources.GetObject("PBSearch.Image")));
            this.PBSearch.Location = new System.Drawing.Point(781, 27);
            this.PBSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBSearch.Name = "PBSearch";
            this.PBSearch.Size = new System.Drawing.Size(26, 28);
            this.PBSearch.TabIndex = 6;
            this.PBSearch.TabStop = false;
            this.PBSearch.Click += new System.EventHandler(this.PBSearch_Click);
            // 
            // CBSearch
            // 
            this.CBSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBSearch.FormattingEnabled = true;
            this.CBSearch.Items.AddRange(new object[] {
            "Name",
            "Mobile No."});
            this.CBSearch.Location = new System.Drawing.Point(461, 26);
            this.CBSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBSearch.Name = "CBSearch";
            this.CBSearch.Size = new System.Drawing.Size(311, 30);
            this.CBSearch.TabIndex = 7;
            // 
            // ucSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.CBSearch);
            this.Controls.Add(this.PBSearch);
            this.Controls.Add(this.DGVSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.CBSearchBy);
            this.Controls.Add(this.LblSearchBy);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Location = new System.Drawing.Point(2, 10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(1532, 688);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSearchBy;
        private System.Windows.Forms.ComboBox CBSearchBy;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.DataGridView DGVSearch;
        private System.Windows.Forms.PictureBox PBSearch;
        private System.Windows.Forms.ComboBox CBSearch;
    }
}
