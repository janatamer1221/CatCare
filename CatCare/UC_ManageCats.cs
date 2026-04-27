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
    public partial class UC_Managecats : UserControl
    {
        CatManager manager = new CatManager();
        public UC_Managecats()
        {
            InitializeComponent();
            manager.LoadData();
            dgvCats.Rows.Clear();
            Cat[] savedCats = manager.GetAllCats();

            if (savedCats != null)
            {
                foreach (Cat c in savedCats)
                {
                    dgvCats.Rows.Add(c.Name, c.Age, "Indoor", c.HealthStatus.ToString());
                }
            }
        }

            
    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string catName = txtName.Text;
            int catAge = (int)numAge.Value;
            string catType = cmbType.Text;

            HealthStatus status = HealthStatus.Healthy;
            if (cmbStatus.Text == "Sick")
            {
                status = HealthStatus.Sick;
            }

            string result = manager.AddCat(catName, catAge, status);

            MessageBox.Show(result, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result.Contains("successfully"))
            {
                dgvCats.Rows.Add(catName, catAge, catType, cmbStatus.Text);

               
                if (status == HealthStatus.Sick)
                {
                    MessageBox.Show("Alert: Since your cat is marked as Sick, please take it to the vet!", "Urgent Care Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtName.Clear();
                numAge.Value = 0;
                cmbType.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;
            }
            DataStore.SaveAllData(manager.GetAllCats().ToList());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCats.SelectedRows.Count > 0)
            {
                //To make sure the user want to delete the cat
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this cat?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (confirm == DialogResult.No)
                {
                    return;
                }
                string catNameToDelete = dgvCats.SelectedRows[0].Cells[0].Value.ToString();
                string resultMessage = manager.RemoveCat(catNameToDelete);

                MessageBox.Show(resultMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultMessage.Contains("successfully"))
                {
                    dgvCats.Rows.RemoveAt(dgvCats.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a cat from the table to delete.", "Select a Cat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCareTip_Click(object sender, EventArgs e)
        {
            if (dgvCats.SelectedRows.Count > 0)
            {
                string catName = dgvCats.SelectedRows[0].Cells[0].Value.ToString();

                
                Cat selectedCat = manager.SearchCat(catName);

                if (selectedCat != null)
                {
                    
                    MessageBox.Show(selectedCat.GetCareTip(), "Care Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a cat from the table first.", "Select a Cat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.Text == "Indoor")
            {
                IndoorCat tempIndoor = new IndoorCat();
                MessageBox.Show(tempIndoor.IndoorNote(), "Type Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            else if (cmbType.Text == "Outdoor")
            {
                OutdoorCat tempOutdoor = new OutdoorCat();
                MessageBox.Show(tempOutdoor.OutdoorNote(), "Type Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSickCats_Click(object sender, EventArgs e)
        {
            dgvCats.Rows.Clear();

            
            var sickCats = manager.GetSickCats();

            if (sickCats != null)
            {
                foreach (var cat in sickCats)
                {
                    
                    dgvCats.Rows.Add(cat.Name, cat.Age, " " , cat.HealthStatus.ToString());
                }
            }
        }
    }
}
