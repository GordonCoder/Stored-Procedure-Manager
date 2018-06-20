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
                + ";pwd=" + Properties.Settings.Default.PasswordString
            );

        SqlConnection cnAMDB = new SqlConnection
            (
            "server="
            + Properties.Settings.Default.ServerNameString
            + "\\" + Properties.Settings.Default.InstanceString
            + ";database= AutomationManager"
            + ";uid=" + Properties.Settings.Default.UserNameString
            + ";pwd=" + Properties.Settings.Default.PasswordString
            );

        public Main()
        {
            InitializeComponent();
            try
            {
                using
                    (SqlConnection cnAMDB = new SqlConnection
                        (
                        "server="
                        + Properties.Settings.Default.ServerNameString
                        + "\\" + Properties.Settings.Default.InstanceString
                        + ";database= AutomationManager"
                        + ";uid=" + Properties.Settings.Default.UserNameString
                        + ";pwd=" + Properties.Settings.Default.PasswordString
                        )
                    )
                {
                    cnAMDB.Open();
                    LoadMainButtonConfig();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Connection - Please Update Database Connection Information");
            }
            finally
            {
                cnsp.Close();
            }
        }

        public void AMDBconnectionString()
        {
            string AMDBconnectionString = 
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString;


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
                + ";pwd=" + Properties.Settings.Default.PasswordString
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
            string AMDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString;

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString;

            try
            {
                SqlConnection cnAMDB_B1 = new SqlConnection(AMDBconnectionString);
                cnAMDB_B1.Open();
                SqlCommand cmdAMDB_B1 = new SqlCommand("SELECT * FROM AM_Button1Info", cnAMDB_B1);
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
                    string FilePath = sdr["FilePath"].ToString();

                    if (string.IsNullOrWhiteSpace(SPName))
                    {
                        MessageBox.Show("No Stored Procedure set on the button configuration. Please update the button configuration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlConnection cnSPDB_B1 = new SqlConnection(SPDBconnectionString);
                        cnSPDB_B1.Open();
                        SqlCommand cmdSPDB_B1 = new SqlCommand(SPName, cnSPDB_B1);

                        cmdSPDB_B1.Parameters.AddWithValue(ParamName1, SqlDbType.VarChar);
                        cmdSPDB_B1.Parameters[ParamName1].Value = ParamValue1;

                        cmdSPDB_B1.Connection = cnSPDB_B1;
                        cmdSPDB_B1.CommandType = CommandType.StoredProcedure;
                        cmdSPDB_B1.ExecuteNonQuery();
                        MessageBox.Show("The " + SPName + " Stored Procedure was run.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
            cnsp.Open();
            SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName2String, cnsp);

            cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
            cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName2String;

            cmd.Connection = cnsp;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cnsp.Close();
            MessageBox.Show("The " + Properties.Settings.Default.SPName2String + " Stored Procedure was run.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnsp.Close();
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
                + ";pwd=" + Properties.Settings.Default.PasswordString;

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString;

            string strInsert;

            using (StreamReader sr = new StreamReader(File.Open("C:\\Users\\sean\\Desktop\\BulkInsertTest\\PayrollExportSQL.csv", FileMode.Open)))
            {
                using (SqlConnection cnSPDB_B3 = new SqlConnection(SPDBconnectionString))
                {
                    cnSPDB_B3.Open();
                    string line = "";
                    while ((line = sr.ReadLine()) != "")
                    {
                        string[] parts = line.Split(new string[] { "," }, StringSplitOptions.None);

                        FileInfo fileinfoInsert = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Stored Procedure Manager\\SQL Scripts\\Custom Tables\\Button 3.sql");

                        strInsert = fileinfoInsert.OpenText().ReadToEnd();

                        string cmdTxt = String.Format
                            (strInsert
                            , parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8], parts[9], parts[10]);
                        using (SqlCommand cmdSPDB_B3 = new SqlCommand(cmdTxt, cnSPDB_B3))
                        {
                            cmdSPDB_B3.ExecuteNonQuery();
                        }
                    }
                }
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
                + ";pwd=" + Properties.Settings.Default.PasswordString;

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString;
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
                    string FilePath = sdr["FilePath"].ToString();
                    bool FPCheckBox = (Convert.ToBoolean(sdr["FPCheckBox"]));

                    if (FPCheckBox == true)
                    {
                    string strInsert;
                        using (StreamReader sr = new StreamReader(File.Open(FilePath, FileMode.Open)))
                        {
                            using (SqlConnection SPDBconnectionStringfp_B4 = new SqlConnection(SPDBconnectionString))
                            {
                                SPDBconnectionStringfp_B4.Open();
                                string line = "";
                                while ((line = sr.ReadLine()) != "")
                                {
                                    string[] parts = line.Split(new string[] { "," }, StringSplitOptions.None);

                                    FileInfo fileinfoInsert = new FileInfo
                                        ("C:\\ProgramData\\Sierra Workforce Solutions\\Stored Procedure Manager\\SQL Scripts\\Custom Tables\\Button 4.sql");

                                    strInsert = fileinfoInsert.OpenText().ReadToEnd();

                                    string cmdfpTxtB4 = String.Format
                                        (strInsert
                                        , parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8], parts[9], parts[10]
                                        , parts[11], parts[12], parts[13], parts[14], parts[15], parts[16], parts[17], parts[18], parts[19], parts[20]);
                                    using (SqlCommand cmdSPDBfp_B4 = new SqlCommand(cmdfpTxtB4, SPDBconnectionStringfp_B4))
                                    {
                                        cmdSPDBfp_B4.ExecuteNonQuery();
                                    }
                                }
                                if (SPDBconnectionStringfp_B4.State == ConnectionState.Open)
                                {
                                    SPDBconnectionStringfp_B4.Close();
                                    MessageBox.Show("The file was uploaded.");
                                }
                            }
                        }
                    }

                    if (string.IsNullOrWhiteSpace(SPName))
                    {
                        //MessageBox.Show("No Stored Procedure set on the button configuration. Please update the button configuration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(ex.Message, "1");
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
                + ";pwd=" + Properties.Settings.Default.PasswordString;

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString;
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
                    string FilePath = sdr["FilePath"].ToString();
                    bool FPCheckBox = (Convert.ToBoolean(sdr["FPCheckBox"]));

                    if (FPCheckBox == true)
                    {
                        string strInsert;
                        using (StreamReader sr = new StreamReader(File.Open(FilePath, FileMode.Open)))
                        {
                            using (SqlConnection SPDBconnectionStringfp_B5 = new SqlConnection(SPDBconnectionString))
                            {
                                SPDBconnectionStringfp_B5.Open();
                                string line = "";
                                while ((line = sr.ReadLine()) != "")
                                {
                                    string[] parts = line.Split(new string[] { "," }, StringSplitOptions.None);

                                    FileInfo fileinfoInsert = new FileInfo
                                        ("C:\\ProgramData\\Sierra Workforce Solutions\\Stored Procedure Manager\\SQL Scripts\\Custom Tables\\Button 5.sql");

                                    strInsert = fileinfoInsert.OpenText().ReadToEnd();

                                    string cmdfpTxtB5 = String.Format
                                        (strInsert
                                        , parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8], parts[9], parts[10]
                                        , parts[11], parts[12], parts[13], parts[14], parts[15], parts[16], parts[17], parts[18], parts[19], parts[20]);
                                    using (SqlCommand cmdSPDBfp_B5 = new SqlCommand(cmdfpTxtB5, SPDBconnectionStringfp_B5))
                                    {
                                        cmdSPDBfp_B5.ExecuteNonQuery();
                                    }
                                }
                                if (SPDBconnectionStringfp_B5.State == ConnectionState.Open)
                                {
                                    SPDBconnectionStringfp_B5.Close();
                                    MessageBox.Show("The file was uploaded.");
                                }
                            }
                        }
                    }

                    if (string.IsNullOrWhiteSpace(SPName))
                    {
                        //MessageBox.Show("No Stored Procedure set on the button configuration. Please update the button configuration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(ex.Message, "1");
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
                + ";pwd=" + Properties.Settings.Default.PasswordString;

            string SPDBconnectionString =
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database=" + Properties.Settings.Default.DatabaseString
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString;
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
                    string FilePath = sdr["FilePath"].ToString();
                    bool FPCheckBox = (Convert.ToBoolean(sdr["FPCheckBox"]));

                    if (FPCheckBox == true)
                    {
                        string strInsert;
                        using (StreamReader sr = new StreamReader(File.Open(FilePath, FileMode.Open)))
                        {
                            using (SqlConnection SPDBconnectionStringfp_B6 = new SqlConnection(SPDBconnectionString))
                            {
                                SPDBconnectionStringfp_B6.Open();
                                string line = "";
                                while ((line = sr.ReadLine()) != "")
                                {
                                    string[] parts = line.Split(new string[] { "," }, StringSplitOptions.None);

                                    FileInfo fileinfoInsert = new FileInfo
                                        ("C:\\ProgramData\\Sierra Workforce Solutions\\Stored Procedure Manager\\SQL Scripts\\Custom Tables\\Button 6.sql");

                                    strInsert = fileinfoInsert.OpenText().ReadToEnd();

                                    string cmdfpTxtB6 = String.Format
                                        (strInsert
                                        , parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8], parts[9], parts[10]
                                        , parts[11], parts[12], parts[13], parts[14], parts[15], parts[16], parts[17], parts[18], parts[19], parts[20]);
                                    using (SqlCommand cmdSPDBfp_B6 = new SqlCommand(cmdfpTxtB6, SPDBconnectionStringfp_B6))
                                    {
                                        cmdSPDBfp_B6.ExecuteNonQuery();
                                    }
                                }
                                if (SPDBconnectionStringfp_B6.State == ConnectionState.Open)
                                {
                                    SPDBconnectionStringfp_B6.Close();
                                    MessageBox.Show("The file was uploaded.");
                                }
                            }
                        }
                    }

                    if (string.IsNullOrWhiteSpace(SPName))
                    {
                        //MessageBox.Show("No Stored Procedure set on the button configuration. Please update the button configuration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(ex.Message, "1");
            }
            finally
            {

            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                cnsp.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName7String, cnsp);
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName7String;
                cmd.Connection = cnsp;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cnsp.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName7String + " Stored Procedure was run.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnsp.Close();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                cnsp.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName8String, cnsp);
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName8String;
                cmd.Connection = cnsp;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cnsp.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName8String + " Stored Procedure was run.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnsp.Close();
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                cnsp.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName9String, cnsp);
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName9String;
                cmd.Connection = cnsp;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cnsp.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName9String + " Stored Procedure was run.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnsp.Close();
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                cnsp.Open();
                SqlCommand cmd = new SqlCommand(Properties.Settings.Default.SPName10String, cnsp);
                cmd.Parameters.AddWithValue("@param1", SqlDbType.VarChar);
                cmd.Parameters["@param1"].Value = Properties.Settings.Default.ParamName10String;
                cmd.Connection = cnsp;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cnsp.Close();
                MessageBox.Show("The " + Properties.Settings.Default.SPName10String + " Stored Procedure was run.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnsp.Close();
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


