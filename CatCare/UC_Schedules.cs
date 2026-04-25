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
    public partial class UC_Schedules : UserControl
    {
        CatManager manager = new CatManager();
        public UC_Schedules()
        {
            InitializeComponent();
            LoadSchedulesToGrid();
            manager.LoadData();
            cmbCatName.Items.Clear();
            Cat[] allCats = manager.GetAllCats();
            if (allCats != null)
            {
                foreach (var cat in allCats)
                {
                    cmbCatName.Items.Add(cat.Name);
                }
            }
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (cmbCatName.SelectedIndex == -1 || cmbScheduleType.SelectedIndex == -1)
            {

                MessageBox.Show("Please select a cat and a type!");
                return;
            }

            
            ScheduleType sType = (cmbScheduleType.Text == "Meal") ? ScheduleType.Meal : ScheduleType.Vaccine;
            Schedule newSch = new Schedule
            {
                Type = sType,
                Date = dtpScheduleDate.Value,
                Notes = txtNotes.Text
            };

            
            string catName = cmbCatName.Text;
            string msg = manager.AddScheduleToCat(catName, newSch);

            
            MessageBox.Show(msg);
            if (msg.Contains("successfully"))
            {
                dgvSchedules.Rows.Add(catName, sType.ToString(), newSch.Date.ToString("g"), newSch.Notes, newSch.GetTimeRemaining());
                txtNotes.Clear();
                cmbCatName.SelectedIndex = -1;
                LoadSchedulesToGrid();
            }
            DataStore.SaveAllData(manager.GetAllCats().ToList());
        }
        private void LoadSchedulesToGrid()
        {
            dgvSchedules.Rows.Clear();
            Cat[] allCats = manager.GetAllCats();

            if (allCats != null)
            {
                foreach (var cat in allCats)
                {
                    
                    foreach (var sch in cat.Schedules)
                    {
                        dgvSchedules.Rows.Add(cat.Name, sch.Type.ToString(), sch.Date.ToString("g"), sch.Notes , sch.GetTimeRemaining());

                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
