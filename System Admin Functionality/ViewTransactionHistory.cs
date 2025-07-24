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
            List<string> users = new List<string>();
            string queryToRetrieveAccounts = "SELECT [Forename], [Surname] FROM dbo.[UserDetailsTable]";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryToRetrieveAccounts, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string forename = reader.GetString(0);
                        string surname = reader.GetString(1);
                        users.Add(forename + " " + surname);
                    }
                }
                con.Close();
                return users;
            }
        }

        private void LoadDGVData()
        {
            dgvTransactionHistory.DefaultCellStyle.Font = new Font("Candara", 10);
            dgvTransactionHistory.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            dgvTransactionHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Candara", 11, FontStyle.Bold);
            dgvTransactionHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.MidnightBlue;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT [Customer],[Target Account Name],[Source Account Name], [Amount Transferred in Target Account Currency], [Transaction Date] FROM dbo.[TransactionHistoryTable]";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvTransactionHistory.DataSource = table;
                }
            }
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

        public ViewTransactionHistory()
        {
            InitializeComponent();
            LoadDGVData();
        }

        
    }
}
