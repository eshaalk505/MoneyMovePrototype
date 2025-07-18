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
    public partial class AboutMoneyMove : Form
    {
        private Form _previousForm;
        public AboutMoneyMove(Form previousForm)
        {
            InitializeComponent();
            lblAboutDescription.Text = "MoneyMove, based in the UK, aims to provide money management and transfer services across the world." + Environment.NewLine +
                                     "Inspired by similar platforms such as Revolut, Wise and TransferGo, it allows registered system users" + Environment.NewLine +
                                     "to create multiple accounts in different currencies, facilitating the smooth transferring of money from" + Environment.NewLine +
                                     "one currency to another through accounts in different currencies. With built-in security features, MoneyMove" + Environment.NewLine +
                                     "aims to protect against fraudulent activity by detecting suspicious transactions and handling these accordingly." + Environment.NewLine +
                                     "This project was built as part of the Software Engineering Concepts and Methods assignment as a prototype of a" + Environment.NewLine +
                                     "pre-defined money transfer system specification.";
            _previousForm = previousForm;
            pbxBackToPreviousPage.Image = Image.FromFile(@"arrow.png");
        }

        private void pbxBackToPreviousPage_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, _previousForm);
        }
    }
}
