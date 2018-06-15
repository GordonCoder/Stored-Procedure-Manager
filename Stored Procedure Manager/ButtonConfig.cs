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
                    LoadButtonConfig();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Connection - Please Update Database Connection Information");
            }
            finally
            {
                cn.Close();
            }
        }

        // Load all needed configuration
        private void LoadButtonConfig()
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

            SPName1TextBox.Clear();
            SPName2TextBox.Clear();
            SPName3TextBox.Clear();
            SPName4TextBox.Clear();
            SPName5TextBox.Clear();
            SPName6TextBox.Clear();
            SPName7TextBox.Clear();
            SPName8TextBox.Clear();
            SPName9TextBox.Clear();
            SPName10TextBox.Clear();

            ParamName1TextBox.Clear();
            ParamName2TextBox.Clear();
            ParamName3TextBox.Clear();
            ParamName4TextBox.Clear();
            ParamName5TextBox.Clear();
            ParamName6TextBox.Clear();
            ParamName7TextBox.Clear();
            ParamName8TextBox.Clear();
            ParamName9TextBox.Clear();
            ParamName10TextBox.Clear();

            // Open the connection to the database and select the data within the table
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from cust_SPManagerConfig", cn);
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

                    // Load Parameters from the database
                    this.ParamName1TextBox.Text = (dr["Param01"].ToString());
                    this.ParamName2TextBox.Text = (dr["Param02"].ToString());
                    this.ParamName3TextBox.Text = (dr["Param03"].ToString());
                    this.ParamName4TextBox.Text = (dr["Param04"].ToString());
                    this.ParamName5TextBox.Text = (dr["Param05"].ToString());
                    this.ParamName6TextBox.Text = (dr["Param06"].ToString());
                    this.ParamName7TextBox.Text = (dr["Param07"].ToString());
                    this.ParamName8TextBox.Text = (dr["Param08"].ToString());
                    this.ParamName9TextBox.Text = (dr["Param09"].ToString());
                    this.ParamName10TextBox.Text = (dr["Param10"].ToString());
                }
            }
            cn.Close();
        }

        // Save Button function
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Save the data from the text fields in the database
            // TO-DO Need to replace the button text in the Values to use Parameters instead (@Button1Name instead of Button1NameText.Text)
            // TO - DO Need to do this https://stackoverflow.com/questions/19866570/how-do-i-encrypt-user-settings

            SqlCommand cmd = new SqlCommand
                (
                    "update cust_SPManagerConfig " +
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
                    "SPName10 = '" + SPName10TextBox.Text + "'," +
                    "Param01 = '" + ParamName1TextBox.Text + "', " +
                    "Param02 = '" + ParamName2TextBox.Text + "'," +
                    "Param03 = '" + ParamName3TextBox.Text + "'," +
                    "Param04 = '" + ParamName4TextBox.Text + "'," +
                    "Param05 = '" + ParamName5TextBox.Text + "'," +
                    "Param06 = '" + ParamName6TextBox.Text + "'," +
                    "Param07 = '" + ParamName7TextBox.Text + "'," +
                    "Param08 = '" + ParamName8TextBox.Text + "'," +
                    "Param09 = '" + ParamName9TextBox.Text + "'," +
                    "Param10 = '" + ParamName10TextBox.Text + "'", cn);
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

            Properties.Settings.Default.ParamName1String = ParamName1TextBox.Text;
            Properties.Settings.Default.ParamName2String = ParamName2TextBox.Text;
            Properties.Settings.Default.ParamName3String = ParamName3TextBox.Text;
            Properties.Settings.Default.ParamName4String = ParamName4TextBox.Text;
            Properties.Settings.Default.ParamName5String = ParamName5TextBox.Text;
            Properties.Settings.Default.ParamName6String = ParamName6TextBox.Text;
            Properties.Settings.Default.ParamName7String = ParamName7TextBox.Text;
            Properties.Settings.Default.ParamName8String = ParamName8TextBox.Text;
            Properties.Settings.Default.ParamName9String = ParamName9TextBox.Text;
            Properties.Settings.Default.ParamName10String = ParamName10TextBox.Text;
            Properties.Settings.Default.Save();



            LoadButtonConfig();

        }

        private void ButtonConfig_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt && e.Control && e.KeyValue == 'W')
            {
                PasswordForm dlg = new PasswordForm();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (Properties.Settings.Default.PasswordOk == dlg.PasswordtextBox.Text)
                        MessageBox.Show("Good password");
                    //enableControls(true);
                    else
                        MessageBox.Show("Invalid password");
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

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

        private void BorderPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.borderpanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void ParamName7TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewButtonConfig_Click(object sender, EventArgs e)
        {
            ButtonSetup b = new ButtonSetup();
            b.Show();
            b.Focus();
        }
    }
}
