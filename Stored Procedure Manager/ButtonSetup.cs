﻿using System;
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
        SqlConnection cnAMDB = new SqlConnection
            (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString
            );
        public ButtonSetup()
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
                LoadButtonConfig();
                cnAMDB.Close();
            }
                      
        }

        private void LoadButtonConfig() // Need to Try statements
        {
            treeView1.ExpandAll();

            //=======================================================================================
            // Load Button 1 Data
            //=======================================================================================
            DataTable dtb1 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb1 = new SqlCommand("SELECT * FROM AM_Button1Info", cnAMDB); 
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
                this.ExecuteCheckBoxButton1.Checked = (bool)dtb1.Rows[0]["EPCheckBox"];
                this.FilePath1Button1TextBox.Text = dtb1.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton1.Checked = (bool)dtb1.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();

            //=======================================================================================
            // Load Button 2 Data
            //=======================================================================================
            DataTable dtb2 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb2 = new SqlCommand("SELECT * FROM AM_Button2Info", cnAMDB);
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
                this.ExecuteCheckBoxButton2.Checked = (bool)dtb2.Rows[0]["EPCheckBox"];
                this.FilePath2Button2TextBox.Text = dtb2.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton2.Checked = (bool)dtb2.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();

            //=======================================================================================
            // Load Button 3 Data
            //=======================================================================================
            DataTable dtb3 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb3 = new SqlCommand("SELECT * FROM AM_Button3Info", cnAMDB);
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
                this.ExecuteCheckBoxButton3.Checked = (bool)dtb3.Rows[0]["EPCheckBox"];
                this.FilePath3Button3TextBox.Text = dtb3.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton3.Checked = (bool)dtb3.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();

            //=======================================================================================
            // Load Button 4 Data
            //=======================================================================================
            DataTable dtb4 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb4 = new SqlCommand("SELECT * FROM AM_Button4Info", cnAMDB);
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
                this.ExecuteCheckBoxButton4.Checked = (bool)dtb4.Rows[0]["EPCheckBox"];
                this.FilePath4Button4TextBox.Text = dtb4.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton4.Checked = (bool)dtb4.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();

            //=======================================================================================
            // Load Button 5 Data
            //=======================================================================================
            DataTable dtb5 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb5 = new SqlCommand("SELECT * FROM AM_Button5Info", cnAMDB);
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
                this.ExecuteCheckBoxButton5.Checked = (bool)dtb5.Rows[0]["EPCheckBox"];
                this.FilePath5Button5TextBox.Text = dtb5.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton5.Checked = (bool)dtb5.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();

            //=======================================================================================
            // Load Button 5 Data
            //=======================================================================================
            DataTable dtb6 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb6 = new SqlCommand("SELECT * FROM AM_Button6Info", cnAMDB);
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
                this.ExecuteCheckBoxButton6.Checked = (bool)dtb6.Rows[0]["EPCheckBox"];
                this.FilePath6Button6TextBox.Text = dtb6.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton6.Checked = (bool)dtb6.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();

            //=======================================================================================
            // Load Button 7 Data
            //=======================================================================================
            DataTable dtb7 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb7 = new SqlCommand("SELECT * FROM AM_Button7Info", cnAMDB);
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
                this.ExecuteCheckBoxButton7.Checked = (bool)dtb7.Rows[0]["EPCheckBox"];
                this.FilePath7Button7TextBox.Text = dtb7.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton7.Checked = (bool)dtb7.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();

            //=======================================================================================
            // Load Button 8 Data
            //=======================================================================================
            DataTable dtb8 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb8 = new SqlCommand("SELECT * FROM AM_Button8Info", cnAMDB);
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
                this.ExecuteCheckBoxButton8.Checked = (bool)dtb8.Rows[0]["EPCheckBox"];
                this.FilePath8Button8TextBox.Text = dtb8.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton8.Checked = (bool)dtb8.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();

            //=======================================================================================
            // Load Button 9 Data
            //=======================================================================================
            DataTable dtb9 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb9 = new SqlCommand("SELECT * FROM AM_Button9Info", cnAMDB);
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
                this.ExecuteCheckBoxButton9.Checked = (bool)dtb9.Rows[0]["EPCheckBox"];
                this.FilePath9Button9TextBox.Text = dtb9.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton9.Checked = (bool)dtb9.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();

            //=======================================================================================
            // Load Button 10 Data
            //=======================================================================================
            DataTable dtb10 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb10 = new SqlCommand("SELECT * FROM AM_Button10Info", cnAMDB);
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
                this.ExecuteCheckBoxButton10.Checked = (bool)dtb10.Rows[0]["EPCheckBox"];
                this.FilePath10Button10TextBox.Text = dtb10.Rows[0]["FilePath"].ToString();
                this.FilePathCheckBoxButton10.Checked = (bool)dtb10.Rows[0]["FPCheckBox"];
            }
            cnAMDB.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

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
        private void ExecuteCheckBoxButton1_CheckedChanged(object sender, EventArgs e) // Execute Check Box Tab 1
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
        private void SaveButton1_Click(object sender, EventArgs e) // Save Button Tab 1
        {
            try
            {
                cnAMDB.Open();
                SqlCommand SaveButton1CMD = new SqlCommand
                    (
                    "update dbo.AM_Buttons " +
                    "set " +
                    "ButtonName = '" + Button1NameText.Text + "', " +
                    "SPName = '" + SPName1TextBox.Text + "'" +
                    "WHERE ButtonID = '1'" +

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
                    "ButtonID = '1' " +

                    "update dbo.AM_Executable " +
                    "set " +
                    "ExecutablePath = '" + ExecutePath1Button1TextBox.Text + "', " +
                    "ExecutableParam = '" + ExecuteParam1Button1TextBox.Text + "', " +
                    "EPCheckBox = '" + ExecuteCheckBoxButton1.Checked + "'" +
                    "WHERE " +
                    "ExecutableID = '1' " +
                    "AND " +
                    "ButtonID = '1'" +

                    "update dbo.AM_FileImport " +
                    "set " +
                    "FilePath = '" + FilePath1Button1TextBox.Text + "', " +
                    "FPCheckBox = '" + FilePathCheckBoxButton1.Checked + "'" +
                    "WHERE " +
                    "FileID = '1' " +
                    "AND " +
                    "ButtonID = '1'"

                    , cnAMDB
                     );
                
                SaveButton1CMD.ExecuteNonQuery();
                MessageBox.Show("Record updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                cnAMDB.Close();
            }
        }

        //=======================================================================================
        // Save Button for Tab 2
        //=======================================================================================
        private void SaveButton2_Click(object sender, EventArgs e) // Save Button Tab 2
        {
            SqlCommand SaveButton2CMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button2NameText.Text + "', " +
                "SPName = '" + SPName2TextBox.Text + "'" +
                "WHERE ButtonID = '2'" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button2TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button2TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '2' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button2TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button2TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '2' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button2TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button2TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '2' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button2TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button2TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '2' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button2TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button2TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '2' " +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath2Button2TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam2Button2TextBox.Text + "', " +
                "EPCheckBox = '" + ExecuteCheckBoxButton2.Checked + "'" +
                "WHERE " +
                "ExecutableID = '2' " +
                "AND " +
                "ButtonID = '2'" +

                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath2Button2TextBox.Text + "', " +
                "FPCheckBox = '" + FilePathCheckBoxButton2.Checked + "'" +
                "WHERE " +
                "FileID = '2' " +
                "AND " +
                "ButtonID = '2'"

                , cnAMDB
                 );
            cnAMDB.Open();
            SaveButton2CMD.ExecuteNonQuery();
            cnAMDB.Close();

            MessageBox.Show("Record updated");
        }

        //=======================================================================================
        // Save Button for Tab 3
        //=======================================================================================
        private void SaveButton3_Click(object sender, EventArgs e) // Save Button Tab 3
        {
            SqlCommand SaveButton3CMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button3NameText.Text + "', " +
                "SPName = '" + SPName3TextBox.Text + "'" +
                "WHERE ButtonID = '3'" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button3TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button3TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '3' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button3TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button3TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '3' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button3TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button3TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '3' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button3TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button3TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '3' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button3TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button3TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '3' " +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath3Button3TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam3Button3TextBox.Text + "', " +
                "EPCheckBox = '" + ExecuteCheckBoxButton3.Checked + "'" +
                "WHERE " +
                "ExecutableID = '3' " +
                "AND " +
                "ButtonID = '3'" +

                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath3Button3TextBox.Text + "', " +
                "FPCheckBox = '" + FilePathCheckBoxButton3.Checked + "'" +
                "WHERE " +
                "FileID = '3' " +
                "AND " +
                "ButtonID = '3'"

                , cnAMDB
                 );
            cnAMDB.Open();
            SaveButton3CMD.ExecuteNonQuery();
            cnAMDB.Close();

            MessageBox.Show("Record updated");
        }

        //=======================================================================================
        // Save Button for Tab 4
        //=======================================================================================
        private void SaveButton4_Click(object sender, EventArgs e) // Save Button Tab 4
        {
            SqlCommand SaveButton4CMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button4NameText.Text + "', " +
                "SPName = '" + SPName4TextBox.Text + "'" +
                "WHERE ButtonID = '4'" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button4TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button4TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '4' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button4TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button4TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '4' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button4TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button4TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '4' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button4TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button4TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '4' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button4TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button4TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '4' " +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath4Button4TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam4Button4TextBox.Text + "', " +
                "EPCheckBox = '" + ExecuteCheckBoxButton4.Checked + "'" +
                "WHERE " +
                "ExecutableID = '4' " +
                "AND " +
                "ButtonID = '4'" +

                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath4Button4TextBox.Text + "', " +
                "FPCheckBox = '" + FilePathCheckBoxButton4.Checked + "'" +
                "WHERE " +
                "FileID = '4' " +
                "AND " +
                "ButtonID = '4'"

                , cnAMDB
                 );
            cnAMDB.Open();
            SaveButton4CMD.ExecuteNonQuery();
            cnAMDB.Close();

            MessageBox.Show("Record updated");
        }

        //=======================================================================================
        // Save Button for Tab 5
        //=======================================================================================
        private void SaveButton5_Click(object sender, EventArgs e) // Save Button Tab 5
        {
            SqlCommand SaveButton5CMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button5NameText.Text + "', " +
                "SPName = '" + SPName5TextBox.Text + "'" +
                "WHERE ButtonID = '5'" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button5TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button5TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '5' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button5TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button5TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '5' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button5TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button5TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '5' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button5TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button5TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '5' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button5TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button5TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '5' " +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath5Button5TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam5Button5TextBox.Text + "', " +
                "EPCheckBox = '" + ExecuteCheckBoxButton5.Checked + "'" +
                "WHERE " +
                "ExecutableID = '5' " +
                "AND " +
                "ButtonID = '5'" +

                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath5Button5TextBox.Text + "', " +
                "FPCheckBox = '" + FilePathCheckBoxButton5.Checked + "'" +
                "WHERE " +
                "FileID = '5' " +
                "AND " +
                "ButtonID = '5'"

                , cnAMDB
                 );
            cnAMDB.Open();
            SaveButton5CMD.ExecuteNonQuery();
            cnAMDB.Close();

            MessageBox.Show("Record updated");
        }

        //=======================================================================================
        // Save Button for Tab 6
        //=======================================================================================
        private void SaveButton6_Click(object sender, EventArgs e) // Save Button Tab 6
        {
            SqlCommand SaveButton6CMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button6NameText.Text + "', " +
                "SPName = '" + SPName6TextBox.Text + "'" +
                "WHERE ButtonID = '6'" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button6TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button6TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '6' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button6TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button6TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '6' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button6TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button6TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '6' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button6TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button6TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '6' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button6TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button6TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '6' " +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath6Button6TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam6Button6TextBox.Text + "', " +
                "EPCheckBox = '" + ExecuteCheckBoxButton6.Checked + "'" +
                "WHERE " +
                "ExecutableID = '6' " +
                "AND " +
                "ButtonID = '6'" +

                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath6Button6TextBox.Text + "', " +
                "FPCheckBox = '" + FilePathCheckBoxButton6.Checked + "'" +
                "WHERE " +
                "FileID = '6' " +
                "AND " +
                "ButtonID = '6'"

                , cnAMDB
                 );
            cnAMDB.Open();
            SaveButton6CMD.ExecuteNonQuery();
            cnAMDB.Close();

            MessageBox.Show("Record updated");
        }

        //=======================================================================================
        // Save Button for Tab 7
        //=======================================================================================
        private void SaveButton7_Click(object sender, EventArgs e) // Save Button Tab 7
        {
            SqlCommand SaveButton7CMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button7NameText.Text + "', " +
                "SPName = '" + SPName7TextBox.Text + "'" +
                "WHERE ButtonID = '7'" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button7TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button7TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '7' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button7TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button7TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '7' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button7TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button7TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '7' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button7TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button7TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '7' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button7TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button7TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '7' " +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath7Button7TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam7Button7TextBox.Text + "', " +
                "EPCheckBox = '" + ExecuteCheckBoxButton7.Checked + "'" +
                "WHERE " +
                "ExecutableID = '7' " +
                "AND " +
                "ButtonID = '7'" +

                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath7Button7TextBox.Text + "', " +
                "FPCheckBox = '" + FilePathCheckBoxButton7.Checked + "'" +
                "WHERE " +
                "FileID = '7' " +
                "AND " +
                "ButtonID = '7'"

                , cnAMDB
                 );
            cnAMDB.Open();
            SaveButton7CMD.ExecuteNonQuery();
            cnAMDB.Close();

            MessageBox.Show("Record updated");
        }

        //=======================================================================================
        // Save Button for Tab 8
        //=======================================================================================
        private void SaveButton8_Click(object sender, EventArgs e) // Save Button Tab 8
        {
            SqlCommand SaveButton8CMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button8NameText.Text + "', " +
                "SPName = '" + SPName8TextBox.Text + "'" +
                "WHERE ButtonID = '8'" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button8TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button8TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '8' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button8TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button8TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '8' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button8TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button8TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '8' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button8TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button8TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '8' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button8TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button8TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '8' " +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath8Button8TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam8Button8TextBox.Text + "', " +
                "EPCheckBox = '" + ExecuteCheckBoxButton8.Checked + "'" +
                "WHERE " +
                "ExecutableID = '8' " +
                "AND " +
                "ButtonID = '8'" +

                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath8Button8TextBox.Text + "', " +
                "FPCheckBox = '" + FilePathCheckBoxButton8.Checked + "'" +
                "WHERE " +
                "FileID = '8' " +
                "AND " +
                "ButtonID = '8'"

                , cnAMDB
                 );
            cnAMDB.Open();
            SaveButton8CMD.ExecuteNonQuery();
            cnAMDB.Close();

            MessageBox.Show("Record updated");
        }

        //=======================================================================================
        // Save Button for Tab 9
        //=======================================================================================
        private void SaveButton9_Click(object sender, EventArgs e) // Save Button Tab 9
        {
            SqlCommand SaveButton9CMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button9NameText.Text + "', " +
                "SPName = '" + SPName9TextBox.Text + "'" +
                "WHERE ButtonID = '9'" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button9TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button9TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '9' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button9TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button9TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '9' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button9TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button9TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '9' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button9TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button9TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '9' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button9TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button9TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '9' " +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath9Button9TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam9Button9TextBox.Text + "', " +
                "EPCheckBox = '" + ExecuteCheckBoxButton9.Checked + "'" +
                "WHERE " +
                "ExecutableID = '9' " +
                "AND " +
                "ButtonID = '9'" +

                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath9Button9TextBox.Text + "', " +
                "FPCheckBox = '" + FilePathCheckBoxButton9.Checked + "'" +
                "WHERE " +
                "FileID = '9' " +
                "AND " +
                "ButtonID = '9'"

                , cnAMDB
                 );
            cnAMDB.Open();
            SaveButton9CMD.ExecuteNonQuery();
            cnAMDB.Close();

            MessageBox.Show("Record updated");
        }

        //=======================================================================================
        // Save Button for Tab 10
        //=======================================================================================
        private void SaveButton10_Click(object sender, EventArgs e) // Save Button Tab 10
        {
            SqlCommand SaveButton10CMD = new SqlCommand
                (
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + Button10NameText.Text + "', " +
                "SPName = '" + SPName10TextBox.Text + "'" +
                "WHERE ButtonID = '10'" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1Button10TextBox.Text + "', " +
                "ParamValue = '" + ParamValue1Button10TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = '10' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2Button10TextBox.Text + "', " +
                "ParamValue = '" + ParamValue2Button10TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = '10' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3Button10TextBox.Text + "', " +
                "ParamValue= '" + ParamValue3Button10TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = '10' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button10TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button10TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = '10' " +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4Button10TextBox.Text + "', " +
                "ParamValue= '" + ParamValue4Button10TextBox.Text + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = '10' " +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutePath10Button10TextBox.Text + "', " +
                "ExecutableParam = '" + ExecuteParam10Button10TextBox.Text + "', " +
                "EPCheckBox = '" + ExecuteCheckBoxButton10.Checked + "'" +
                "WHERE " +
                "ExecutableID = '10' " +
                "AND " +
                "ButtonID = '10'" +

                "update dbo.AM_FileImport " +
                "set " +
                "FilePath = '" + FilePath10Button10TextBox.Text + "', " +
                "FPCheckBox = '" + FilePathCheckBoxButton10.Checked + "'" +
                "WHERE " +
                "FileID = '10' " +
                "AND " +
                "ButtonID = '10'"

                , cnAMDB
                 );
            cnAMDB.Open();
            SaveButton10CMD.ExecuteNonQuery();
            cnAMDB.Close();

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

        private void FilePathCheckBoxButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
