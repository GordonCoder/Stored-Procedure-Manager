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
    public partial class ButtonSetup : Form
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
        public ButtonSetup()
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

            LoadButtonConfig();
        }

        private void LoadButtonConfig()
        {
            treeView1.ExpandAll();

            // Clear Buttons for fresh data
            ExecutePath1Button1TextBox.Clear();
            //EXE2TextBox.Clear();
            //EXE3TextBox.Clear();
            //EXE4TextBox.Clear();
            //EXE5TextBox.Clear();
            //EXE6TextBox.Clear();
            //EXE7TextBox.Clear();
            //EXE8TextBox.Clear();
            //EXE9TextBox.Clear();
            //EXE10TextBox.Clear();

            ExecutePath1Button1TextBox.Text = Properties.Settings.Default.EXE1String;
            //EXE2TextBox.Text = Properties.Settings.Default.EXE2String;
            //EXE3TextBox.Text = Properties.Settings.Default.EXE3String;
            //EXE4TextBox.Text = Properties.Settings.Default.EXE4String;
            //EXE5TextBox.Text = Properties.Settings.Default.EXE5String;
            //EXE6TextBox.Text = Properties.Settings.Default.EXE6String;
            //EXE7TextBox.Text = Properties.Settings.Default.EXE7String;
            //EXE8TextBox.Text = Properties.Settings.Default.EXE8String;
            //EXE9TextBox.Text = Properties.Settings.Default.EXE9String;
            //EXE10TextBox.Text = Properties.Settings.Default.EXE10String;

            ExecuteParam1Button1TextBox.Clear();
            //Param2TextBox.Clear();
            //Param3TextBox.Clear();
            //Param4TextBox.Clear();
            //Param5TextBox.Clear();
            //Param6TextBox.Clear();
            //Param7TextBox.Clear();
            //Param8TextBox.Clear();
            //Param9TextBox.Clear();
            //Param10TextBox.Clear();

            ExecuteParam1Button1TextBox.Text = Properties.Settings.Default.Param1String;
            //Param2TextBox.Text = Properties.Settings.Default.Param2String;
            //Param3TextBox.Text = Properties.Settings.Default.Param3String;
            //Param4TextBox.Text = Properties.Settings.Default.Param4String;
            //Param5TextBox.Text = Properties.Settings.Default.Param5String;
            //Param6TextBox.Text = Properties.Settings.Default.Param6String;
            //Param7TextBox.Text = Properties.Settings.Default.Param7String;
            //Param8TextBox.Text = Properties.Settings.Default.Param8String;
            //Param9TextBox.Text = Properties.Settings.Default.Param9String;
            //Param10TextBox.Text = Properties.Settings.Default.Param10String;

            EXE1checkBox.Checked = Properties.Settings.Default.EXE1checkBoxString;
            //EXE2checkBox.Checked = Properties.Settings.Default.EXE2checkBoxString;
            //EXE3checkBox.Checked = Properties.Settings.Default.EXE3checkBoxString;
            //EXE4checkBox.Checked = Properties.Settings.Default.EXE4checkBoxString;
            //EXE5checkBox.Checked = Properties.Settings.Default.EXE5checkBoxString;
            //EXE6checkBox.Checked = Properties.Settings.Default.EXE6checkBoxString;
            //EXE7checkBox.Checked = Properties.Settings.Default.EXE7checkBoxString;
            //EXE8checkBox.Checked = Properties.Settings.Default.EXE8checkBoxString;
            //EXE9checkBox.Checked =  Properties.Settings.Default.EXE9checkBoxString;
            //EXE10checkBox.Checked = Properties.Settings.Default.EXE10checkBoxString;

            //=======================================================================================
            // Load Button 1 Data
            //=======================================================================================
            DataTable dtb1 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb1 = new SqlCommand("SELECT * FROM AM_Button1Info", cn); 
            SqlDataAdapter sqlDab1 = new SqlDataAdapter(sqlcmdb1);
            sqlDab1.Fill(dtb1);
            if (dtb1.Rows.Count > 0)
            {
                this.Button1NameText.Text = dtb1.Rows[0]["ButtonName"].ToString();
                this.SPName1TextBox.Text = dtb1.Rows[0]["SPName"].ToString();
                this.ParamName1Button1TextBox.Text = dtb1.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button1TextBox.Text = dtb1.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button1TextBox.Text = dtb1.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button1TextBox.Text = dtb1.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button1TextBox.Text = dtb1.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button1TextBox.Text = dtb1.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button1TextBox.Text = dtb1.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button1TextBox.Text = dtb1.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button1TextBox.Text = dtb1.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button1TextBox.Text = dtb1.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath1Button1TextBox.Text = dtb1.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam1Button1TextBox.Text = dtb1.Rows[0]["ExecutableParam"].ToString();
                this.FilePath1Button1TextBox.Text = dtb1.Rows[0]["FilePath"].ToString();
            }
            cn.Close();

            //=======================================================================================
            // Load Button 2 Data
            //=======================================================================================
            DataTable dtb2 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb2 = new SqlCommand("SELECT * FROM AM_Button2Info", cn);
            SqlDataAdapter sqlDab2 = new SqlDataAdapter(sqlcmdb2);
            sqlDab2.Fill(dtb2);
            if (dtb2.Rows.Count > 0)
            {
                this.Button2NameText.Text = dtb2.Rows[0]["ButtonName"].ToString();
                this.SPName2TextBox.Text = dtb2.Rows[0]["SPName"].ToString();
                this.ParamName1Button2TextBox.Text = dtb2.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button2TextBox.Text = dtb2.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button2TextBox.Text = dtb2.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button2TextBox.Text = dtb2.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button2TextBox.Text = dtb2.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button2TextBox.Text = dtb2.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button2TextBox.Text = dtb2.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button2TextBox.Text = dtb2.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button2TextBox.Text = dtb2.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button2TextBox.Text = dtb2.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath2Button2TextBox.Text = dtb2.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam2Button2TextBox.Text = dtb2.Rows[0]["ExecutableParam"].ToString();
                this.FilePath2Button2TextBox.Text = dtb2.Rows[0]["FilePath"].ToString();
            }
            cn.Close();

            //=======================================================================================
            // Load Button 3 Data
            //=======================================================================================
            DataTable dtb3 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb3 = new SqlCommand("SELECT * FROM AM_Button3Info", cn);
            SqlDataAdapter sqlDab3 = new SqlDataAdapter(sqlcmdb3);
            sqlDab3.Fill(dtb3);
            if (dtb3.Rows.Count > 0)
            {
                this.Button3NameText.Text = dtb3.Rows[0]["ButtonName"].ToString();
                this.SPName3TextBox.Text = dtb3.Rows[0]["SPName"].ToString();
                this.ParamName1Button3TextBox.Text = dtb3.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button3TextBox.Text = dtb3.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button3TextBox.Text = dtb3.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button3TextBox.Text = dtb3.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button3TextBox.Text = dtb3.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button3TextBox.Text = dtb3.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button3TextBox.Text = dtb3.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button3TextBox.Text = dtb3.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button3TextBox.Text = dtb3.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button3TextBox.Text = dtb3.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath3Button3TextBox.Text = dtb3.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam3Button3TextBox.Text = dtb3.Rows[0]["ExecutableParam"].ToString();
                this.FilePath3Button3TextBox.Text = dtb3.Rows[0]["FilePath"].ToString();
            }
            cn.Close();

            //=======================================================================================
            // Load Button 4 Data
            //=======================================================================================
            DataTable dtb4 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb4 = new SqlCommand("SELECT * FROM AM_Button4Info", cn);
            SqlDataAdapter sqlDab4 = new SqlDataAdapter(sqlcmdb4);
            sqlDab4.Fill(dtb4);
            if (dtb4.Rows.Count > 0)
            {
                this.Button4NameText.Text = dtb4.Rows[0]["ButtonName"].ToString();
                this.SPName4TextBox.Text = dtb4.Rows[0]["SPName"].ToString();
                this.ParamName1Button4TextBox.Text = dtb4.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button4TextBox.Text = dtb4.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button4TextBox.Text = dtb4.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button4TextBox.Text = dtb4.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button4TextBox.Text = dtb4.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button4TextBox.Text = dtb4.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button4TextBox.Text = dtb4.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button4TextBox.Text = dtb4.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button4TextBox.Text = dtb4.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button4TextBox.Text = dtb4.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath4Button4TextBox.Text = dtb4.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam4Button4TextBox.Text = dtb4.Rows[0]["ExecutableParam"].ToString();
                this.FilePath4Button4TextBox.Text = dtb4.Rows[0]["FilePath"].ToString();
            }
            cn.Close();

            //=======================================================================================
            // Load Button 5 Data
            //=======================================================================================
            DataTable dtb5 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb5 = new SqlCommand("SELECT * FROM AM_Button5Info", cn);
            SqlDataAdapter sqlDab5 = new SqlDataAdapter(sqlcmdb5);
            sqlDab5.Fill(dtb5);
            if (dtb5.Rows.Count > 0)
            {
                this.Button5NameText.Text = dtb5.Rows[0]["ButtonName"].ToString();
                this.SPName5TextBox.Text = dtb5.Rows[0]["SPName"].ToString();
                this.ParamName1Button5TextBox.Text = dtb5.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button5TextBox.Text = dtb5.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button5TextBox.Text = dtb5.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button5TextBox.Text = dtb5.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button5TextBox.Text = dtb5.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button5TextBox.Text = dtb5.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button5TextBox.Text = dtb5.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button5TextBox.Text = dtb5.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button5TextBox.Text = dtb5.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button5TextBox.Text = dtb5.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath5Button5TextBox.Text = dtb5.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam5Button5TextBox.Text = dtb5.Rows[0]["ExecutableParam"].ToString();
                this.FilePath5Button5TextBox.Text = dtb5.Rows[0]["FilePath"].ToString();
            }
            cn.Close();

            //=======================================================================================
            // Load Button 5 Data
            //=======================================================================================
            DataTable dtb6 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb6 = new SqlCommand("SELECT * FROM AM_Button6Info", cn);
            SqlDataAdapter sqlDab6 = new SqlDataAdapter(sqlcmdb6);
            sqlDab6.Fill(dtb6);
            if (dtb6.Rows.Count > 0)
            {
                this.Button6NameText.Text = dtb6.Rows[0]["ButtonName"].ToString();
                this.SPName6TextBox.Text = dtb6.Rows[0]["SPName"].ToString();
                this.ParamName1Button6TextBox.Text = dtb6.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button6TextBox.Text = dtb6.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button6TextBox.Text = dtb6.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button6TextBox.Text = dtb6.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button6TextBox.Text = dtb6.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button6TextBox.Text = dtb6.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button6TextBox.Text = dtb6.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button6TextBox.Text = dtb6.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button6TextBox.Text = dtb6.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button6TextBox.Text = dtb6.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath6Button6TextBox.Text = dtb6.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam6Button6TextBox.Text = dtb6.Rows[0]["ExecutableParam"].ToString();
                this.FilePath6Button6TextBox.Text = dtb6.Rows[0]["FilePath"].ToString();
            }
            cn.Close();

            //=======================================================================================
            // Load Button 7 Data
            //=======================================================================================
            DataTable dtb7 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb7 = new SqlCommand("SELECT * FROM AM_Button7Info", cn);
            SqlDataAdapter sqlDab7 = new SqlDataAdapter(sqlcmdb7);
            sqlDab7.Fill(dtb7);
            if (dtb7.Rows.Count > 0)
            {
                this.Button7NameText.Text = dtb7.Rows[0]["ButtonName"].ToString();
                this.SPName7TextBox.Text = dtb7.Rows[0]["SPName"].ToString();
                this.ParamName1Button7TextBox.Text = dtb7.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button7TextBox.Text = dtb7.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button7TextBox.Text = dtb7.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button7TextBox.Text = dtb7.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button7TextBox.Text = dtb7.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button7TextBox.Text = dtb7.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button7TextBox.Text = dtb7.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button7TextBox.Text = dtb7.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button7TextBox.Text = dtb7.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button7TextBox.Text = dtb7.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath7Button7TextBox.Text = dtb7.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam7Button7TextBox.Text = dtb7.Rows[0]["ExecutableParam"].ToString();
                this.FilePath7Button7TextBox.Text = dtb7.Rows[0]["FilePath"].ToString();
            }
            cn.Close();

            //=======================================================================================
            // Load Button 8 Data
            //=======================================================================================
            DataTable dtb8 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb8 = new SqlCommand("SELECT * FROM AM_Button8Info", cn);
            SqlDataAdapter sqlDab8 = new SqlDataAdapter(sqlcmdb8);
            sqlDab8.Fill(dtb8);
            if (dtb8.Rows.Count > 0)
            {
                this.Button8NameText.Text = dtb8.Rows[0]["ButtonName"].ToString();
                this.SPName8TextBox.Text = dtb8.Rows[0]["SPName"].ToString();
                this.ParamName1Button8TextBox.Text = dtb8.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button8TextBox.Text = dtb8.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button8TextBox.Text = dtb8.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button8TextBox.Text = dtb8.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button8TextBox.Text = dtb8.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button8TextBox.Text = dtb8.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button8TextBox.Text = dtb8.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button8TextBox.Text = dtb8.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button8TextBox.Text = dtb8.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button8TextBox.Text = dtb8.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath8Button8TextBox.Text = dtb8.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam8Button8TextBox.Text = dtb8.Rows[0]["ExecutableParam"].ToString();
                this.FilePath8Button8TextBox.Text = dtb8.Rows[0]["FilePath"].ToString();
            }
            cn.Close();

            //=======================================================================================
            // Load Button 9 Data
            //=======================================================================================
            DataTable dtb9 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb9 = new SqlCommand("SELECT * FROM AM_Button9Info", cn);
            SqlDataAdapter sqlDab9 = new SqlDataAdapter(sqlcmdb9);
            sqlDab9.Fill(dtb9);
            if (dtb9.Rows.Count > 0)
            {
                this.Button9NameText.Text = dtb9.Rows[0]["ButtonName"].ToString();
                this.SPName9TextBox.Text = dtb9.Rows[0]["SPName"].ToString();
                this.ParamName1Button9TextBox.Text = dtb9.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button9TextBox.Text = dtb9.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button9TextBox.Text = dtb9.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button9TextBox.Text = dtb9.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button9TextBox.Text = dtb9.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button9TextBox.Text = dtb9.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button9TextBox.Text = dtb9.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button9TextBox.Text = dtb9.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button9TextBox.Text = dtb9.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button9TextBox.Text = dtb9.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath9Button9TextBox.Text = dtb9.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam9Button9TextBox.Text = dtb9.Rows[0]["ExecutableParam"].ToString();
                this.FilePath9Button9TextBox.Text = dtb9.Rows[0]["FilePath"].ToString();
            }
            cn.Close();

            //=======================================================================================
            // Load Button 10 Data
            //=======================================================================================
            DataTable dtb10 = new DataTable();
            cn.Open();
            SqlCommand sqlcmdb10 = new SqlCommand("SELECT * FROM AM_Button10Info", cn);
            SqlDataAdapter sqlDab10 = new SqlDataAdapter(sqlcmdb10);
            sqlDab10.Fill(dtb10);
            if (dtb10.Rows.Count > 0)
            {
                this.Button10NameText.Text = dtb10.Rows[0]["ButtonName"].ToString();
                this.SPName10TextBox.Text = dtb10.Rows[0]["SPName"].ToString();
                this.ParamName1Button10TextBox.Text = dtb10.Rows[0]["ParamName1"].ToString();
                this.ParamName2Button10TextBox.Text = dtb10.Rows[0]["ParamName2"].ToString();
                this.ParamName3Button10TextBox.Text = dtb10.Rows[0]["ParamName3"].ToString();
                this.ParamName4Button10TextBox.Text = dtb10.Rows[0]["ParamName4"].ToString();
                this.ParamName5Button10TextBox.Text = dtb10.Rows[0]["ParamName5"].ToString();
                this.ParamValue1Button10TextBox.Text = dtb10.Rows[0]["ParamValue1"].ToString();
                this.ParamValue2Button10TextBox.Text = dtb10.Rows[0]["ParamValue2"].ToString();
                this.ParamValue3Button10TextBox.Text = dtb10.Rows[0]["ParamValue3"].ToString();
                this.ParamValue4Button10TextBox.Text = dtb10.Rows[0]["ParamValue4"].ToString();
                this.ParamValue5Button10TextBox.Text = dtb10.Rows[0]["ParamValue5"].ToString();

                this.ExecutePath10Button10TextBox.Text = dtb10.Rows[0]["ExecutablePath"].ToString();
                this.ExecuteParam10Button10TextBox.Text = dtb10.Rows[0]["ExecutableParam"].ToString();
                this.FilePath10Button10TextBox.Text = dtb10.Rows[0]["FilePath"].ToString();
            }
            cn.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EXE1String = ExecutePath1Button1TextBox.Text;
            //Properties.Settings.Default.EXE2String = EXE2TextBox.Text;
            //Properties.Settings.Default.EXE3String = EXE3TextBox.Text;
            //Properties.Settings.Default.EXE4String = EXE4TextBox.Text;
            //Properties.Settings.Default.EXE5String = EXE5TextBox.Text;
            //Properties.Settings.Default.EXE6String = EXE6TextBox.Text;
            //Properties.Settings.Default.EXE7String = EXE7TextBox.Text;
            //Properties.Settings.Default.EXE8String = EXE8TextBox.Text;
            //Properties.Settings.Default.EXE9String = EXE9TextBox.Text;
            //Properties.Settings.Default.EXE10String = EXE10TextBox.Text;

            Properties.Settings.Default.Param1String = ExecuteParam1Button1TextBox.Text;
            //Properties.Settings.Default.Param2String = Param2TextBox.Text;
            //Properties.Settings.Default.Param3String = Param3TextBox.Text;
            //Properties.Settings.Default.Param4String = Param4TextBox.Text;
            //Properties.Settings.Default.Param5String = Param5TextBox.Text;
            //Properties.Settings.Default.Param6String = Param6TextBox.Text;
            //Properties.Settings.Default.Param7String = Param7TextBox.Text;
            //Properties.Settings.Default.Param8String = Param8TextBox.Text;
            //Properties.Settings.Default.Param9String = Param9TextBox.Text;
            //Properties.Settings.Default.Param10String = Param10TextBox.Text;

            Properties.Settings.Default.EXE1checkBoxString = EXE1checkBox.Checked;
            //Properties.Settings.Default.EXE2checkBoxString = EXE2checkBox.Checked;
            //Properties.Settings.Default.EXE3checkBoxString = EXE3checkBox.Checked;
            //Properties.Settings.Default.EXE4checkBoxString = EXE4checkBox.Checked;
            //Properties.Settings.Default.EXE5checkBoxString = EXE5checkBox.Checked;
            //Properties.Settings.Default.EXE6checkBoxString = EXE6checkBox.Checked;
            //Properties.Settings.Default.EXE7checkBoxString = EXE7checkBox.Checked;
            //Properties.Settings.Default.EXE8checkBoxString = EXE8checkBox.Checked;
            //Properties.Settings.Default.EXE9checkBoxString = EXE9checkBox.Checked;
            //Properties.Settings.Default.EXE10checkBoxString = EXE10checkBox.Checked;

            Properties.Settings.Default.Save();

            // Save the data from the text fields in the database
            // TO-DO Need to replace the button text in the Values to use Parameters instead (@Button1Name instead of Button1NameText.Text)
            // TO - DO Need to do this https://stackoverflow.com/questions/19866570/how-do-i-encrypt-user-settings

            //SqlCommand cmd = new SqlCommand
            //    (
            //        "update AM_Buttons" +
            //        "set " +
            //        "ButtonName = '" + Button1NameText.Text + "', " +
            //        "SPName = '" + SPName1TextBox.Text + "', " +
            //        "WHERE ButtonID = '1'", cn);
            //cn.Open();
            //cmd.ExecuteNonQuery();
            //cn.Close();
            //MessageBox.Show("Record updated");

            Properties.Settings.Default.SPName1String = SPName1TextBox.Text;
            Properties.Settings.Default.SPName2String = SPName2TextBox.Text;
            Properties.Settings.Default.SPName3String = SPName3TextBox.Text;
            Properties.Settings.Default.SPName4String = SPName4TextBox.Text;
            Properties.Settings.Default.SPName5String = SPName5TextBox.Text;
            Properties.Settings.Default.SPName6String = SPName6TextBox.Text;
            Properties.Settings.Default.SPName7String = SPName7TextBox.Text;
            Properties.Settings.Default.SPName8String = SPName8TextBox.Text;
            Properties.Settings.Default.SPName9String = SPName9TextBox.Text;
            Properties.Settings.Default.SPName10String = SPName10TextBox.Text;

            //Properties.Settings.Default.ParamName1String = ParamName1TextBox.Text;
            //Properties.Settings.Default.ParamName2String = ParamName2TextBox.Text;
            //Properties.Settings.Default.ParamName3String = ParamName3TextBox.Text;
            //Properties.Settings.Default.ParamName4String = ParamName4TextBox.Text;
            //Properties.Settings.Default.ParamName5String = ParamName5TextBox.Text;
            //Properties.Settings.Default.ParamName6String = ParamName6TextBox.Text;
            //Properties.Settings.Default.ParamName7String = ParamName7TextBox.Text;
            //Properties.Settings.Default.ParamName8String = ParamName8TextBox.Text;
            //Properties.Settings.Default.ParamName9String = ParamName9TextBox.Text;
            //Properties.Settings.Default.ParamName10String = ParamName10TextBox.Text;
            Properties.Settings.Default.Save();



            LoadButtonConfig();

            this.Close();
        }

        private void ImportTestButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.EXE1String, Properties.Settings.Default.Param1String);
        }

        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Name == "Button2Node")
            {
                this.TabControl.SelectTab("Button2Tab");
            }

        }

        private void Button1NameText_Click(object sender, EventArgs e)
        {
            Info1TextBox.Text = Properties.Settings.Default.InfoTextBoxButtonNameString;
        }

        private void SPName1TextBox_Click(object sender, EventArgs e)
        {
            Info1TextBox.Text = Properties.Settings.Default.InfoTextBoxSPNameString;
        }

        //=======================================================================================
        // Execute Check Box for each Tab
        //=======================================================================================
        private void EXEcheckBox1_CheckedChanged(object sender, EventArgs e) // Execute Check Box Tab 1
        {
            // If checked then run exe
        }


        //=======================================================================================
        // Notes Button for each Tab
        //=======================================================================================
        private void Notes1Button_Click(object sender, EventArgs e) // Notes Button Tab 1
        {

        }

        //=======================================================================================
        // Save Button for Tab 1
        //=======================================================================================
        private void Save1Button1_Click(object sender, EventArgs e) // Save Button Tab 1
        {
            SqlCommand Button1NameCMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button1NameText.Text + "', " +
                "SPName = '" + SPName1TextBox.Text + "'" +
                "WHERE ButtonID = '1'", cn
                );
            cn.Open();
            Button1NameCMD.ExecuteNonQuery();
            cn.Close();

            SqlCommand Button1ParamsCMD = new SqlCommand
                (
                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button1TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button1TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '1' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button1TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button1TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '1' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button1TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button1TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '1' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button1TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button1TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '1' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button1TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button1TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '1' "

                , cn
                 );
            cn.Open();
            Button1ParamsCMD.ExecuteNonQuery();
            cn.Close();

            SqlCommand Button1ExecutableCMD = new SqlCommand
                (
                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath1Button1TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam1Button1TextBox.Text + "'" +
                "WHERE " +
                "ExecutableID = '1' " +
                "AND " +
                "ButtonID = '1'"

                , cn
                 );
            cn.Open();
            Button1ExecutableCMD.ExecuteNonQuery();
            cn.Close();

            SqlCommand Button1FileCMD = new SqlCommand
                (
                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath1Button1TextBox.Text + "'" +
                "WHERE " +
                "FileID = '1' " +
                "AND " +
                "ButtonID = '1'"

                , cn
                 );
            cn.Open();
            Button1FileCMD.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Record updated");
        }

        private void Save2Button2_Click(object sender, EventArgs e) // Save Button Tab 2
        {
            SqlCommand cmd = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button2NameText.Text + "', " +
                "SPName = '" + SPName2TextBox.Text + "'" +
                "WHERE ButtonID = '2'", cn
                );
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");
        }

        private void Save3Button3_Click(object sender, EventArgs e) // Save Button Tab 3
        {
            SqlCommand cmd = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button3NameText.Text + "', " +
                "SPName = '" + SPName3TextBox.Text + "'" +
                "WHERE ButtonID = '3'", cn
                );
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");
        }

        private void Save4Button4_Click(object sender, EventArgs e) // Save Button Tab 4
        {
            SqlCommand cmd = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button4NameText.Text + "', " +
                "SPName = '" + SPName4TextBox.Text + "'" +
                "WHERE ButtonID = '4'", cn
                );
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");
        }

        private void Save5Button5_Click(object sender, EventArgs e) // Save Button Tab 5
        {
            SqlCommand cmd = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button5NameText.Text + "', " +
                "SPName = '" + SPName5TextBox.Text + "'" +
                "WHERE ButtonID = '5'", cn
                );
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");
        }

        private void Save6Button6_Click(object sender, EventArgs e) // Save Button Tab 6
        {
            SqlCommand cmd = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button6NameText.Text + "', " +
                "SPName = '" + SPName6TextBox.Text + "'" +
                "WHERE ButtonID = '6'", cn
                );
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");
        }

        private void Save7Button7_Click(object sender, EventArgs e) // Save Button Tab 7
        {
            SqlCommand cmd = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button7NameText.Text + "', " +
                "SPName = '" + SPName7TextBox.Text + "'" +
                "WHERE ButtonID = '7'", cn
                );
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");
        }

        private void Save8Button8_Click(object sender, EventArgs e) // Save Button Tab 8
        {
            SqlCommand cmd = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button8NameText.Text + "', " +
                "SPName = '" + SPName8TextBox.Text + "'" +
                "WHERE ButtonID = '8'", cn
                );
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");
        }

        private void Save9Button9_Click(object sender, EventArgs e) // Save Button Tab 9
        {
            SqlCommand cmd = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button9NameText.Text + "', " +
                "SPName = '" + SPName9TextBox.Text + "'" +
                "WHERE ButtonID = '9'", cn
                );
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");
        }

        private void Save10Button10_Click(object sender, EventArgs e) // Save Button Tab 10
        {
            SqlCommand cmd = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button10NameText.Text + "', " +
                "SPName = '" + SPName10TextBox.Text + "'" +
                "WHERE ButtonID = '10'", cn
                );
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");
        }




// No code needed

        private void EXE1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Param1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName1TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
