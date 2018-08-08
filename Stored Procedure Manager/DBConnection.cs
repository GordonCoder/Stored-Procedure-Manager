﻿using System;
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
    public partial class DBConnection : Form
    {

        //// SQL Connection that can be used throughout the Form
        //SqlConnection cn = new SqlConnection
        //    (
        //        "server="
        //        + Properties.Settings.Default.ServerNameString
        //        + "\\" + Properties.Settings.Default.InstanceString
        //        + ";database=" + Properties.Settings.Default.DatabaseString
        //        + ";uid=" + Properties.Settings.Default.UserNameString
        //        + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString)
        //    );
        SqlConnection cn = new SqlConnection();

        public DBConnection()
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
                        + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString)
                        ))
                {
                    cn.Open();
                    LoadDBConfig();
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

        private void LoadDBConfig()
        {

            this.ServerNameTextBox.Text = Properties.Settings.Default.ServerNameString;
            this.InstanceTextBox.Text = Properties.Settings.Default.InstanceString;
            this.DatabaseTextBox.Text = Properties.Settings.Default.DatabaseString;
            this.UserNameTextBox.Text = Properties.Settings.Default.UserNameString;
            this.PasswordTextBox.Text = Cipher.Decrypt(Properties.Settings.Default.PasswordString);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.ServerNameString = ServerNameTextBox.Text;
            Properties.Settings.Default.InstanceString = InstanceTextBox.Text;
            Properties.Settings.Default.DatabaseString = DatabaseTextBox.Text;
            Properties.Settings.Default.UserNameString = UserNameTextBox.Text;
            Properties.Settings.Default.PasswordString = Cipher.Encrypt(PasswordTextBox.Text);
            Properties.Settings.Default.Save();
            try
            {
                using (SqlConnection cn = new SqlConnection
                        (
                        "server="
                        + Properties.Settings.Default.ServerNameString
                        + "\\" + Properties.Settings.Default.InstanceString
                        + ";database=" + Properties.Settings.Default.DatabaseString
                        + ";uid=" + Properties.Settings.Default.UserNameString
                        + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString)
                        ))
                {
                    cn.Open();
                    //Properties.Settings.Default.ServerNameString = ServerNameTextBox.Text;
                    //Properties.Settings.Default.InstanceString = InstanceTextBox.Text;
                    //Properties.Settings.Default.DatabaseString = DatabaseTextBox.Text;
                    //Properties.Settings.Default.UserNameString = UserNameTextBox.Text;
                    //Properties.Settings.Default.PasswordString = PasswordTextBox.Text;
                    Properties.Settings.Default.PassFailString = "Pass";
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Connection information has been saved. Connection Successful!");
                }
            }
            catch (Exception ex)
            {
                Properties.Settings.Default.PassFailString = "Fail";
                Properties.Settings.Default.Save();
                MessageBox.Show(ex.Message, "Invalid Connection - Please Update Database Connection Information");
            }
            finally
            {
                cn.Close();
            }
            
        }

        private void DBConnection_Load(object sender, EventArgs e)
        {
            
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection
                        (
                        "server="
                        + Properties.Settings.Default.ServerNameString
                        + "\\" + Properties.Settings.Default.InstanceString
                        + ";database=" + Properties.Settings.Default.DatabaseString
                        + ";uid=" + Properties.Settings.Default.UserNameString
                        + ";pwd=" + Cipher.Decrypt(Properties.Settings.Default.PasswordString)
                        ))
                {
                    cn.Open();
                    MessageBox.Show("Connection Successful!");
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

        private void BorderPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.borderpanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
