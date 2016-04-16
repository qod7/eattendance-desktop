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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStaffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnAttendances = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDevices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnStaffs = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.tablesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.devicesGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridDevices = new System.Windows.Forms.DataGridView();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancesGroupBox = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblInfoStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridAttendances = new System.Windows.Forms.DataGridView();
            this.AttendanceAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceEntryMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesSplitContainer)).BeginInit();
            this.tablesSplitContainer.Panel1.SuspendLayout();
            this.tablesSplitContainer.Panel2.SuspendLayout();
            this.tablesSplitContainer.SuspendLayout();
            this.devicesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevices)).BeginInit();
            this.attendancesGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAttendances)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.staffsToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAttendancesToolStripMenuItem,
            this.manualAttendanceToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // viewAttendancesToolStripMenuItem
            // 
            this.viewAttendancesToolStripMenuItem.Name = "viewAttendancesToolStripMenuItem";
            this.viewAttendancesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewAttendancesToolStripMenuItem.Text = "View Attendances";
            this.viewAttendancesToolStripMenuItem.Click += new System.EventHandler(this.btnAttendances_Click);
            // 
            // manualAttendanceToolStripMenuItem
            // 
            this.manualAttendanceToolStripMenuItem.Name = "manualAttendanceToolStripMenuItem";
            this.manualAttendanceToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.manualAttendanceToolStripMenuItem.Text = "Manual Attendance";
            this.manualAttendanceToolStripMenuItem.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // staffsToolStripMenuItem
            // 
            this.staffsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStaffsToolStripMenuItem,
            this.timetableToolStripMenuItem,
            this.iDGeneratorToolStripMenuItem});
            this.staffsToolStripMenuItem.Name = "staffsToolStripMenuItem";
            this.staffsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.staffsToolStripMenuItem.Text = "Staffs";
            // 
            // manageStaffsToolStripMenuItem
            // 
            this.manageStaffsToolStripMenuItem.Name = "manageStaffsToolStripMenuItem";
            this.manageStaffsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.manageStaffsToolStripMenuItem.Text = "Manage Staffs";
            this.manageStaffsToolStripMenuItem.Click += new System.EventHandler(this.btnStaffs_Click);
            // 
            // timetableToolStripMenuItem
            // 
            this.timetableToolStripMenuItem.Name = "timetableToolStripMenuItem";
            this.timetableToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.timetableToolStripMenuItem.Text = "Timetable";
            // 
            // iDGeneratorToolStripMenuItem
            // 
            this.iDGeneratorToolStripMenuItem.Name = "iDGeneratorToolStripMenuItem";
            this.iDGeneratorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.iDGeneratorToolStripMenuItem.Text = "ID Generator";
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
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.btnDevices_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncDatabaseToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // syncDatabaseToolStripMenuItem
            // 
            this.syncDatabaseToolStripMenuItem.Name = "syncDatabaseToolStripMenuItem";
            this.syncDatabaseToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.syncDatabaseToolStripMenuItem.Text = "Sync Database";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.mainSplitContainer.Panel1.Controls.Add(this.btnLogout);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnSync);
            this.mainSplitContainer.Panel1.Controls.Add(this.label3);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnManual);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnAttendances);
            this.mainSplitContainer.Panel1.Controls.Add(this.label2);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnConnect);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnDevices);
            this.mainSplitContainer.Panel1.Controls.Add(this.label1);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnTimetable);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnStaffs);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnDepartments);
            this.mainSplitContainer.Panel1MinSize = 80;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.mainSplitContainer.Panel2.Controls.Add(this.tablesSplitContainer);
            this.mainSplitContainer.Panel2MinSize = 100;
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 587);
            this.mainSplitContainer.SplitterDistance = 80;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::eattendance_desktop.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(651, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(75, 74);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSync
            // 
            this.btnSync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Image = global::eattendance_desktop.Properties.Resources.sync;
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSync.Location = new System.Drawing.Point(573, 3);
            this.btnSync.Name = "btnSync";
            this.btnSync.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSync.Size = new System.Drawing.Size(75, 74);
            this.btnSync.TabIndex = 10;
            this.btnSync.Text = "Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(568, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 65);
            this.label3.TabIndex = 9;
            // 
            // btnManual
            // 
            this.btnManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Image = global::eattendance_desktop.Properties.Resources.manual_attendance;
            this.btnManual.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManual.Location = new System.Drawing.Point(490, 3);
            this.btnManual.Name = "btnManual";
            this.btnManual.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnManual.Size = new System.Drawing.Size(75, 74);
            this.btnManual.TabIndex = 8;
            this.btnManual.Text = "Manual";
            this.btnManual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnAttendances
            // 
            this.btnAttendances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAttendances.FlatAppearance.BorderSize = 0;
            this.btnAttendances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendances.Image = global::eattendance_desktop.Properties.Resources.attendances;
            this.btnAttendances.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAttendances.Location = new System.Drawing.Point(412, 3);
            this.btnAttendances.Name = "btnAttendances";
            this.btnAttendances.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAttendances.Size = new System.Drawing.Size(75, 74);
            this.btnAttendances.TabIndex = 7;
            this.btnAttendances.Text = "Attendances";
            this.btnAttendances.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAttendances.UseVisualStyleBackColor = true;
            this.btnAttendances.Click += new System.EventHandler(this.btnAttendances_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(407, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 65);
            this.label2.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Image = global::eattendance_desktop.Properties.Resources.connect;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConnect.Location = new System.Drawing.Point(329, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnConnect.Size = new System.Drawing.Size(75, 74);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDevices
            // 
            this.btnDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDevices.FlatAppearance.BorderSize = 0;
            this.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevices.Image = global::eattendance_desktop.Properties.Resources.Device;
            this.btnDevices.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDevices.Location = new System.Drawing.Point(251, 3);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDevices.Size = new System.Drawing.Size(75, 74);
            this.btnDevices.TabIndex = 4;
            this.btnDevices.Text = "Devices";
            this.btnDevices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDevices.UseVisualStyleBackColor = true;
            this.btnDevices.Click += new System.EventHandler(this.btnDevices_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(246, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 65);
            this.label1.TabIndex = 3;
            // 
            // btnTimetable
            // 
            this.btnTimetable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimetable.FlatAppearance.BorderSize = 0;
            this.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetable.Image = global::eattendance_desktop.Properties.Resources.timetables;
            this.btnTimetable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimetable.Location = new System.Drawing.Point(168, 3);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTimetable.Size = new System.Drawing.Size(75, 74);
            this.btnTimetable.TabIndex = 2;
            this.btnTimetable.Text = "Timetable";
            this.btnTimetable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimetable.UseVisualStyleBackColor = true;
            // 
            // btnStaffs
            // 
            this.btnStaffs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStaffs.FlatAppearance.BorderSize = 0;
            this.btnStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffs.Image = global::eattendance_desktop.Properties.Resources.user;
            this.btnStaffs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffs.Location = new System.Drawing.Point(90, 3);
            this.btnStaffs.Name = "btnStaffs";
            this.btnStaffs.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnStaffs.Size = new System.Drawing.Size(75, 74);
            this.btnStaffs.TabIndex = 1;
            this.btnStaffs.Text = "Staffs";
            this.btnStaffs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaffs.UseVisualStyleBackColor = true;
            this.btnStaffs.Click += new System.EventHandler(this.btnStaffs_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDepartments.FlatAppearance.BorderSize = 0;
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartments.Image = global::eattendance_desktop.Properties.Resources.usergroup;
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartments.Location = new System.Drawing.Point(12, 3);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDepartments.Size = new System.Drawing.Size(75, 74);
            this.btnDepartments.TabIndex = 0;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartments.UseVisualStyleBackColor = true;
            // 
            // tablesSplitContainer
            // 
            this.tablesSplitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.tablesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.tablesSplitContainer.Margin = new System.Windows.Forms.Padding(3, 105, 3, 3);
            this.tablesSplitContainer.Name = "tablesSplitContainer";
            this.tablesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tablesSplitContainer.Panel1
            // 
            this.tablesSplitContainer.Panel1.Controls.Add(this.devicesGroupBox);
            this.tablesSplitContainer.Panel1MinSize = 66;
            // 
            // tablesSplitContainer.Panel2
            // 
            this.tablesSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tablesSplitContainer.Panel2.Controls.Add(this.attendancesGroupBox);
            this.tablesSplitContainer.Panel2MinSize = 100;
            this.tablesSplitContainer.Size = new System.Drawing.Size(784, 503);
            this.tablesSplitContainer.SplitterDistance = 217;
            this.tablesSplitContainer.TabIndex = 3;
            // 
            // devicesGroupBox
            // 
            this.devicesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.devicesGroupBox.Controls.Add(this.dataGridDevices);
            this.devicesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.devicesGroupBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.devicesGroupBox.Name = "devicesGroupBox";
            this.devicesGroupBox.Size = new System.Drawing.Size(784, 217);
            this.devicesGroupBox.TabIndex = 0;
            this.devicesGroupBox.TabStop = false;
            this.devicesGroupBox.Text = "Devices";
            // 
            // dataGridDevices
            // 
            this.dataGridDevices.AllowUserToAddRows = false;
            this.dataGridDevices.AllowUserToDeleteRows = false;
            this.dataGridDevices.AllowUserToOrderColumns = true;
            this.dataGridDevices.AllowUserToResizeRows = false;
            this.dataGridDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDevices.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDevices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceName,
            this.DeviceStatus,
            this.DeviceNumber,
            this.DeviceIPAddress,
            this.DevicePort,
            this.DeviceRemark});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDevices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDevices.Location = new System.Drawing.Point(3, 16);
            this.dataGridDevices.MultiSelect = false;
            this.dataGridDevices.Name = "dataGridDevices";
            this.dataGridDevices.ReadOnly = true;
            this.dataGridDevices.RowTemplate.ReadOnly = true;
            this.dataGridDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDevices.ShowEditingIcon = false;
            this.dataGridDevices.Size = new System.Drawing.Size(778, 198);
            this.dataGridDevices.TabIndex = 1;
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeviceName.FillWeight = 80F;
            this.DeviceName.Frozen = true;
            this.DeviceName.HeaderText = "Name";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            this.DeviceName.Width = 168;
            // 
            // DeviceStatus
            // 
            this.DeviceStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeviceStatus.FillWeight = 50F;
            this.DeviceStatus.HeaderText = "Status";
            this.DeviceStatus.Name = "DeviceStatus";
            this.DeviceStatus.ReadOnly = true;
            this.DeviceStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DeviceStatus.Width = 105;
            // 
            // DeviceNumber
            // 
            this.DeviceNumber.FillWeight = 50F;
            this.DeviceNumber.HeaderText = "Device Number";
            this.DeviceNumber.Name = "DeviceNumber";
            this.DeviceNumber.ReadOnly = true;
            this.DeviceNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeviceIPAddress
            // 
            this.DeviceIPAddress.FillWeight = 50F;
            this.DeviceIPAddress.HeaderText = "IPAddress";
            this.DeviceIPAddress.Name = "DeviceIPAddress";
            this.DeviceIPAddress.ReadOnly = true;
            this.DeviceIPAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DevicePort
            // 
            this.DevicePort.FillWeight = 30F;
            this.DevicePort.HeaderText = "Port";
            this.DevicePort.Name = "DevicePort";
            this.DevicePort.ReadOnly = true;
            this.DevicePort.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeviceRemark
            // 
            this.DeviceRemark.FillWeight = 80F;
            this.DeviceRemark.HeaderText = "Remarks";
            this.DeviceRemark.Name = "DeviceRemark";
            this.DeviceRemark.ReadOnly = true;
            // 
            // attendancesGroupBox
            // 
            this.attendancesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.attendancesGroupBox.Controls.Add(this.statusStrip);
            this.attendancesGroupBox.Controls.Add(this.dataGridAttendances);
            this.attendancesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.attendancesGroupBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.attendancesGroupBox.Name = "attendancesGroupBox";
            this.attendancesGroupBox.Size = new System.Drawing.Size(784, 282);
            this.attendancesGroupBox.TabIndex = 1;
            this.attendancesGroupBox.TabStop = false;
            this.attendancesGroupBox.Text = "Attendance Entries";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfoStatusStrip});
            this.statusStrip.Location = new System.Drawing.Point(3, 257);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(778, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblInfoStatusStrip
            // 
            this.lblInfoStatusStrip.Name = "lblInfoStatusStrip";
            this.lblInfoStatusStrip.Size = new System.Drawing.Size(0, 17);
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
            this.AttendanceAccountNo,
            this.AttendanceCardNo,
            this.AttendanceAccountType,
            this.AttendanceStaffName,
            this.AttendanceTime,
            this.AttendanceDevice,
            this.AttendanceEntryMethod});
            this.dataGridAttendances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAttendances.Location = new System.Drawing.Point(3, 16);
            this.dataGridAttendances.MultiSelect = false;
            this.dataGridAttendances.Name = "dataGridAttendances";
            this.dataGridAttendances.ReadOnly = true;
            this.dataGridAttendances.Size = new System.Drawing.Size(778, 263);
            this.dataGridAttendances.TabIndex = 1;
            // 
            // AttendanceAccountNo
            // 
            this.AttendanceAccountNo.HeaderText = "Account No.";
            this.AttendanceAccountNo.Name = "AttendanceAccountNo";
            this.AttendanceAccountNo.ReadOnly = true;
            // 
            // AttendanceCardNo
            // 
            this.AttendanceCardNo.HeaderText = "Card No.";
            this.AttendanceCardNo.Name = "AttendanceCardNo";
            this.AttendanceCardNo.ReadOnly = true;
            this.AttendanceCardNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceCardNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AttendanceAccountType
            // 
            this.AttendanceAccountType.HeaderText = "Account Type";
            this.AttendanceAccountType.Name = "AttendanceAccountType";
            this.AttendanceAccountType.ReadOnly = true;
            // 
            // AttendanceStaffName
            // 
            this.AttendanceStaffName.HeaderText = "Staff Name";
            this.AttendanceStaffName.Name = "AttendanceStaffName";
            this.AttendanceStaffName.ReadOnly = true;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Attendance Desktop";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.tablesSplitContainer.Panel1.ResumeLayout(false);
            this.tablesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablesSplitContainer)).EndInit();
            this.tablesSplitContainer.ResumeLayout(false);
            this.devicesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevices)).EndInit();
            this.attendancesGroupBox.ResumeLayout(false);
            this.attendancesGroupBox.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAttendances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStaffsToolStripMenuItem;
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
        private System.Windows.Forms.DataGridView dataGridDevices;
        private System.Windows.Forms.GroupBox attendancesGroupBox;
        private System.Windows.Forms.DataGridView dataGridAttendances;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnStaffs;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button btnDevices;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnAttendances;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ToolStripStatusLabel lblInfoStatusStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicePort;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceRemark;
        private System.Windows.Forms.ToolStripMenuItem iDGeneratorToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceAccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceEntryMethod;
    }
}

