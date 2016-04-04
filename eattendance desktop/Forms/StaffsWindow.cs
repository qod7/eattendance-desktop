﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eattendance_desktop.Forms
{
    public partial class StaffsWindow : Form
    {
        DatabaseHandler DB = new DatabaseHandler();
        public StaffsWindow()
        {
            InitializeComponent();
            populateStaffs();
        }

        private void populateStaffs()
        {
            this.dataGridStaffs.DataSource = DB.getStaffDataSource();
        }
    }
}
