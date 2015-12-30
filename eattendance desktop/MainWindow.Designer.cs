namespace eattendance_desktop
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attemptSyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tablesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.devicesGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeviceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancesGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AttendanceUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceEntryMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.tablesSplitContainer.Panel1.SuspendLayout();
            this.tablesSplitContainer.Panel2.SuspendLayout();
            this.tablesSplitContainer.SuspendLayout();
            this.devicesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.attendancesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAttendancesToolStripMenuItem,
            this.manualAttendanceToolStripMenuItem,
            this.attemptSyncToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // viewAttendancesToolStripMenuItem
            // 
            this.viewAttendancesToolStripMenuItem.Name = "viewAttendancesToolStripMenuItem";
            this.viewAttendancesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewAttendancesToolStripMenuItem.Text = "View Attendances";
            // 
            // manualAttendanceToolStripMenuItem
            // 
            this.manualAttendanceToolStripMenuItem.Name = "manualAttendanceToolStripMenuItem";
            this.manualAttendanceToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.manualAttendanceToolStripMenuItem.Text = "Manual Attendance";
            // 
            // attemptSyncToolStripMenuItem
            // 
            this.attemptSyncToolStripMenuItem.Name = "attemptSyncToolStripMenuItem";
            this.attemptSyncToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.attemptSyncToolStripMenuItem.Text = "Attempt Sync";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGroupsToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.timetableToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // userGroupsToolStripMenuItem
            // 
            this.userGroupsToolStripMenuItem.Name = "userGroupsToolStripMenuItem";
            this.userGroupsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.userGroupsToolStripMenuItem.Text = "User Groups";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // timetableToolStripMenuItem
            // 
            this.timetableToolStripMenuItem.Name = "timetableToolStripMenuItem";
            this.timetableToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.timetableToolStripMenuItem.Text = "Timetable";
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plansToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // plansToolStripMenuItem
            // 
            this.plansToolStripMenuItem.Name = "plansToolStripMenuItem";
            this.plansToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.plansToolStripMenuItem.Text = "Plans";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.mainSplitContainer.Panel1MinSize = 80;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.mainSplitContainer.Panel2.Controls.Add(this.tablesSplitContainer);
            this.mainSplitContainer.Panel2MinSize = 100;
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 537);
            this.mainSplitContainer.SplitterDistance = 80;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // tablesSplitContainer
            // 
            this.tablesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.tablesSplitContainer.Margin = new System.Windows.Forms.Padding(3, 105, 3, 3);
            this.tablesSplitContainer.Name = "tablesSplitContainer";
            this.tablesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tablesSplitContainer.Panel1
            // 
            this.tablesSplitContainer.Panel1.Controls.Add(this.devicesGroupBox);
            // 
            // tablesSplitContainer.Panel2
            // 
            this.tablesSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tablesSplitContainer.Panel2.Controls.Add(this.attendancesGroupBox);
            this.tablesSplitContainer.Size = new System.Drawing.Size(784, 453);
            this.tablesSplitContainer.SplitterDistance = 210;
            this.tablesSplitContainer.TabIndex = 3;
            // 
            // devicesGroupBox
            // 
            this.devicesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.devicesGroupBox.Controls.Add(this.dataGridView1);
            this.devicesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.devicesGroupBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.devicesGroupBox.Name = "devicesGroupBox";
            this.devicesGroupBox.Size = new System.Drawing.Size(784, 210);
            this.devicesGroupBox.TabIndex = 0;
            this.devicesGroupBox.TabStop = false;
            this.devicesGroupBox.Text = "Devices";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceName,
            this.DeviceStatus,
            this.DeviceNumber,
            this.DeviceIPAddress,
            this.DevicePort,
            this.DeviceRemark});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 191);
            this.dataGridView1.TabIndex = 1;
            // 
            // DeviceName
            // 
            this.DeviceName.HeaderText = "Name";
            this.DeviceName.Name = "DeviceName";
            // 
            // DeviceStatus
            // 
            this.DeviceStatus.HeaderText = "Status";
            this.DeviceStatus.Name = "DeviceStatus";
            this.DeviceStatus.ReadOnly = true;
            // 
            // DeviceNumber
            // 
            this.DeviceNumber.HeaderText = "Number";
            this.DeviceNumber.Name = "DeviceNumber";
            this.DeviceNumber.ReadOnly = true;
            // 
            // DeviceIPAddress
            // 
            this.DeviceIPAddress.HeaderText = "IPAddress";
            this.DeviceIPAddress.Name = "DeviceIPAddress";
            this.DeviceIPAddress.ReadOnly = true;
            // 
            // DevicePort
            // 
            this.DevicePort.HeaderText = "Port";
            this.DevicePort.Name = "DevicePort";
            this.DevicePort.ReadOnly = true;
            // 
            // DeviceRemark
            // 
            this.DeviceRemark.HeaderText = "Remarks";
            this.DeviceRemark.Name = "DeviceRemark";
            this.DeviceRemark.ReadOnly = true;
            this.DeviceRemark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // attendancesGroupBox
            // 
            this.attendancesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.attendancesGroupBox.Controls.Add(this.dataGridView2);
            this.attendancesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.attendancesGroupBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.attendancesGroupBox.Name = "attendancesGroupBox";
            this.attendancesGroupBox.Size = new System.Drawing.Size(784, 239);
            this.attendancesGroupBox.TabIndex = 1;
            this.attendancesGroupBox.TabStop = false;
            this.attendancesGroupBox.Text = "Attendance Entries";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceUserID,
            this.AttendanceAccountNumber,
            this.AttendanceAccountType,
            this.AttendanceUserName,
            this.AttendanceTime,
            this.AttendanceDevice,
            this.AttendanceEntryMethod});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(778, 220);
            this.dataGridView2.TabIndex = 1;
            // 
            // AttendanceUserID
            // 
            this.AttendanceUserID.HeaderText = "User ID";
            this.AttendanceUserID.Name = "AttendanceUserID";
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
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Text = "E Attendance Desktop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.tablesSplitContainer.Panel1.ResumeLayout(false);
            this.tablesSplitContainer.Panel2.ResumeLayout(false);
            this.tablesSplitContainer.ResumeLayout(false);
            this.devicesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.attendancesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attemptSyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timetableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer tablesSplitContainer;
        private System.Windows.Forms.GroupBox devicesGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewButtonColumn DeviceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicePort;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceRemark;
        private System.Windows.Forms.GroupBox attendancesGroupBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceAccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceEntryMethod;
    }
}

