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
        CatManager manager = new CatManager();
        bool isDragging = false;
        Point startPoint = new Point(0, 0);
        ScheduleTimer appTimer;
        public Form1()
        {
            InitializeComponent();
            
            manager.LoadData(); 
            appTimer = new ScheduleTimer(manager);
            appTimer.Start();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
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
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear(); //To delete whatever was in the pnlContainer

            UC_Managecats ucCats = new UC_Managecats(); //to call the user control window (UC_ManageCats)
            ucCats.Dock = DockStyle.Fill; //will fill the pnlContainer screen
            pnlContainer.Controls.Add(ucCats); //show up in the pnlContainer
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UC_Schedules ucSchedules = new UC_Schedules();
            ucSchedules.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucSchedules);
        }

        private void btnHealthRecords_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UC_HealthRecords ucHealth = new UC_HealthRecords();
            ucHealth.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucHealth);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var cat in manager.GetAllCats())
            {
                foreach (var sch in cat.Schedules)
                {
                    
                    if (sch.IsUpcoming())
                    {
                        MessageBox.Show($"Reminder: {cat.Name} has a {sch.Type} coming up!\nNotes: {sch.Notes}",
                                        "Schedule Alert",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
        }

