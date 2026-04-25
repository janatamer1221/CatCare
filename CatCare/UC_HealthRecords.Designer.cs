namespace CatCare
{
    partial class UC_HealthRecords
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHealthRecords = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCatName = new System.Windows.Forms.ComboBox();
            this.cmbHealthStatus = new System.Windows.Forms.ComboBox();
            this.dtpRecordDate = new System.Windows.Forms.DateTimePicker();
            this.txtClinicalNotes = new System.Windows.Forms.TextBox();
            this.btnHealthRecords = new System.Windows.Forms.Button();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHealthStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClinicalNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnHealthRecords);
            this.panel1.Controls.Add(this.txtClinicalNotes);
            this.panel1.Controls.Add(this.dtpRecordDate);
            this.panel1.Controls.Add(this.cmbHealthStatus);
            this.panel1.Controls.Add(this.cmbCatName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 205);
            this.panel1.TabIndex = 0;
            // 
            // dgvHealthRecords
            // 
            this.dgvHealthRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHealthRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dgvHealthRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHealthRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHealthRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHealthRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColRecordDate,
            this.ColHealthStatus,
            this.ColClinicalNotes});
            this.dgvHealthRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHealthRecords.Location = new System.Drawing.Point(0, 205);
            this.dgvHealthRecords.Name = "dgvHealthRecords";
            this.dgvHealthRecords.RowHeadersVisible = false;
            this.dgvHealthRecords.RowHeadersWidth = 51;
            this.dgvHealthRecords.RowTemplate.Height = 24;
            this.dgvHealthRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHealthRecords.Size = new System.Drawing.Size(584, 245);
            this.dgvHealthRecords.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cat Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(278, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Record Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(278, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clinical Notes";
            // 
            // cmbCatName
            // 
            this.cmbCatName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCatName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatName.FormattingEnabled = true;
            this.cmbCatName.Location = new System.Drawing.Point(139, 30);
            this.cmbCatName.Name = "cmbCatName";
            this.cmbCatName.Size = new System.Drawing.Size(121, 31);
            this.cmbCatName.TabIndex = 4;
            // 
            // cmbHealthStatus
            // 
            this.cmbHealthStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHealthStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHealthStatus.FormattingEnabled = true;
            this.cmbHealthStatus.Items.AddRange(new object[] {
            "Healthy",
            "Sick"});
            this.cmbHealthStatus.Location = new System.Drawing.Point(139, 92);
            this.cmbHealthStatus.Name = "cmbHealthStatus";
            this.cmbHealthStatus.Size = new System.Drawing.Size(121, 31);
            this.cmbHealthStatus.TabIndex = 5;
            // 
            // dtpRecordDate
            // 
            this.dtpRecordDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRecordDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecordDate.Location = new System.Drawing.Point(428, 31);
            this.dtpRecordDate.Name = "dtpRecordDate";
            this.dtpRecordDate.Size = new System.Drawing.Size(136, 30);
            this.dtpRecordDate.TabIndex = 6;
            // 
            // txtClinicalNotes
            // 
            this.txtClinicalNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalNotes.Location = new System.Drawing.Point(428, 92);
            this.txtClinicalNotes.Multiline = true;
            this.txtClinicalNotes.Name = "txtClinicalNotes";
            this.txtClinicalNotes.Size = new System.Drawing.Size(136, 31);
            this.txtClinicalNotes.TabIndex = 7;
            // 
            // btnHealthRecords
            // 
            this.btnHealthRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnHealthRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHealthRecords.FlatAppearance.BorderSize = 0;
            this.btnHealthRecords.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHealthRecords.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHealthRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealthRecords.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealthRecords.ForeColor = System.Drawing.Color.White;
            this.btnHealthRecords.Location = new System.Drawing.Point(227, 148);
            this.btnHealthRecords.Name = "btnHealthRecords";
            this.btnHealthRecords.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnHealthRecords.Size = new System.Drawing.Size(176, 32);
            this.btnHealthRecords.TabIndex = 8;
            this.btnHealthRecords.Text = "Add Health Records";
            this.btnHealthRecords.UseVisualStyleBackColor = false;
            this.btnHealthRecords.Click += new System.EventHandler(this.btnHealthRecords_Click);
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColRecordDate
            // 
            this.ColRecordDate.HeaderText = "Record Date";
            this.ColRecordDate.MinimumWidth = 6;
            this.ColRecordDate.Name = "ColRecordDate";
            this.ColRecordDate.ReadOnly = true;
            // 
            // ColHealthStatus
            // 
            this.ColHealthStatus.HeaderText = "Health Status";
            this.ColHealthStatus.MinimumWidth = 6;
            this.ColHealthStatus.Name = "ColHealthStatus";
            this.ColHealthStatus.ReadOnly = true;
            // 
            // ColClinicalNotes
            // 
            this.ColClinicalNotes.HeaderText = "Clinical Notes";
            this.ColClinicalNotes.MinimumWidth = 6;
            this.ColClinicalNotes.Name = "ColClinicalNotes";
            this.ColClinicalNotes.ReadOnly = true;
            // 
            // UC_HealthRecords
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.dgvHealthRecords);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(584, 450);
            this.Name = "UC_HealthRecords";
            this.Size = new System.Drawing.Size(584, 450);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHealthRecords;
        private System.Windows.Forms.ComboBox cmbHealthStatus;
        private System.Windows.Forms.ComboBox cmbCatName;
        private System.Windows.Forms.TextBox txtClinicalNotes;
        private System.Windows.Forms.DateTimePicker dtpRecordDate;
        private System.Windows.Forms.Button btnHealthRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHealthStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClinicalNotes;
    }
}
