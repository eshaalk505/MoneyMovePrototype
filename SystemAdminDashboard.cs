using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMovePrototype
{
    public partial class SystemAdminDashboard : Form
    {
        public SystemAdminDashboard()
        {
            InitializeComponent();
            lblWelcomeDashboard.Text = "Welcome back " + SessionManager.Instance._forenameOfUser + "!";
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure you want to log out? Any unsaved changes will be lost and the site will close down.", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                SessionManager.Instance.FinishSession();
            }
        }

        private void aboutMoneyMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new AboutMoneyMove());
        }

        private void viewCaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyAccount accountToView = new CurrencyAccount(Convert.ToString(dgvSusCases.SelectedCells[0].Value), Convert.ToString(dgvSusCases.SelectedCells[1].Value), Convert.ToString(dgvSusCases.SelectedCells[2].Value), Convert.ToDecimal(dgvSusCases.SelectedCells[3].Value));

            SuspiciousCase selectedCase = new SuspiciousCase(Convert.ToInt32(dgvSusCases.SelectedCells[0].Value), Convert.ToInt32(dgvSusCases.SelectedCells[1].Value), Convert.ToString(dgvSusCases.SelectedCells[2].Value), Convert.ToString(dgvSusCases.SelectedCells[3].Value), Convert.ToBoolean(dgvSusCases.SelectedCells[4].Value), Convert.ToString(dgvSusCases.SelectedCells[5].Value), Convert.ToString(dgvSusCases.SelectedCells[6].Value), Convert.ToString(dgvSusCases.SelectedCells[7].Value));
            FormManagement.NavigateToNextForm(this,new ManageSuspiciousCaseDetails(selectedCase));
        }
    }
}
