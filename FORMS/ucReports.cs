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
using Microsoft.Reporting.WinForms;

namespace MobileServiceCenter.FORMS
{
    public partial class ucReports : UserControl
    {
        
        public ucReports()
        {
            InitializeComponent();
        }

        private void getReports(int opType)
        {
            try
            {
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
                string strSQL = "";
                if (opType == 1)
                    strSQL = "SELECT TblUserReg.UserID, TblUserReg.FullName, TblUserReg.UserAddress, TblUserReg.UserDOB, TblUserReg.UserGender, TblUserReg.UserMobileNo, TblUserReg.UserType, TblLogin.UserName, TblLogin.Password, TblLogin.SecurityQuestion, TblLogin.SecurityAnswer, TblLogin.EmailId FROM TblUserReg inner join TblLogin on TblUserReg.UserID = TblLogin.UserID ";
                else if (opType == 2)
                    strSQL = "SELECT CustID, CustFullName, CustMobileNo, CustEmailID, CustAddress, CustAadhaarNo FROM dbo.TblCustReg";
                else if (opType == 3)
                    strSQL = "SELECT TblCustMob.MobID, TblCustMob.CustID, TblCustMob.MobCompany, TblCustMob.MobModel, TblCustMob.MobVarient, TblCustMob.MobIMEI1, TblCustMob.MobIMEI2, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustReg.CustEmailID, TblCustReg.CustAadhaarNo FROM TblCustMob INNER JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID";
                else if (opType == 4)
                    strSQL = "SELECT TblMobSubmit.SubmitedID, TblMobSubmit.MobID, TblMobSubmit.SubmitedDate, TblMobSubmit.ProblemDesc, TblMobSubmit.RepairDate, TblMobSubmit.RepairStatus, TblCustMob.CustID, TblCustMob.MobCompany, TblCustMob.MobModel,TblCustMob.MobVarient, TblCustMob.MobIMEI1, TblCustMob.MobIMEI2, TblCustReg.CustFullName, TblCustReg.CustMobileNo, TblCustReg.CustEmailID, TblCustReg.CustAadhaarNo FROM TblMobSubmit INNER JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID INNER JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID";
                else if (opType == 5)
                    strSQL = "SELECT TblMobReturn.ReturnedID, TblMobReturn.SubmitedID, TblMobReturn.RepairDesc, TblMobReturn.ReturnedDate, TblMobReturn.TotalBillAmt, TblMobSubmit.RepairStatus, TblMobSubmit.RepairDate, TblMobSubmit.ProblemDesc,  TblMobSubmit.SubmitedDate, TblMobSubmit.MobID, TblCustMob.CustID, TblCustMob.MobCompany, TblCustMob.MobModel, TblCustMob.MobVarient, TblCustReg.CustFullName, TblCustReg.CustMobileNo FROM TblMobReturn INNER JOIN TblMobSubmit ON TblMobReturn.SubmitedID = TblMobSubmit.SubmitedID INNER JOIN TblCustMob ON TblMobSubmit.MobID = TblCustMob.MobID INNER JOIN TblCustReg ON TblCustMob.CustID = TblCustReg.CustID";
                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                ReportDataSource objRDS = new ReportDataSource();
                rvReports.LocalReport.DataSources.Clear();
                objRDS.Value = objDS.Tables[0];
                if (opType == 1)
                {
                    objRDS.Name = "DSUser";
                    rvReports.LocalReport.ReportPath = "..\\..\\Reports\\rwUser.rdlc";
                }
                else if (opType == 2)
                {
                    objRDS.Name = "DSCust";
                    rvReports.LocalReport.ReportPath = "..\\..\\Reports\\rwCust.rdlc";
                }
                else if (opType == 3)
                {
                    objRDS.Name = "DSMob";
                    rvReports.LocalReport.ReportPath = "..\\..\\Reports\\rwMob.rdlc";
                }
                else if (opType == 4)
                {
                    objRDS.Name = "DSMobSubmit";
                    rvReports.LocalReport.ReportPath = "..\\..\\Reports\\rwMobSubmit.rdlc";
                }
                else if (opType == 5)
                {
                    objRDS.Name = "DSMobReturn";
                    rvReports.LocalReport.ReportPath = "..\\..\\Reports\\rwMobReturn.rdlc";
                }
                rvReports.LocalReport.DataSources.Add(objRDS);
                rvReports.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void BtnUserReports_Click(object sender, EventArgs e)
        {
            getReports(1);
        }

        private void BtnCustReports_Click(object sender, EventArgs e)
        {
            getReports(2);
        }

        private void BtnCustMobReports_Click(object sender, EventArgs e)
        {
            getReports(3);
        }

        private void BtnCustMobSubReports_Click(object sender, EventArgs e)
        {
            getReports(4);
        }

        private void BtnCustMobReturnReports_Click(object sender, EventArgs e)
        {
            getReports(5);
        }

      
    }
}
