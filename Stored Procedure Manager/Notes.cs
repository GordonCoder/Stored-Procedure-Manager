using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Stored_Procedure_Manager
{
    public partial class Notes : Form
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

        // NOTE - Passing a method from one form to another
        //https://stackoverflow.com/questions/25717113/display-combobox-value-of-fom1-to-another-form-in-textbox

        string result = null;
        public Notes(String selected)
        {
            InitializeComponent();
            result = selected;

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
                LoadNotes();
            }
            if (cnAMDB.State == ConnectionState.Open)
            {
                cnAMDB.Close();
            }
        }

        private void LoadNotes()
        {
            richTextBox1.Clear();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("SELECT NoteText FROM [dbo].[AM_Notes] WHERE ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + result + "','-'),'Button ')))", cnAMDB);
                cnAMDB.Open();
                sqlcmd.ExecuteNonQuery();
                SqlDataReader sqldr;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                    try
                    {
                        string NoteText = (string)sqldr["NoteText"].ToString();
                        richTextBox1.Text = NoteText;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnAMDB.State == ConnectionState.Open)
                {
                    cnAMDB.Close();
                }
            }            
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string Text = richTextBox1.Text;

            string InsertStatement =
            "UPDATE [dbo].[AM_Notes] SET [NoteText] =  '" + Text + "' WHERE ButtonID = (SELECT TRIM(dbo.fn_GetRestOfLineAfterLast(dbo.fn_GetLineUpToValue('" + result + "','-'),'Button ')))";

            using (SqlCommand SaveButtonCMD = new SqlCommand(InsertStatement, cnAMDB))
            {
                try
                {
                    cnAMDB.Open();
                    SaveButtonCMD.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Note Update Issue");
                }
                finally
                {
                    Thread.Sleep(2000);
                    cnAMDB.Close();
                    MessageBox.Show("Note data updated");
                }
            }
            if (cnAMDB.State == ConnectionState.Open)
            {
                cnAMDB.Close();
            }


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
