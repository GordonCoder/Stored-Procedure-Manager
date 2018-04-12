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

namespace Stored_Procedure_Manager
{
    public partial class Tools : Form
    {
        // SQL connection to be used 
        SqlConnection cn = new SqlConnection
            (
            "server="
            + Properties.Settings.Default.ServerNameString
            + "\\" + Properties.Settings.Default.InstanceString
            + ";database=" + Properties.Settings.Default.DatabaseString
            + ";uid=" + Properties.Settings.Default.UserNameString
            + ";pwd=" + Properties.Settings.Default.PasswordString
            );

        SqlCommand cmd = new SqlCommand();

        public Tools()
        {
            InitializeComponent();
            try
            {
                using (SqlConnection cn = new SqlConnection
                        (
                        "server="
                        + Properties.Settings.Default.ServerNameString
                        + "\\" + Properties.Settings.Default.InstanceString
                        + ";database=" + Properties.Settings.Default.DatabaseString
                        + ";uid=" + Properties.Settings.Default.UserNameString
                        + ";pwd=" + Properties.Settings.Default.PasswordString
                        ))
                {
                    cn.Open();
                    String PF = "Pass";
                    if (PF.Contains("Pass") == true)
                    {
                        { TableButton.Enabled = true; }
                        { SPButton.Enabled = true; }
                        { SQLUtilitiesButton.Enabled = true; }
                    }
                    else
                    {
                        { TableButton.Enabled = false; }
                        { SPButton.Enabled = false; }
                        { SQLUtilitiesButton.Enabled = false; }
                    }
                }
            }
            catch (Exception ex)
            {
                String PF = "Fail";
                if (PF.Contains("Pass") == true)
                {
                    { TableButton.Enabled = true; }
                    { SPButton.Enabled = true; }
                    { SQLUtilitiesButton.Enabled = true; }
                }
                else
                {
                    { TableButton.Enabled = false; }
                    { SPButton.Enabled = false; }
                    { SQLUtilitiesButton.Enabled = false; }
                }
                MessageBox.Show(ex.Message, "Invalid Connection - Please Update Database Connection Information");
            }
            finally
            {
                cn.Close();
            }
        }

        private void Tools_Load(object sender, EventArgs e)
        {

        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection
                        (
                        "server="
                        + Properties.Settings.Default.ServerNameString
                        + "\\" + Properties.Settings.Default.InstanceString
                        + ";database=" + Properties.Settings.Default.DatabaseString
                        + ";uid=" + Properties.Settings.Default.UserNameString
                        + ";pwd=" + Properties.Settings.Default.PasswordString
                        ))
                try
                {
                    cn.Open();
                    using
                        (SqlCommand command = new SqlCommand(
                            "CREATE TABLE cust_SPManagerConfig" +
                            "(ButtonName01 varchar(max) NULL" +
                            ", SPName01 varchar(max) NULL" +
                            ", ButtonName02 varchar(max) NULL" +
                            ", SPName02 varchar(max) NULL" +
                            ", ButtonName03 varchar(max) NULL" +
                            ", SPName03 varchar(max) NULL" +
                            ", ButtonName04 varchar(max) NULL" +
                            ", SPName04 varchar(max) NULL" +
                            ", ButtonName05 varchar(max) NULL" +
                            ", SPName05 varchar(max) NULL" +
                            ", ButtonName06 varchar(max) NULL" +
                            ", SPName06 varchar(max) NULL" +
                            ", ButtonName07 varchar(max) NULL" +
                            ", SPName07 varchar(max) NULL" +
                            ", ButtonName08 varchar(max) NULL" +
                            ", SPName08 varchar(max) NULL" +
                            ", ButtonName09 varchar(max) NULL" +
                            ", SPName09 varchar(max) NULL" +
                            ", ButtonName10 varchar(max) NULL" +
                            ", SPName10 varchar(max) NULL);", cn))
                        command.ExecuteNonQuery();
                    MessageBox.Show("The table was successfully created in the " + Properties.Settings.Default.DatabaseString + " database!", "Table Created");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
        }

        private void SPButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection
                        (
                        "server="
                        + Properties.Settings.Default.ServerNameString
                        + "\\" + Properties.Settings.Default.InstanceString
                        + ";database=" + Properties.Settings.Default.DatabaseString
                        + ";uid=" + Properties.Settings.Default.UserNameString
                        + ";pwd=" + Properties.Settings.Default.PasswordString
                        ))
                try
                {
                    cn.Open();
                    using
                        (SqlCommand command = new SqlCommand(
                            // After testing, use this name for the table cust_cust_SPManagerButtonConfig
                            "CREATE Procedure cust_SPManagerTest " +
                            "AS " +
                            "UPDATE cust_SPManagerConfig " +
                            "SET " +
                            "ButtonName10 = 'TEST WORKED'" +
                            ",SPName10 = 'TEST WORKED';", cn))
                        command.ExecuteNonQuery();
                    MessageBox.Show("The Stored Procedure was successfully created in the " + Properties.Settings.Default.DatabaseString + " database!", "Stored Procedure Created");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
        }

        private void SQLUtilitiesButton_Click(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection
            (
            "server="
            + Properties.Settings.Default.ServerNameString
            + "\\" + Properties.Settings.Default.InstanceString
            + ";database=" + Properties.Settings.Default.DatabaseString
            + ";uid=" + Properties.Settings.Default.UserNameString
            + ";pwd=" + Properties.Settings.Default.PasswordString
            ))
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("cust_SPManagerTest", cn);
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Check the Button Configuration to see if the words TEST WORKED is present for button 10", "Test Successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
        }

        private void BorderPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.BorderPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
