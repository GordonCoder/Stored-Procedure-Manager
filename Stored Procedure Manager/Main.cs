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
    
    public partial class Main : Form
    {
        // SQL Connection that can be used throughout the Form
        SqlConnection cn = new SqlConnection
            (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString
            );

        public Main()
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
                    loadButtonConfig();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Connection - Please Update Database Connection Information");
            }
            finally
            {
                cn.Close();
            }
        }

        // Load the names of the buttons
        private void loadButtonConfig()
        {
            DataTable dt = new DataTable();
            cn.Open();
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM cust_SPManagerConfig", cn);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlcmd);
            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.button1.Text = dt.Rows[0]["ButtonName01"].ToString();
                this.button2.Text = dt.Rows[0]["ButtonName02"].ToString();
                this.button3.Text = dt.Rows[0]["ButtonName03"].ToString();
                this.button4.Text = dt.Rows[0]["ButtonName04"].ToString();
                this.button5.Text = dt.Rows[0]["ButtonName05"].ToString();
                this.button6.Text = dt.Rows[0]["ButtonName06"].ToString();
                this.button7.Text = dt.Rows[0]["ButtonName07"].ToString();
                this.button8.Text = dt.Rows[0]["ButtonName08"].ToString();
                this.button9.Text = dt.Rows[0]["ButtonName09"].ToString();
                this.button10.Text = dt.Rows[0]["ButtonName10"].ToString();
            }
            cn.Close();
        }

        // TO - DO I need to make this more secure by following the information in this link
        // https://msdn.microsoft.com/library/ms182310.aspx

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName1String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName1String + " Stored Procedure was ran.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName2String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName2String + " Stored Procedure was ran.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName3String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName3String + " Stored Procedure was ran.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName4String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName4String + " Stored Procedure was ran.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName5String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName5String + " Stored Procedure was ran.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName6String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName6String + " Stored Procedure was ran.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName7String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName7String + " Stored Procedure was ran.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName8String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName8String + " Stored Procedure was ran.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName9String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName9String + " Stored Procedure was ran.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName10String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName10String + " Stored Procedure was ran.");
        }

        private void databaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ModernUI_Click(object sender, EventArgs e)
        {

        }
    }
}
