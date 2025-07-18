using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMovePrototype
{
    public partial class WelcomeToMoneyMove : Form
    {
        public WelcomeToMoneyMove()
        {
            InitializeComponent();
        }

        private void WelcomeToMoneyMove_Load(object sender, EventArgs e)
        {
            pbxMainPagePic.Image = Image.FromFile(@"mainPagePhoto.jpg");
            pbxSystemUser.Image = Image.FromFile(@"systemUser.png");
            pbxSystemAdmin.Image = Image.FromFile(@"systemAdmin.png");
        }

        private void pbxSystemUser_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new SystemUserLoginPage());
        }

        private void pbxSystemAdmin_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new SystemAdminLoginPage());
        }

        private void lblUserAccess_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new SystemUserLoginPage());
        }

        private void lblAdminAccess_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new SystemAdminLoginPage());

        }

        private void aboutMoneyMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this,new AboutMoneyMove(this));
        }
    }
}
