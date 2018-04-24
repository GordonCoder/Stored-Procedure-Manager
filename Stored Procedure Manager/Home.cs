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
                        { homebutton.Enabled = true; }
                        { buttonconfigbutton.Enabled = true; }
                        { toolsButton.Enabled = true; }
                    }
                    else
                    {
                        { homebutton.Enabled = false; }
                        { buttonconfigbutton.Enabled = false; }
                        { toolsButton.Enabled = false; }
                    }
                }
            }
            catch (Exception ex)
            {
                String PF = "Fail";
                if (PF.Contains("Pass") == true)
                {
                    { homebutton.Enabled = true; }
                    { buttonconfigbutton.Enabled = true; }
                    { toolsButton.Enabled = true; }
                }
                else
                {
                    { homebutton.Enabled = false; }
                    { buttonconfigbutton.Enabled = false; }
                    { toolsButton.Enabled = false; }
                }
                MessageBox.Show(ex.Message, "Invalid Connection - Please Update Database Connection Information");

                container.Controls.Clear();
                DBConnection db = new DBConnection();
                db.TopLevel = false;
                container.Controls.Add(db);
                db.Show();
                db.Focus();
            }
            finally
            {
                
            }

            LoadButtonConfig();
        }

        private void LoadButtonConfig()
        {
            String var = Properties.Settings.Default.PassFailString;
            if (var.Contains("Pass") == true)
            { homebutton.Enabled = true; }
            else { homebutton.Enabled = false; }

        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
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
            container.Controls.Clear();
            ButtonConfig b = new ButtonConfig();
            b.TopLevel = false;
            container.Controls.Add(b);
            b.Show();
            b.Focus();
        }

        private void DBConnectButton_Click(object sender, EventArgs e)
        {
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
    }
}

