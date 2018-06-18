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
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ("The tables were successfully created!", "Tables Created", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    //t.Hide();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (cnTables.State == ConnectionState.Open)
                {
                    cnTables.Close();
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
                            "IF NOT EXISTS (Select * From cust_SPManagerConfig) " +
                            "INSERT INTO cust_SPManagerConfig " +
                            "(ButtonName10, SPName10) " +
                            "VALUES " +
                            "('TEST WORKED', 'TEST WORKED') " +
                            "ELSE " +
                            "UPDATE cust_SPManagerConfig " +
                            "SET ButtonName10 = 'TEST WORKED' " +
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

        private void CreateDBProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
