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
    }
}
