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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void loadButtonConfig(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SPName1String))
            { homebutton.Enabled = false; }
            else { homebutton.Enabled = true; }
        }
        private void homebutton_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            Main m = new Main();
            m.TopLevel = false;
            container.Controls.Add(m);
            m.Show();
        }

        private void buttonconfigbutton_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ButtonConfig b = new ButtonConfig();
            b.TopLevel = false;
            container.Controls.Add(b);
            b.Show();
        }

        private void dbconnectbutton_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            DBConnection db = new DBConnection();
            db.TopLevel = false;
            container.Controls.Add(db);
            db.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolsButton_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            Tools t = new Tools();
            t.TopLevel = false;
            container.Controls.Add(t);
            t.Show();
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
