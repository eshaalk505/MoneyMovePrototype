using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMovePrototype
{
    public class InformationManagementMethods
    {
        protected string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";

        public int getIDFromUserName(string username)
        {
            string query = @"SELECT ID FROM dbo.[UserDetailsTable] WHERE Username = @username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    string ID = result.ToString();
                    int IDToReturn = Convert.ToInt32(ID);
                    return IDToReturn;
                }
            }
        }

        public string getForenameFromID(int userID)
        {
            string query = @"SELECT Forename FROM dbo.[UserDetailsTable] WHERE ID = @userID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);

                    object result = cmd.ExecuteScalar();

                    string forename = result.ToString();
                    return forename;
                }
            }
        }

        public string getSurnameFromID(int userID)
        {
            string query = @"SELECT Surname FROM dbo.[UserDetailsTable] WHERE ID = @userID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);

                    object result = cmd.ExecuteScalar();

                    string surname = result.ToString();
                    return surname;
                }
            }
        }
    }
}
