﻿using eattendance_desktop.Forms;
using eattendance_desktop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eattendance_desktop
{
    public partial class MainWindow : Form
    {
        DatabaseHandler DB = new DatabaseHandler();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Show devices data from database
            populateDevices();
            // Show unsynced attendances in database
            populateAttendances();
            // register device selection changed event
            this.dataGridDevices.SelectionChanged += new System.EventHandler(this.dataGridDevices_SelectionChangedClick);
            this.dataGridDevices_SelectionChangedClick(null, null);
            InitializeStatusStripTimer();

            // logged in message
            showStatusMessage("Logged in as " + Common.loginCredential.username);
        }

        #region Devices Table

        private void populateDevices()
        {
            // Get data from database into memory
            DB.getDevicesIntoMemory();
            // now use the data to fill up the table
            fillDevices();
        }

        private void fillDevices()
        {
            // First clear the dataGridView
            dataGridDevices.DataSource = null;
            dataGridDevices.Rows.Clear();
            int rowcount = 0;
            foreach (Device device in Common.Devices)
            {
                dataGridDevices.Rows.Add();
                dataGridDevices.Rows[rowcount].Cells[0].Value = device.name;
                dataGridDevices.Rows[rowcount].Cells[1].Value = device.status;
                dataGridDevices.Rows[rowcount].Cells[2].Value = device.deviceNumber;
                dataGridDevices.Rows[rowcount].Cells[3].Value = device.IP;
                dataGridDevices.Rows[rowcount].Cells[4].Value = device.port;
                dataGridDevices.Rows[rowcount].Cells[5].Value = device.remarks;

                dataGridDevices.Rows[rowcount].Cells[1].Style = (device.isConnected ? Common.OnlineStyle : Common.OfflineStyle);
                rowcount++;
            }
        }

        private void dataGridDevices_SelectionChangedClick(object sender, EventArgs e)
        {
            try
            {
                btnConnect.Enabled = false;
                String status = (String)dataGridDevices.SelectedRows[0].Cells[1].Value;
                if (status == null)
                {
                    btnConnect.Enabled = false;
                }
                else if (status.ToLower().Equals("online"))
                {
                    btnConnect.Enabled = true;
                    btnConnect.Text = "Disconnect";
                }
                else if (status.ToLower().Equals("offline"))
                {
                    btnConnect.Enabled = true;
                    btnConnect.Text = "Connect";
                }
            }
            catch { }
        }
        
        #endregion

        #region Devices Window

        private void btnDevices_Click(object sender, EventArgs e)
        {
            DevicesWindow devicesWindow = new DevicesWindow();
            devicesWindow.FormClosed += new FormClosedEventHandler(devicesWindowClosed);
            devicesWindow.ShowDialog();
        }

        private void devicesWindowClosed(object sender, FormClosedEventArgs e)
        {
            this.fillDevices();
            this.dataGridDevices_SelectionChangedClick(null, null);
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDeviceWindow addDeviceWindow = new AddDeviceWindow();
            addDeviceWindow.FormClosed += new FormClosedEventHandler(devicesWindowClosed); // same handler function does fine here
            addDeviceWindow.ShowDialog();
        }

        #endregion

        #region Attendances Table

        public void populateAttendances()
        {
            // First clear the table
            dataGridAttendances.DataSource = null;
            dataGridAttendances.Rows.Clear();
            // Get data from database into memory
            List<Attendance> attendances = DB.getAttendances();
            // now use the data to fill up the table
            dataGridAttendances.DataSource = null;
            dataGridAttendances.Rows.Clear();
            int rowcount = 0;
            foreach (Attendance attendance in attendances)
            {
                insertAttendanceToTable(attendance, rowcount);
                rowcount++;
            }
        }

        public void insertAttendanceToTable(Attendance attendance, int nRow = -1)
        {
            if (nRow == -1)
                nRow = dataGridAttendances.RowCount;
            Staff staff = DB.getStaff(Convert.ToInt32(attendance.userid));
            if (staff != null)
            {
                dataGridAttendances.Rows.Add();
                dataGridAttendances.Rows[nRow].Cells[0].Value = attendance.userid;
                dataGridAttendances.Rows[nRow].Cells[1].Value = staff.cardNumber;
                dataGridAttendances.Rows[nRow].Cells[2].Value = Common.UserPrivilege[staff.privilege];
                dataGridAttendances.Rows[nRow].Cells[3].Value = staff.name;
                dataGridAttendances.Rows[nRow].Cells[4].Value = attendance.datetime.ToString("hh:mm tt, MMM d");
                dataGridAttendances.Rows[nRow].Cells[5].Value = attendance.device;
                dataGridAttendances.Rows[nRow].Cells[6].Value = attendance.entryMethod;
            }
        }

        #endregion

        #region Attendances Window

        private void btnAttendances_Click(object sender, EventArgs e)
        {
            using (AttendancesWindow attendancesWindow = new AttendancesWindow())
            {
                attendancesWindow.ShowDialog();
                // reload the attendances table
                populateAttendances();
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            using (ManualAttendanceWindow manualAttendanceWindow = new ManualAttendanceWindow())
            {
                manualAttendanceWindow.ShowDialog();

                // retrieve the attendance that was saved and update dataGridAttendances
                if (manualAttendanceWindow.newAttendance != null)
                {
                    insertAttendanceToTable(manualAttendanceWindow.newAttendance);
                }
            }
        }

        #endregion

        #region Staffs Window
        private void btnStaffs_Click(object sender, EventArgs e)
        {
            using (StaffsWindow staffsWindow = new StaffsWindow())
            {
                staffsWindow.ShowDialog();
            }
        }
        #endregion

        #region Other UI Event Handlers
        private void btnConnect_Click(object sender, EventArgs e)
        {
            int deviceNumber = Convert.ToInt32(dataGridDevices.SelectedRows[0].Cells[2].Value);
            Device selectedDevice = null;
            selectedDevice = Common.Devices.Find(x => x.deviceNumber == deviceNumber);

            if (selectedDevice == null) return;
            if (selectedDevice.IP == "" || selectedDevice.port == "")
            {
                MessageBox.Show("IP and Port cannot be null", "Error");
                return;
            }
            int idwErrorCode = 0;

            this.lblInfoStatusStrip.Text = "Attempting connection. Please Wait.";
            this.statusStrip.Refresh();
            Cursor = Cursors.WaitCursor;
            if (btnConnect.Text == "Disconnect")
            {
                selectedDevice.device.Disconnect();
                selectedDevice.device.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(
                    (sEnrollNumber, iIsInValid, iAttState, iVerifyMethod, iYear, iMonth, iDay, iHour, iMinute, iSecond, iWorkCode) => OnAttTransactionEx(
                        selectedDevice, sEnrollNumber, iIsInValid, iAttState, iVerifyMethod, iYear, iMonth, iDay, iHour, iMinute, iSecond, iWorkCode));
                selectedDevice.isConnected = false;
                selectedDevice.status = "Offline";
                btnConnect.Text = "Connect";
                dataGridDevices.SelectedRows[0].Cells[1].Value = "Offline";
                dataGridDevices.SelectedRows[0].Cells[1].Style = Common.OfflineStyle;
                Cursor = Cursors.Default;
                showStatusMessage("Successfully disconnected.");
                return;
            }

            selectedDevice.isConnected = selectedDevice.device.Connect_Net(selectedDevice.IP, Convert.ToInt32(selectedDevice.port));
            if (selectedDevice.isConnected)
            {
                btnConnect.Text = "Disconnect";
                btnConnect.Refresh();
                selectedDevice.status = "Online";
                dataGridDevices.SelectedRows[0].Cells[1].Value = "Online";
                dataGridDevices.SelectedRows[0].Cells[1].Style = Common.OnlineStyle;
                showStatusMessage("Connection Successful.");

                selectedDevice.device.RegEvent(selectedDevice.deviceNumber, 65535);
                selectedDevice.device.SetDeviceTime(selectedDevice.deviceNumber);
                selectedDevice.device.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(
                    (sEnrollNumber, iIsInValid, iAttState, iVerifyMethod, iYear, iMonth, iDay, iHour, iMinute, iSecond, iWorkCode) => OnAttTransactionEx(
                        selectedDevice, sEnrollNumber, iIsInValid, iAttState, iVerifyMethod, iYear, iMonth, iDay, iHour, iMinute, iSecond, iWorkCode));
            }
            else
            {
                selectedDevice.device.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device, ErrorCode " + idwErrorCode.ToString(), "Error");
                showStatusMessage("Connection Failed.");
            }
            Cursor = Cursors.Default;
        }
        #endregion

        #region RTEvent Handlers
        private void OnAttTransactionEx(Device device, string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod,
            int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode)
        {
            // try to get staff from database for said enrollNumber
            Staff staff = DB.getStaff(Convert.ToInt32(sEnrollNumber));
            if (staff != null)
            {
                // create the attendance object
                Attendance attendance = new Attendance(sEnrollNumber, DateTime.Now, device.name, Common.VerifyMethods[iVerifyMethod]);
                // add attendance to database
                DB.insertAttendance(attendance);
                // now fill the attendancs table
                dataGridAttendances.Rows.Add();
                int rowIndex = dataGridAttendances.Rows.Count - 1;
                dataGridAttendances.Rows[rowIndex].Cells[0].Value = attendance.userid;
                dataGridAttendances.Rows[rowIndex].Cells[2].Value = Common.UserPrivilege[staff.privilege];
                dataGridAttendances.Rows[rowIndex].Cells[3].Value = staff.name;
                dataGridAttendances.Rows[rowIndex].Cells[4].Value = attendance.datetime.ToString("hh:mm tt, MMM d");
                dataGridAttendances.Rows[rowIndex].Cells[5].Value = attendance.device;
                dataGridAttendances.Rows[rowIndex].Cells[6].Value = attendance.entryMethod;
            }
        }
        #endregion

        #region logout

        // This property will be read back in LoginWindow after MainWindow is closed
        public ExitIntent exitIntent = ExitIntent.CLOSE;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Delete the token in the local database
            try
            {
                DB.clearLoginCredential();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
                MessageBox.Show(ex.Message, "Error");
            }
            // clear the devices array in memory
            Common.Devices = null;
            Common.iMaxDeviceNumber = 0;
            // now close this form
            this.exitIntent = ExitIntent.LOGOUT;
            this.Close();
        }

        #endregion

        #region statusStrip
        Timer statusStripTimer = new Timer();
        private void InitializeStatusStripTimer()
        {
            statusStripTimer.Interval = 2500;
            statusStripTimer.Tick += emptyStatusStripInfoLabel;
        }

        private void showStatusMessage(String msg, int interval = 2500)
        {
            this.lblInfoStatusStrip.Text = msg;
            clearStatusStripInfoLabel(interval);
        }

        private void clearStatusStripInfoLabel(int interval)
        {
            statusStripTimer.Interval = interval;
            statusStripTimer.Start();
        }

        void emptyStatusStripInfoLabel(object sender, EventArgs e)
        {
            this.lblInfoStatusStrip.Text = "";
            statusStripTimer.Stop();
        }
        #endregion
    }
}
