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
    public partial class CreateDBLoading : Form
    {
        public CreateDBLoading()
        {
            InitializeComponent();
        }

        public void CreateDBProgressBarTimer_Tick(object sender, EventArgs e)
        {
            this.CreateDBProgressBar.Increment(7);
        }

        private void CreateDBProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
