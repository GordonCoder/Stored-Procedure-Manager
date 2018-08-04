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
using System.Threading;

namespace Stored_Procedure_Manager
{
    public partial class ButtonConfig : Form
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
        public ButtonConfig()
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
                LoadButtonNames();
            }
            if (cnAMDB.State == ConnectionState.Open)
            {
                cnAMDB.Close();
            }
        }

        private void LoadButtonNames() // Need Try statements
        {
            DataTable dtb1 = new DataTable();
            cnAMDB.Open();
            SqlCommand sqlcmdb1 = new SqlCommand("SELECT DISTINCT CONCAT('Button ', CONVERT(varchar(10), ButtonId) , ' - ', ButtonName) AS ButtonName FROM AM_ButtonInfo_AllButtons ", cnAMDB);
            SqlDataAdapter sqlDab1 = new SqlDataAdapter(sqlcmdb1);
            sqlDab1.Fill(dtb1);
            this.ButtonConfigComboBox.Items.Clear();
            for (int i = 0; i < dtb1.Rows.Count; i++)
            {
                this.ButtonConfigComboBox.Text = "Select Button Name";
                this.ButtonConfigComboBox.Items.Add(dtb1.Rows[i]["ButtonName"]);

            }
            if (cnAMDB.State == ConnectionState.Open)
            {
                cnAMDB.Close();
            }
        }

        public string strComboBox
        {
            get => ButtonConfigComboBox.Text;
        }

        private void ButtonConfigComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        SqlCommand sqlcmdhc = new SqlCommand("SELECT * FROM [dbo].[AM_ButtonInfo_AllButtons] WHERE IDandName = '" + ButtonConfigComboBox.Text + "'", cnAMDB);
        cnAMDB.Open();
        sqlcmdhc.ExecuteNonQuery();
        SqlDataReader sqldr;
        sqldr = sqlcmdhc.ExecuteReader();
        while (sqldr.Read())
            try
            {
                string ButtonName = (string)sqldr["ButtonName"].ToString();
                ButtonNameTextBox.Text = ButtonName;

                string SPName = (string)sqldr["SPName"].ToString();
                SPNameTextBox.Text = SPName;

                //Parameter Names
                string ParamName1 = (string)sqldr["ParamName1"].ToString();
                ParamNameTextBox1.Text = ParamName1;

                string ParamName2 = (string)sqldr["ParamName2"].ToString();
                ParamNameTextBox2.Text = ParamName2;

                string ParamName3 = (string)sqldr["ParamName3"].ToString();
                ParamNameTextBox3.Text = ParamName3;

                string ParamName4 = (string)sqldr["ParamName4"].ToString();
                ParamNameTextBox4.Text = ParamName4;

                string ParamName5 = (string)sqldr["ParamName5"].ToString();
                ParamNameTextBox5.Text = ParamName5;

                //Parameter Inputs
                string ParamValue1 = (string)sqldr["ParamValue1"].ToString();
                ParamInputTextBox1.Text = ParamValue1;

                string ParamValue2 = (string)sqldr["ParamValue2"].ToString();
                ParamInputTextBox2.Text = ParamValue2;

                string ParamValue3 = (string)sqldr["ParamValue3"].ToString();
                ParamInputTextBox3.Text = ParamValue3;

                string ParamValue4 = (string)sqldr["ParamValue4"].ToString();
                ParamInputTextBox4.Text = ParamValue4;

                string ParamValue5 = (string)sqldr["ParamValue5"].ToString();
                ParamInputTextBox5.Text = ParamValue5;

                //Executable Path and Input
                string ExecutablePath = (string)sqldr["ExecutablePath"].ToString();
                ExePathTextBox.Text = ExecutablePath;

                string ExecutableParam = (string)sqldr["ExecutableParam"].ToString();
                ExeParamTextBox.Text = ExecutableParam;

                this.ExeCheckBox.Checked = (bool)sqldr["EPCheckBox"];

                // Note Value
                //string NoteText = (string)sqldr["NoteText"].ToString();
                //ParamInputTextBox4.Text = NoteText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "?");
            }
            finally
            {
                
            }
            if (cnAMDB.State == ConnectionState.Open)
            {
                cnAMDB.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string ButtonName = ButtonNameTextBox.Text;
            string SPName = SPNameTextBox.Text;
            string ParamName1 = ParamNameTextBox1.Text;
            string ParamName2 = ParamNameTextBox2.Text;
            string ParamName3 = ParamNameTextBox3.Text;
            string ParamName4 = ParamNameTextBox4.Text;
            string ParamName5 = ParamNameTextBox5.Text;

            string ParamValue1 = ParamInputTextBox1.Text;
            string ParamValue2 = ParamInputTextBox2.Text;
            string ParamValue3 = ParamInputTextBox3.Text;
            string ParamValue4 = ParamInputTextBox4.Text;
            string ParamValue5 = ParamInputTextBox5.Text;

            string ExecutablePath = ExePathTextBox.Text;
            string ExecutableParam = ExeParamTextBox.Text;
            
            bool EPCheckBox = ExeCheckBox.Checked;

            string InsertStatement =
                "update dbo.AM_Buttons " +
                "set " +
                "ButtonName = '" + ButtonName + "', " +
                "SPName = '" + SPName + "' " +
                "WHERE ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + ButtonConfigComboBox.Text + "','-'),'Button ')))" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName1 + "', " +
                "ParamValue = '" + ParamValue1 + "'" +
                "WHERE " +
                "ParamID = '1' " +
                "AND " +
                "ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + ButtonConfigComboBox.Text + "','-'),'Button ')))" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName2 + "', " +
                "ParamValue = '" + ParamValue2 + "'" +
                "WHERE " +
                "ParamID = '2' " +
                "AND " +
                "ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + ButtonConfigComboBox.Text + "','-'),'Button ')))" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName3 + "', " +
                "ParamValue= '" + ParamValue3 + "'" +
                "WHERE " +
                "ParamID = '3' " +
                "AND " +
                "ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + ButtonConfigComboBox.Text + "','-'),'Button ')))" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName4 + "', " +
                "ParamValue= '" + ParamValue4 + "'" +
                "WHERE " +
                "ParamID = '4' " +
                "AND " +
                "ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + ButtonConfigComboBox.Text + "','-'),'Button ')))" +

                "update dbo.AM_ButtonParam " +
                "set " +
                "ParamName = '" + ParamName5 + "', " +
                "ParamValue= '" + ParamValue5 + "'" +
                "WHERE " +
                "ParamID = '5' " +
                "AND " +
                "ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + ButtonConfigComboBox.Text + "','-'),'Button ')))" +

                "update dbo.AM_Executable " +
                "set " +
                "ExecutablePath = '" + ExecutablePath + "', " +
                "ExecutableParam = '" + ExecutableParam + "', " +
                "EPCheckBox = '" + EPCheckBox + "'" +
                "WHERE " +
                "ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + ButtonConfigComboBox.Text + "','-'),'Button ')))" +

                "update dbo.AM_Buttons " +
                "set " +
                "IDandName = (SELECT CONCAT('Button ', CONVERT(varchar(10), ButtonId) , ' - ', ButtonName)  FROM [dbo].[AM_Buttons] WHERE ButtonId = (SELECT ButtonID FROM AM_Buttons WHERE ButtonId = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + ButtonConfigComboBox.Text + "','-'),'Button ')))))" +
                "WHERE " +
                "ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + ButtonConfigComboBox.Text + "','-'),'Button ')))"
                ;

            using (SqlCommand SaveButtonCMD = new SqlCommand(InsertStatement, cnAMDB))
            {
                try
                {
                    cnAMDB.Open();
                    SaveButtonCMD.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Button Update Issue");
                }
                finally
                {
                    Thread.Sleep(2000);
                    cnAMDB.Close();
                    LoadButtonNames();
                    MessageBox.Show("Button data updated");
                }
            }
            if (cnAMDB.State == ConnectionState.Open)
            {
                cnAMDB.Close();
            }         
        }

        private void NotesButton_Click(object sender, EventArgs e)
        {
            Notes n = new Notes(ButtonConfigComboBox.SelectedItem.ToString());
            n.Show();
            n.Focus();
        }


    }
}
