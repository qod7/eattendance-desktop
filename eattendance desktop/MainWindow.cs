using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eattendance_desktop
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            populateDevices();
            // register device selection changed event
            this.dataGridDevices.SelectionChanged += new System.EventHandler(this.dataGridDevices_SelectionChangedClick);
            this.dataGridDevices_SelectionChangedClick(null, null);
            InitializeStatusStripTimer();
        }

        private void populateDevices()
        {
            // TODO Replace following code to get data from database.
            // name, status, number, ip, port, remark
            object[] data = new object[]{new object[] {"Main Gate", "192.168.2.130", "4370", ""},
                                         new object[] {"Back Gate", "192.168.2.131", "4370", ""},
                                         new object[] {"Canteen", "192.168.2.132", "4370", "Shut down for maintenance"}};
            foreach (object[] row in data)
            {
                Common.Devices.Add(new Device((String)row[0], ++Common.iMaxDeviceNumber, (String)row[1], (String)row[2], (String)row[3]));
            }

            // now use the data to fill up the table
            Common.OnlineStyle.BackColor = Color.LimeGreen;
            Common.OfflineStyle.BackColor = Color.LightSlateGray;
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
            // String ip = (String)dataGridDevices.SelectedRows[0].Cells[3].Value;
            // MessageBox.Show(ip);
            String status = (String)dataGridDevices.SelectedRows[0].Cells[1].Value;
            if (status == null)
            {
                btnConnect.Enabled = true;
                btnConnect.Enabled = false;
            }
            else if (status.ToLower().Equals("online"))
            {
                btnConnect.Enabled = true;
                btnConnect.Text = "Disconnect";
            }
            else if (status.ToLower().Equals("offline"))
            {
                btnConnect.Text = "Connect";
            }
            else
            {
                btnConnect.Enabled = false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int deviceNumber = Convert.ToInt32(dataGridDevices.SelectedRows[0].Cells[2].Value);
            Device selectedDevice = null;
            foreach (Device device in Common.Devices)
            {
                if (device.deviceNumber == deviceNumber) {
                    selectedDevice = device;
                    break;
                }
            }

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
                selectedDevice.isConnected = false;
                selectedDevice.status = "Offline";
                btnConnect.Text = "Connect";
                dataGridDevices.SelectedRows[0].Cells[1].Value = "Offline";
                dataGridDevices.SelectedRows[0].Cells[1].Style = Common.OfflineStyle;
                Cursor = Cursors.Default;
                this.lblInfoStatusStrip.Text = "Successfully disconnected.";
                clearStatusStripInfoLabel();
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
                this.lblInfoStatusStrip.Text = "Connection Successful.";
                clearStatusStripInfoLabel();

                selectedDevice.device.RegEvent(selectedDevice.deviceNumber, 65535);
            }
            else
            {
                selectedDevice.device.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device, ErrorCode=" + idwErrorCode.ToString(), "Error");
                this.lblInfoStatusStrip.Text = "Connection Failed.";
                clearStatusStripInfoLabel();
            }
            Cursor = Cursors.Default;
        }


        Timer statusStripTimer = new Timer();
        private void InitializeStatusStripTimer()
        {
            statusStripTimer.Interval = 2500;
            statusStripTimer.Tick += emptyStatusStripInfoLabel;
        }
        private void clearStatusStripInfoLabel()
        {
            statusStripTimer.Start();
        }

        void emptyStatusStripInfoLabel(object sender, EventArgs e)
        {
            this.lblInfoStatusStrip.Text = "";
            statusStripTimer.Stop();
        }
    }
}
