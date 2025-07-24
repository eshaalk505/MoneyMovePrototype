using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MoneyMovePrototype.System_Admin_Functionality
{
    public class OTPMethods
    {
        string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";
        public string GenerateCode()
        {
            Random rnd = new Random();
            string code = rnd.Next(100000,999999).ToString();
            return code;
        }

        public string RetrieveEmailOfUser(int userID)
        {
            string query = "SELECT [Username] FROM dbo.[UserDetailsTable] WHERE [ID] = @id";
            string email="Error";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id",userID);
                    email = Convert.ToString(cmd.ExecuteScalar());
                }
                return email;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return email;
            }
        }
        public void SendEmail(string receiverEmail, string code)
        {
            string appPassword = "xbom fyin fcsr blau";
            MailMessage email= new MailMessage("eshaalk505@gmail.com",receiverEmail);
            email.Subject = "Your One-Time Password for MoneyMove";
            email.Body = "Your OTP to access MoneyMove is " + code;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
            smtpClient.Credentials = new NetworkCredential("eshaalk505@gmail.com", appPassword);
            smtpClient.EnableSsl = true;
            smtpClient.Send(email);
        }

        public bool IsOTPCorrect(string expectedOTP, string enteredOTP)
        {
            if (expectedOTP==enteredOTP)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
