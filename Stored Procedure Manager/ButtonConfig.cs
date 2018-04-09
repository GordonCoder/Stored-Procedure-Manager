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
    public partial class ButtonConfig : Form
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
        SqlDataReader dr;

        public ButtonConfig()
        {
            InitializeComponent();
            loadButtonConfig();
        }

        // Load all needed configuration
        private void loadButtonConfig()
        {
            // Clear Buttons for fresh data
            Button1NameText.Clear();
            Button2NameText.Clear();
            Button3NameText.Clear();
            Button4NameText.Clear();
            Button5NameText.Clear();
            Button6NameText.Clear();
            Button7NameText.Clear();
            Button8NameText.Clear();
            Button9NameText.Clear();
            Button10NameText.Clear();

            // Open the connection to the database and select the data within the table
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from SPManagerButtonConfig", cn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())

                {
                    // Load Button Names from the database to the Buttons
                    this.Button1NameText.Text = (dr["ButtonName01"].ToString());
                    this.Button2NameText.Text = (dr["ButtonName02"].ToString());
                    this.Button3NameText.Text = (dr["ButtonName03"].ToString());
                    this.Button4NameText.Text = (dr["ButtonName04"].ToString());
                    this.Button5NameText.Text = (dr["ButtonName05"].ToString());
                    this.Button6NameText.Text = (dr["ButtonName06"].ToString());
                    this.Button7NameText.Text = (dr["ButtonName07"].ToString());
                    this.Button8NameText.Text = (dr["ButtonName08"].ToString());
                    this.Button9NameText.Text = (dr["ButtonName09"].ToString());
                    this.Button10NameText.Text = (dr["ButtonName10"].ToString());

                    // Load Stored Procedure Names from the database
                    this.SPName1TextBox.Text = (dr["SPName01"].ToString());
                    this.SPName2TextBox.Text = (dr["SPName02"].ToString());
                    this.SPName3TextBox.Text = (dr["SPName03"].ToString());
                    this.SPName4TextBox.Text = (dr["SPName04"].ToString());
                    this.SPName5TextBox.Text = (dr["SPName05"].ToString());
                    this.SPName6TextBox.Text = (dr["SPName06"].ToString());
                    this.SPName7TextBox.Text = (dr["SPName07"].ToString());
                    this.SPName8TextBox.Text = (dr["SPName08"].ToString());
                    this.SPName9TextBox.Text = (dr["SPName09"].ToString());
                    this.SPName10TextBox.Text = (dr["SPName10"].ToString());
                }
            }
            cn.Close();
        }

        // Save Button function
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Save the data from the text fields in the database
            // TO-DO Need to replace the button text in the Values to use Parameters instead (@Button1Name instead of Button1NameText.Text)
            SqlCommand cmd = new SqlCommand
                (
                    "update SPManagerButtonConfig " +
                    "set " +
                    "ButtonName01 = '" + Button1NameText.Text + "', " +
                    "ButtonName02 = '" + Button2NameText.Text + "', " +
                    "ButtonName03 = '" + Button3NameText.Text + "', " +
                    "ButtonName04 = '" + Button4NameText.Text + "', " +
                    "ButtonName05 = '" + Button5NameText.Text + "', " +
                    "ButtonName06 = '" + Button6NameText.Text + "', " +
                    "ButtonName07 = '" + Button7NameText.Text + "', " +
                    "ButtonName08 = '" + Button8NameText.Text + "', " +
                    "ButtonName09 = '" + Button9NameText.Text + "', " +
                    "ButtonName10 = '" + Button10NameText.Text + "', " +
                    "SPName01 = '" + SPName1TextBox.Text + "', " +
                    "SPName02 = '" + SPName2TextBox.Text + "'," +
                    "SPName03 = '" + SPName3TextBox.Text + "'," +
                    "SPName04 = '" + SPName4TextBox.Text + "'," +
                    "SPName05 = '" + SPName5TextBox.Text + "'," +
                    "SPName06 = '" + SPName6TextBox.Text + "'," +
                    "SPName07 = '" + SPName7TextBox.Text + "'," +
                    "SPName08 = '" + SPName8TextBox.Text + "'," +
                    "SPName09 = '" + SPName9TextBox.Text + "'," +
                    "SPName10 = '" + SPName10TextBox.Text + "'", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Record updated");

            Properties.Settings.Default.SPName1String = SPName1TextBox.Text;
            Properties.Settings.Default.SPName2String = SPName2TextBox.Text;
            Properties.Settings.Default.SPName3String = SPName3TextBox.Text;
            Properties.Settings.Default.SPName4String = SPName4TextBox.Text;
            Properties.Settings.Default.SPName5String = SPName5TextBox.Text;
            Properties.Settings.Default.SPName6String = SPName6TextBox.Text;
            Properties.Settings.Default.SPName7String = SPName7TextBox.Text;
            Properties.Settings.Default.SPName8String = SPName8TextBox.Text;
            Properties.Settings.Default.SPName9String = SPName9TextBox.Text;
            Properties.Settings.Default.SPName10String = SPName10TextBox.Text;
            Properties.Settings.Default.Save();

            loadButtonConfig();
            Button1NameText.Text = "";
            Button2NameText.Text = "";
            Button3NameText.Text = "";
            Button4NameText.Text = "";
            Button5NameText.Text = "";
            Button6NameText.Text = "";
            Button7NameText.Text = "";
            Button8NameText.Text = "";
            Button9NameText.Text = "";
            Button10NameText.Text = "";

            SPName1TextBox.Text = "";
            SPName2TextBox.Text = "";
            SPName3TextBox.Text = "";
            SPName4TextBox.Text = "";
            SPName5TextBox.Text = "";
            SPName6TextBox.Text = "";
            SPName7TextBox.Text = "";
            SPName8TextBox.Text = "";
            SPName9TextBox.Text = "";
            SPName10TextBox.Text = "";

            Main M = new Main();
            M.Show();
            this.Hide();

        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Main M = new Main();
            M.Show();
            this.Hide();
        }

        private void Button1NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button6NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button7NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button8NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button9NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button10NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName4TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName5TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName6TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName7TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName8TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName9TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPName10TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
