namespace eattendance_desktop
{
    partial class AttendancesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendancesWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridAttendances = new System.Windows.Forms.DataGridView();
            this.AttendanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceEntryMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAttendances)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 311);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridAttendances);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 269);
            this.panel3.TabIndex = 4;
            // 
            // dataGridAttendances
            // 
            this.dataGridAttendances.AllowUserToAddRows = false;
            this.dataGridAttendances.AllowUserToDeleteRows = false;
            this.dataGridAttendances.AllowUserToOrderColumns = true;
            this.dataGridAttendances.AllowUserToResizeRows = false;
            this.dataGridAttendances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAttendances.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAttendances.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAttendances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAttendances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceID,
            this.AttendanceUserID,
            this.AttendanceAccountNumber,
            this.AttendanceAccountType,
            this.AttendanceUserName,
            this.AttendanceTime,
            this.AttendanceDevice,
            this.AttendanceEntryMethod});
            this.dataGridAttendances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAttendances.Location = new System.Drawing.Point(0, 0);
            this.dataGridAttendances.Name = "dataGridAttendances";
            this.dataGridAttendances.ReadOnly = true;
            this.dataGridAttendances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAttendances.Size = new System.Drawing.Size(784, 269);
            this.dataGridAttendances.TabIndex = 2;
            // 
            // AttendanceID
            // 
            this.AttendanceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AttendanceID.FillWeight = 50F;
            this.AttendanceID.Frozen = true;
            this.AttendanceID.HeaderText = "ID";
            this.AttendanceID.Name = "AttendanceID";
            this.AttendanceID.ReadOnly = true;
            this.AttendanceID.Width = 50;
            // 
            // AttendanceUserID
            // 
            this.AttendanceUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AttendanceUserID.FillWeight = 70F;
            this.AttendanceUserID.Frozen = true;
            this.AttendanceUserID.HeaderText = "User ID";
            this.AttendanceUserID.Name = "AttendanceUserID";
            this.AttendanceUserID.ReadOnly = true;
            this.AttendanceUserID.Width = 70;
            // 
            // AttendanceAccountNumber
            // 
            this.AttendanceAccountNumber.HeaderText = "Account Number";
            this.AttendanceAccountNumber.Name = "AttendanceAccountNumber";
            this.AttendanceAccountNumber.ReadOnly = true;
            this.AttendanceAccountNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceAccountNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AttendanceAccountType
            // 
            this.AttendanceAccountType.HeaderText = "Account Type";
            this.AttendanceAccountType.Name = "AttendanceAccountType";
            this.AttendanceAccountType.ReadOnly = true;
            // 
            // AttendanceUserName
            // 
            this.AttendanceUserName.HeaderText = "User Name";
            this.AttendanceUserName.Name = "AttendanceUserName";
            this.AttendanceUserName.ReadOnly = true;
            // 
            // AttendanceTime
            // 
            this.AttendanceTime.HeaderText = "Time";
            this.AttendanceTime.Name = "AttendanceTime";
            this.AttendanceTime.ReadOnly = true;
            // 
            // AttendanceDevice
            // 
            this.AttendanceDevice.HeaderText = "Device";
            this.AttendanceDevice.Name = "AttendanceDevice";
            this.AttendanceDevice.ReadOnly = true;
            this.AttendanceDevice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AttendanceEntryMethod
            // 
            this.AttendanceEntryMethod.HeaderText = "Entry Method";
            this.AttendanceEntryMethod.Name = "AttendanceEntryMethod";
            this.AttendanceEntryMethod.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteAll);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 42);
            this.panel2.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(12, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Selected Attendance";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(675, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAll.Location = new System.Drawing.Point(181, 10);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // AttendancesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "AttendancesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saved Attendances";
            this.Load += new System.EventHandler(this.AttendancessWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAttendances)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridAttendances;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceAccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceEntryMethod;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}