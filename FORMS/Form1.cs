using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MobileServiceCenter
{
    public partial class Form1 : Form
    {
        private object txtUsername;

        public Form1()
        {
            InitializeComponent();
        }

        void getLogin()
        {
            try
            {
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
                string strSQL = "";
                strSQL = "SELECT * FROM TblLogin WHERE UserName=@Username AND Password=@Password";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                objCmd.Parameters.AddWithValue("@Username", TxtUsername.Text);
                objCmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                if (objDS.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    MainForm objMF = new MainForm();
                    objMF.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username and/or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

     
        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
            {
                TxtUsername.Text = "Username";
                TxtUsername.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                getLogin();
            }
        }

        private bool validateData()
        {
            if(TxtUsername.Text==""||TxtUsername.Text==" " || TxtUsername.Text == "Username")
            {
                MessageBox.Show("Please Enter Username.");
                TxtUsername.Focus();
                return false;
            }
            if(TxtPassword.Text==""||TxtPassword.Text==" "||TxtPassword.Text=="Password")
            {
                MessageBox.Show("Please Enter Password.");
                TxtPassword.Focus();
                return false;
            }
            return true;
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Username")
            {
                TxtUsername.Text = "";
                TxtUsername.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Password")
            {
                TxtPassword.Text = "";
                TxtPassword.ForeColor = System.Drawing.Color.Black;
                TxtPassword.PasswordChar = '*';
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Password";
                TxtPassword.PasswordChar = '\0';
                TxtPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void LinkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FORMS.ForgotPassword objFP = new FORMS.ForgotPassword();
            objFP.Show();
        }

    }
}
