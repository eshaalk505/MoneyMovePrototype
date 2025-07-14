using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMovePrototype
{
    public partial class TransferFunds : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\eshaa\\Documents\\Year 2\\Software Engineering Concepts + Methods\\MoneyMovePrototype\\MoneyMoveDB.mdf\";Integrated Security=True";

        public List<string> loadAccounts()
        {
            int userID=SessionManager.Instance._idOfUser;
            List<string> accounts = new List<string>();
            string queryToRetrieveAccounts = "SELECT [Account Name] FROM dbo.[CurrencyAccountsToUsersTable] WHERE [User ID]=@uid";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryToRetrieveAccounts, con);
                cmd.Parameters.AddWithValue("@uid", userID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accounts.Add(reader.GetString(0));
                    }
                }
                con.Close();
                return accounts;
            }
        }
        public TransferFunds()
        {
            InitializeComponent();
            lblAccountWarning.Text = "WARNING: Source and target accounts cannot be the same." + Environment.NewLine + "Please change one of these to proceed";
            lblAccountWarning.Hide();
            lblAmountToTransfer.Text = "Please specify the amount to transfer" + Environment.NewLine + "in the currency of the SOURCE account:";
            lblAmountReceived.Text = "Amount that will be received" + Environment.NewLine + "in the currenct of the TARGET account:";
            lblTransferFormatWarning.Text = "WARNING: please only use numbers (0-9) and" + Environment.NewLine + "a maximum of 2 decimal places";
            lblTransferFormatWarning.Hide();
        }

        private void TransferFunds_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> accounts = loadAccounts();
                cmbSourceAccounts.Items.Clear();
                cmbSourceAccounts.Items.AddRange (accounts.ToArray());
                cmbTargetAccounts.Items.Clear();
                cmbTargetAccounts.Items.AddRange(accounts.ToArray());

            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void cmbTargetAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cmbSourceAccounts.Text)== Convert.ToString(cmbTargetAccounts.Text))
            {
                btnTransferFunds.Hide();
                lblAccountWarning.Show();
            }
            else
            {
                btnTransferFunds.Show();
                lblAccountWarning.Hide();
            }
        }

        private bool IsValidNumberInput(string input)
        {
            return Regex.IsMatch(input, @"^\d+(\.\d{1,2})?$");
        }

        private void checkIfFundsAvailable()
        {
            decimal amountEntered = Convert.ToDecimal(txtAmountToTransfer.Text);
            //retrieve amount in selected target account
            //do an if statement to compare amount being transferred against balance - if balance is higher then it's fine, if balance is lower then warning, if they're the same then different warning
            //if funda available then run converCurrency
        }
        private void convertCurrency()
        {
            decimal amountToConvert=Convert.ToDecimal(txtAmountToTransfer.Text);
            //get currency of source account
            //convert amount being transferred out of source account into GBP (amount being transferred in GBP)
            //get currenct of target account
            //convert amount being transferred (in GBP format) into currency of target account
        }
        private void txtAmountToTranfer_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidNumberInput(txtAmountToTransfer.Text))
            {
                btnTransferFunds.Hide();
                lblTransferFormatWarning.Show();
            }
            else
            {
                btnTransferFunds.Show();
                lblTransferFormatWarning.Hide();
            }
        }
    }
}
