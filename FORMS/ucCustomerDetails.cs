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
    public partial class ucCustomerDetails : UserControl
    {
        public ucCustomerDetails()
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
                    strSQL = "SELECT TblCustReg.CustID, TblCustReg.CustFullName, TblCustReg.CustAddress,TblCustReg.CustMobileNo, TblCustReg.CustEmailID,TblCustReg.CustAadhaarNo FROM TblCustReg";
                else if (opType == 2)
                    strSQL = "SELECT TblCustReg.CustID, TblCustReg.CustFullName, TblCustReg.CustAddress, TblCustReg.CustAadhaarNo, TblCustReg.CustMobileNo,  TblCustReg.CustEmailID FROM TblCustReg WHERE CustID=@CustID";
                else if (opType == 3)
                    strSQL = "SELECT ISNULL(MAX(UserID) + 1, 1) AS MaxID FROM TblCustReg";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2)
                    objCmd.Parameters.AddWithValue("@CustID", CBSelectEditDelete.SelectedValue);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                if (opType == 1)
                {
                    DGVCustReg.DataSource = objDS.Tables[0];
                    CBSelectEditDelete.DataSource = objDS.Tables[0];
                    CBSelectEditDelete.DisplayMember = "CustFullName";
                    CBSelectEditDelete.ValueMember = "CustID";
                }
                else if (opType == 2)
                {
                    TXTCustFullName.Text = objDS.Tables[0].Rows[0]["CustFullName"].ToString();
                    TXTCustAddress.Text = objDS.Tables[0].Rows[0]["CustAddress"].ToString();
                    TXTCustMobNo.Text = objDS.Tables[0].Rows[0]["CustMobileNo"].ToString();
                    TXTCustEmailID.Text = objDS.Tables[0].Rows[0]["CustEmailID"].ToString();
                    TXTCustAdhar.Text = objDS.Tables[0].Rows[0]["CustAadhaarNo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            saveData(2);
        }

        bool validateData()
        {
            if (TXTCustFullName.Text == "" || TXTCustFullName.Text == " ")
            {
                MessageBox.Show("Please Enter Admin Name.");
                TXTCustFullName.Focus();
                return false;
            }
            if (TXTCustAddress.Text == "" || TXTCustAddress.Text == " ")
            {
                MessageBox.Show("Please Enter Address.");
                TXTCustAddress.Focus();
                return false;
            }
            if (TXTCustMobNo.Text == "" || TXTCustMobNo.Text == " ")
            {
                MessageBox.Show("Please Enter Mobile No.");
                TXTCustMobNo.Focus();
                return false;
            }
            else
            {
                try
                {
                    Int64 iMobNo = Convert.ToInt64(TXTCustMobNo.Text);
                    if (TXTCustMobNo.Text.Length != 10)
                    {
                        MessageBox.Show("Invalid Mobile No");
                        TXTCustMobNo.Focus();
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Mobile No");
                    TXTCustMobNo.Focus();
                    return false;
                }
            }
            try
            {
                bool b = Regex.IsMatch(TXTCustEmailID.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                return b;
            }
            catch
            {
                MessageBox.Show("Invalid Email-ID");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                saveData(1);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            saveData(3);
        }

        private void saveData(int opType)
        {
            try
            {
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
                string strSQL = "";
                if (opType == 1)
                    strSQL = "INSERT INTO TblCustReg VALUES(@CustFullName, @CustMobileNo, @CustEmailID, @CustAddress, @CustAadhaarNo)";
                else if (opType == 2)
                    strSQL = "UPDATE TblCustReg set CustFullName = @CustFullName, CustAddress = @CustAddress, CustMobileNo = @CustMobileNo, CustAadhaarNo = @CustAadhaarNo, CustEmailID = @CustEmailID WHERE CustID = @CustID";
                else if (opType == 3)
                    strSQL = "DELETE FROM TblCustReg WHERE CustID = @CustID";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2|| opType == 3)
                {
                    objCmd.Parameters.AddWithValue("@CustID", CBSelectEditDelete.SelectedValue);
                }
                objCmd.Parameters.AddWithValue("@CustFullName", TXTCustFullName.Text);
                objCmd.Parameters.AddWithValue("@CustAddress", TXTCustAddress.Text);
                objCmd.Parameters.AddWithValue("@CustMobileNo", TXTCustMobNo.Text);
                objCmd.Parameters.AddWithValue("@CustEmailID", TXTCustEmailID.Text);
                objCmd.Parameters.AddWithValue("@CustAadhaarNo", TXTCustAdhar.Text);
                objCon.Open();
                int i = objCmd.ExecuteNonQuery();
                if (i > 0)
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
            CBSelectEditDelete.SelectedIndex = -1;
            CBSelectEditDelete.Text = "";
            TXTCustFullName.Text = "";
            TXTCustAddress.Text = "";
            TXTCustMobNo.Text = "";
            TXTCustEmailID.Text = "";
            TXTCustAdhar.Text = "";
        }

        private void ucCustomerDetails_Load(object sender, EventArgs e)
        {
            getData(1);
        }
        private void DGVCustReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getData(2);
        }

        private void CBSelectEditDelete_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getData(2);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void TXTCustEmailID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
