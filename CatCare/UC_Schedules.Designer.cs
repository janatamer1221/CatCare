namespace CatCare
{
    partial class UC_Schedules
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
            this.pnlSchedules = new System.Windows.Forms.Panel();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.cmbScheduleType = new System.Windows.Forms.ComboBox();
            this.cmbCatName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeREaming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSchedules
            // 
            this.pnlSchedules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlSchedules.Controls.Add(this.btnAddSchedule);
            this.pnlSchedules.Controls.Add(this.txtNotes);
            this.pnlSchedules.Controls.Add(this.dtpScheduleDate);
            this.pnlSchedules.Controls.Add(this.cmbScheduleType);
            this.pnlSchedules.Controls.Add(this.cmbCatName);
            this.pnlSchedules.Controls.Add(this.label4);
            this.pnlSchedules.Controls.Add(this.label3);
            this.pnlSchedules.Controls.Add(this.label2);
            this.pnlSchedules.Controls.Add(this.label1);
            this.pnlSchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSchedules.Location = new System.Drawing.Point(0, 0);
            this.pnlSchedules.Name = "pnlSchedules";
            this.pnlSchedules.Size = new System.Drawing.Size(626, 205);
            this.pnlSchedules.TabIndex = 0;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAddSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSchedule.FlatAppearance.BorderSize = 0;
            this.btnAddSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchedule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
            this.btnAddSchedule.Location = new System.Drawing.Point(245, 149);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(140, 36);
            this.btnAddSchedule.TabIndex = 8;
            this.btnAddSchedule.Text = "Add Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = false;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(447, 89);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(170, 45);
            this.txtNotes.TabIndex = 7;
            // 
            // dtpScheduleDate
            // 
            this.dtpScheduleDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScheduleDate.CustomFormat = "dd/MM/yyyy hh:mm:tt";
            this.dtpScheduleDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScheduleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduleDate.Location = new System.Drawing.Point(447, 52);
            this.dtpScheduleDate.Name = "dtpScheduleDate";
            this.dtpScheduleDate.Size = new System.Drawing.Size(170, 25);
            this.dtpScheduleDate.TabIndex = 6;
            // 
            // cmbScheduleType
            // 
            this.cmbScheduleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbScheduleType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbScheduleType.FormattingEnabled = true;
            this.cmbScheduleType.Items.AddRange(new object[] {
            "Meal",
            "Vaccine"});
            this.cmbScheduleType.Location = new System.Drawing.Point(150, 103);
            this.cmbScheduleType.Name = "cmbScheduleType";
            this.cmbScheduleType.Size = new System.Drawing.Size(121, 31);
            this.cmbScheduleType.TabIndex = 5;
            // 
            // cmbCatName
            // 
            this.cmbCatName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCatName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatName.FormattingEnabled = true;
            this.cmbCatName.Location = new System.Drawing.Point(150, 46);
            this.cmbCatName.Name = "cmbCatName";
            this.cmbCatName.Size = new System.Drawing.Size(121, 31);
            this.cmbCatName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(330, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(316, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date/Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schedule Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cat Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedules.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.colType,
            this.ColDateAndTime,
            this.ColNotes,
            this.ColTimeREaming});
            this.dgvSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedules.Location = new System.Drawing.Point(0, 205);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.RowHeadersVisible = false;
            this.dgvSchedules.RowHeadersWidth = 51;
            this.dgvSchedules.RowTemplate.Height = 24;
            this.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedules.Size = new System.Drawing.Size(626, 249);
            this.dgvSchedules.TabIndex = 1;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Cat Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // ColDateAndTime
            // 
            this.ColDateAndTime.HeaderText = "Date And Time";
            this.ColDateAndTime.MinimumWidth = 6;
            this.ColDateAndTime.Name = "ColDateAndTime";
            this.ColDateAndTime.ReadOnly = true;
            // 
            // ColNotes
            // 
            this.ColNotes.HeaderText = "Notes";
            this.ColNotes.MinimumWidth = 6;
            this.ColNotes.Name = "ColNotes";
            this.ColNotes.ReadOnly = true;
            // 
            // ColTimeREaming
            // 
            this.ColTimeREaming.HeaderText = "Time Remaining";
            this.ColTimeREaming.MinimumWidth = 6;
            this.ColTimeREaming.Name = "ColTimeREaming";
            this.ColTimeREaming.ReadOnly = true;
            // 
            // UC_Schedules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.dgvSchedules);
            this.Controls.Add(this.pnlSchedules);
            this.MinimumSize = new System.Drawing.Size(626, 454);
            this.Name = "UC_Schedules";
            this.Size = new System.Drawing.Size(626, 454);
            this.pnlSchedules.ResumeLayout(false);
            this.pnlSchedules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSchedules;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpScheduleDate;
        private System.Windows.Forms.ComboBox cmbScheduleType;
        private System.Windows.Forms.ComboBox cmbCatName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeREaming;
    }
}
