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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MoneyMovePrototype
{
    public partial class ManageSuspiciousCaseDetails : Form
    {
        string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";

        public ManageSuspiciousCaseDetails(SuspiciousCase selectedCase)
        {
            InitializeComponent();
            pbxBackToDashboard.Image = Image.FromFile(@"arrow.png");
            lblID.Text = Convert.ToString(selectedCase.caseID);
            txtAccountProvider.Text=Convert.ToString(selectedCase.customerForename)+" "+Convert.ToString(selectedCase.customerSurname);
            cmbCaseStatus.Text=Convert.ToString(selectedCase.caseStatus);
            cmbReason.Text=Convert.ToString(selectedCase.reason);
            txtCustID.Text = Convert.ToString(selectedCase.caseID);
            if (selectedCase.evidenceProvided==false)
            {
                cmbEvidence.Text = "No";
            }
            else
            {
                cmbEvidence.Text = "Yes";
            }
            cmbRefundStatus.Text=Convert.ToString(selectedCase.refundStatus);
            cmbAccStatus.Text=Convert.ToString(selectedCase.userAccountStatus);
            rtbNotes.Text = Convert.ToString(selectedCase.additionalInfo);
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            string queryToUpdateCase = "UPDATE dbo.[SuspiciousTransactions] SET [Status]=@st,[Reason for Suspicion]=@rs,[Evidence Provided]=@ep,[Refund Status]=@rfds,[User Account Status]=@uas,[Additional Notes]=@an WHERE [ID]=@caseID";
            bool updatedEvidenceStatus;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryToUpdateCase, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@caseID", Convert.ToInt32(lblID.Text));
                    cmd.Parameters.AddWithValue("@st", Convert.ToString(cmbCaseStatus.Text));
                    cmd.Parameters.AddWithValue("@rs", Convert.ToString(cmbReason.Text));
                    cmd.Parameters.AddWithValue("@rfds", Convert.ToString(cmbRefundStatus.Text));
                    cmd.Parameters.AddWithValue("@uas", Convert.ToString(cmbAccStatus.Text));
                    cmd.Parameters.AddWithValue("an", Convert.ToString(rtbNotes.Text));
                    if (cmbEvidence.Text == "Yes")
                    {
                        updatedEvidenceStatus = true;
                    }
                    else
                    {
                        updatedEvidenceStatus = false;
                    }
                    cmd.Parameters.AddWithValue("@ep", updatedEvidenceStatus);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            MessageBox.Show("Update complete!");
            FormManagement.MoveBackToPreviousForm(this, new SystemAdminDashboard());
        }

        private void pbxBackToDashboard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to proceed? Any unsaved changes will be lost.", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new SystemAdminDashboard());
            }
        }

        private bool HasEvidenceBeenRequested()
        {
            //ADD TO DATABASE
            string queryToCheck = "SELECT [Evidence Requested] FROM dbo.[SuspiciousTransactions] WHERE ID=@caseID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryToCheck, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@caseID", Convert.ToInt32(lblID.Text));
                    object result =cmd.ExecuteScalar();
                    bool evidenceRequested=Convert.ToBoolean(result);
                    con.Close();
                    if (evidenceRequested)
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

        private void SendEvidenceRequest()
        {
            string queryToSendRequest = "UPDATE dbo.[SuspiciousTransactions] SET [Status]=@st,[Reason for Suspicion]=@rs,[Evidence Provided]=@ep,[Refund Status]=@rfds,[User Account Status]=@uas,[Additional Notes]=@an WHERE [ID]=@caseID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryToSendRequest, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@caseID", Convert.ToInt32(lblID.Text));
                    cmd.Parameters.AddWithValue("@caseID", Convert.ToInt32(lblID.Text));
                    cmd.Parameters.AddWithValue("@st", Convert.ToString(cmbCaseStatus.Text));
                    cmd.Parameters.AddWithValue("@rs", Convert.ToString(cmbReason.Text));
                    cmd.Parameters.AddWithValue("@rfds", Convert.ToString(cmbRefundStatus.Text));
                    cmd.Parameters.AddWithValue("@uas", Convert.ToString(cmbAccStatus.Text));
                    cmd.Parameters.AddWithValue("an", Convert.ToString(rtbNotes.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Evidence request has been sent! Please await a response from the customer");
        }
        private void btnSendEvidenceRequest_Click(object sender, EventArgs e)
        {
            bool evidenceRequested = HasEvidenceBeenRequested();
            if (evidenceRequested)
            {
                MessageBox.Show("An evidence request for this case has already been sent - you cannot send another");
            }
            else
            {
                SendEvidenceRequest();
            }
        }

        private bool CheckIfUserIsAlreadyBlocked()
        {
            string verificationQuery = "SELECT [IsAccountBlocked] FROM dbo.[UserDetailsTable] WHERE [ID]=@id";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(verificationQuery, con);
                cmd.Parameters.AddWithValue("@id",Convert.ToInt32(txtCustID.Text));
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    bool isAccountBlocked = Convert.ToBoolean(result);
                    return isAccountBlocked;
                }
                return false;
            }
        }
        private void btnBlockUser_Click(object sender, EventArgs e)
        {
            bool isUserAlreadyBlocked = CheckIfUserIsAlreadyBlocked();
            if (isUserAlreadyBlocked)
            {
                MessageBox.Show("User is already blocked, they cannot be blocked again");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you would like to block this user? They will not be able to access their account", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string queryToBlockUser = "UPDATE dbo.[UserDetailsTable] SET [IsAccountBlocked]=@isBlocked WHERE [ID]=@id";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(queryToBlockUser, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtCustID.Text));
                            cmd.Parameters.AddWithValue("@isBlocked", true);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    MessageBox.Show("User has been blocked successfully");
                    FormManagement.MoveBackToPreviousForm(this, new SystemAdminDashboard());
                }
            }
        }

        private void btnUnblockUser_Click(object sender, EventArgs e)
        {
            bool isUserAlreadyBlocked = CheckIfUserIsAlreadyBlocked();
            if (!isUserAlreadyBlocked)
            {
                MessageBox.Show("User is already unblocked");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you would like to unblock this user?", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string queryToUnblockUser = "UPDATE dbo.[UserDetailsTable] SET [IsAccountBlocked]=@isBlocked WHERE [ID]=@id";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(queryToUnblockUser, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtCustID.Text));
                            cmd.Parameters.AddWithValue("@isBlocked", false);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    MessageBox.Show("User has been unblocked successfully");
                    FormManagement.MoveBackToPreviousForm(this, new SystemAdminDashboard());
                }
            }
        }
    }
}
