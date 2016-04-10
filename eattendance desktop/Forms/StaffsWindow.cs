using eattendance_desktop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eattendance_desktop.Forms
{
    public partial class StaffsWindow : Form
    {
        DatabaseHandler DB = new DatabaseHandler();
        bool uiInitialized = false;
        bool panelDirty = false;
        bool newEntryInPanel = false;
        bool onRowValidatingActive = false;
        public StaffsWindow()
        {
            InitializeComponent();
        }

        private void StaffsWindow_Load(object sender, EventArgs e)
        {
            initElementData();
            this.dataGridStaffs.SelectionChanged += new System.
                EventHandler(this.dataGridStaffs_SelectionChanged);
            this.dataGridStaffs.RowValidating += new System.Windows.Forms.
                DataGridViewCellCancelEventHandler(this.dataGridStaffs_OnRowValidating);
            this.dataGridStaffs.Leave += new EventHandler(this.dataGridStaffs_OnLeave);
            this.dataGridStaffs.Enter += new EventHandler(this.dataGridStaffs_OnEnter);
            // invoke SelectionChanged for first time
            this.dataGridStaffs_SelectionChanged(sender, null);
            // all elements initialized now
            this.uiInitialized = true;
        }

        private void initElementData()
        {
            // populate staff-table
            fillTable();
            // populate departments and comboDeparment
            fillDepartment();
            // populate comboPrivilege
            this.comboPrivilege.DataSource = Common.UserPrivilege;
            // populate comboGender
            this.comboGender.DataSource = Common.Gender;
        }

        private void dataGridStaffs_OnEnter(object sender, EventArgs e)
        {
            onRowValidatingActive = true;
        }

        private void dataGridStaffs_OnLeave(object sender, EventArgs e)
        {
            onRowValidatingActive = false;
        }

        private void dataGridStaffs_OnRowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (onRowValidatingActive && panelDirty)
            {
                switch (MessageBox.Show("You have unsaved changes. Discard them?",
                        "Confirm Discard Changes", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        return;
                }
            }
            e.Cancel = false;
        }

        private void dataGridStaffs_SelectionChanged(object sender, EventArgs e)
        {
            // change the selected staff
            Staff staff = DB.getStaff(Convert.ToInt32(dataGridStaffs.SelectedRows[0].Cells[0].Value));
            // Fill bottom panel with staff details
            fillPanel(staff, false);
            this.panelDirty = false;
        }

        private bool confirmExitPanel()
        {
            // check if current data in panel not saved, offer save
            if (this.panelDirty)
            {
                switch (MessageBox.Show("You have unsaved changes. Save first?",
                    "Unsaved changes", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        // true -> proceed with the flow; false -> stop right there
                        return this.saveStaff();
                    case DialogResult.No:
                        // nothing to do then. just go with the flow
                        return true;
                    case DialogResult.Cancel:
                        return false;
                }
            }
            return true;
        }

        private void fillDepartment()
        {
            // first clear the pre-existing data
            treeViewDepartments.Nodes.Clear();
            comboDepartment.Items.Clear();

            List<Department> departments = DB.getDepartments();
            List<TreeNode> departmentsNode = new List<TreeNode>();
            foreach (var dept in departments)
            {
                TreeNode node = new TreeNode(dept.name);
                node.Tag = dept;
                departmentsNode.Add(node);
                comboDepartment.Items.Add(dept);
            }
            TreeNode rootNode = new TreeNode("Organization", departmentsNode.ToArray());
            rootNode.ExpandAll();
            treeViewDepartments.Nodes.Add(rootNode);
        }

        private void fillTable()
        {
            List<List<string>> rows = DB.getStaffData();
            int oldRowCount = dataGridStaffs.RowCount;
            int oldSelectionIndex = -1;
            if (dataGridStaffs.SelectedRows.Count > 0)
                oldSelectionIndex = dataGridStaffs.SelectedRows[0].Index;
            int rowCount = 0;
            // add new rows
            foreach (var row in rows)
            {
                dataGridStaffs.Rows.Add(row.ToArray());
                rowCount++;
            }
            // remove old rows
            for (int i = 0; i < oldRowCount; i++)
            {
                dataGridStaffs.Rows.RemoveAt(0);
            }
            // now restore the selected index
            if (oldSelectionIndex >= 0)
            {
                if (oldSelectionIndex >= dataGridStaffs.RowCount)
                    oldSelectionIndex = dataGridStaffs.RowCount - 1;
                dataGridStaffs.Rows[oldSelectionIndex].Selected = true;
            }
            // Why this shitty workaround? 
            // For some reason Rows.Clear() throws an ArgumentOutOfRangeException.
            // So does Rows.RemoveAt(0) when there's only one row. Strange!
        }

        private void fillPanel(Staff staff, bool isNewStaff)
        {
            this.newEntryInPanel = isNewStaff;
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

        private Staff panelToStaff()
        {
            Staff staff = new Staff(this.textName.Text.Replace("'", ""), 
                Convert.ToInt32(this.textAccountNo.Text), 
                Convert.ToInt32(this.textPassword.Text));
            // BASIC
            staff.privilege = this.comboPrivilege.SelectedIndex;

            if (textCardNo.Text.Equals("")) staff.cardNumber = null;
            else staff.cardNumber = Convert.ToInt32(this.textCardNo.Text);

            //staff.department_pk = (int)this.comboDepartment.SelectedValue;
            staff.contact = this.textContact.Text.Replace("'", "");
            staff.gender = this.comboGender.Text;
            staff.address = this.textAddress.Text.Replace("'", "");
            staff.dateOfBirth = this.dateTimeDOB.Value;

            // ADDITIONAL
            staff.email = this.textEmail.Text.Replace("'", "");
            staff.title = this.textTitle.Text.Replace("'", "");
            staff.post = this.textPost.Text.Replace("'", "");
            staff.dateOfEmployment = this.dateTimeDateOfEmployment.Value;
            staff.nationality = this.textNationality.Text.Replace("'", "");
            staff.homeAddress = this.textHomeAddress.Text.Replace("'", "");
            staff.officeTel = this.textOfficeTel.Text.Replace("'", "");
            staff.homeTel = this.textHomeTel.Text.Replace("'", "");
            staff.mobile1 = this.textMobile1.Text.Replace("'", "");
            staff.mobile2 = this.textMobile2.Text.Replace("'", "");

            // EXTRAS
            foreach (DataGridViewRow row in dataGridViewExtras.Rows)
            {
                if (row.Cells[0].Value != null)
                    staff.extras.Add(row.Cells[0].Value.ToString().Replace("'", ""), 
                        row.Cells[1].Value.ToString().Replace("'", ""));
            }

            // PHOTO

            // FINGERPRINTS

            return staff;
        }

        private void panelDirtied(object sender, EventArgs e)
        {
            if (uiInitialized) this.panelDirty = true;
        }

        private void panelDirtied(object sender, DataGridViewCellEventArgs e)
        {
            this.panelDirtied(sender, (EventArgs)null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // if 'Cancel' option selected, return
            if (!confirmExitPanel()) return;
            // else, first reload the table, in case it was just updated
            this.fillTable();
            // then create a new staff
            Staff staff = new Staff("New Staff", DB.getMaxAccountNumber() + 1, 12345678);
            fillPanel(staff, true);
            // restore panelDirty
            panelDirty = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // confirm delete?
            // remove from database
            switch (MessageBox.Show("Are you sure you want to delete the selected staff?", 
                "Confirm Delete", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    // get selected staff
                    int accountNumber = Convert.ToInt32(this.dataGridStaffs.SelectedRows[0].Cells[0].Value.ToString());
                    DB.deleteStaff(accountNumber);
                    // reload the table
                    this.fillTable();
                    MessageBox.Show("Staff delete successful.");
                    break;
                case DialogResult.No:
                    // nothing to do then
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.saveStaff())
            {
                // restore dirty
                panelDirty = false;
                // reload table
                this.fillTable();
            }
        }

        private bool saveStaff()
        {
            // check if any change
            if (!panelDirty) return true;
            // get selected account number (unedited one)
            string sAccountNumber = dataGridStaffs.SelectedRows[0].Cells[0].Value.ToString();
            int accountNumber = Convert.ToInt32(sAccountNumber);
            // validate data first
            int panelAccountNumber;
            int panelPassword;
            long panelCardNumber;
            if (!int.TryParse(textAccountNo.Text.ToString(), out panelAccountNumber))
            {
                MessageBox.Show("Account number non-numeric or too long.");
                return false;
            }
            if (!int.TryParse(textPassword.Text.ToString(), out panelPassword) || textPassword.Text.Length > 8)
            {
                MessageBox.Show("Password has to be numeric and 8 digits or less.");
                return false;
            }
            string cardNo = textCardNo.Text.ToString();
            if (!cardNo.Equals("") && !long.TryParse(cardNo, out panelCardNumber))
            {
                MessageBox.Show("Card number non-numeric or too long.");
                return false;
            }
            if (textName.Text.ToString().Equals(""))
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }

            // check if this is a new staff
            if (this.newEntryInPanel)
            {
                // check if the new accountNumber exists in database
                Staff dbStaff = DB.getStaff(panelAccountNumber);
                if (dbStaff != null)
                {
                    MessageBox.Show("Another entry with same account number already exists. Creation aborted.");
                    return false;
                }
                // db.insert
                DB.insertStaff(panelToStaff());
            }
            else
            {
                // check if accountNumber needs updating
                if (this.textAccountNo.Text.ToString().Equals(sAccountNumber))
                {
                    //db.update
                    DB.updateStaff(accountNumber, panelToStaff());
                }
                else
                {
                    // check if the new accountNumber exists in database
                    Staff dbStaff = DB.getStaff(panelAccountNumber);
                    if (dbStaff != null)
                    {
                        MessageBox.Show("Another entry with same account number already exists. Cannot update");
                        return false;
                    }
                    // db.update
                    DB.updateStaff(panelAccountNumber, panelToStaff());
                }
            }

            return true;
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            //find the root "organization" node
            TreeNode rootNode = treeViewDepartments.Nodes[0];
            //create the new node and department object to add
            Department dept = new Department(DB.getMaxDepartmentID() + 1, "New Department");
            TreeNode newNode = new TreeNode(String.Format("New Department {0}", dept.id));
            newNode.Tag = dept;
            // add new dept to database
            DB.insertDepartment(dept);
            //add the new child to the selected node
            rootNode.Nodes.Add(newNode);
        }

        private void treeViewDepartments_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            TreeNode node = e.Node;
            Department tag = (Department)node.Tag;
            if (e.Label.Equals(""))
            {
                MessageBox.Show("Department name cannot be empty.");
                e.CancelEdit = true;
            }
            else
            {
                tag.name = e.Label;
                DB.updateDepartment(tag.id, tag);
            }
        }

        private void btnEditDept_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewDepartments.SelectedNode;
            selectedNode.BeginEdit();
        }

        private void btnRemoveDept_Click(object sender, EventArgs e)
        {
            // confirm delete?
            // remove from database
            switch (MessageBox.Show("Are you sure you want to delete the selected department?",
                "Confirm Delete", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    // get selected department
                    Department dept = (Department)this.treeViewDepartments.SelectedNode.Tag;
                    DB.deleteDepartment(dept.id);
                    // reload the table
                    this.fillTable();
                    MessageBox.Show("Staff delete successful.");
                    break;
                case DialogResult.No:
                    // nothing to do then
                    break;
            }
        }
    }
}
