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
    public partial class ucRepairStatus : UserControl
    {
        public ucRepairStatus()
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
                    strSQL = "SELECT TblMobReturn.ReturnedID, TblMobReturn.SubmitedID, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustMob.MobCompany, TblCustMob.MobModel, TblCustMob.MobVarient, TblCustMob.MobIMEI2, TblCustMob.MobIMEI1,TblCustReg.CustAddress,TblMobReturn.RepairDesc,TblMobSubmit.ProblemDesc, TblMobSubmit.RepairStatus, TblMobSubmit.SubmitedDate, TblMobSubmit.RepairDate, TblMobReturn.ReturnedDate, TblMobReturn.TotalBillAmt, TblMobSubmit.MobID, TblCustMob.CustID, TblCustReg.CustID FROM TblMobReturn INNER JOIN TblMobSubmit ON TblMobReturn.SubmitedID = TblMobSubmit.SubmitedID INNER JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID INNER JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID";
                else if (opType == 2)
                    strSQL = "SELECT TblMobReturn.ReturnedID, TblMobReturn.SubmitedID, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustMob.MobCompany, TblCustMob.MobModel, TblCustMob.MobVarient, TblCustMob.MobIMEI2, TblCustMob.MobIMEI1,TblCustReg.CustAddress,TblMobReturn.RepairDesc,TblMobSubmit.ProblemDesc, TblMobSubmit.RepairStatus, TblMobSubmit.SubmitedDate, TblMobSubmit.RepairDate, TblMobReturn.ReturnedDate, TblMobReturn.TotalBillAmt, TblMobSubmit.MobID, TblCustMob.CustID, TblCustReg.CustID FROM TblMobReturn INNER JOIN TblMobSubmit ON TblMobReturn.SubmitedID = TblMobSubmit.SubmitedID INNER JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID INNER JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID WHERE TblMobReturn.ReturnedID=@ReturnedID";
                else if (opType == 3)
                    strSQL = "select * from TblCustReg";
                else if (opType == 4)
                    strSQL = "select * from tblcustmob Where CustID = @CustID";
                else if (opType == 5)
                    strSQL = "select * from tblCustMob Where MobID = @MobID";
                else if (opType == 6)
                    strSQL = "select * from tblMobSubmit where MobID = @MobID";
                else if (opType == 7)
                    strSQL = "select * from tblMobSubmit Where SubmitedID = @SubmitedID";
                else if (opType == 8)
                    strSQL = "select * from tblcustmob";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2)
                    objCmd.Parameters.AddWithValue("@ReturnedID", CBMobSelectEditDelete.SelectedValue);
                else if (opType == 4)
                    objCmd.Parameters.AddWithValue("@CustID", CBSelectCustomer.SelectedValue);
                else if (opType == 5)
                    objCmd.Parameters.AddWithValue("@MobID", CBSelectMobile.SelectedValue);
                else if (opType == 6)
                    objCmd.Parameters.AddWithValue("@MobID", CBSelectMobile.SelectedValue);
                else if (opType == 7)
                    objCmd.Parameters.AddWithValue("@SubmitedID", CBMobSubmit.SelectedValue);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                if (objDS.Tables[0].Rows.Count > 0)
                {
                    if (opType == 1)
                    {

                        DGVCustReg.DataSource = objDS.Tables[0];
                        CBMobSelectEditDelete.DataSource = objDS.Tables[0];
                        CBMobSelectEditDelete.DisplayMember = "ReturnedID";
                        CBMobSelectEditDelete.ValueMember = "ReturnedID";

                    }
                    else if (opType == 2)
                    {
                        CBSelectCustomer.SelectedValue = objDS.Tables[0].Rows[0]["CustID"].ToString();
                        CBSelectMobile.SelectedValue = objDS.Tables[0].Rows[0]["MobID"].ToString();
                        TXTMobCompany.Text = objDS.Tables[0].Rows[0]["MobCompany"].ToString();
                        TXTMobVar.Text = objDS.Tables[0].Rows[0]["MobVarient"].ToString();
                        TXTMobIMEI1.Text = objDS.Tables[0].Rows[0]["MobIMEI1"].ToString();
                        TXTMobIMEI2.Text = objDS.Tables[0].Rows[0]["MobIMEI2"].ToString();
                        CBMobileStatus.Text=objDS.Tables[0].Rows[0]["RepairStatus"].ToString();
                        TXTMobRepairDesc.Text = objDS.Tables[0].Rows[0]["RepairDesc"].ToString();
                        TXTTotalBillAmt.Text = objDS.Tables[0].Rows[0]["TotalBillAmt"].ToString();
                    }
                    else if (opType == 3)
                    {

                        CBSelectCustomer.DataSource = objDS.Tables[0];
                        CBSelectCustomer.DisplayMember = "CustFullName";
                        CBSelectCustomer.ValueMember = "CustID";

                    }
                    else if (opType == 4 || opType == 8)
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
                    else if (opType == 6)
                    {
                        CBMobSubmit.DataSource = objDS.Tables[0];
                        CBMobSubmit.DisplayMember = "SubmitedDate";
                        CBMobSubmit.ValueMember = "SubmitedID";
                    }
                    else if (opType == 7)
                    {
                        TXTMobProbDesc.Text = objDS.Tables[0].Rows[0]["ProblemDesc"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No records found");
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
                    strSQL = "INSERT INTO TblMobReturn (SubmitedID, RepairDesc, TotalBillAmt) VALUES (@SubmitedID, @RepairDesc, @TotalBillAmt) update TblMobSubmit set RepairDate = GETDATE(), RepairStatus = @RepairStatus where SubmitedID = @SubmitedID";
                else if (opType == 2)
                    strSQL = "UPDATE TblMobReturn set SubmitedID=@SubmitedID, RepairDesc = @RepairDesc, TotalBillAmt = @TotalBillAmt WHERE ReturnedID = @ReturnedID";
                else if (opType == 3)
                    strSQL = "DELETE FROM TblMobReturn WHERE ReturnedID = @ReturnedID";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2 || opType == 3)
                {
                    objCmd.Parameters.AddWithValue("@ReturnedID", CBMobSelectEditDelete.SelectedValue);
                }
                objCmd.Parameters.AddWithValue("@SubmitedID", CBSelectMobile.SelectedValue);
                objCmd.Parameters.AddWithValue("@RepairDesc", TXTMobRepairDesc.Text);
                objCmd.Parameters.AddWithValue("@TotalBillAmt", TXTTotalBillAmt.Text);
                objCmd.Parameters.AddWithValue("@RepairStatus", CBMobileStatus.Text);

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
            TXTMobRepairDesc.Text = "";
            TXTTotalBillAmt.Text = "";
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
            getData(6);
        }

        private void CBMobSubmit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getData(7);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            saveData(2);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            saveData(3);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void ucRepairStatus_Load(object sender, EventArgs e)
        {
            getData(1);
            getData(3);
        }

        private void CBMobSelectEditDelete_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getData(8);
            getData(2);
            getData(6);
        }

        private void DGVCustReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
