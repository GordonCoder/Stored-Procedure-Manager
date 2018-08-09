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
    public partial class ProgressPopUp : Form
    {
        public ProgressPopUp()
        {
            InitializeComponent();
        }

        private void ProgressPopUp_Load(object sender, EventArgs e)
        {

            // set initial image
            this.buttonOK.Enabled = false;
            this.pictureBox.Image = Properties.Resources.SierraLogo;

            ////this.StartProcess();
            //DateTime Tthen = DateTime.Now;
            //do
            //{
            //    Application.DoEvents();
            //}
            //while (Tthen.AddSeconds(1) > DateTime.Now);
            //{
                // show animated image
                this.pictureBox.Image = Properties.Resources.SpinningSierra;
                // change button states
                this.buttonOK.Enabled = false;
                // start background operation
                this.backgroundWorker.RunWorkerAsync();
            //}
        }

        //private void StartProcess(object sender, EventArgs e)
        private void StartProcess()
        {
            // show animated image
            this.pictureBox.Image = Properties.Resources.SpinningSierra;
            // change button states
            this.buttonOK.Enabled = false;
            // start background operation
            this.backgroundWorker.RunWorkerAsync();
        }

        private void OnDoWork(object sender, DoWorkEventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (this.backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                // report progress
                this.backgroundWorker.ReportProgress(-1, string.Format("Performing step {0}...", i + 1));
                // simulate operation step
                System.Threading.Thread.Sleep(rand.Next(100, 1000));

                // Need this later to present error if SP or executable has issue
                //if (this.simulateError)
                //{
                //    this.simulateError = false;
                //    throw new Exception("Unexpected error!");
                //}
            }
        }

        private void OnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // hide animation
            this.pictureBox.Image = Properties.Resources.SierraLogo;
            // show result indication
            if (e.Error != null)
            {
                this.labelProgress.Text = "Operation failed: " + e.Error.Message;
                this.pictureBox.Image = Properties.Resources.SierraLogo;
            }
            else
            {
                this.labelProgress.Text = "Operation finished successfuly!";
                this.pictureBox.Image = Properties.Resources.SierraLogo;
            }

            // restore button states
            this.buttonOK.Enabled = true;
        }



        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
