using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stored_Procedure_Manager
{
    public partial class DBConnection : Form
    {
        public DBConnection()
        {
            InitializeComponent();
            loadDBConfig();
        }

        private void loadDBConfig()
        {

            this.ServerNameTextBox.Text = Properties.Settings.Default.ServerNameString;
            this.InstanceTextBox.Text = Properties.Settings.Default.InstanceString;
            this.DatabaseTextBox.Text = Properties.Settings.Default.DatabaseString;
            this.UserNameTextBox.Text = Properties.Settings.Default.UserNameString;
            this.PasswordTextBox.Text = Properties.Settings.Default.PasswordString;
        }

        private void ServerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatabaseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerNameString = ServerNameTextBox.Text;
            Properties.Settings.Default.InstanceString = InstanceTextBox.Text;
            Properties.Settings.Default.DatabaseString = DatabaseTextBox.Text;
            Properties.Settings.Default.UserNameString = UserNameTextBox.Text;
            Properties.Settings.Default.PasswordString = PasswordTextBox.Text;
            Properties.Settings.Default.Save();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
