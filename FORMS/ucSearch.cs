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
    public partial class ucSearch : UserControl
    {
        public ucSearch()
        {
            InitializeComponent();
        }
        private void getData(int opType)
        {
            try
            {
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
                string strSQL = "";
                if (opType == 1 || opType == 2)
                    strSQL = "select * from TblCustReg";
                else if (opType == 3)
                    strSQL = "SELECT TblMobSubmit.SubmitedID, TblMobSubmit.MobID, TblCustMob.CustID, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustMob.MobCompany, TblCustMob.MobModel, TblMobSubmit.SubmitedDate, TblMobSubmit.ProblemDesc, TblMobSubmit.RepairStatus, TblMobReturn.ReturnedID, TblMobReturn.RepairDesc, TblMobReturn.ReturnedDate, TblMobReturn.TotalBillAmt FROM TblMobSubmit LEFT JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID LEFT JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID LEFT JOIN TblMobReturn ON TblMobSubmit.SubmitedID = TblMobReturn.SubmitedID WHERE TblCustMob.CustID = @CustID";
                else if (opType == 4)
                    strSQL = "SELECT TblMobSubmit.SubmitedID, TblMobSubmit.MobID, TblCustMob.CustID, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustMob.MobCompany, TblCustMob.MobModel, TblMobSubmit.SubmitedDate, TblMobSubmit.ProblemDesc, TblMobSubmit.RepairStatus, TblMobReturn.ReturnedID, TblMobReturn.RepairDesc, TblMobReturn.ReturnedDate, TblMobReturn.TotalBillAmt FROM TblMobSubmit LEFT JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID LEFT JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID LEFT JOIN TblMobReturn ON TblMobSubmit.SubmitedID = TblMobReturn.SubmitedID WHERE TblMobSubmit.RepairStatus = 'Work in progress or Pending' ";
                else if (opType == 5)
                    strSQL = "SELECT TblMobSubmit.SubmitedID, TblMobSubmit.MobID, TblCustMob.CustID, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustMob.MobCompany, TblCustMob.MobModel, TblMobSubmit.SubmitedDate, TblMobSubmit.ProblemDesc, TblMobSubmit.RepairStatus, TblMobReturn.ReturnedID, TblMobReturn.RepairDesc, TblMobReturn.ReturnedDate, TblMobReturn.TotalBillAmt FROM TblMobSubmit LEFT JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID LEFT JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID LEFT JOIN TblMobReturn ON TblMobSubmit.SubmitedID = TblMobReturn.SubmitedID WHERE TblMobSubmit.RepairStatus = 'Repair not possible' ";
                else if (opType == 6)
                    strSQL = "SELECT TblMobSubmit.SubmitedID, TblMobSubmit.MobID, TblCustMob.CustID, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustMob.MobCompany, TblCustMob.MobModel, TblMobSubmit.SubmitedDate, TblMobSubmit.ProblemDesc, TblMobSubmit.RepairStatus, TblMobReturn.ReturnedID, TblMobReturn.RepairDesc, TblMobReturn.ReturnedDate, TblMobReturn.TotalBillAmt FROM TblMobSubmit LEFT JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID LEFT JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID LEFT JOIN TblMobReturn ON TblMobSubmit.SubmitedID = TblMobReturn.SubmitedID WHERE TblMobSubmit.RepairStatus = 'Handset repaired but customer not pickup' ";
                else if (opType == 7)
                    strSQL = "SELECT TblMobSubmit.SubmitedID, TblMobSubmit.MobID, TblCustMob.CustID, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustMob.MobCompany, TblCustMob.MobModel, TblMobSubmit.SubmitedDate, TblMobSubmit.ProblemDesc, TblMobSubmit.RepairStatus, TblMobReturn.ReturnedID, TblMobReturn.RepairDesc, TblMobReturn.ReturnedDate, TblMobReturn.TotalBillAmt FROM TblMobSubmit LEFT JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID LEFT JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID LEFT JOIN TblMobReturn ON TblMobSubmit.SubmitedID = TblMobReturn.SubmitedID WHERE TblMobSubmit.RepairStatus = 'Handset delivered' ";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 3)
                    objCmd.Parameters.AddWithValue("@CustID", CBSearch.SelectedValue);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                if (objDS.Tables[0].Rows.Count > 0)
                {
                    if (opType == 1)
                    {
                        CBSearch.DataSource = objDS.Tables[0];
                        CBSearch.DisplayMember = "CustFullName";
                        CBSearch.ValueMember = "CustID";
                    }
                    else if (opType == 2)
                    {
                        CBSearch.DataSource = objDS.Tables[0];
                        CBSearch.DisplayMember = "CustMobileNo";
                        CBSearch.ValueMember = "CustID";
                    }
                    else if (opType == 3 || opType == 4 || opType == 5 || opType == 6 || opType == 7)
                    {
                        DGVSearch.DataSource = objDS.Tables[0];
                        foreach (DataGridViewRow Myrow in DGVSearch.Rows)
                        {            //Here 2 cell is target value and 1 cell is Volume
                            if (Myrow.Cells["RepairStatus"].Value.ToString() == "Repair not possible")// Or your condition 
                            {
                                Myrow.DefaultCellStyle.BackColor = Color.Red;
                            }
                            else if(Myrow.Cells["RepairStatus"].Value.ToString() == "Handset delivered")
                            {
                                Myrow.DefaultCellStyle.BackColor = Color.Green;
                            }
                            else if (Myrow.Cells["RepairStatus"].Value.ToString() == "Handset repaired but customer not pickup")
                            {
                                Myrow.DefaultCellStyle.BackColor = Color.Yellow;
                            }
                            else if (Myrow.Cells["RepairStatus"].Value.ToString() == "Work in progress or Pending")
                            {
                                Myrow.DefaultCellStyle.BackColor = Color.White;
                            }
                        }
                    }
                }
                else
                {
                    DGVSearch.DataSource = null;
                    MessageBox.Show("No records found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void CBSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSearchBy.SelectedIndex == 1)
            {
                getData(1);
            }
            else if (CBSearchBy.SelectedIndex == 2)
            {
                getData(2);
            }
            else if (CBSearchBy.SelectedIndex == 3)
            {
                getData(4);
            }
            else if (CBSearchBy.SelectedIndex == 4)
            {
                getData(5);
            }
            else if (CBSearchBy.SelectedIndex == 5)
            {
                getData(6);
            }
            else if (CBSearchBy.SelectedIndex == 6)
            {
                getData(7);
            }
        }

        private void PBSearch_Click(object sender, EventArgs e)
        {
            if (CBSearchBy.SelectedIndex == 1 || CBSearchBy.SelectedIndex == 2)
            {
                getData(3);
            }
            else if (CBSearchBy.SelectedIndex == 3)
            {
                getData(4);
            }
            else if (CBSearchBy.SelectedIndex == 4)
            {
                getData(5);
            }
            else if (CBSearchBy.SelectedIndex == 5)
            {
                getData(6);
            }
            else if (CBSearchBy.SelectedIndex == 6)
            {
                getData(7);
            }
        }
    }
}
