namespace CatCare
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnHealthRecords = new System.Windows.Forms.Button();
            this.btnSchedules = new System.Windows.Forms.Button();
            this.btnManageCats = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlSideBar.Controls.Add(this.btnHealthRecords);
            this.pnlSideBar.Controls.Add(this.btnSchedules);
            this.pnlSideBar.Controls.Add(this.btnManageCats);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(270, 592);
            this.pnlSideBar.TabIndex = 0;
            this.pnlSideBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pnlSideBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pnlSideBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnHealthRecords
            // 
            this.btnHealthRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHealthRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHealthRecords.FlatAppearance.BorderSize = 0;
            this.btnHealthRecords.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHealthRecords.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHealthRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealthRecords.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealthRecords.ForeColor = System.Drawing.Color.White;
            this.btnHealthRecords.Image = global::CatCare.Properties.Resources.icons8_cat_footprint_24;
            this.btnHealthRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHealthRecords.Location = new System.Drawing.Point(0, 100);
            this.btnHealthRecords.Name = "btnHealthRecords";
            this.btnHealthRecords.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHealthRecords.Size = new System.Drawing.Size(270, 50);
            this.btnHealthRecords.TabIndex = 2;
            this.btnHealthRecords.Text = "Health Records";
            this.btnHealthRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHealthRecords.UseVisualStyleBackColor = true;
            this.btnHealthRecords.Click += new System.EventHandler(this.btnHealthRecords_Click);
            // 
            // btnSchedules
            // 
            this.btnSchedules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedules.FlatAppearance.BorderSize = 0;
            this.btnSchedules.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSchedules.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedules.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedules.ForeColor = System.Drawing.Color.White;
            this.btnSchedules.Image = global::CatCare.Properties.Resources.Cat_schedule1;
            this.btnSchedules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedules.Location = new System.Drawing.Point(0, 50);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSchedules.Size = new System.Drawing.Size(270, 50);
            this.btnSchedules.TabIndex = 1;
            this.btnSchedules.Text = "Schedules";
            this.btnSchedules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedules.UseVisualStyleBackColor = true;
            this.btnSchedules.Click += new System.EventHandler(this.btnSchedules_Click);
            // 
            // btnManageCats
            // 
            this.btnManageCats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCats.FlatAppearance.BorderSize = 0;
            this.btnManageCats.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCats.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageCats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCats.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCats.ForeColor = System.Drawing.Color.White;
            this.btnManageCats.Image = global::CatCare.Properties.Resources.icons8_cat_head_24;
            this.btnManageCats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCats.Location = new System.Drawing.Point(0, 0);
            this.btnManageCats.Name = "btnManageCats";
            this.btnManageCats.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnManageCats.Size = new System.Drawing.Size(270, 50);
            this.btnManageCats.TabIndex = 0;
            this.btnManageCats.Text = "Manage Cats";
            this.btnManageCats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageCats.UseVisualStyleBackColor = true;
            this.btnManageCats.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.pnlContainer.BackgroundImage = global::CatCare.Properties.Resources.Untitled_design__1_;
            this.pnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(270, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(881, 592);
            this.pnlContainer.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 592);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cat Care Tracker";
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageCats;
        private System.Windows.Forms.Button btnSchedules;
        private System.Windows.Forms.Button btnHealthRecords;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Timer timer1;
    }
}

