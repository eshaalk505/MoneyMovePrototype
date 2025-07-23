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

namespace MoneyMovePrototype.System_Admin_Functionality
{
    public partial class ViewTransactionHistory : Form
    {
        string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";

        public List<string> loadUsers()
        {
            //NEEDS FINISHING
            List<string> users = new List<string>();
            string queryToRetrieveAccounts = "SELECT [Forename] AND [Surname] FROM dbo.[UserDetailsTable]";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryToRetrieveAccounts, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(reader.GetString(0));
                    }
                }
                con.Close();
                return users;
            }
        }

        public ViewTransactionHistory()
        {
            InitializeComponent();
        }

        private void ViewTransactionHistory_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> users = loadUsers();
                users.Add("All");
                if (users.Count != 0)
                {
                    cmbFilters.Items.Clear();
                    cmbFilters.Items.AddRange(users.ToArray());
                    cmbFilters.Items.Clear();
                    cmbFilters.Items.AddRange(users.ToArray());
                }
                else
                {
                    MessageBox.Show("No transaction history for this user");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
