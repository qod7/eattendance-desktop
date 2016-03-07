using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace eattendance_desktop
{
    public partial class DevicesWindow : Form
    {
        DatabaseHandler DB = new DatabaseHandler();
        public DevicesWindow()
        {
            InitializeComponent();
        }

        private void DevicesWindow_Load(object sender, EventArgs e)
        {
            populateTable();
            // now register for grid change events
            this.dataGridDevices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDevices_CellValueChanged);
            //this.dataGridDevices.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridDevices_CellValidating);
            //this.dataGridDevices.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridDevices_RowsAdded);
        }

        private void populateTable()
        {
            // use the data in Common.Devices to fill up the table
            int rowcount = 0;
            foreach (Device device in Common.Devices)
            {
                dataGridDevices.Rows.Add();
                if (device.isConnected)
                    // this is an uneditable row; make it look grey
                    dataGridDevices.Rows[rowcount].DefaultCellStyle = Common.OnlineStyle;
                else
                    dataGridDevices.Rows[rowcount].ReadOnly = false;
                dataGridDevices.Rows[rowcount].Cells[0].Value = rowcount + 1;
                dataGridDevices.Rows[rowcount].Cells[1].Value = device.name;
                dataGridDevices.Rows[rowcount].Cells[2].Value = device.IP;
                dataGridDevices.Rows[rowcount].Cells[3].Value = device.port;
                dataGridDevices.Rows[rowcount].Cells[4].Value = device.remarks;
                rowcount++;
            }
        }

        private void dataGridDevices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCell thisCell = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex];
                thisCell.Style = Common.BoldCellStyle;
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridDevices.Rows[dataGridDevices.SelectedCells[0].RowIndex];
                switch (MessageBox.Show("Are you sure you want to delete " + selectedRow.Cells[1].Value +
                    "?", "Confirm Delete", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        dataGridDevices.Rows.Remove(selectedRow);
                        updateSerialNumbers();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            catch { }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridDevices.Rows.Add();
            int rowIndex = dataGridDevices.Rows.Count - 1;
            dataGridDevices.Rows[rowIndex].ReadOnly = false;
            dataGridDevices.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
            dataGridDevices.Rows[rowIndex].Cells[1].Value = "New Device";
            dataGridDevices.Rows[rowIndex].Cells[2].Value = "192.168.1.100";
            dataGridDevices.Rows[rowIndex].Cells[3].Value = "4370";
            dataGridDevices.Rows[rowIndex].Cells[4].Value = "";
            dataGridDevices.Rows[rowIndex].Cells[1].Selected = true;
            dataGridDevices.BeginEdit(true);
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateDeviceData())
            {
                // save changes to database and update Common.devices
                DB.deleteAllDevices();
                List<Device> tempDevices = new List<Device>();
                foreach (DataGridViewRow thisRow in dataGridDevices.Rows)
                {
                    Device newDevice = new Device(
                        thisRow.Cells[1].FormattedValue.ToString().Trim(),
                        Convert.ToInt32(thisRow.Cells[0].FormattedValue.ToString().Trim()),
                        thisRow.Cells[2].FormattedValue.ToString().Trim(),
                        thisRow.Cells[3].FormattedValue.ToString().Trim(),
                        thisRow.Cells[4].FormattedValue.ToString().Trim()
                    );
                    DB.insertDevice(newDevice);

                    Device selectedDevice = Common.Devices.Find(x => (x.IP == newDevice.IP && x.port == newDevice.port));
                    if (selectedDevice != null && selectedDevice.isConnected) 
                    {
                        tempDevices.Add(selectedDevice);
                    }
                    else
                    {
                        // selectedDevice not found, create one; or is editable, so update it.
                        tempDevices.Add(newDevice);
                    }
                }
                Common.Devices = tempDevices;
                Common.iMaxDeviceNumber = dataGridDevices.RowCount;
                this.Close();
            }
        }

        private bool validateDeviceData()
        {
            bool flag = true;

            var ipPorts = new HashSet<string>();

            foreach (DataGridViewRow thisRow in dataGridDevices.Rows)
            {
                thisRow.ErrorText = string.Empty;
                String name = thisRow.Cells[1].FormattedValue.ToString().Trim();
                String ip = thisRow.Cells[2].FormattedValue.ToString().Trim();
                String port = thisRow.Cells[3].FormattedValue.ToString().Trim();
                ipPorts.Add(String.Format("{0}:{1}", ip, port));

                if (string.IsNullOrEmpty(name))
                {
                    thisRow.ErrorText = "Device Name cannot be empty.";
                    flag = false;
                }
                else if (Common.ipRegex.Match(ip).Length == 0)
                {
                    thisRow.ErrorText = "Please enter a valid IPv4 address.";
                    flag = false;
                }
                else if (Common.portRegex.Match(port).Length == 0)
                {
                    thisRow.ErrorText = "Please enter a valid port number.";
                    flag = false;
                }
            }
            // check for ip:port duplicates
            if (ipPorts.Count != this.dataGridDevices.RowCount)
            {
                MessageBox.Show("All IP:PORT combinations have to be unique.", "Uniqueness verification failed");
                flag = false;
            }
            return flag;
        }

        private void updateSerialNumbers()
        {
            int i = 1;
            foreach (DataGridViewRow row in this.dataGridDevices.Rows)
            {
                row.Cells[0].Value = i;
                i++;
            }
        }
    }
}
