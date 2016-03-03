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
    public partial class AddDeviceWindow : Form
    {
        zkemkeeper.CZKEMClass tempDevice = new zkemkeeper.CZKEMClass();
        DatabaseHandler DB = new DatabaseHandler();

        public AddDeviceWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // first validate data - Only name. IP, Port are already validated.
            if (String.IsNullOrEmpty(txtDeviceName.Text.ToString().Trim()))
            {
                errorProvider1.SetError(txtDeviceName, "Name cannot be empty.");
                return;
            }
            // Now create device
            Device device = new Device(tempDevice, btnConnect.Text.ToString().Equals("Disconnect"), txtDeviceName.Text.Trim(),
                ++Common.iMaxDeviceNumber, txtDeviceIP.Text, txtDevicePort.Value.ToString(), txtDeviceRemarks.Text.Trim());
            // add this to database
            DB.insertDevice(device);
            // Update Common
            Common.Devices.Add(device);
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int idwErrorCode = 0;
            Cursor = Cursors.WaitCursor;
            if (btnConnect.Text == "Disconnect")
            {
                tempDevice.Disconnect();
                btnConnect.Text = "Attempt Connection";
                lblDeviceStatus.Text = "Disconnected";
                lblDeviceStatus.ForeColor = Color.DarkGray;
                Cursor = Cursors.Default;
                return;
            }

            bool isConnected = tempDevice.Connect_Net(txtDeviceIP.Text.ToString().Trim(), Convert.ToInt32(txtDevicePort.Value));
            if (isConnected)
            {
                btnConnect.Text = "Disconnect";
                btnConnect.Refresh();
                lblDeviceStatus.Text = "Connected";
                lblDeviceStatus.ForeColor = Color.Green;
                tempDevice.RegEvent(Common.iMaxDeviceNumber+1, 65535);
            }
            else
            {
                tempDevice.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device, ErrorCode " + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        private void AddDeviceWindow_Load(object sender, EventArgs e)
        {
            txtDeviceName.Text = String.Format("New Device {0}", Common.iMaxDeviceNumber + 1);
        }
    }
}
