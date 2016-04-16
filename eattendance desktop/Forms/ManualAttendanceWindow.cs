using eattendance_desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eattendance_desktop
{
    public partial class ManualAttendanceWindow : Form
    {
        public Attendance newAttendance = null;
        DatabaseHandler DB = new DatabaseHandler();
        List<List<string>> staffData;

        public ManualAttendanceWindow()
        {
            InitializeComponent();
            initDataSources();
        }

        private void initDataSources()
        {
            // Grab Usernames and ID from database and populate staff names and id
            staffData = DB.getStaffDataBasic();
            foreach (List<string> staff in staffData)
            {
                comboBoxUserID.Items.Add(staff[0]);
                comboBoxUserName.Items.Add(staff[1]);
            }

            // Register events for syncing UserName and UserID
            this.comboBoxUserName.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserName_SelectedIndexChanged);
            this.comboBoxUserID.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserID_SelectedIndexChanged);

            if (staffData.Count > 0)
            {
                // invoke select for first time
                this.comboBoxUserID.SelectedIndex = 0;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // construct attendance datetime
            DateTime date = dateTimePickerAttendanceDate.Value;
            DateTime time = dateTimePickerAttendanceTime.Value;
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second, DateTimeKind.Local);
            if (dateTime > DateTime.Now)
            {
                MessageBox.Show("Cannot save attendance in the future", "Invalid Date or Time");
            }
            else
            {
                this.newAttendance = new Attendance(comboBoxUserID.Text, dateTime, "Admin's Terminal", "Manual");
                DB.insertAttendance(this.newAttendance);
                MessageBox.Show("Attendance successfully saved.", "Success");
                this.Close();
            }
        }

        private void comboBoxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUserID.SelectedIndex = comboBoxUserName.SelectedIndex;
        }

        private void comboBoxUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUserName.SelectedIndex = comboBoxUserID.SelectedIndex;
            string imageName = staffData[comboBoxUserID.SelectedIndex][2];
            if (imageName.Equals(""))
                pictureBoxUserImage.Image = Properties.Resources.profile_user_outline;
            else
                pictureBoxUserImage.Image = Common.NameToImage(imageName);
        }
    }
}
