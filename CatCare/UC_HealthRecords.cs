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
    public partial class UC_HealthRecords : UserControl
    {
        CatManager manager = new CatManager();
        public UC_HealthRecords()
        {
            InitializeComponent();
            manager.LoadData();
            PopulateCatCombo();
            LoadHealthRecordsToGrid();
        }
        private void PopulateCatCombo()
        {
            cmbCatName.Items.Clear();
            var cats = manager.GetAllCats();
            if (cats != null)
            {
                foreach (var cat in cats)
                {
                    cmbCatName.Items.Add(cat.Name);
                }
            }
        }
        private void LoadHealthRecordsToGrid()
        {
            dgvHealthRecords.Rows.Clear();
            var allCats = manager.GetAllCats();
            if (allCats != null)
            {
                foreach (var cat in allCats)
                {
                    foreach (var record in cat.HealthRecords)
                    {
                        dgvHealthRecords.Rows.Add(cat.Name, record.Date.ToShortDateString(), record.Status.ToString(), record.Notes);
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void btnHealthRecords_Click(object sender, EventArgs e)
        {
            if (cmbCatName.SelectedIndex == -1 || cmbHealthStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a cat and its health status!");
                return;
            }

            string selectedCatName = cmbCatName.Text;
            Cat selectedCat = manager.GetAllCats().FirstOrDefault(c => c.Name == selectedCatName);

            if (selectedCat != null)
            {
                HealthRecord record = new HealthRecord
                {
                    CatId = selectedCat.Id,
                    Date = dtpRecordDate.Value,
                    Status = (cmbHealthStatus.Text == "Healthy") ? HealthStatus.Healthy : HealthStatus.Sick,
                    Notes = txtClinicalNotes.Text

                };


                string result = manager.AddHealthRecordToCat(selectedCat.Id, record);
                MessageBox.Show(result, "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadHealthRecordsToGrid();
                txtClinicalNotes.Clear();
                DataStore.SaveAllData(manager.GetAllCats().ToList());
            }
        }
        
    }
}
