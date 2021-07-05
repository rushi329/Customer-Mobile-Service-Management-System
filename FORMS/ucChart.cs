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
    public partial class ucChart : UserControl
    {
        public ucChart()
        {
            InitializeComponent();
        }

        private void ucChart_Load(object sender, EventArgs e)
        {

        }
        private void getData(int opType)
        {
            try
            {
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
                string strSQL = "";
                if (opType == 1)
                    strSQL = "SELECT MONTH(ReturnedDate) AS MONTH, SUM(TotalBillAmt) AS TotalBillAmt FROM TblMobReturn GROUP BY MONTH(ReturnedDate)";
                else if (opType == 2)
                    strSQL = "SELECT YEAR(ReturnedDate) AS MONTH, SUM(TotalBillAmt) AS TotalBillAmt FROM TblMobReturn GROUP BY YEAR(ReturnedDate)";
                else if (opType == 3)
                    strSQL = "SELECT MONTH(ReturnedDate) AS MONTH, COUNT(TotalBillAmt) AS TotalBillAmt FROM TblMobReturn GROUP BY MONTH(ReturnedDate)";
                else if (opType == 4)
                    strSQL = "SELECT YEAR(ReturnedDate) AS MONTH, COUNT(TotalBillAmt) AS TotalBillAmt FROM TblMobReturn GROUP BY YEAR(ReturnedDate)";

                SqlCommand objCmd = new SqlCommand(strSQL, objCon);
                SqlDataAdapter objSDA = new SqlDataAdapter(objCmd);
                DataSet objDS = new DataSet();
                objSDA.Fill(objDS);
                if (objDS.Tables[0].Rows.Count > 0)
                {
                    chartData.Titles.Clear();
                    if (opType == 1 || opType == 3)
                    {
                        chartData.Titles.Add("Monthly Bill Amt");
                    }
                    else if (opType == 2 || opType == 4)
                    {
                        chartData.Titles.Add("Yearly Bill Amt");
                    }
                    chartData.DataSource = objDS.Tables[0];
                    chartData.Series["DATA"].XValueMember = "MONTH";
                    chartData.Series["DATA"].YValueMembers = "TotalBillAmt";

                }
                else
                {
                    chartData.DataSource = null;
                    MessageBox.Show("No records found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CBSearchBy.SelectedIndex == 1)
            {
                getData(1);
            }
            else if (CBSearchBy.SelectedIndex == 2)
            {
                getData(2);
            }
            BtnSave.BackColor = ColorTranslator.FromHtml("#BB86FC");
            BtnTotalCust.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BtnTotalCust_Click(object sender, EventArgs e)
        {
            if (CBSearchBy.SelectedIndex == 1)
            {
                getData(3);
            }
            else if (CBSearchBy.SelectedIndex == 2)
            {
                getData(4);
            }
            BtnSave.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnTotalCust.BackColor = ColorTranslator.FromHtml("#BB86FC");
        }

        private void chartData_Click(object sender, EventArgs e)
        {

        }
    }
}
