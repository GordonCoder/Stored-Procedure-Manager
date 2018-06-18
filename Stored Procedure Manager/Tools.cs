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
using System.Diagnostics;
using System.IO;

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
            
        //CreateDBLoading t = new CreateDBLoading();
        //t.Show();
        //t.Focus();
        //t.CreateDBProgressBarTimer.Start();

        String strDB;
        SqlConnection cnDB = new SqlConnection
            (
            "server="
            + Properties.Settings.Default.ServerNameString
            + "\\" + Properties.Settings.Default.InstanceString
            + ";database= master" 
            + ";uid=" + Properties.Settings.Default.UserNameString
            + ";pwd=" + Properties.Settings.Default.PasswordString
            );

        strDB = "CREATE DATABASE [AutomationManager]";

        SqlCommand cmdDB = new SqlCommand(strDB, cnDB);
            try
            {
                cnDB.Open();
                cmdDB.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Database Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (cnDB.State == ConnectionState.Open)
                {
                    cnDB.Close();
                }
            }


            String strTables;
            SqlConnection cnTables = new SqlConnection
                (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString
                );

            strTables =
                " CREATE TABLE dbo.AM_Buttons " +
                "(ButtonID INT NOT NULL ,ButtonName VARCHAR(50) NULL ,SPName VARCHAR(50) NULL ,CONSTRAINT PK_AM_Buttons PRIMARY KEY CLUSTERED(ButtonID ASC))" +

                " WAITFOR DELAY '00:00:01'" +

                " CREATE TABLE dbo.AM_Notes " +
                "(NoteID INT NOT NULL ,ButtonID INT NOT NULL ,NoteText VARCHAR(50) NULL ,CONSTRAINT PK_AM_Notes PRIMARY KEY CLUSTERED(NoteID ASC, ButtonID ASC),CONSTRAINT FK_49 FOREIGN KEY(ButtonID)REFERENCES dbo.AM_Buttons (ButtonID))" +

                " WAITFOR DELAY '00:00:01'" +

                " CREATE TABLE dbo.AM_FileImport " +
                "(FileID INT NOT NULL ,ButtonID INT NOT NULL ,FilePath VARCHAR(50) NULL ,CONSTRAINT PK_FileImport PRIMARY KEY CLUSTERED(FileID ASC, ButtonID ASC),CONSTRAINT FK_45 FOREIGN KEY(ButtonID)REFERENCES dbo.AM_Buttons (ButtonID))" +

                " WAITFOR DELAY '00:00:01'" +

                " CREATE TABLE dbo.AM_Executable " +
                "(ExecutableID INT NOT NULL ,ButtonID INT NOT NULL ,ExecutablePath VARCHAR(50) NULL ,ExecutableParam VARCHAR(50) NULL ,CONSTRAINT PK_AM_Executable PRIMARY KEY CLUSTERED(ExecutableID ASC, ButtonID ASC),CONSTRAINT FK_41 FOREIGN KEY(ButtonID)REFERENCES dbo.AM_Buttons (ButtonID))" +

                " WAITFOR DELAY '00:00:01'" +

                " CREATE TABLE dbo.AM_ButtonParam " +
                "(ParamID INT NOT NULL ,ButtonID INT NOT NULL ,ParamName VARCHAR(50) NULL ,ParamValue VARCHAR(50) NULL ,CONSTRAINT PK_AM_ButtonParam PRIMARY KEY CLUSTERED(ParamID ASC, ButtonID ASC),CONSTRAINT FK_21 FOREIGN KEY(ButtonID)REFERENCES dbo.AM_Buttons (ButtonID))";

            SqlCommand cmdTables = new SqlCommand(strTables, cnTables);
            try
            {
                cnTables.Open();
                cmdTables.ExecuteNonQuery();
                //t.CreateDBProgressBarTimer.Stop();
                if (MessageBox.Show
                    ("The Automation Manager Database and Tables were successfully created!", "Tables Created", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    //t.Hide();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Table Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (cnTables.State == ConnectionState.Open)
                {
                    cnTables.Close();
                }
            }

            String strV1;
            String strV2;
            String strV3;
            String strV4;
            String strV5;
            String strV6;
            String strV7;
            String strV8;
            String strV9;
            String strV10;

            SqlConnection cnV = new SqlConnection
                (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString
                );

            FileInfo file1 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo1.sql");
            FileInfo file2 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo2.sql");
            FileInfo file3 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo3.sql");
            FileInfo file4 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo4.sql");
            FileInfo file5 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo5.sql");
            FileInfo file6 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo6.sql");
            FileInfo file7 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo7.sql");
            FileInfo file8 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo8.sql");
            FileInfo file9 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo9.sql");
            FileInfo file10 = new FileInfo("C:\\Users\\sean\\source\\repos\\Stored Procedure Manager\\SQL\\Views\\ButtonInfo10.sql");

            strV1 = file1.OpenText().ReadToEnd();
            strV2 = file2.OpenText().ReadToEnd();
            strV3 = file3.OpenText().ReadToEnd();
            strV4 = file4.OpenText().ReadToEnd();
            strV5 = file5.OpenText().ReadToEnd();
            strV6 = file6.OpenText().ReadToEnd();
            strV7 = file7.OpenText().ReadToEnd();
            strV8 = file8.OpenText().ReadToEnd();
            strV9 = file9.OpenText().ReadToEnd();
            strV10 = file10.OpenText().ReadToEnd();

            SqlCommand cmdV1 = new SqlCommand(strV1, cnV);
            SqlCommand cmdV2 = new SqlCommand(strV2, cnV);
            SqlCommand cmdV3 = new SqlCommand(strV3, cnV);
            SqlCommand cmdV4 = new SqlCommand(strV4, cnV);
            SqlCommand cmdV5 = new SqlCommand(strV5, cnV);
            SqlCommand cmdV6 = new SqlCommand(strV6, cnV);
            SqlCommand cmdV7 = new SqlCommand(strV7, cnV);
            SqlCommand cmdV8 = new SqlCommand(strV8, cnV);
            SqlCommand cmdV9 = new SqlCommand(strV9, cnV);
            SqlCommand cmdV10 = new SqlCommand(strV10, cnV);

            try
            {
                cnV.Open();
                cmdV1.ExecuteNonQuery();
                cmdV2.ExecuteNonQuery();
                cmdV3.ExecuteNonQuery();
                cmdV4.ExecuteNonQuery();
                cmdV5.ExecuteNonQuery();
                cmdV6.ExecuteNonQuery();
                cmdV7.ExecuteNonQuery();
                cmdV8.ExecuteNonQuery();
                cmdV9.ExecuteNonQuery();
                cmdV10.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "View Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (cnV.State == ConnectionState.Open)
                {
                    cnV.Close();
                }
            }

        }

        private void SPButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection
                        (
                        "server="
                        + Properties.Settings.Default.ServerNameString
                        + "\\" + Properties.Settings.Default.InstanceString
                        + ";database= AutomationManager"
                        + ";uid=" + Properties.Settings.Default.UserNameString
                        + ";pwd=" + Properties.Settings.Default.PasswordString
                        ))
                try
                {
                    cn.Open();
                    using
                        (SqlCommand command = new SqlCommand(
                            // After testing, use this name for the table cust_SPManagerButtonConfig
                            "CREATE Procedure ButtonTest " +
                            "AS " +
                            //"IF NOT EXISTS (SELECT * FROM AM_Buttons WHERE ButtonID = 10) " +
                            "INSERT INTO dbo.AM_Buttons (ButtonName,SPName) VALUES ('Button Name Test','SP Name Test') WHERE ButtonID = 10"
                            //"ELSE UPDATE cust_SPManagerConfig " +
                            //"SET ButtonName10 = 'TEST WORKED' " +
                            //",SPName10 = 'TEST WORKED';" +


//"INSERT INTO dbo.AM_Buttons (ButtonID,ButtonName,SPName) VALUES ('10','Button Name Test','SP Name Test')" +
//"INSERT INTO dbo.AM_ButtonParam (ParamID,ButtonID,ParamName,ParamValue) VALUES ('1','10','Param 1 Name Test','Param 1 Value Test'),('2','10','Param 2 Name Test','Param 2 Value Test'),('3','10','Param 3 Name Test','Param 3 Value Test'),('4','10','Param 4  Name Test','Param 4 Value Test'),('5','10','Param 5  Name Test','Param 5 Value Test')" +
//"INSERT INTO dbo.AM_Executable (ExecutableID,ButtonID,ExecutablePath,ExecutableParam) VALUES ('10','10','Executable Path Test','Executable Param Test')" +
//"INSERT INTO dbo.AM_FileImport (FileID,ButtonID,FilePath) VALUES ('10','10','File Path Test')" +
//"INSERT INTO dbo.AM_Notes (NoteID,ButtonID,NoteText) VALUES ('10','10','Note Text Test')"
                            , cn))
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
            OpenFileDialog InstallerFileLocation = new OpenFileDialog();
            InstallerFileLocation.InitialDirectory = Properties.Settings.Default.InstallerFolderString;
            if (InstallerFileLocation.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String FilePath = InstallerFileLocation.FileName;
                Process.Start(FilePath);
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection
            (
            "server="
            + Properties.Settings.Default.ServerNameString
            + "\\" + Properties.Settings.Default.InstanceString
            + ";database= AutomationManager"
            + ";uid=" + Properties.Settings.Default.UserNameString
            + ";pwd=" + Properties.Settings.Default.PasswordString
            ))
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("ButtonTest", cn);
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

        private void CreateDBProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
