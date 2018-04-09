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

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
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
    }
}
