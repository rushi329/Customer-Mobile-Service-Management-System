namespace MobileServiceCenter.FORMS
{
    partial class ucAdminReg
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
            this.LblAdminID = new System.Windows.Forms.Label();
            this.CBAdminNames = new System.Windows.Forms.ComboBox();
            this.LblAdminEmailID = new System.Windows.Forms.Label();
            this.LblAdminMobNo = new System.Windows.Forms.Label();
            this.LblAdminName = new System.Windows.Forms.Label();
            this.TxtAdminName = new System.Windows.Forms.TextBox();
            this.TxtAdminAddress = new System.Windows.Forms.TextBox();
            this.LblAdminAddress = new System.Windows.Forms.Label();
            this.TxtAdminMobNo = new System.Windows.Forms.TextBox();
            this.TxtAdminEmailID = new System.Windows.Forms.TextBox();
            this.GBGender = new System.Windows.Forms.GroupBox();
            this.RBFemale = new System.Windows.Forms.RadioButton();
            this.RBMale = new System.Windows.Forms.RadioButton();
            this.DTPDOB = new System.Windows.Forms.DateTimePicker();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.LblSecurityQuestion = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.CBSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.BTNSave = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.DGVAdminReg = new System.Windows.Forms.DataGridView();
            this.LBLMaxID = new System.Windows.Forms.Label();
            this.LBLUserType = new System.Windows.Forms.Label();
            this.CBUserType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GBGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdminReg)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdminID
            // 
            this.LblAdminID.AutoSize = true;
            this.LblAdminID.BackColor = System.Drawing.Color.Transparent;
            this.LblAdminID.ForeColor = System.Drawing.Color.White;
            this.LblAdminID.Location = new System.Drawing.Point(10, 62);
            this.LblAdminID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdminID.Name = "LblAdminID";
            this.LblAdminID.Size = new System.Drawing.Size(183, 22);
            this.LblAdminID.TabIndex = 0;
            this.LblAdminID.Text = "Select to Edit/Delete :";
            // 
            // CBAdminNames
            // 
            this.CBAdminNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CBAdminNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBAdminNames.FormattingEnabled = true;
            this.CBAdminNames.Location = new System.Drawing.Point(199, 59);
            this.CBAdminNames.Margin = new System.Windows.Forms.Padding(2);
            this.CBAdminNames.Name = "CBAdminNames";
            this.CBAdminNames.Size = new System.Drawing.Size(219, 30);
            this.CBAdminNames.TabIndex = 1;
            this.CBAdminNames.SelectionChangeCommitted += new System.EventHandler(this.CBAdminNames_SelectionChangeCommitted);
            // 
            // LblAdminEmailID
            // 
            this.LblAdminEmailID.AutoSize = true;
            this.LblAdminEmailID.BackColor = System.Drawing.Color.Transparent;
            this.LblAdminEmailID.ForeColor = System.Drawing.Color.White;
            this.LblAdminEmailID.Location = new System.Drawing.Point(93, 222);
            this.LblAdminEmailID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdminEmailID.Name = "LblAdminEmailID";
            this.LblAdminEmailID.Size = new System.Drawing.Size(100, 22);
            this.LblAdminEmailID.TabIndex = 2;
            this.LblAdminEmailID.Text = "Email-ID :";
            // 
            // LblAdminMobNo
            // 
            this.LblAdminMobNo.AutoSize = true;
            this.LblAdminMobNo.BackColor = System.Drawing.Color.Transparent;
            this.LblAdminMobNo.ForeColor = System.Drawing.Color.White;
            this.LblAdminMobNo.Location = new System.Drawing.Point(90, 189);
            this.LblAdminMobNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdminMobNo.Name = "LblAdminMobNo";
            this.LblAdminMobNo.Size = new System.Drawing.Size(103, 22);
            this.LblAdminMobNo.TabIndex = 3;
            this.LblAdminMobNo.Text = "Mobile No :";
            // 
            // LblAdminName
            // 
            this.LblAdminName.AutoSize = true;
            this.LblAdminName.BackColor = System.Drawing.Color.Transparent;
            this.LblAdminName.ForeColor = System.Drawing.Color.White;
            this.LblAdminName.Location = new System.Drawing.Point(66, 96);
            this.LblAdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdminName.Name = "LblAdminName";
            this.LblAdminName.Size = new System.Drawing.Size(127, 22);
            this.LblAdminName.TabIndex = 5;
            this.LblAdminName.Text = "Admin Name :";
            // 
            // TxtAdminName
            // 
            this.TxtAdminName.Location = new System.Drawing.Point(199, 93);
            this.TxtAdminName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdminName.Name = "TxtAdminName";
            this.TxtAdminName.Size = new System.Drawing.Size(219, 29);
            this.TxtAdminName.TabIndex = 2;
            // 
            // TxtAdminAddress
            // 
            this.TxtAdminAddress.Location = new System.Drawing.Point(199, 126);
            this.TxtAdminAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdminAddress.Multiline = true;
            this.TxtAdminAddress.Name = "TxtAdminAddress";
            this.TxtAdminAddress.Size = new System.Drawing.Size(219, 56);
            this.TxtAdminAddress.TabIndex = 3;
            // 
            // LblAdminAddress
            // 
            this.LblAdminAddress.AutoSize = true;
            this.LblAdminAddress.BackColor = System.Drawing.Color.Transparent;
            this.LblAdminAddress.ForeColor = System.Drawing.Color.White;
            this.LblAdminAddress.Location = new System.Drawing.Point(109, 129);
            this.LblAdminAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdminAddress.Name = "LblAdminAddress";
            this.LblAdminAddress.Size = new System.Drawing.Size(84, 22);
            this.LblAdminAddress.TabIndex = 8;
            this.LblAdminAddress.Text = "Address :";
            // 
            // TxtAdminMobNo
            // 
            this.TxtAdminMobNo.Location = new System.Drawing.Point(199, 186);
            this.TxtAdminMobNo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdminMobNo.Name = "TxtAdminMobNo";
            this.TxtAdminMobNo.Size = new System.Drawing.Size(219, 29);
            this.TxtAdminMobNo.TabIndex = 4;
            // 
            // TxtAdminEmailID
            // 
            this.TxtAdminEmailID.Location = new System.Drawing.Point(199, 219);
            this.TxtAdminEmailID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdminEmailID.Name = "TxtAdminEmailID";
            this.TxtAdminEmailID.Size = new System.Drawing.Size(219, 29);
            this.TxtAdminEmailID.TabIndex = 5;
            // 
            // GBGender
            // 
            this.GBGender.Controls.Add(this.RBFemale);
            this.GBGender.Controls.Add(this.RBMale);
            this.GBGender.ForeColor = System.Drawing.Color.White;
            this.GBGender.Location = new System.Drawing.Point(199, 252);
            this.GBGender.Margin = new System.Windows.Forms.Padding(2);
            this.GBGender.Name = "GBGender";
            this.GBGender.Padding = new System.Windows.Forms.Padding(2);
            this.GBGender.Size = new System.Drawing.Size(221, 98);
            this.GBGender.TabIndex = 12;
            this.GBGender.TabStop = false;
            this.GBGender.Text = "Gender ";
            // 
            // RBFemale
            // 
            this.RBFemale.AutoSize = true;
            this.RBFemale.ForeColor = System.Drawing.Color.White;
            this.RBFemale.Location = new System.Drawing.Point(12, 63);
            this.RBFemale.Margin = new System.Windows.Forms.Padding(2);
            this.RBFemale.Name = "RBFemale";
            this.RBFemale.Size = new System.Drawing.Size(89, 26);
            this.RBFemale.TabIndex = 7;
            this.RBFemale.TabStop = true;
            this.RBFemale.Text = "Female";
            this.RBFemale.UseVisualStyleBackColor = true;
            // 
            // RBMale
            // 
            this.RBMale.AutoSize = true;
            this.RBMale.ForeColor = System.Drawing.Color.White;
            this.RBMale.Location = new System.Drawing.Point(12, 29);
            this.RBMale.Margin = new System.Windows.Forms.Padding(2);
            this.RBMale.Name = "RBMale";
            this.RBMale.Size = new System.Drawing.Size(71, 26);
            this.RBMale.TabIndex = 6;
            this.RBMale.TabStop = true;
            this.RBMale.Text = "Male";
            this.RBMale.UseVisualStyleBackColor = true;
            // 
            // DTPDOB
            // 
            this.DTPDOB.CustomFormat = "dd-MMM-yyyy";
            this.DTPDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDOB.Location = new System.Drawing.Point(199, 388);
            this.DTPDOB.Margin = new System.Windows.Forms.Padding(2);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(221, 29);
            this.DTPDOB.TabIndex = 8;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.BackColor = System.Drawing.Color.Transparent;
            this.LblGender.ForeColor = System.Drawing.Color.White;
            this.LblGender.Location = new System.Drawing.Point(115, 283);
            this.LblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(78, 22);
            this.LblGender.TabIndex = 15;
            this.LblGender.Text = "Gender :";
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.BackColor = System.Drawing.Color.Transparent;
            this.LblDOB.ForeColor = System.Drawing.Color.White;
            this.LblDOB.Location = new System.Drawing.Point(60, 393);
            this.LblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(133, 22);
            this.LblDOB.TabIndex = 16;
            this.LblDOB.Text = "Date Of Birth :";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.BackColor = System.Drawing.Color.Transparent;
            this.LblUsername.ForeColor = System.Drawing.Color.White;
            this.LblUsername.Location = new System.Drawing.Point(93, 424);
            this.LblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(100, 22);
            this.LblUsername.TabIndex = 17;
            this.LblUsername.Text = "Username :";
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.LblAnswer.ForeColor = System.Drawing.Color.White;
            this.LblAnswer.Location = new System.Drawing.Point(112, 557);
            this.LblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(81, 22);
            this.LblAnswer.TabIndex = 18;
            this.LblAnswer.Text = "Answer :";
            // 
            // LblSecurityQuestion
            // 
            this.LblSecurityQuestion.AutoSize = true;
            this.LblSecurityQuestion.BackColor = System.Drawing.Color.Transparent;
            this.LblSecurityQuestion.ForeColor = System.Drawing.Color.White;
            this.LblSecurityQuestion.Location = new System.Drawing.Point(32, 523);
            this.LblSecurityQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSecurityQuestion.Name = "LblSecurityQuestion";
            this.LblSecurityQuestion.Size = new System.Drawing.Size(161, 22);
            this.LblSecurityQuestion.TabIndex = 19;
            this.LblSecurityQuestion.Text = "Security Question :";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.ForeColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(97, 457);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(96, 22);
            this.LblPassword.TabIndex = 20;
            this.LblPassword.Text = "Password :";
            // 
            // CBSecurityQuestion
            // 
            this.CBSecurityQuestion.FormattingEnabled = true;
            this.CBSecurityQuestion.Items.AddRange(new object[] {
            "Your First School Name",
            "Your Best Friend Name",
            "Your Favourite Teacher Name",
            "Your Pet Name",
            "Your Favourite Color"});
            this.CBSecurityQuestion.Location = new System.Drawing.Point(199, 520);
            this.CBSecurityQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.CBSecurityQuestion.Name = "CBSecurityQuestion";
            this.CBSecurityQuestion.Size = new System.Drawing.Size(221, 30);
            this.CBSecurityQuestion.TabIndex = 11;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(199, 421);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(221, 29);
            this.TxtUsername.TabIndex = 9;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(199, 454);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(221, 29);
            this.TxtPassword.TabIndex = 10;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtSecurityAnswer
            // 
            this.TxtSecurityAnswer.Location = new System.Drawing.Point(199, 554);
            this.TxtSecurityAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSecurityAnswer.Name = "TxtSecurityAnswer";
            this.TxtSecurityAnswer.Size = new System.Drawing.Size(221, 29);
            this.TxtSecurityAnswer.TabIndex = 12;
            // 
            // BTNSave
            // 
            this.BTNSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BTNSave.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.BTNSave.ForeColor = System.Drawing.Color.White;
            this.BTNSave.Location = new System.Drawing.Point(31, 612);
            this.BTNSave.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(120, 40);
            this.BTNSave.TabIndex = 13;
            this.BTNSave.Text = "Save";
            this.BTNSave.UseVisualStyleBackColor = false;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BTNDelete.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.BTNDelete.ForeColor = System.Drawing.Color.White;
            this.BTNDelete.Location = new System.Drawing.Point(279, 612);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(120, 40);
            this.BTNDelete.TabIndex = 15;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.BTNUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.BTNUpdate.ForeColor = System.Drawing.Color.White;
            this.BTNUpdate.Location = new System.Drawing.Point(155, 612);
            this.BTNUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(120, 40);
            this.BTNUpdate.TabIndex = 14;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.UseVisualStyleBackColor = false;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(746, 14);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(569, 51);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "Admin Registeration Form";
            // 
            // DGVAdminReg
            // 
            this.DGVAdminReg.AccessibleDescription = " ";
            this.DGVAdminReg.AllowUserToAddRows = false;
            this.DGVAdminReg.AllowUserToDeleteRows = false;
            this.DGVAdminReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAdminReg.Location = new System.Drawing.Point(455, 59);
            this.DGVAdminReg.Margin = new System.Windows.Forms.Padding(2);
            this.DGVAdminReg.MultiSelect = false;
            this.DGVAdminReg.Name = "DGVAdminReg";
            this.DGVAdminReg.ReadOnly = true;
            this.DGVAdminReg.RowTemplate.Height = 24;
            this.DGVAdminReg.Size = new System.Drawing.Size(1059, 524);
            this.DGVAdminReg.TabIndex = 54;
            this.DGVAdminReg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAdminReg_CellClick);
            // 
            // LBLMaxID
            // 
            this.LBLMaxID.AutoSize = true;
            this.LBLMaxID.Location = new System.Drawing.Point(176, 35);
            this.LBLMaxID.Name = "LBLMaxID";
            this.LBLMaxID.Size = new System.Drawing.Size(19, 22);
            this.LBLMaxID.TabIndex = 55;
            this.LBLMaxID.Text = "0";
            this.LBLMaxID.Visible = false;
            // 
            // LBLUserType
            // 
            this.LBLUserType.AutoSize = true;
            this.LBLUserType.BackColor = System.Drawing.Color.Transparent;
            this.LBLUserType.ForeColor = System.Drawing.Color.White;
            this.LBLUserType.Location = new System.Drawing.Point(92, 357);
            this.LBLUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLUserType.Name = "LBLUserType";
            this.LBLUserType.Size = new System.Drawing.Size(101, 22);
            this.LBLUserType.TabIndex = 57;
            this.LBLUserType.Text = "User Type :";
            // 
            // CBUserType
            // 
            this.CBUserType.FormattingEnabled = true;
            this.CBUserType.Items.AddRange(new object[] {
            "ADMIN",
            "EMPLOYEE"});
            this.CBUserType.Location = new System.Drawing.Point(199, 354);
            this.CBUserType.Margin = new System.Windows.Forms.Padding(2);
            this.CBUserType.Name = "CBUserType";
            this.CBUserType.Size = new System.Drawing.Size(221, 30);
            this.CBUserType.TabIndex = 58;
            this.CBUserType.Text = "--SELECT--";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(34)))), ((int)(((byte)(253)))));
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(403, 612);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(199, 487);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.Size = new System.Drawing.Size(221, 29);
            this.TxtConfirmPassword.TabIndex = 59;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 490);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 60;
            this.label2.Text = "Confirm Password :";
            // 
            // ucAdminReg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBUserType);
            this.Controls.Add(this.LBLUserType);
            this.Controls.Add(this.LBLMaxID);
            this.Controls.Add(this.DGVAdminReg);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.TxtSecurityAnswer);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.CBSecurityQuestion);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblSecurityQuestion);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblDOB);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.DTPDOB);
            this.Controls.Add(this.GBGender);
            this.Controls.Add(this.TxtAdminEmailID);
            this.Controls.Add(this.TxtAdminMobNo);
            this.Controls.Add(this.LblAdminAddress);
            this.Controls.Add(this.TxtAdminAddress);
            this.Controls.Add(this.TxtAdminName);
            this.Controls.Add(this.LblAdminName);
            this.Controls.Add(this.LblAdminMobNo);
            this.Controls.Add(this.LblAdminEmailID);
            this.Controls.Add(this.CBAdminNames);
            this.Controls.Add(this.LblAdminID);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Location = new System.Drawing.Point(2, 10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucAdminReg";
            this.Size = new System.Drawing.Size(1532, 688);
            this.Load += new System.EventHandler(this.ucAdminreg_Load);
            this.GBGender.ResumeLayout(false);
            this.GBGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdminReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAdminID;
        private System.Windows.Forms.ComboBox CBAdminNames;
        private System.Windows.Forms.Label LblAdminEmailID;
        private System.Windows.Forms.Label LblAdminMobNo;
        private System.Windows.Forms.Label LblAdminName;
        private System.Windows.Forms.TextBox TxtAdminName;
        private System.Windows.Forms.TextBox TxtAdminAddress;
        private System.Windows.Forms.Label LblAdminAddress;
        private System.Windows.Forms.TextBox TxtAdminMobNo;
        private System.Windows.Forms.TextBox TxtAdminEmailID;
        private System.Windows.Forms.GroupBox GBGender;
        private System.Windows.Forms.RadioButton RBFemale;
        private System.Windows.Forms.RadioButton RBMale;
        private System.Windows.Forms.DateTimePicker DTPDOB;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblAnswer;
        private System.Windows.Forms.Label LblSecurityQuestion;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.ComboBox CBSecurityQuestion;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtSecurityAnswer;
        private System.Windows.Forms.Button BTNSave;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView DGVAdminReg;
        private System.Windows.Forms.Label LBLMaxID;
        private System.Windows.Forms.Label LBLUserType;
        private System.Windows.Forms.ComboBox CBUserType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Label label2;
    }
}
