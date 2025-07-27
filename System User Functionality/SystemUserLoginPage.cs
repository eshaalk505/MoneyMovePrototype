using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MoneyMovePrototype.System_User_Functionality;

namespace MoneyMovePrototype
{
    public partial class SystemUserLoginPage : Form
    {
        InformationManagementMethods informationManagementMethods = new InformationManagementMethods();
        public SystemUserLoginPage()
        {
            InitializeComponent();
        }

        private void SystemUserLoginPage_Load(object sender, EventArgs e)
        {
            pbxSystemUser.Image = Image.FromFile(@"systemUser.png");
            pbxBackToWelcomePage.Image = Image.FromFile(@"arrow.png");
        }

        private bool CheckIfAccountHasBeenBlocked(string username)
        {
            string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";
            string verificationQuery = "SELECT [IsAccountBlocked] FROM dbo.[UserDetailsTable] WHERE Username=@un";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(verificationQuery, con);
                cmd.Parameters.AddWithValue("@un", username);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    bool isAccountBlocked =Convert.ToBoolean(result);
                    return isAccountBlocked;
                }
                return false;
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password=txtPassword.Text.Trim();
            string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";
            string usernameCountQuery = "SELECT COUNT(*) FROM dbo.[UserDetailsTable] WHERE Username=@username";
            string verificationQuery = "SELECT * FROM dbo.[UserDetailsTable] WHERE Username= '" + username + "' AND Password='" + password + "'";
            string roleVerificationQuery = @"SELECT IsSystemAdministrator FROM dbo.[UserDetailsTable] WHERE Username = @Username AND Password = @Password";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(usernameCountQuery, conn);
                cmd.Parameters.AddWithValue("@username", username);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount == 0)
                {
                    MessageBox.Show("Username does not exist, pleasy try again");
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand(verificationQuery, conn);
                    using (SqlConnection conn2 = new SqlConnection(connectionString))
                    {
                        object result = cmd2.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Login failed, please check details again");
                        }
                        else
                        {
                            using (SqlConnection conn3 = new SqlConnection(connectionString))
                            {
                                conn3.Open();
                                using (SqlCommand cmd3 = new SqlCommand(roleVerificationQuery, conn3))
                                {
                                    cmd3.Parameters.AddWithValue("@Username", username);
                                    cmd3.Parameters.AddWithValue("@Password", password);

                                    object result2 = cmd3.ExecuteScalar();

                                    if (result2 != null)
                                    {
                                        bool isAdmin = Convert.ToBoolean(result2);

                                        if (isAdmin == true)
                                        {
                                            MessageBox.Show("You are a system administrator. Please use the relevant portal");
                                        }
                                        else
                                        {
                                            //Login details were correct
                                            bool isAccountBlocked = CheckIfAccountHasBeenBlocked(username);
                                            if (isAccountBlocked)
                                            {
                                                MessageBox.Show("Your account has been blocked by system administration due to failure to provide evidence in a suspicious transaction request. Please contact the details under 'About' for further support.");
                                                this.Close(); // Close the login form
                                            }
                                            else
                                            {
                                                int ID = informationManagementMethods.getIDFromUserName(username);
                                                string forename = informationManagementMethods.getForenameFromID(ID);
                                                string surname = informationManagementMethods.getSurnameFromID(ID);
                                                SessionManager.Instance.CreateSession(ID, username, forename, surname);
                                                FormManagement.NavigateToNextForm(this, new VerifyOTP());
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error checking details, please try again.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void lblGoToOtherPage_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this,new SystemAdminLoginPage());
        }

        private void pbxBackToWelcomePage_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new WelcomeToMoneyMove());
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (btnShowHidePassword.Text=="Show")
            {
                btnShowHidePassword.Text = "Hide";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnShowHidePassword.Text = "Show";
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
