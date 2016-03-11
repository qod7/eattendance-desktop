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
        public ManualAttendanceWindow()
        {
            InitializeComponent();
            initDataSources();
        }

        private void initDataSources()
        {
            // TODO Grab Usernames and ID from databases
            SortedDictionary<string, string> users = new SortedDictionary<string, string> {
                {"200", "Ram Sharma"},
                {"201", "Hari Man"},
                {"202", "Gopal Basnet"},
                {"203", "Govinda Sah"}
            };

            // populate usernames
            comboBoxUserName.DataSource = new BindingSource(users, null);
            comboBoxUserName.DisplayMember = "Value";
            comboBoxUserName.ValueMember = "Key";

            // populate userid
            comboBoxUserID.DataSource = new BindingSource(users, null);
            comboBoxUserID.DisplayMember = "Key";
            comboBoxUserID.ValueMember = "Key";

            // show userimage
            // TODO:: pictureBoxUserImage.Image = get image from db;

            // Register events for syncing UserName and UserID
            this.comboBoxUserName.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserName_SelectedIndexChanged);
            this.comboBoxUserID.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserID_SelectedIndexChanged);
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
            // TODO Update userimage here
        }

        private void comboBoxUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUserName.SelectedIndex = comboBoxUserID.SelectedIndex;
            // TODO Update userimage here
        }
    }
}
