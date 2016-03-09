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
        public ManualAttendanceWindow()
        {
            InitializeComponent();
            initDataSources();
        }

        private void initDataSources()
        {
            // TODO Grab Usernames and ID from databases
            SortedDictionary<string, string> users = new SortedDictionary<string, string> {
                {"000000", "Ram Sharma"},
                {"111111", "Hari Man"},
                {"222222", "Gopal Basnet"},
                {"333333", "Govinda Sah"}
            };
            comboBoxUserName.DataSource = new BindingSource(users, null);
            comboBoxUserName.DisplayMember = "Value";
            comboBoxUserName.ValueMember = "Key";

            comboBoxUserID.DataSource = new BindingSource(users, null);
            comboBoxUserID.DisplayMember = "Key";
            comboBoxUserID.ValueMember = "Key";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
