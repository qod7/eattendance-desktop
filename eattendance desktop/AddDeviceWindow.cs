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
        public AddDeviceWindow()
        {
            InitializeComponent();
        }

        private void txtDeviceName_Validating(object sender, CancelEventArgs e)
        {
            //((TextBox)sender).Text
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you mean accept?");
        }
    }
}
