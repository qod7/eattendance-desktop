using eattendance_desktop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eattendance_desktop.Forms
{
    public partial class StaffsWindow : Form
    {
        DatabaseHandler DB = new DatabaseHandler();
        public StaffsWindow()
        {
            InitializeComponent();
        }

        private void StaffsWindow_Load(object sender, EventArgs e)
        {
            initElementData();
            this.dataGridStaffs.SelectionChanged += new System.EventHandler(this.dataGridStaffs_SelectionChanged);
        }

        private void initElementData()
        {
            // populate staff-table
            this.dataGridStaffs.DataSource = DB.getStaffDataSource();
            // populate comboPrivilege
            this.comboPrivilege.DataSource = Common.UserPrivilege;
        }

        private void dataGridStaffs_SelectionChanged(object sender, EventArgs e)
        {
            Staff staff = DB.getStaff(Convert.ToInt32(dataGridStaffs.SelectedRows[0].Cells[0].Value));
            // Fill bottom panel with staff details

            // BASIC
            this.textName.Text = staff.name;
            this.textAccountNo.Text = staff.accountNumber.ToString();
            this.textPassword.Text = staff.password.ToString();
            this.comboPrivilege.SelectedIndex = staff.privilege;
            this.textCardNo.Text = staff.cardNumber.ToString();
            this.comboDepartment.SelectedValue = staff.department_pk;
            this.textContact.Text = staff.contact;
            this.comboGender.Text = staff.gender;
            this.textAddress.Text = staff.address;
            this.dateTimeDOB.Value = (DateTime)staff.dateOfBirth;

            // ADDITIONAL
            this.textEmail.Text = staff.email;
            this.textTitle.Text = staff.title;
            this.textPost.Text = staff.post;
            this.dateTimeDateOfEmployment.Value = (DateTime)staff.dateOfEmployment;
            this.textNationality.Text = staff.nationality;
            this.textHomeAddress.Text = staff.homeAddress;
            this.textOfficeTel.Text = staff.officeTel;
            this.textHomeTel.Text = staff.homeTel;
            this.textMobile1.Text = staff.mobile1;
            this.textMobile2.Text = staff.mobile2;

            // EXTRAS
            this.dataGridViewExtras.Rows.Clear();
            foreach (KeyValuePair<string, string> item in staff.extras)
            {
                this.dataGridViewExtras.Rows.Add(item.Key, item.Value);
            }

            // PHOTO

            // FINGERPRINTS
        }
    }
}
