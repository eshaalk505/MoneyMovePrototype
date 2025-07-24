using MoneyMovePrototype.System_Admin_Functionality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMovePrototype.System_User_Functionality
{
    public partial class VerifyOTP : Form
    {
        OTPMethods otpmethods = new OTPMethods();
        string otpCode;
        string receiverEmail;
        public VerifyOTP()
        {
            InitializeComponent();
            otpCode=otpmethods.GenerateCode();
            receiverEmail = otpmethods.RetrieveEmailOfUser(SessionManager.Instance._idOfUser);
            otpmethods.SendEmail(receiverEmail, otpCode);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            bool isOTPCorrect=otpmethods.IsOTPCorrect(otpCode,txtEnteredOTP.Text);
            if (isOTPCorrect)
            {
                MessageBox.Show("Verified successfully!");
                FormManagement.NavigateToNextForm(this, new SystemUserDashboard());
            }
            else
            {
                MessageBox.Show("Incorrect code, please try again");
                FormManagement.MoveBackToPreviousForm(this, new SystemUserLoginPage());
            }
        }
    }
}
