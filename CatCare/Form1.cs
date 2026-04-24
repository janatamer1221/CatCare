using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCare
{
    public partial class Form1 : Form
    {
        bool isDragging = false;
        Point startPoint = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging  = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X , p.Y - this.startPoint.Y );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); //To close the application
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear(); //To delete whatever was in the pnlContainer

            UC_Managecats ucCats = new UC_Managecats(); //to call the user control window (UC_ManageCats)
            ucCats.Dock = DockStyle.Fill; //will fill the pnlContainer screen
            pnlContainer.Controls.Add(ucCats); //show up in the pnlContainer
        }
    }
}
