using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace MobileServiceCenter.FORMS
{
    public partial class ucAdminReg : UserControl
    {
        public ucAdminReg()
        {
            InitializeComponent();
        }

        private void getData(int opType)
        {
            try
            {
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
                string strSQL = "";
                if (opType == 1)
                    strSQL = "SELECT TblUserReg.UserID, TblUserReg.FullName, TblUserReg.UserAddress, TblUserReg.UserDOB, TblUserReg.UserGender, TblUserReg.UserMobileNo,  TblUserReg.UserType, TblLogin.UserName, TblLogin.Password, TblLogin.SecurityQuestion, TblLogin.SecurityAnswer, TblLogin.EmailId FROM TblUserReg inner join TblLogin on TblUserReg.UserID = TblLogin.UserID ";
                else if (opType == 2)
                    strSQL = "SELECT TblUserReg.UserID, TblUserReg.FullName, TblUserReg.UserAddress, TblUserReg.UserDOB, TblUserReg.UserGender, TblUserReg.UserMobileNo, TblUserReg.UserType, TblLogin.UserName, TblLogin.Password, TblLogin.SecurityQuestion, TblLogin.SecurityAnswer, TblLogin.EmailId FROM TblUserReg inner join TblLogin on TblUserReg.UserID = TblLogin.UserID WHERE TblUserReg.UserID=@UserID";
                else if (opType == 3)
                    strSQL = "SELECT ISNULL(MAX(UserID) + 1, 1) AS MaxID FROM TblUserReg";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2)
                    objCmd.Parameters.AddWithValue("@UserID", CBAdminNames.SelectedValue);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                if (opType == 1)
                {
                    DGVAdminReg.DataSource = objDS.Tables[0];
                    CBAdminNames.DataSource = objDS.Tables[0];
                    CBAdminNames.DisplayMember = "FullName";
                    CBAdminNames.ValueMember = "UserID";
                }
                else if (opType == 2)
                {
                    TxtAdminName.Text = objDS.Tables[0].Rows[0]["FullName"].ToString();
                    TxtAdminAddress.Text = objDS.Tables[0].Rows[0]["UserAddress"].ToString();
                    TxtAdminMobNo.Text = objDS.Tables[0].Rows[0]["UserMobileNo"].ToString();
                    TxtAdminEmailID.Text = objDS.Tables[0].Rows[0]["EmailID"].ToString();
                    string strGender = objDS.Tables[0].Rows[0]["UserGender"].ToString();
                    if (strGender == "MALE")
                        RBMale.Checked = true;
                    else if (strGender == "FEMALE")
                        RBFemale.Checked = true;
                    DTPDOB.Text = objDS.Tables[0].Rows[0]["UserDOB"].ToString();
                    CBUserType.Text = objDS.Tables[0].Rows[0]["UserType"].ToString();
                }
                else if (opType == 3)
                {
                    LBLMaxID.Text = objDS.Tables[0].Rows[0]["MaxID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void saveData(int opType)
        {
            try
            {
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
                string strSQL = "";
                if (opType == 1)
                    strSQL = "INSERT INTO TblUserReg VALUES(@UserID, @FullName, @UserAddress, @UserMobileNo, @UserGender, @UserType, @UserDOB) INSERT INTO TblLogin VALUES(@UserID, @Username, @Password, @EmailID, @SecurityQuestion, @SecurityAnswer)";
                else if (opType == 2)
                    strSQL = "UPDATE TblUserReg set FullName = @FullName, UserAddress = @UserAddress, UserMobileNo = @UserMobileNo, UserGender = @UserGender, UserType = @UserType,  UserDOB = @UserDOB WHERE UserID = @UserID UPDATE TblLogin set Username = @Username, Password = @Password, EmailID = @EmailID, SecurityQuestion = @SecurityQuestion, SecurityAnswer = @SecurityAnswer where UserID = @UserID";
                else if (opType == 3)
                    strSQL = "DELETE FROM TblUserReg WHERE UserID = @UserID DELETE FROM TblLogin WHERE UserID = @UserID";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 1)
                {
                    objCmd.Parameters.AddWithValue("@UserID", LBLMaxID.Text);
                }
                else
                {
                    objCmd.Parameters.AddWithValue("@UserID", CBAdminNames.SelectedValue);
                }
                objCmd.Parameters.AddWithValue("@FullName", TxtAdminName.Text);
                objCmd.Parameters.AddWithValue("@UserAddress", TxtAdminAddress.Text);
                objCmd.Parameters.AddWithValue("@UserMobileNo", TxtAdminMobNo.Text);
                objCmd.Parameters.AddWithValue("@EmailID", TxtAdminEmailID.Text);
                objCmd.Parameters.AddWithValue("@UserType", CBUserType.Text);
                objCmd.Parameters.AddWithValue("@UserDOB", DTPDOB.Text);
                string strGender = "";
                if (RBMale.Checked == true)
                    strGender = "MALE";
                else if (RBFemale.Checked == true)
                    strGender = "FEMALE";
                objCmd.Parameters.AddWithValue("@UserGender", strGender);
                objCmd.Parameters.AddWithValue("@Username", TxtUsername.Text);
                objCmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                objCmd.Parameters.AddWithValue("@SecurityQuestion", CBSecurityQuestion.Text);
                objCmd.Parameters.AddWithValue("@SecurityAnswer", TxtSecurityAnswer.Text);
                objCon.Open();
                int i = objCmd.ExecuteNonQuery();
                if (i > 1)
                {
                    if (opType == 1)
                        MessageBox.Show("Data saved successfully");
                    else if (opType == 2)
                        MessageBox.Show("Data updated successfully");
                    else if (opType == 3)
                        MessageBox.Show("Data deleted successfully");
                    clearAll();
                    getData(1);
                }
                objCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void clearAll()
        {
            CBAdminNames.SelectedIndex = -1;
            CBAdminNames.Text = "";
            TxtAdminName.Text = "";
            TxtAdminAddress.Text = "";
            TxtAdminMobNo.Text = "";
            TxtAdminEmailID.Text = "";
            RBMale.Checked = false;
            RBFemale.Checked = false;
            DTPDOB.Text = DateTime.Now.ToString();
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            CBSecurityQuestion.Text = "";
            TxtSecurityAnswer.Text = "";
            TxtConfirmPassword.Text = "";
        }
        
        bool validateData()
        {
            if (TxtAdminName.Text == "" || TxtAdminName.Text == " ")
            {
                MessageBox.Show("Please Enter Admin Name.");
                TxtAdminName.Focus();
                return false;
            }
            if (TxtAdminAddress.Text == "" || TxtAdminAddress.Text == " ")
            {
                MessageBox.Show("Please Enter Address.");
                TxtAdminAddress.Focus();
                return false;
            }
            if (TxtAdminMobNo.Text == "" || TxtAdminMobNo.Text == " ")
            {
                MessageBox.Show("Please Enter Mobile No.");
                TxtAdminMobNo.Focus();
                return false;
            }
            else
            {
                try
                {
                    Int64 iMobNo = Convert.ToInt64(TxtAdminMobNo.Text);
                    if (TxtAdminMobNo.Text.Length != 10)
                    {
                        MessageBox.Show("Invalid Mobile No");
                        TxtAdminMobNo.Focus();
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Mobile No");
                    TxtAdminMobNo.Focus();
                    return false;
                }
            }
            try
            {
                bool b = Regex.IsMatch(TxtAdminEmailID.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                return b;
            }
            catch
            {
                MessageBox.Show("Invalid Email-ID");
                return false;
            }
            if (TxtPassword.Text.Equals(TxtConfirmPassword.Text))
            {

            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
            return true;
        }
        

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                getData(3);
                saveData(1);
            }
        }
        
        private void ucAdminreg_Load(object sender, EventArgs e)
        {
            getData(1);
        }

        private void DGVAdminReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getData(2);
        }
        

        private void CBAdminNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getData(2);
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            saveData(2);
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            saveData(3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be less than or greater than 12 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
