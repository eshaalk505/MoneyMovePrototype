using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MoneyMovePrototype
{
    public partial class SetDesignatedAccount : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\eshaa\\Documents\\Year 2\\Software Engineering Concepts + Methods\\MoneyMovePrototype\\MoneyMoveDB.mdf\";Integrated Security=True";
        public SetDesignatedAccount()
        {
            InitializeComponent();
            lblOtherAccount.Text = "Please enter the account" + Environment.NewLine + "provider name here:";
            lblExpDateFormat.Text = "Please use the following format:" + Environment.NewLine + "MM/YY e.g. 03/27";
            lblOtherAccount.Hide();
            txtAccountProvider.Hide();
        }

        private void cmbAccountProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cmbAccountProvider.SelectedItem)=="Other")
            {
                lblOtherAccount.Show();
                txtAccountProvider.Show();
            }
            else
            {
                lblOtherAccount.Hide();
                txtAccountProvider.Hide();
            }
        }

        private void AddDesignatedAccountDetails(string provider, string cardnum, string expdate, string name, string cvv)
        {
            string addDetailsQuery = "UPDATE dbo.[UserDetailsTable] SET [DesAccountProvider]=@dap,[CardNumber]=@cn,[ExpDate]=@ed,[NameOnCard]=@noc,[SecCode]=@sc WHERE ID=@userID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(addDetailsQuery, con))
                {
                    cmd.Parameters.AddWithValue("@dap", provider);
                    cmd.Parameters.AddWithValue("@cn", cardnum);
                    cmd.Parameters.AddWithValue("@ed", expdate);
                    cmd.Parameters.AddWithValue("@noc", name);
                    cmd.Parameters.AddWithValue("@sc", cvv);
                    cmd.Parameters.AddWithValue("@userID", SessionManager.Instance._idOfUser);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }

        private void DeleteCurrentDesignatedAccount()
        {
            string deleteDetailsQuery = "UPDATE dbo.[UserDetailsTable] SET [DesAccountProvider]=NULL,[CardNumber]=NULL,[ExpDate]=NULL,[NameOnCard]=NULL,[SecCode]=NULL WHERE ID=@userID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(deleteDetailsQuery, con))
                {
                    cmd.Parameters.AddWithValue("@userID", SessionManager.Instance._idOfUser);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }
        private void btnSetAccount_Click(object sender, EventArgs e)
        {
            string accountProvider;
            if (cmbAccountProvider.Text=="Other")
            {
                accountProvider=txtAccountProvider.Text;
            }
            else
            {
                accountProvider=cmbAccountProvider.Text;
            }
            string checkAccountAlreadyThereQuery = "SELECT [DesAccountProvider] FROM dbo.[UserDetailsTable] WHERE ID=@userID";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(checkAccountAlreadyThereQuery, con);
                    cmd.Parameters.AddWithValue("@userID", SessionManager.Instance._idOfUser);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        DialogResult outcome= MessageBox.Show("Our systems show you have already set a designated bank account. Are you sure you would like to overwrite this?", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (outcome == DialogResult.Yes)
                        {
                            AddDesignatedAccountDetails(accountProvider, txtCardNum.Text, txtExpDate.Text, txtName.Text, txtSec.Text);
                            MessageBox.Show("Designated bank account now amended successfully!");
                        }
                        else
                        {
                            AddDesignatedAccountDetails(accountProvider, txtCardNum.Text, txtExpDate.Text, txtName.Text, txtSec.Text);
                            MessageBox.Show("Designated bank account now added successfully!");
                        }
                    }
                    else
                    {
                        AddDesignatedAccountDetails(accountProvider, txtCardNum.Text, txtExpDate.Text, txtName.Text, txtSec.Text);
                        MessageBox.Show("Designated bank account now added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex));
            }

        }
    }
}
