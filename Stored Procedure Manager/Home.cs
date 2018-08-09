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


namespace Stored_Procedure_Manager
{
    public partial class Home : Form
    {
        public Point mouseLocation;

        public Home()
        {
            InitializeComponent();

            string ActivationPass = Properties.Settings.Default.ActivationPass;
            string PassFail = Properties.Settings.Default.PassFailString;


            // If Blank - first time install and use
            if (Properties.Settings.Default.ActivationPass == "")
            {
                homebutton.Enabled = false;
                buttonconfigbutton.Enabled = false;
                dbconnectbutton.Enabled = false;
                toolsButton.Enabled = false;
                LoadActivation();
            }
            else if (Cipher.Decrypt(Properties.Settings.Default.ActivationPass).Contains("trial") == true)
            {
                homebutton.Enabled = true;
                buttonconfigbutton.Enabled = true;
                dbconnectbutton.Enabled = true;
                toolsButton.Enabled = true;
            }
            else
            {
                homebutton.Enabled = false;
                buttonconfigbutton.Enabled = false;
                dbconnectbutton.Enabled = false;
                toolsButton.Enabled = false;
                LoadActivation();
            }
        }

        //private void LoadButtonConfig()
        //{
        //    string var = Properties.Settings.Default.PassFailString;
        //    if (var.Contains("Pass") == true)
        //    { homebutton.Enabled = true; }
        //    else { homebutton.Enabled = false; }

        //}

        private void LoadActivation()
        {
            if
            (MessageBox.Show("Invalid Activation Password - Please enter an Activation Password", "Activation Invalid", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Activation a = new Activation();
                a.Show();
                a.Focus();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            panelSlice.Height = homebutton.Height;
            panelSlice.Top = homebutton.Top;
            container.Controls.Clear();
            Main m = new Main();
            m.LoadMainButtonConfig();
            m.TopLevel = false;
            container.Controls.Add(m);
            m.Show();
            m.Focus();
        }

        private void ButtonConfigButton_Click(object sender, EventArgs e)
        {
            panelSlice.Height = buttonconfigbutton.Height;
            panelSlice.Top = buttonconfigbutton.Top;
            container.Controls.Clear();
            ButtonConfig b = new ButtonConfig();
            b.TopLevel = false;
            container.Controls.Add(b);
            b.Show();
            b.Focus();
        }

        private void DBConnectButton_Click(object sender, EventArgs e)
        {
            panelSlice.Height = dbconnectbutton.Height;
            panelSlice.Top = dbconnectbutton.Top;
            container.Controls.Clear();
            DBConnection db = new DBConnection();
            db.TopLevel = false;
            container.Controls.Add(db);
            db.Show();
            db.Focus();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolsButton_Click(object sender, EventArgs e)
        {
            panelSlice.Height = toolsButton.Height;
            panelSlice.Top = toolsButton.Top;
            container.Controls.Clear();
            Tools t = new Tools();
            t.TopLevel = false;
            container.Controls.Add(t);
            t.Show();
            t.Focus();
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void HolidayEngineButton_Click(object sender, EventArgs e)
        {
            panelSlice.Height = HolidayEngineButton.Height;
            panelSlice.Top = HolidayEngineButton.Top;
            container.Controls.Clear();
            HolidayEngine h = new HolidayEngine();
            h.TopLevel = false;
            container.Controls.Add(h);
            h.Show();
            h.Focus();
        }
    }
}

