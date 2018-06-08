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
                    LoadMainButtonConfig();
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
        public void LoadMainButtonConfig()
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

            // This make the button Active only if there is a Stored Procedure filled in the Stored Procedure text box.
            // If nothing is populated on the Stored Procedure text box, then the button is set to inactive

            string buttoninactivetext = "Not Configured";

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName1String))
            {button1.Enabled = false; button1.Text = buttoninactivetext; }
            else {button1.Enabled = true;}
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName2String))
            { button2.Enabled = false; button2.Text = buttoninactivetext; }
            else { button2.Enabled = true; }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName3String))
            { button3.Enabled = false; button3.Text = buttoninactivetext; }
            else { button3.Enabled = true; }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName4String))
            { button4.Enabled = false; button4.Text = buttoninactivetext; }
            else { button4.Enabled = true; }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName5String))
            { button5.Enabled = false; button5.Text = buttoninactivetext; }
            else { button5.Enabled = true; }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName6String))
            { button6.Enabled = false; button6.Text = buttoninactivetext; }
            else { button6.Enabled = true; }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName7String))
            { button7.Enabled = false; button7.Text = buttoninactivetext; }
            else { button7.Enabled = true; }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName8String))
            { button8.Enabled = false; button8.Text = buttoninactivetext; }
            else { button8.Enabled = true; }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName9String))
            { button9.Enabled = false; button9.Text = buttoninactivetext; }
            else { button9.Enabled = true; }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName10String))
            { button10.Enabled = false; button10.Text = buttoninactivetext; }
            else { button10.Enabled = true; }
        }


        // TO - DO I need to make this more secure by following the information in this link
        // https://msdn.microsoft.com/library/ms182310.aspx
        // TO - DO Need to make each button do a TRY to see if the Stored Procedure exists before executing it.
        // Need to catch the exceptions also and present them to the user

        private void Button1_Click(object sender, EventArgs e)
            
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName1String, cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName1String + " Stored Procedure was run.");
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName2String, cn);
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName2String + " Stored Procedure was run.");
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

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName3String, cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName3String + " Stored Procedure was run.");
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

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName4String, cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName4String + " Stored Procedure was run.");
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

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName5String, cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName5String + " Stored Procedure was run.");
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

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName6String, cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName6String + " Stored Procedure was run.");
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

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName7String, cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName7String + " Stored Procedure was run.");
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

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName8String, cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName8String + " Stored Procedure was run.");
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

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName9String, cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName9String + " Stored Procedure was run.");
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

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName10String, cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName10String + " Stored Procedure was run.");
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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BorderPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.borderpanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

    }
}
