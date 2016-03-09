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
        }
    }
}
