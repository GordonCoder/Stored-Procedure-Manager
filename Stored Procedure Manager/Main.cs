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
using System.Configuration;
using System.IO;

namespace Stored_Procedure_Manager
{

    public partial class Main : Form
    {
        // SQL Connection that can be used throughout the Form
        SqlConnection cnsp = new SqlConnection
            (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString)
            );

        SqlConnection cnAMDB = new SqlConnection
            (
            "server="
            + Properties.Settings.Default.ServerNameString
            + "\\" + Properties.Settings.Default.InstanceString
            + ";database= AutomationManager"
            + ";uid=" + Properties.Settings.Default.UserNameString
            + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString)
            );

        public Main()
        {
            InitializeComponent();

        }

        public void AMDBconnectionString()
        {
            try
            {
                string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Connection - Please Update Database Connection Information");
            }
            finally
            {
            }

        }

        public void SPDBconnectionString()
        {
            try
            {
                SqlConnection cnSPDB = new SqlConnection
                (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Connection - Please Update Database Connection Information");
            }
            finally
            {
            }
        }

        // Load the names of the buttons
        public void LoadMainButtonConfig()
        {
            DataTable dtb1 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb1 = new SqlCommand("SELECT * FROM AM_Button1Info", cnAMDB);
            SqlDataAdapter sqlDab1 = new SqlDataAdapter(sqlcmdb1);
            sqlDab1.Fill(dtb1);
            if (dtb1.Rows.Count > 0)
            {
                this.button1.Text = dtb1.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();

            DataTable dtb2 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb2 = new SqlCommand("SELECT * FROM AM_Button2Info", cnAMDB);
            SqlDataAdapter sqlDab2 = new SqlDataAdapter(sqlcmdb2);
            sqlDab2.Fill(dtb2);
            if (dtb2.Rows.Count > 0)
            {
                this.button2.Text = dtb2.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();

            DataTable dtb3 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb3 = new SqlCommand("SELECT * FROM AM_Button3Info", cnAMDB);
            SqlDataAdapter sqlDab3 = new SqlDataAdapter(sqlcmdb3);
            sqlDab3.Fill(dtb3);
            if (dtb3.Rows.Count > 0)
            {
                this.button3.Text = dtb3.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();

            DataTable dtb4 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb4 = new SqlCommand("SELECT * FROM AM_Button4Info", cnAMDB);
            SqlDataAdapter sqlDab4 = new SqlDataAdapter(sqlcmdb4);
            sqlDab4.Fill(dtb4);
            if (dtb4.Rows.Count > 0)
            {
                this.button4.Text = dtb4.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();

            DataTable dtb5 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb5 = new SqlCommand("SELECT * FROM AM_Button5Info", cnAMDB);
            SqlDataAdapter sqlDab5 = new SqlDataAdapter(sqlcmdb5);
            sqlDab5.Fill(dtb5);
            if (dtb5.Rows.Count > 0)
            {
                this.button5.Text = dtb5.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();

            DataTable dtb6 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb6 = new SqlCommand("SELECT * FROM AM_Button6Info", cnAMDB);
            SqlDataAdapter sqlDab6 = new SqlDataAdapter(sqlcmdb6);
            sqlDab6.Fill(dtb6);
            if (dtb6.Rows.Count > 0)
            {
                this.button6.Text = dtb6.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();

            DataTable dtb7 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb7 = new SqlCommand("SELECT * FROM AM_Button7Info", cnAMDB);
            SqlDataAdapter sqlDab7 = new SqlDataAdapter(sqlcmdb7);
            sqlDab7.Fill(dtb7);
            if (dtb7.Rows.Count > 0)
            {
                this.button7.Text = dtb7.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();

            DataTable dtb8 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb8 = new SqlCommand("SELECT * FROM AM_Button8Info", cnAMDB);
            SqlDataAdapter sqlDab8 = new SqlDataAdapter(sqlcmdb8);
            sqlDab8.Fill(dtb8);
            if (dtb8.Rows.Count > 0)
            {
                this.button8.Text = dtb8.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();

            DataTable dtb9 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb9 = new SqlCommand("SELECT * FROM AM_Button9Info", cnAMDB);
            SqlDataAdapter sqlDab9 = new SqlDataAdapter(sqlcmdb9);
            sqlDab9.Fill(dtb9);
            if (dtb9.Rows.Count > 0)
            {
                this.button9.Text = dtb9.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();

            DataTable dtb10 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb10 = new SqlCommand("SELECT * FROM AM_Button10Info", cnAMDB);
            SqlDataAdapter sqlDab10 = new SqlDataAdapter(sqlcmdb10);
            sqlDab10.Fill(dtb10);
            if (dtb10.Rows.Count > 0)
            {
                this.button10.Text = dtb10.Rows[0]["ButtonName"].ToString();
            }
            cnAMDB.Close();
        }

        // TO - DO I need to make this more secure by following the information in this link
        // https://msdn.microsoft.com/library/ms182310.aspx
        // TO - DO Need to make each button do a TRY to see if the Stored Procedure exists before executing it.
        // Need to catch the exceptions also and present them to the user

        //===========================================================================================================
        // Button 1 Click
        //===========================================================================================================
        private void Button1_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B1 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B1.Open();
                SqlCommand cmdAMDB_B1 = new SqlCommand("SELECT * FROM AM_Button1Info", AMDBconnectionString_B1);
                SqlDataReader sdr = cmdAMDB_B1.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));
                    
// Stored Procedure Execution Setting

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B1 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B1.Open();
                        SqlCommand cmdSPDB_B1 = new SqlCommand(SPName, SPDBconnectionString_B1);

                        cmdSPDB_B1.Connection = SPDBconnectionString_B1;
                        cmdSPDB_B1.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B1.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B1.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B1.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B1 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B1.Open();
                        SqlCommand cmdSPDB_B1 = new SqlCommand(SPName, SPDBconnectionString_B1);

                        cmdSPDB_B1.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B1.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B1.Connection = SPDBconnectionString_B1;
                        cmdSPDB_B1.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B1.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B1.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B1.Close();
                        }
                    }

// Execution Path Settings

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                //Possibly say something about not being able to find the view that loads the data
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        //===========================================================================================================
        // Button 2 Click
        //===========================================================================================================
        private void Button2_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B2 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B2.Open();
                SqlCommand cmdAMDB_B2 = new SqlCommand("SELECT * FROM AM_Button2Info", AMDBconnectionString_B2);
                SqlDataReader sdr = cmdAMDB_B2.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B2 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B2.Open();
                        SqlCommand cmdSPDB_B2 = new SqlCommand(SPName, SPDBconnectionString_B2);

                        cmdSPDB_B2.Connection = SPDBconnectionString_B2;
                        cmdSPDB_B2.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B2.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B2.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B2.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B2 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B2.Open();
                        SqlCommand cmdSPDB_B2 = new SqlCommand(SPName, SPDBconnectionString_B2);

                        cmdSPDB_B2.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B2.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B2.Connection = SPDBconnectionString_B2;
                        cmdSPDB_B2.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B2.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B2.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B2.Close();
                        }
                    }

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                //Possibly say something about not being able to find the view that loads the data
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        //===========================================================================================================
        // Button 3 Click
        //===========================================================================================================
        private void Button3_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B3 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B3.Open();
                SqlCommand cmdAMDB_B3 = new SqlCommand("SELECT * FROM AM_Button3Info", AMDBconnectionString_B3);
                SqlDataReader sdr = cmdAMDB_B3.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B3 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B3.Open();
                        SqlCommand cmdSPDB_B3 = new SqlCommand(SPName, SPDBconnectionString_B3);

                        cmdSPDB_B3.Connection = SPDBconnectionString_B3;
                        cmdSPDB_B3.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B3.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B3.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B3.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B3 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B3.Open();
                        SqlCommand cmdSPDB_B3 = new SqlCommand(SPName, SPDBconnectionString_B3);

                        cmdSPDB_B3.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B3.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B3.Connection = SPDBconnectionString_B3;
                        cmdSPDB_B3.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B3.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B3.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B3.Close();
                        }
                    }

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                //Possibly say something about not being able to find the view that loads the data
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        //=======================================================================================
        // Button 4 Click
        //=======================================================================================
        private void Button4_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B4 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B4.Open();
                SqlCommand cmdAMDB_B4 = new SqlCommand("SELECT * FROM AM_Button4Info", AMDBconnectionString_B4);
                SqlDataReader sdr = cmdAMDB_B4.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B4 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B4.Open();
                        SqlCommand cmdSPDB_B4 = new SqlCommand(SPName, SPDBconnectionString_B4);

                        cmdSPDB_B4.Connection = SPDBconnectionString_B4;
                        cmdSPDB_B4.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B4.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B4.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B4.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B4 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B4.Open();
                        SqlCommand cmdSPDB_B4 = new SqlCommand(SPName, SPDBconnectionString_B4);

                        cmdSPDB_B4.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B4.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B4.Connection = SPDBconnectionString_B4;
                        cmdSPDB_B4.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B4.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B4.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B4.Close();
                        }
                    }

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                
            }
        }

        //=======================================================================================
        // Button 5 Click
        //=======================================================================================
        private void Button5_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B5 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B5.Open();
                SqlCommand cmdAMDB_B5 = new SqlCommand("SELECT * FROM AM_Button5Info", AMDBconnectionString_B5);
                SqlDataReader sdr = cmdAMDB_B5.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B5 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B5.Open();
                        SqlCommand cmdSPDB_B5 = new SqlCommand(SPName, SPDBconnectionString_B5);

                        cmdSPDB_B5.Connection = SPDBconnectionString_B5;
                        cmdSPDB_B5.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B5.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B5.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B5.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B5 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B5.Open();
                        SqlCommand cmdSPDB_B5 = new SqlCommand(SPName, SPDBconnectionString_B5);

                        cmdSPDB_B5.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B5.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B5.Connection = SPDBconnectionString_B5;
                        cmdSPDB_B5.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B5.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B5.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B5.Close();
                        }
                    }

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                //Possibly say something about not being able to find the view that loads the data
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        //=======================================================================================
        // Button 6 Click
        //=======================================================================================
        private void Button6_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B6 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B6.Open();
                SqlCommand cmdAMDB_B6 = new SqlCommand("SELECT * FROM AM_Button6Info", AMDBconnectionString_B6);
                SqlDataReader sdr = cmdAMDB_B6.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B6 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B6.Open();
                        SqlCommand cmdSPDB_B6 = new SqlCommand(SPName, SPDBconnectionString_B6);

                        cmdSPDB_B6.Connection = SPDBconnectionString_B6;
                        cmdSPDB_B6.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B6.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B6.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B6.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B6 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B6.Open();
                        SqlCommand cmdSPDB_B6 = new SqlCommand(SPName, SPDBconnectionString_B6);

                        cmdSPDB_B6.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B6.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B6.Connection = SPDBconnectionString_B6;
                        cmdSPDB_B6.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B6.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B6.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B6.Close();
                        }
                    }

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                //Possibly say something about not being able to find the view that loads the data
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        //=======================================================================================
        // Button 7 Click
        //=======================================================================================
        private void Button7_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B7 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B7.Open();
                SqlCommand cmdAMDB_B7 = new SqlCommand("SELECT * FROM AM_Button7Info", AMDBconnectionString_B7);
                SqlDataReader sdr = cmdAMDB_B7.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B7 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B7.Open();
                        SqlCommand cmdSPDB_B7 = new SqlCommand(SPName, SPDBconnectionString_B7);

                        cmdSPDB_B7.Connection = SPDBconnectionString_B7;
                        cmdSPDB_B7.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B7.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B7.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B7.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B7 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B7.Open();
                        SqlCommand cmdSPDB_B7 = new SqlCommand(SPName, SPDBconnectionString_B7);

                        cmdSPDB_B7.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B7.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B7.Connection = SPDBconnectionString_B7;
                        cmdSPDB_B7.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B7.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B7.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B7.Close();
                        }
                    }

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                //Possibly say something about not being able to find the view that loads the data
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }
        //=======================================================================================
        // Button 8 Click
        //=======================================================================================
        private void Button8_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B8 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B8.Open();
                SqlCommand cmdAMDB_B8 = new SqlCommand("SELECT * FROM AM_Button8Info", AMDBconnectionString_B8);
                SqlDataReader sdr = cmdAMDB_B8.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B8 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B8.Open();
                        SqlCommand cmdSPDB_B8 = new SqlCommand(SPName, SPDBconnectionString_B8);

                        cmdSPDB_B8.Connection = SPDBconnectionString_B8;
                        cmdSPDB_B8.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B8.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B8.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B8.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B8 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B8.Open();
                        SqlCommand cmdSPDB_B8 = new SqlCommand(SPName, SPDBconnectionString_B8);

                        cmdSPDB_B8.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B8.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B8.Connection = SPDBconnectionString_B8;
                        cmdSPDB_B8.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B8.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B8.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B8.Close();
                        }
                    }

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                //Possibly say something about not being able to find the view that loads the data
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        //=======================================================================================
        // Button 9 Click
        //=======================================================================================
        private void Button9_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B9 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B9.Open();
                SqlCommand cmdAMDB_B9 = new SqlCommand("SELECT * FROM AM_Button9Info", AMDBconnectionString_B9);
                SqlDataReader sdr = cmdAMDB_B9.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B9 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B9.Open();
                        SqlCommand cmdSPDB_B9 = new SqlCommand(SPName, SPDBconnectionString_B9);

                        cmdSPDB_B9.Connection = SPDBconnectionString_B9;
                        cmdSPDB_B9.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B9.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B9.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B9.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B9 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B9.Open();
                        SqlCommand cmdSPDB_B9 = new SqlCommand(SPName, SPDBconnectionString_B9);

                        cmdSPDB_B9.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B9.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B9.Connection = SPDBconnectionString_B9;
                        cmdSPDB_B9.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B9.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B9.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B9.Close();
                        }
                    }

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                //Possibly say something about not being able to find the view that loads the data
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        //=======================================================================================
        // Button 10 Click
        //=======================================================================================
        private void Button10_Click(object sender, EventArgs e)
        {
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString);
            try
            {
                SqlConnection AMDBconnectionString_B10 = new SqlConnection(AMDBconnectionString);
                AMDBconnectionString_B10.Open();
                SqlCommand cmdAMDB_B10 = new SqlCommand("SELECT * FROM AM_Button10Info", AMDBconnectionString_B10);
                SqlDataReader sdr = cmdAMDB_B10.ExecuteReader();
                while (sdr.Read())
                {
                    string ButtonName = sdr["ButtonName"].ToString();
                    string SPName = sdr["SPName"].ToString();
                    string ParamName1 = sdr["ParamName1"].ToString();
                    string ParamName2 = sdr["ParamName2"].ToString();
                    string ParamName3 = sdr["ParamName3"].ToString();
                    string ParamName4 = sdr["ParamName4"].ToString();
                    string ParamName5 = sdr["ParamName5"].ToString();
                    string ParamValue1 = sdr["ParamValue1"].ToString();
                    string ParamValue2 = sdr["ParamValue2"].ToString();
                    string ParamValue3 = sdr["ParamValue3"].ToString();
                    string ParamValue4 = sdr["ParamValue4"].ToString();
                    string ParamValue5 = sdr["ParamValue5"].ToString();
                    string ExecutablePath = sdr["ExecutablePath"].ToString();
                    string ExecutableParam = sdr["ExecutableParam"].ToString();
                    bool EPCheckBox = (Convert.ToBoolean(sdr["EPCheckBox"]));

                    if (string.IsNullOrWhiteSpace(ParamName1))
                    {
                        SqlConnection SPDBconnectionString_B10 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B10.Open();
                        SqlCommand cmdSPDB_B10 = new SqlCommand(SPName, SPDBconnectionString_B10);

                        cmdSPDB_B10.Connection = SPDBconnectionString_B10;
                        cmdSPDB_B10.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B10.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B10.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B10.Close();
                        }
                    }
                    else
                    {
                        SqlConnection SPDBconnectionString_B10 = new SqlConnection(SPDBconnectionString);
                        SPDBconnectionString_B10.Open();
                        SqlCommand cmdSPDB_B10 = new SqlCommand(SPName, SPDBconnectionString_B10);

                        cmdSPDB_B10.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B10.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B10.Connection = SPDBconnectionString_B10;
                        cmdSPDB_B10.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B10.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                        if (SPDBconnectionString_B10.State == ConnectionState.Open)
                        {
                            SPDBconnectionString_B10.Close();
                        }
                    }

                    if (EPCheckBox == true)
                    {
                        System.Diagnostics.Process.Start(ExecutablePath, ExecutableParam);
                    }
                }
            }
            catch (Exception ex)
            {
                //Possibly say something about not being able to find the view that loads the data
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        //private void BorderPanel_Paint(object sender, PaintEventArgs e)
        //{
        //    ControlPaint.DrawBorder(e.Graphics, this.borderpanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        //}

    }
}


