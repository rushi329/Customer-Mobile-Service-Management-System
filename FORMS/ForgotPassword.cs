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
using System.Net;
using System.Net.Mail;

namespace MobileServiceCenter.FORMS
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
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
                    strSQL = "SELECT TblUserReg.UserID, TblUserReg.FullName, TblUserReg.UserAddress, TblUserReg.UserDOB, TblUserReg.UserGender, TblUserReg.UserMobileNo, TblUserReg.UserType, TblLogin.UserName, TblLogin.Password, TblLogin.SecurityQuestion, TblLogin.SecurityAnswer, TblLogin.EmailId FROM TblUserReg inner join TblLogin on TblUserReg.UserID = TblLogin.UserID WHERE TblLogin.UserName = @UserName AND TblLogin.EmailId = @EmailId AND TblLogin.SecurityQuestion = @SecurityQuestion AND TblLogin.SecurityAnswer = @SecurityAnswer";
                else if (opType == 2)
                    strSQL = "SELECT Password FROM TblLogin where EmailID = @EmailID";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2)
                    objCmd.Parameters.AddWithValue("@EmailID", TxtAdminEmailID.Text);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                if (objDS.Tables[0].Rows.Count > 0)
                {
                    if (opType == 2)
                    {


                        string password = objDS.Tables[0].Rows[0]["Password"].ToString();

                        MailMessage mm = new MailMessage("shubhamuc414@gmail.com", TxtAdminEmailID.Text);
                        mm.Subject = "Your Password :";
                        mm.Body = string.Format("Hello : {0} is your Email-ID \n your password is {1}", TxtAdminEmailID.Text, password);
                        mm.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential nc = new NetworkCredential();
                        nc.UserName = "shubhamuc414@gmail.com";
                        nc.Password = "shubhamuc1112";
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = nc;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        MessageBox.Show("Your Password has been sent to" + TxtAdminEmailID.Text);
                    }
                    
                }
                else
                {
                    MessageBox.Show(" EmailID Does Not Exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    
    private void BTNSave_MouseHover(object sender, EventArgs e)
        {
            BTNSave.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BTNSave_MouseLeave(object sender, EventArgs e)
        {
            BTNSave.BackColor = ColorTranslator.FromHtml("#BB86FC");
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            getData(2);
        }

        private void LinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 objLF = new Form1();
            objLF.Show();
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 objLF = new Form1();
            objLF.Show();
        }
    }
}
