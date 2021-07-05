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

namespace MobileServiceCenter.FORMS
{
    public partial class ucMobSubmit : UserControl
    {
        public ucMobSubmit()
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
                    strSQL = "SELECT TblMobSubmit.SubmitedID, TblMobSubmit.MobID, TblCustReg.CustFullName, TblMobSubmit.ProblemDesc, TblMobSubmit.RepairStatus, TblCustMob.MobCompany, TblCustMob.MobModel, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustReg.CustEmailID, TblMobSubmit.SubmitedDate, TblMobSubmit.RepairDate, TblCustMob.CustID FROM TblMobSubmit INNER JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID INNER JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID";
                else if (opType == 2)
                    strSQL = "SELECT TblMobSubmit.*, TblCustMob.MobID, TblCustMob.CustID , TblCustMob.MobCompany, TblCustMob.MobModel, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustReg.CustEmailID FROM TblMobSubmit INNER JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID INNER JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID WHERE TblMobSubmit.SubmitedID = @SubmitedID";
                else if (opType == 3)
                    strSQL = "select * from TblCustReg";
                else if (opType == 4)
                    strSQL = "select * from TblCustMob where CustID = @CustID";
                else if (opType == 5)
                    strSQL = "select * from TblCustMob where MobID = @MobID";
                else if (opType == 6)
                    strSQL = "select * from TblCustMob ";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2)
                    objCmd.Parameters.AddWithValue("@SubmitedID", CBMobSelectEditDelete.SelectedValue);
                else if (opType == 4)
                    objCmd.Parameters.AddWithValue("@CustID", CBSelectCustomer.SelectedValue);
                else if (opType == 5)
                    objCmd.Parameters.AddWithValue("@MobID", CBSelectMobile.SelectedValue);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                if (objDS.Tables[0].Rows.Count > 0)
                {
                    if (opType == 1)
                    {
                        DGVCustReg.DataSource = objDS.Tables[0];
                        CBMobSelectEditDelete.DataSource = objDS.Tables[0];
                        CBMobSelectEditDelete.DisplayMember = "SubmitedID";
                        CBMobSelectEditDelete.ValueMember = "SubmitedID";
                    }
                    else if (opType == 2)
                    {
                        CBSelectCustomer.SelectedValue = objDS.Tables[0].Rows[0]["CustID"].ToString();
                        CBSelectMobile.SelectedValue = objDS.Tables[0].Rows[0]["MobID"].ToString();
                        DTPMobSubDate.Text = objDS.Tables[0].Rows[0]["SubmitedDate"].ToString();
                        TXTMobProbDesc.Text = objDS.Tables[0].Rows[0]["ProblemDesc"].ToString();
                    }
                    else if (opType == 3)
                    {
                        CBSelectCustomer.DataSource = objDS.Tables[0];
                        CBSelectCustomer.DisplayMember = "CustFullName";
                        CBSelectCustomer.ValueMember = "CustID";
                    }
                    else if (opType == 4 || opType == 6)
                    {
                        CBSelectMobile.DataSource = objDS.Tables[0];
                        CBSelectMobile.DisplayMember = "MobModel";
                        CBSelectMobile.ValueMember = "MobID";
                    }
                    else if (opType == 5)
                    {
                        TXTMobCompany.Text = objDS.Tables[0].Rows[0]["MobCompany"].ToString();
                        TXTMobVar.Text = objDS.Tables[0].Rows[0]["MobVarient"].ToString();
                        TXTMobIMEI1.Text = objDS.Tables[0].Rows[0]["MobIMEI1"].ToString();
                        TXTMobIMEI2.Text = objDS.Tables[0].Rows[0]["MobIMEI2"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No records found.");
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
                    strSQL = "INSERT INTO TblMobSubmit VALUES(@MobID, @SubmitedDate, @ProblemDesc, GETDATE(), 'Work in progress or Pending')";
                else if (opType == 2)
                    strSQL = "UPDATE TblMobSubmit set MobID = @MobID, SubmitedDate = @SubmitedDate, ProblemDesc = @ProblemDesc where SubmitedID = @SubmitedID";
                else if (opType == 3)
                    strSQL = "DELETE FROM TblMobSubmit WHERE SubmitedID = @SubmitedID";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2 || opType == 3)
                {
                    objCmd.Parameters.AddWithValue("@SubmitedID", CBMobSelectEditDelete.SelectedValue);
                }
                objCmd.Parameters.AddWithValue("@MobID", CBSelectMobile.SelectedValue);
                objCmd.Parameters.AddWithValue("@SubmitedDate", DTPMobSubDate.Text);
                objCmd.Parameters.AddWithValue("@ProblemDesc", TXTMobProbDesc.Text);
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
            CBMobSelectEditDelete.SelectedIndex = -1;
            CBMobSelectEditDelete.Text = "";
            CBSelectCustomer.SelectedIndex = -1;
            CBSelectCustomer.Text = "";
            CBSelectMobile.SelectedIndex = -1;
            CBSelectMobile.Text = "";
            TXTMobCompany.Text = "";
            TXTMobVar.Text = "";
            TXTMobIMEI1.Text = "";
            TXTMobIMEI2.Text = "";
            TXTMobProbDesc.Text = "";
            DTPMobSubDate.Text = "";
        }
        private void ucMobSubmit_Load(object sender, EventArgs e)
        {
            getData(1);
            getData(3);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            saveData(2);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveData(1);
        }

        private void CBSelectCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getData(4);
        }

        private void CBSelectMobile_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getData(5);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            saveData(3);
        }
        private void CBMobSelectEditDelete_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getData(6);
            getData(3);
            getData(2);
            getData(5);
        }
    }
}
//SELECT TblMobSubmit.SubmitedID, TblMobSubmit.MobID, TblCustMob.CustID, TblCustMob.MobileCompany, TblCustMob.MobModel, TblMobSubmit.SubmitedDate, TblMobSubmit.ProblemDesc, TblMobSubmit.RepairStatus FROM TblMobSubmit inner join TblCustMob on TblMobSubmit.MobID = TblCustMob.MobID