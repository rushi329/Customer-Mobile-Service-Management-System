using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileServiceCenter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdminRegisteration_Click(object sender, EventArgs e)
        {
            FORMS.ucAdminReg objAR = new FORMS.ucAdminReg();
            GBoxForms.Controls.Clear();
            GBoxForms.Controls.Add(objAR);
            BtnAdminRegisteration.BackColor = ColorTranslator.FromHtml("#BB86FC");
            BTNCustMobPhone.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnRepairStatus.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnCustomerDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReturnDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");            
            BtnSubmitDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSearch.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReports.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnChart.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BtnCustomerDetails_Click(object sender, EventArgs e)
        {
            FORMS.ucCustomerDetails objAR = new FORMS.ucCustomerDetails();
            GBoxForms.Controls.Clear();
            GBoxForms.Controls.Add(objAR);
            BtnAdminRegisteration.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BTNCustMobPhone.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnRepairStatus.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnCustomerDetails.BackColor = ColorTranslator.FromHtml("#BB86FC");
            BtnReturnDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSubmitDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSearch.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReports.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnChart.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BtnSubmitDetails_Click(object sender, EventArgs e)
        {
            FORMS.ucMobSubmit objAR = new FORMS.ucMobSubmit();
            GBoxForms.Controls.Clear();
            GBoxForms.Controls.Add(objAR);
            BtnAdminRegisteration.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BTNCustMobPhone.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnRepairStatus.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnCustomerDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReturnDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSubmitDetails.BackColor = ColorTranslator.FromHtml("#BB86FC");
            BtnSearch.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReports.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnChart.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BtnReturnDetails_Click(object sender, EventArgs e)
        {
            FORMS.ucMobReturn objAR = new FORMS.ucMobReturn();
            GBoxForms.Controls.Clear();
            GBoxForms.Controls.Add(objAR);
            BtnAdminRegisteration.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BTNCustMobPhone.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnCustomerDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnRepairStatus.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReturnDetails.BackColor = ColorTranslator.FromHtml("#BB86FC");
            BtnSubmitDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSearch.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReports.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnChart.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BTNCustMobPhone_Click(object sender, EventArgs e)
        {
            FORMS.ucCustMobilePhone objAR = new FORMS.ucCustMobilePhone();
            GBoxForms.Controls.Clear();
            GBoxForms.Controls.Add(objAR);
            BtnAdminRegisteration.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BTNCustMobPhone.BackColor = ColorTranslator.FromHtml("#BB86FC");
            BtnRepairStatus.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnCustomerDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReturnDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSubmitDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSearch.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReports.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnChart.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FORMS.ucSearch objAR = new FORMS.ucSearch();
            GBoxForms.Controls.Clear();
            GBoxForms.Controls.Add(objAR);
            BtnAdminRegisteration.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BTNCustMobPhone.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnRepairStatus.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnCustomerDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReturnDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSubmitDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSearch.BackColor = ColorTranslator.FromHtml("#BB86FC");
            BtnReports.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnChart.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BtnRepairStatus_Click(object sender, EventArgs e)
        {
            FORMS.ucRepairStatus objAR = new FORMS.ucRepairStatus();
            GBoxForms.Controls.Clear();
            GBoxForms.Controls.Add(objAR);
            BtnAdminRegisteration.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BTNCustMobPhone.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnRepairStatus.BackColor = ColorTranslator.FromHtml("#BB86FC");
            BtnCustomerDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReturnDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSubmitDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSearch.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReports.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnChart.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            FORMS.ucReports objAR = new FORMS.ucReports();
            GBoxForms.Controls.Clear();
            GBoxForms.Controls.Add(objAR);
            BtnAdminRegisteration.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BTNCustMobPhone.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnRepairStatus.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnCustomerDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReturnDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSubmitDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSearch.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReports.BackColor = ColorTranslator.FromHtml("#BB86FC");
            BtnChart.BackColor = ColorTranslator.FromHtml("#7F22FD");
        }

        private void BtnChart_Click(object sender, EventArgs e)
        {
            FORMS.ucChart objAR = new FORMS.ucChart();
            GBoxForms.Controls.Clear();
            GBoxForms.Controls.Add(objAR);
            BtnAdminRegisteration.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BTNCustMobPhone.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnRepairStatus.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnCustomerDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReturnDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSubmitDetails.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnSearch.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnReports.BackColor = ColorTranslator.FromHtml("#7F22FD");
            BtnChart.BackColor = ColorTranslator.FromHtml("#BB86FC");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LblDateTime.Text = DateTime.Now.ToString("dd/MM/yyy ,HH:mm:ss");
        }

        private void LblDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}
