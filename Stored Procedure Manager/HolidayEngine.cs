using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.IntegrationServices;

namespace Stored_Procedure_Manager
{
    public partial class HolidayEngine : Form
    {

        // SQL Connection that can be used throughout the Form
        SqlConnection cnAMDB = new SqlConnection
            (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString
            );

        public HolidayEngine()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cnAMDB = new SqlConnection
                        (
                        "server="
                        + Properties.Settings.Default.ServerNameString
                        + "\\" + Properties.Settings.Default.InstanceString
                        + ";database= AutomationManager"
                        + ";uid=" + Properties.Settings.Default.UserNameString
                        + ";pwd=" + Properties.Settings.Default.PasswordString
                        ))
                {
                    cnAMDB.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Connection - Please Update Database Connection Information");
            }
            finally
            {
                LoadPayPolicyNames();
            }
        }

        private void LoadPayPolicyNames() // Need Try statements
        {
            DataTable dtb1 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb1 = new SqlCommand("SELECT PayPolicyName FROM CT_HolidayEngine", cnAMDB);
            SqlDataAdapter sqlDab1 = new SqlDataAdapter(sqlcmdb1);
            sqlDab1.Fill(dtb1);
            for (int i = 0; i < dtb1.Rows.Count; i++)
            {
                this.HolidayEngineComboBox.Text = "Select Pay Policy";
                this.HolidayEngineComboBox.Items.Add(dtb1.Rows[i]["PayPolicyName"]);

            }
            cnAMDB.Close();
        }

        private void HolidayEngineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlcmdhc = new SqlCommand("SELECT * FROM CT_HolidayEngine where PayPolicyName = '" + HolidayEngineComboBox.Text + "'", cnAMDB);
            cnAMDB.Open();
            sqlcmdhc.ExecuteNonQuery();
            SqlDataReader sqldr;
            sqldr = sqlcmdhc.ExecuteReader();
            while (sqldr.Read())
            {
                string PayPolicyName = (string)sqldr["PayPolicyName"].ToString();
                PayPolicyNameTextBox.Text = PayPolicyName;

                string HolidayPayCode = (string)sqldr["HolidayPayCode"].ToString();
                HolidayPayCodeTextBox.Text = HolidayPayCode;

                string HolidayComment = (string)sqldr["HolidayComment"].ToString();
                HolidayCommentTextBox.Text = HolidayComment;

                string Hours = (string)sqldr["Amount"].ToString();
                HoursTextBox.Text = Hours;

                string FutureDays = (string)sqldr["FutureDays"].ToString();
                FutureDaysTextBox.Text = FutureDays;

                string ProbationDays = (string)sqldr["ProbationDays"].ToString();
                ProbationDaysTextBox.Text = ProbationDays;

                string ProbationMonths = (string)sqldr["ProbationMths"].ToString();
                ProbationMonthsTextBox.Text = ProbationMonths;

                string Exception = (string)sqldr["Exception"].ToString();
                ExceptionsTextBox.Text = Exception;

                this.DayBeforeCheckBox.Checked = (bool)sqldr["DayBefore"];

                this.DayAfterCheckBox.Checked = (bool)sqldr["DayAfter"];

                this.TowardOTCheckBox.Checked = (bool)sqldr["CountOT"];

                this.TowardHolidayCheckBox.Checked = (bool)sqldr["CountHoliday"];

                this.ApplyRateCheckBox.Checked = (bool)sqldr["ApplyExpRate"];
            }
            cnAMDB.Close();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {

            string PayPolicyName = PayPolicyNameTextBox.Text;
            string HolidayPayCode = HolidayPayCodeTextBox.Text;
            string HolidayComment = HolidayCommentTextBox.Text;
            string Hours = HoursTextBox.Text;
            string FutureDays = FutureDaysTextBox.Text;
            string ProbationDays = ProbationDaysTextBox.Text;
            string ProbationMonths = ProbationMonthsTextBox.Text;
            bool DayBefore = DayBeforeCheckBox.Checked;
            bool DayAfter = DayAfterCheckBox.Checked;
            bool TowardOT = TowardOTCheckBox.Checked;
            bool TowardHoliday = TowardHolidayCheckBox.Checked;
            bool ApplyRate = ApplyRateCheckBox.Checked;
            string Exception = ExceptionsTextBox.Text;

            string InsertStatement =
                "If " +
                    "(NOT exists " +
                        "(select * from [dbo].[CT_HolidayEngine] where PayPolicyName = PayPolicyName)) " +
                "BEGIN " +
                    "INSERT INTO CT_HolidayEngine " +
                    "([PayPolicyName],[HolidayPayCode],[Amount],[FutureDays],[HolidayComment],[ProbationDays],[ProbationMths],[DayBefore],[DayAfter],[ApplyExpRate],[CountOT],[CountHoliday],[Exception]) " +
                    "VALUES " +
                    "('" + PayPolicyName + "', '" + HolidayPayCode + "', '" + Hours + "', '" + FutureDays + "', '" + HolidayComment + "', '" + ProbationDays + "', '" + ProbationMonths + "', '" + DayBefore + "', '" + DayAfter + "', '" + ApplyRate + "', '" + TowardOT + "', '" + TowardHoliday + "', '" + Exception + "') " +
                "END " +
                "ELSE " +
                "BEGIN " +
                    "UPDATE CT_HolidayEngine " +
                    "set " +
                    "PayPolicyName = '" + PayPolicyName + "', " +
                    "HolidayPayCode = '" + HolidayPayCode + "', " +
                    "Amount = '" + Hours + "', " +
                    "FutureDays = '" + FutureDays + "', " +
                    "HolidayComment = '" + HolidayComment + "', " +
                    "ProbationDays = '" + ProbationDays + "', " +
                    "ProbationMths = '" + ProbationMonths + "', " +
                    "DayBefore = '" + DayBefore + "', " +
                    "DayAfter = '" + DayAfter + "', " +
                    "ApplyExpRate = '" + ApplyRate + "', " +
                    "CountOT = '" + TowardOT + "', " +
                    "CountHoliday = '" + TowardHoliday + "', " +
                    "Exception = '" + Exception + "'" +
                    "WHERE " +
                    "PayPolicyName = '" + PayPolicyName + "'" +
                "END";

            using (SqlCommand SaveButtonCMD = new SqlCommand(InsertStatement, cnAMDB))
            {
                try
                {
                    cnAMDB.Open();
                    SaveButtonCMD.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "?");
                }
                finally
                {
                    MessageBox.Show("Record updated");
                }
            }
            cnAMDB.Close();
        }
    }
}
