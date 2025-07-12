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
    public partial class SystemUserDashboard : Form
    {
        public SystemUserDashboard()
        {
            InitializeComponent();
            lblWelcomeDashboard.Text = "Welcome back " + SessionManager.Instance._forenameOfUser + "!";

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out? Any unsaved changes will be lost and the site will close down.", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                SessionManager.Instance.FinishSession();
            }
        }
    }
}
