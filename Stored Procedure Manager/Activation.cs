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
    public partial class Activation : Form
    {
        public Activation()
        {
            InitializeComponent();
        }

        private void ActivationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ActivationPass = ActivationTextBox.Text;
            Properties.Settings.Default.Save();

            String var = Properties.Settings.Default.ActivationPass;

            if (var.Equals("620190") == true)
            {
                MessageBox.Show("Automation Manager Activated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
