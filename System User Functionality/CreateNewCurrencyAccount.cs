using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMovePrototype
{
    public partial class CreateNewCurrencyAccount : Form
    {
        string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";
        public CreateNewCurrencyAccount()
        {
            InitializeComponent();
            pbxBackToDashboard.Image = Image.FromFile(@"arrow.png");
        }

        private void createNewAccountRecord(int userID, int currencyAccountID, string accountName, float balance)
        {
            string queryToCreateNewAccount = "INSERT INTO dbo.[CurrencyAccountsToUsersTable] ([User ID],[Currency Account ID],[Account Name],[Balance In Currency]) " +
                "VALUES (@uid,@caid,@an,@bal)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(queryToCreateNewAccount, con);
                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.Parameters.AddWithValue("@caid", currencyAccountID);
                    cmd.Parameters.AddWithValue("@an", accountName);
                    cmd.Parameters.AddWithValue("@bal", balance);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("New account successfully created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = SessionManager.Instance._idOfUser;
                string selectedCurrency = cmbAccountCurrency.SelectedItem.ToString();
                int currencyAccountID;
                float balance = 0;
                string queryToGetCurrencyID = "SELECT ID FROM dbo.[CurrencyAccountsTable] WHERE Currency=@currency";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(queryToGetCurrencyID, con);
                    cmd.Parameters.AddWithValue("@currency", selectedCurrency);
                    object result = cmd.ExecuteScalar();
                    currencyAccountID = Convert.ToInt32(result);
                    con.Close();
                }
                createNewAccountRecord(userID, currencyAccountID, txtAccountName.Text, balance);

            }
            catch (Exception)
            {

                MessageBox.Show("Error creating account. Please check the entered details and connection and try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxBackToDashboard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to proceed? Any unsaved changes will be lost.", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new SystemUserDashboard());
            }
        }
    }
}
