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
        public DevicesWindow()
        {
            InitializeComponent();
        }

        private void DevicesWindow_Load(object sender, EventArgs e)
        {
            populateTable();
            // now register for grid change events
            this.dataGridDevices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDevices_CellValueChanged);
            this.dataGridDevices.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridDevices_CellValidating);
            //this.dataGridDevices.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridDevices_RowsAdded);
        }

        private void populateTable()
        {
            // use the data in Common.Devices to fill up the table
            int rowcount = 0;
            foreach (Device device in Common.Devices)
            {
                dataGridDevices.Rows.Add();
                dataGridDevices.Rows[rowcount].ReadOnly = false;
                dataGridDevices.Rows[rowcount].Cells[0].Value = device.deviceNumber;
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

        //private void dataGridDevices_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    try
        //    {
        //        Device newDevice = new Device("New Device " + (Common.iMaxDeviceNumber + 1).ToString(), ++Common.iMaxDeviceNumber, "192.168.1.100", "4370", "");
        //        Common.Devices.Add(newDevice);
        //        DataGridView thisDataGridView = (DataGridView)sender;
        //        thisDataGridView.Rows[e.RowIndex].Cells[0].Value = newDevice.deviceNumber;
        //        thisDataGridView.Rows[e.RowIndex].Cells[0].Value = newDevice.name;
        //        thisDataGridView.Rows[e.RowIndex].Cells[0].Value = newDevice.IP;
        //        thisDataGridView.Rows[e.RowIndex].Cells[0].Value = newDevice.port;
        //        thisDataGridView.Rows[e.RowIndex].Cells[0].Value = newDevice.remarks;
        //    }
        //    catch { }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                DataGridViewRow selectedRow = dataGridDevices.Rows[dataGridDevices.SelectedCells[0].RowIndex];
                switch (MessageBox.Show("Are you sure you want to delete " + selectedRow.Cells[1].Value + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes: 
                        // Delete the device from database
                        // Delete the device from Common.Devices
                        // Remove all rows and call populateTable()
                        // OR
                        dataGridDevices.Rows.Remove(selectedRow);
                        break;
                    case DialogResult.No: 
                        break;
                }
            }
            catch {}

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Device newDevice = new Device("New Device " + (Common.iMaxDeviceNumber + 1).ToString(), ++Common.iMaxDeviceNumber, "192.168.1.100", "4370", "");
            Common.Devices.Add(newDevice);
            dataGridDevices.Rows.Add();
            int rowIndex = dataGridDevices.Rows.Count - 1;
            dataGridDevices.Rows[rowIndex].ReadOnly = false;
            dataGridDevices.Rows[rowIndex].Cells[0].Value = newDevice.deviceNumber;
            dataGridDevices.Rows[rowIndex].Cells[1].Value = newDevice.name;
            dataGridDevices.Rows[rowIndex].Cells[2].Value = newDevice.IP;
            dataGridDevices.Rows[rowIndex].Cells[3].Value = newDevice.port;
            dataGridDevices.Rows[rowIndex].Cells[4].Value = newDevice.remarks;
            dataGridDevices.Rows[rowIndex].Cells[1].Selected = true;
            dataGridDevices.BeginEdit(true);
        }

        private void dataGridDevices_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dataGridDevices.Columns[e.ColumnIndex].HeaderText;

            // Confirm that the cell is not empty.
            switch (e.ColumnIndex)
            {
                case 0:
                    break;
                case 1:
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        dataGridDevices.Rows[e.RowIndex].ErrorText = "Device Name cannot be empty.";
                        e.Cancel = true;
                    }
                    break;
                case 2:
                    Match match = Common.ipRegex.Match(e.FormattedValue.ToString());
                    if (match == null)
                    {
                        dataGridDevices.Rows[e.RowIndex].ErrorText = "Please enter a proper IPv4 address.";
                        e.Cancel = true;
                    }
                    break;
                case 3:

                    break;
            }
        }

    }
}
