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
            lblErrorsAndWarnings.Hide();
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

        private bool CheckIfFundsAvailable()
        {
            int userID=SessionManager.Instance._idOfUser;
            decimal amountEntered = Convert.ToDecimal(txtAmountToTransfer.Text);
            decimal amountInSource;
            //retrieve amount in selected source account
            string queryToRetrieveBalanceInSource = "SELECT [Balance In Currency] FROM dbo.[CurrencyAccountsToUsersTable] WHERE [User ID]=@uid AND [Account Name]=@an";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(queryToRetrieveBalanceInSource, con);
                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.Parameters.AddWithValue("@an", cmbSourceAccounts.Text);
                    object result = cmd.ExecuteScalar();
                    con.Close();
                    amountInSource = Convert.ToDecimal(result);
                }
                if (amountInSource < amountEntered)
                {
                    lblErrorsAndWarnings.Show();
                    lblErrorsAndWarnings.Text = "ERROR: your source account does not have sufficient funds for this transaction";
                    return false;
                }
                else if (amountInSource == amountEntered)
                {
                    lblErrorsAndWarnings.Hide();
                    DialogResult result = MessageBox.Show("Upon completing this transaction, your source account will have no remaining funds. Are you sure you would like to proceed?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        return true;
                    }
                    else
                    {
                        lblErrorsAndWarnings.Hide();
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }
        }
        private void ConvertCurrency()
        {
            int caid;
            decimal amountToConvert=Convert.ToDecimal(txtAmountToTransfer.Text);
            decimal multiplierForSourceAccountAmount;
            string queryToGetCAID = "SELECT [Currency Account ID] FROM dbo.[CurrencyAccountsToUsersTable] WHERE [User ID] = @uid AND [Account Name]=@an";
            string queryToGetSourceAccountCurrency = "SELECT [Equivalence to 1GBP] FROM dbo.[CurrencyAccountsTable] WHERE [ID]=@caid";
            try
            {
                //get currency of source account
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(queryToGetCAID, con);
                    cmd.Parameters.AddWithValue("@uid", SessionManager.Instance._idOfUser);
                    cmd.Parameters.AddWithValue("@an", cmbSourceAccounts.Text);
                    object result = cmd.ExecuteScalar();
                    caid = (int)result;
                    SqlCommand cmd2 = new SqlCommand(queryToGetSourceAccountCurrency, con);
                    cmd2.Parameters.AddWithValue("@caid", caid);
                    object result2 = cmd2.ExecuteScalar();
                    multiplierForSourceAccountAmount = Convert.ToDecimal(result2);
                    con.Close();
                }
                
                //convert amount being transferred out of source account into GBP (amount being transferred in GBP)
                decimal amountBeingTransferredinGBP = amountToConvert / multiplierForSourceAccountAmount;

                //get currency of target account
                int caid2;
                decimal amountToConvert2 = Convert.ToDecimal(txtAmountToTransfer.Text);
                decimal multiplierForTargetAccountAmount;
                string queryToGetCAID2 = "SELECT [Currency Account ID] FROM dbo.[CurrencyAccountsToUsersTable] WHERE [User ID] = @uid AND [Account Name]=@an";
                string queryToGetTargetAccountCurrency = "SELECT [Equivalence to 1GBP] FROM dbo.[CurrencyAccountsTable] WHERE [ID]=@caid2";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd3 = new SqlCommand(queryToGetCAID2, con);
                    cmd3.Parameters.AddWithValue("@uid", SessionManager.Instance._idOfUser);
                    cmd3.Parameters.AddWithValue("@an", cmbTargetAccounts.Text);
                    object result3 = cmd3.ExecuteScalar();
                    caid2 = (int)result3;
                    SqlCommand cmd4 = new SqlCommand(queryToGetTargetAccountCurrency, con);
                    cmd4.Parameters.AddWithValue("@caid2", caid2);
                    object result4 = cmd4.ExecuteScalar();
                    multiplierForTargetAccountAmount = Convert.ToDecimal(result4);
                    con.Close();
                }
                //convert amount being transferred (in GBP format) into currency of target account
                decimal amountBeingTransferredInTargetAccountCurrency = amountBeingTransferredinGBP * multiplierForTargetAccountAmount;
                decimal finalAmount = Math.Round(amountBeingTransferredInTargetAccountCurrency, 2);
                txtAmountInTarget.Text = Convert.ToString(finalAmount);
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex));
            } 
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

        private void btnTransferFunds_Click(object sender, EventArgs e)
        {

        }

        private void btnPreviewAmount_Click(object sender, EventArgs e)
        {
            bool areFundsSufficienct = CheckIfFundsAvailable();
            if (areFundsSufficienct)
            {
                ConvertCurrency();
            }
        }
    }
}
