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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            var Password = Properties.Settings.Default.PasswordOk;
            if (PasswordtextBox.Text == Password)
                MessageBox.Show("Good password");
            else
                MessageBox.Show("Invalid password");
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
