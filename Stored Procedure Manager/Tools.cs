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

            //=====================================================================================================================
            // Create Tables in the database
            //=====================================================================================================================
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

                " CREATE TABLE dbo.AM_ButtonParam " +
                "(ParamID INT NOT NULL ,ButtonID INT NOT NULL ,ParamName VARCHAR(50) NULL ,ParamValue VARCHAR(MAX) NULL ,CONSTRAINT PK_AM_ButtonParam PRIMARY KEY CLUSTERED(ParamID ASC, ButtonID ASC),CONSTRAINT FK_21 FOREIGN KEY(ButtonID)REFERENCES dbo.AM_Buttons (ButtonID))" +

                " WAITFOR DELAY '00:00:01'" +

                " CREATE TABLE dbo.AM_Executable " +
                "(ExecutableID INT NOT NULL ,ButtonID INT NOT NULL ,ExecutablePath VARCHAR(MAX) NULL ,EPCheckBox [bit] NULL ,ExecutableParam VARCHAR(MAX) NULL ,CONSTRAINT PK_AM_Executable PRIMARY KEY CLUSTERED(ExecutableID ASC, ButtonID ASC),CONSTRAINT FK_41 FOREIGN KEY(ButtonID)REFERENCES dbo.AM_Buttons (ButtonID))" +

                " WAITFOR DELAY '00:00:01'" +

                " CREATE TABLE dbo.AM_Notes " +
                "(NoteID INT NOT NULL ,ButtonID INT NOT NULL ,NoteText VARCHAR(MAX) NULL ,CONSTRAINT PK_AM_Notes PRIMARY KEY CLUSTERED(NoteID ASC, ButtonID ASC),CONSTRAINT FK_49 FOREIGN KEY(ButtonID)REFERENCES dbo.AM_Buttons (ButtonID))" +

                " WAITFOR DELAY '00:00:01'" +

                "CREATE TABLE dbo.AM_FileImportStaging" +
                "(Column0 varchar(50) NULL, Column1 varchar(50) NULL, Column2 varchar(50) NULL, Column3 varchar(50) NULL, Column4 varchar(50) NULL, Column5 varchar(50) NULL, Column6 varchar(50) NULL, Column7 varchar(50) NULL, Column8 varchar(50) NULL, Column9 varchar(50) NULL, Column10 varchar(50) NULL, Column11 varchar(50) NULL, Column12 varchar(50) NULL, Column13 varchar(50) NULL, Column14 varchar(50) NULL, Column15 varchar(50) NULL, Column16 varchar(50) NULL, Column17 varchar(50) NULL, Column18 varchar(50) NULL, Column19 varchar(50) NULL, Column20 varchar(50) NULL)";

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

            //=====================================================================================================================
            // Create Views in the database
            //=====================================================================================================================
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

            FileInfo file1 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo1.sql");
            FileInfo file2 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo2.sql");
            FileInfo file3 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo3.sql");
            FileInfo file4 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo4.sql");
            FileInfo file5 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo5.sql");
            FileInfo file6 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo6.sql");
            FileInfo file7 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo7.sql");
            FileInfo file8 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo8.sql");
            FileInfo file9 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo9.sql");
            FileInfo file10 = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Views\\ButtonInfo10.sql");

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

            //=====================================================================================================================
            // Load Default data into tables
            //=====================================================================================================================
            String strdd;

            SqlConnection cndd = new SqlConnection
                (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString
                );

            FileInfo filedd = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Default Data\\Default Data.sql");

            strdd = filedd.OpenText().ReadToEnd();

            SqlCommand cmddd = new SqlCommand(strdd, cndd);

            try
            {
                cndd.Open();
                cmddd.ExecuteNonQuery();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "View Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (cndd.State == ConnectionState.Open)
                {
                    cndd.Close();
                }
            }

        }

        private void SPButton_Click(object sender, EventArgs e)
        {
            String strspb;

            SqlConnection cnspb = new SqlConnection
                (
                "server="
                + Properties.Settings.Default.ServerNameString
                + "\\" + Properties.Settings.Default.InstanceString
                + ";database= AutomationManager"
                + ";uid=" + Properties.Settings.Default.UserNameString
                + ";pwd=" + Properties.Settings.Default.PasswordString
                );

            FileInfo filespb = new FileInfo("C:\\ProgramData\\Sierra Workforce Solutions\\Automation Manager\\SQL Scripts\\Stored Procedures\\Button Test.sql");

            strspb = filespb.OpenText().ReadToEnd();

            SqlCommand cmddd = new SqlCommand(strspb, cnspb);

            try
            {
                cnspb.Open();
                cmddd.ExecuteNonQuery();
                MessageBox.Show("Check the Button Configuration to see if the words TEST WORKED is present for button 10", "Test Successful!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Stored Procedure Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (cnspb.State == ConnectionState.Open)
                {
                    cnspb.Close();
                }
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
