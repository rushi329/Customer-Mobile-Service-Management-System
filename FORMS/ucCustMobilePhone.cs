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
    public partial class ucCustMobilePhone : UserControl
    {
        public ucCustMobilePhone()
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
                    strSQL = "SELECT TblCustMob.MobID, TblCustMob.CustID, TblCustMob.MobCompany, TblCustMob.MobModel, TblCustMob.MobVarient, TblCustMob.MobIMEI1, TblCustMob.MobIMEI2 FROM TblCustMob";
                else if (opType == 2)
                    strSQL = "SELECT TblCustMob.MobID, TblCustMob.CustID, TblCustMob.MobCompany, TblCustMob.MobModel, TblCustMob.MobVarient, TblCustMob.MobIMEI1, TblCustMob.MobIMEI2 FROM TblCustMob WHERE MobID=@MobID";
                else if (opType == 3)
                    strSQL = "select * from TblCustReg";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2)
                    objCmd.Parameters.AddWithValue("@MobID", CBMobSelectEditDelete.SelectedValue);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                if (opType == 1)
                {
                    DGVCustReg.DataSource = objDS.Tables[0];
                    CBMobSelectEditDelete.DataSource = objDS.Tables[0];
                    CBMobSelectEditDelete.DisplayMember = "MobModel";
                    CBMobSelectEditDelete.ValueMember = "MobID";
                }
                else if (opType == 2)
                {
                    CBCustID.SelectedValue = objDS.Tables[0].Rows[0]["CustID"].ToString();
                    TXTMobCompany.Text = objDS.Tables[0].Rows[0]["MobCompany"].ToString();
                    TXTMobModel.Text = objDS.Tables[0].Rows[0]["MobModel"].ToString();
                    TXTMobVar.Text = objDS.Tables[0].Rows[0]["MobVarient"].ToString();
                    TXTMobIMEI1.Text = objDS.Tables[0].Rows[0]["MobIMEI1"].ToString();
                    TXTMobIMEI2.Text = objDS.Tables[0].Rows[0]["MobIMEI2"].ToString();
                }
                else if (opType == 3)
                {
                    CBCustID.DataSource = objDS.Tables[0];
                    CBCustID.DisplayMember = "CustFullName";
                    CBCustID.ValueMember = "CustID";
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
                    strSQL = "INSERT INTO TblCustMob VALUES(@CustID, @MobCompany, @MobModel, @MobVarient, @MobIMEI1, @MobIMEI2)";
                else if (opType == 2)
                    strSQL = "UPDATE TblCustMob set CustID = @CustID, MobCompany = @MobCompany, MobModel = @MobModel, MobVarient = @MobVarient, MobIMEI1 = @MobIMEI1, MobIMEI2 = @MobIMEI2 WHERE MobID = @MobID";
                else if (opType == 3)
                    strSQL = "DELETE FROM TblCustMob WHERE MobID = @MobID";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                if (opType == 2 || opType == 3)
                {
                    objCmd.Parameters.AddWithValue("@MobID", CBMobSelectEditDelete.SelectedValue);
                }
                objCmd.Parameters.AddWithValue("@CustID", CBCustID.SelectedValue);
                objCmd.Parameters.AddWithValue("@MobCompany", TXTMobCompany.Text);
                objCmd.Parameters.AddWithValue("@MobModel", TXTMobModel.Text);
                objCmd.Parameters.AddWithValue("@MobVarient", TXTMobVar.Text);
                objCmd.Parameters.AddWithValue("@MobIMEI1", TXTMobIMEI1.Text);
                objCmd.Parameters.AddWithValue("@MobIMEI2", TXTMobIMEI2.Text);
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
            CBCustID.SelectedIndex = -1;
            CBCustID.Text = "";
            TXTMobCompany.Text = "";
            TXTMobModel.Text = "";
            TXTMobVar.Text = "";
            TXTMobIMEI1.Text = "";
            TXTMobIMEI2.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveData(1);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            saveData(2);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            saveData(3);
        }

        private void ucCustMobilePhone_Load(object sender, EventArgs e)
        {
            getData(1);
            getData(3);
        }

        private void DGVCustReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getData(2);
        }

        private void CBMobSelectEditDelete_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getData(2);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
