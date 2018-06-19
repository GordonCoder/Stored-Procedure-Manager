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
            DataTable dtb1 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb1 = new SqlCommand("SELECT * FROM AM_Button1Info", cn);
            SqlDataAdapter sqlDab1 = new SqlDataAdapter(sqlcmdb1);
            sqlDab1.Fill(dtb1);
            if (dtb1.Rows.Count > 0)
            {
                this.button1.Text = dtb1.Rows[0]["ButtonName"].ToString();
            }
            cn.Close();

            DataTable dtb2 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb2 = new SqlCommand("SELECT * FROM AM_Button2Info", cn);
            SqlDataAdapter sqlDab2 = new SqlDataAdapter(sqlcmdb2);
            sqlDab2.Fill(dtb2);
            if (dtb2.Rows.Count > 0)
            {
                this.button2.Text = dtb2.Rows[0]["ButtonName"].ToString();
            }
            cn.Close();

            DataTable dtb3 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb3 = new SqlCommand("SELECT * FROM AM_Button3Info", cn);
            SqlDataAdapter sqlDab3 = new SqlDataAdapter(sqlcmdb3);
            sqlDab3.Fill(dtb3);
            if (dtb3.Rows.Count > 0)
            {
                this.button3.Text = dtb3.Rows[0]["ButtonName"].ToString();
            }
            cn.Close();

            DataTable dtb4 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb4 = new SqlCommand("SELECT * FROM AM_Button4Info", cn);
            SqlDataAdapter sqlDab4 = new SqlDataAdapter(sqlcmdb4);
            sqlDab4.Fill(dtb4);
            if (dtb4.Rows.Count > 0)
            {
                this.button4.Text = dtb4.Rows[0]["ButtonName"].ToString();
            }
            cn.Close();

            DataTable dtb5 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb5 = new SqlCommand("SELECT * FROM AM_Button5Info", cn);
            SqlDataAdapter sqlDab5 = new SqlDataAdapter(sqlcmdb5);
            sqlDab5.Fill(dtb5);
            if (dtb5.Rows.Count > 0)
            {
                this.button5.Text = dtb5.Rows[0]["ButtonName"].ToString();
            }
            cn.Close();

            DataTable dtb6 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb6 = new SqlCommand("SELECT * FROM AM_Button6Info", cn);
            SqlDataAdapter sqlDab6 = new SqlDataAdapter(sqlcmdb6);
            sqlDab6.Fill(dtb6);
            if (dtb6.Rows.Count > 0)
            {
                this.button6.Text = dtb6.Rows[0]["ButtonName"].ToString();
            }
            cn.Close();

            DataTable dtb7 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb7 = new SqlCommand("SELECT * FROM AM_Button7Info", cn);
            SqlDataAdapter sqlDab7 = new SqlDataAdapter(sqlcmdb7);
            sqlDab7.Fill(dtb7);
            if (dtb7.Rows.Count > 0)
            {
                this.button7.Text = dtb7.Rows[0]["ButtonName"].ToString();
            }
            cn.Close();

            DataTable dtb8 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb8 = new SqlCommand("SELECT * FROM AM_Button8Info", cn);
            SqlDataAdapter sqlDab8 = new SqlDataAdapter(sqlcmdb8);
            sqlDab8.Fill(dtb8);
            if (dtb8.Rows.Count > 0)
            {
                this.button8.Text = dtb8.Rows[0]["ButtonName"].ToString();
            }
            cn.Close();

            DataTable dtb9 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb9 = new SqlCommand("SELECT * FROM AM_Button9Info", cn);
            SqlDataAdapter sqlDab9 = new SqlDataAdapter(sqlcmdb9);
            sqlDab9.Fill(dtb9);
            if (dtb9.Rows.Count > 0)
            {
                this.button9.Text = dtb9.Rows[0]["ButtonName"].ToString();
            }
            cn.Close();

            DataTable dtb10 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb10 = new SqlCommand("SELECT * FROM AM_Button10Info", cn);
            SqlDataAdapter sqlDab10 = new SqlDataAdapter(sqlcmdb10);
            sqlDab10.Fill(dtb10);
            if (dtb10.Rows.Count > 0)
            {
                this.button10.Text = dtb10.Rows[0]["ButtonName"].ToString();
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

                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName1String;

                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();

                System.Diagnostics.Process.Start(Properties.Settings.Default.EXE1String);

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

            cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
            cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName2String;

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
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName3String;
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

            //https://www.c-sharpcorner.com/blogs/passing-multiple-parameters-in-sql-in-clause-with-sqlcommand
            //try
            //{ 
            //    cn.Open();
            //    DataSet ds = new DataSet();
            //    String strAppend = "";
            //    String strNames = "";
            //    int index = 1;
            //    String paramName = "";
            //    String[] strArrayNames;
            //    strNames = "Hourly,Hourly2";
            //    strArrayNames = strNames.Split(',');
            //    //SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName3String, cn);
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = cn;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    foreach (String item in strArrayNames)
            //    {
            //        paramName = "@idParam" + index;
            //        cmd.Parameters.AddWithValue(paramName, item); //Making individual parameters for every name  
            //        strAppend += paramName + ",";
            //        index += 1;
            //    }
            //    strAppend = strAppend.ToString().Remove(strAppend.LastIndexOf(","), 1); //Remove the last comma  
            //    cmd.CommandText = "EXEC " + Properties.Settings.Default.SPName3String + " (" + strAppend + ")";

            //    //SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName3String, cn);
            //    //cmd.Parameters.AddWithValue(strAppend, SqlDbType.VarChar);
            //    //cmd.Parameters[strAppend].Value = Properties.Settings.Default.ParamName3String;

            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    cn.Close();
            //}
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName4String, cn);
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName4String;
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
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName5String;
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
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName6String;
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
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName7String;
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
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName8String;
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
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName9String;
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
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName10String;
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


