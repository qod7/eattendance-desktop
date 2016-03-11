using eattendance_desktop.Models;
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
    public partial class AttendancesWindow : Form
    {
        DatabaseHandler DB = new DatabaseHandler();
        public AttendancesWindow()
        {
            InitializeComponent();
        }

        private void AttendancessWindow_Load(object sender, EventArgs e)
        {
            populateTable();
        }

        private void populateTable()
        {
            // Get data from database into memory
            List<Attendance> attendances = DB.getAttendances();
            // now use the data to fill up the table
            dataGridAttendances.DataSource = null;
            dataGridAttendances.Rows.Clear();
            int rowcount = 0;
            foreach (Attendance attendance in attendances)
            {
                dataGridAttendances.Rows.Add();
                dataGridAttendances.Rows[rowcount].Cells[0].Value = attendance.attid;
                dataGridAttendances.Rows[rowcount].Cells[1].Value = attendance.userid;
                // TODO: DB.getUser(attendance.userid) and fill columns 2, 3 and 4
                dataGridAttendances.Rows[rowcount].Cells[5].Value = attendance.datetime.ToString("hh:mm tt, MMM d");
                dataGridAttendances.Rows[rowcount].Cells[6].Value = attendance.device;
                dataGridAttendances.Rows[rowcount].Cells[7].Value = attendance.entryMethod;
                rowcount++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Are you sure you want to delete the selected Rows? It has not been uploaded to the server.", "Confirm Delete", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        foreach (DataGridViewRow row in dataGridAttendances.SelectedRows)
                        {
                            dataGridAttendances.Rows.Remove(row);
                            DB.deleteAttendance((int)row.Cells[0].Value);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            catch { }

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Are you sure you want to delete all attendances? These have not been uploaded to the server.", "Confirm Delete", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        DB.deleteAllAttendances();
                        dataGridAttendances.DataSource = null;
                        dataGridAttendances.Rows.Clear();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            catch { }
        }
    }
}
