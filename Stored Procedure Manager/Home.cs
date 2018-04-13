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
        }

        private void ButtonConfigButton_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            ButtonConfig b = new ButtonConfig();
            b.TopLevel = false;
            container.Controls.Add(b);
            b.Show();
        }

        private void DBConnectButton_Click(object sender, EventArgs e)
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

        private void ToolsButton_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            Tools t = new Tools();
            t.TopLevel = false;
            container.Controls.Add(t);
            t.Show();
        }


        private void Container_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.container.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.headerpanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void LogoPanel_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.logopanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.sidepanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void HomeBorderPanel_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.HomeBorderPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void NewHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
