namespace eattendance_desktop.Forms
{
    partial class StaffsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffsWindow));
            this.tablesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.panelDepartment = new System.Windows.Forms.Panel();
            this.treeViewDepartments = new System.Windows.Forms.TreeView();
            this.panelDepartmentControls = new System.Windows.Forms.Panel();
            this.btnEditDept = new System.Windows.Forms.Button();
            this.btnRemoveDept = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.dataGridStaffs = new System.Windows.Forms.DataGridView();
            this.accountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonStaffImageInfo = new System.Windows.Forms.Button();
            this.buttonClearImage = new System.Windows.Forms.Button();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.staffImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFP1 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboFPDevices = new System.Windows.Forms.ComboBox();
            this.buttonFPConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Basic = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelBasic = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.comboPrivilege = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textAccountNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textCardNo = new System.Windows.Forms.TextBox();
            this.Additional = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelAdditional = new System.Windows.Forms.TableLayoutPanel();
            this.textMobile1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textOfficeTel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textPost = new System.Windows.Forms.TextBox();
            this.textNationality = new System.Windows.Forms.TextBox();
            this.dateTimeDateOfEmployment = new System.Windows.Forms.DateTimePicker();
            this.textMobile2 = new System.Windows.Forms.TextBox();
            this.textHomeTel = new System.Windows.Forms.TextBox();
            this.textHomeAddress = new System.Windows.Forms.TextBox();
            this.Extras = new System.Windows.Forms.TabPage();
            this.dataGridViewExtras = new System.Windows.Forms.DataGridView();
            this.ExtrasColumnKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtrasColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.btnBatch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonFP2 = new System.Windows.Forms.Button();
            this.buttonFP3 = new System.Windows.Forms.Button();
            this.buttonFP4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablesSplitContainer)).BeginInit();
            this.tablesSplitContainer.Panel1.SuspendLayout();
            this.tablesSplitContainer.Panel2.SuspendLayout();
            this.tablesSplitContainer.SuspendLayout();
            this.panelDepartment.SuspendLayout();
            this.panelDepartmentControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaffs)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Basic.SuspendLayout();
            this.tableLayoutPanelBasic.SuspendLayout();
            this.Additional.SuspendLayout();
            this.tableLayoutPanelAdditional.SuspendLayout();
            this.Extras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablesSplitContainer
            // 
            this.tablesSplitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.tablesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.tablesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.tablesSplitContainer.Margin = new System.Windows.Forms.Padding(3, 105, 3, 3);
            this.tablesSplitContainer.Name = "tablesSplitContainer";
            this.tablesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tablesSplitContainer.Panel1
            // 
            this.tablesSplitContainer.Panel1.Controls.Add(this.panelDepartment);
            this.tablesSplitContainer.Panel1.Controls.Add(this.dataGridStaffs);
            this.tablesSplitContainer.Panel1MinSize = 66;
            // 
            // tablesSplitContainer.Panel2
            // 
            this.tablesSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tablesSplitContainer.Panel2.Controls.Add(this.groupBox3);
            this.tablesSplitContainer.Panel2.Controls.Add(this.groupBox2);
            this.tablesSplitContainer.Panel2.Controls.Add(this.groupBox1);
            this.tablesSplitContainer.Panel2MinSize = 200;
            this.tablesSplitContainer.Size = new System.Drawing.Size(784, 392);
            this.tablesSplitContainer.SplitterDistance = 188;
            this.tablesSplitContainer.TabIndex = 3;
            // 
            // panelDepartment
            // 
            this.panelDepartment.Controls.Add(this.treeViewDepartments);
            this.panelDepartment.Controls.Add(this.panelDepartmentControls);
            this.panelDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDepartment.Location = new System.Drawing.Point(0, 0);
            this.panelDepartment.Name = "panelDepartment";
            this.panelDepartment.Size = new System.Drawing.Size(145, 188);
            this.panelDepartment.TabIndex = 3;
            // 
            // treeViewDepartments
            // 
            this.treeViewDepartments.BackColor = System.Drawing.SystemColors.MenuBar;
            this.treeViewDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDepartments.Location = new System.Drawing.Point(0, 21);
            this.treeViewDepartments.Name = "treeViewDepartments";
            this.treeViewDepartments.Size = new System.Drawing.Size(145, 167);
            this.treeViewDepartments.TabIndex = 5;
            this.treeViewDepartments.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewDepartments_AfterLabelEdit);
            this.treeViewDepartments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDepartments_AfterSelect);
            // 
            // panelDepartmentControls
            // 
            this.panelDepartmentControls.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelDepartmentControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDepartmentControls.Controls.Add(this.btnEditDept);
            this.panelDepartmentControls.Controls.Add(this.btnRemoveDept);
            this.panelDepartmentControls.Controls.Add(this.btnAddDept);
            this.panelDepartmentControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDepartmentControls.Location = new System.Drawing.Point(0, 0);
            this.panelDepartmentControls.Name = "panelDepartmentControls";
            this.panelDepartmentControls.Size = new System.Drawing.Size(145, 21);
            this.panelDepartmentControls.TabIndex = 0;
            // 
            // btnEditDept
            // 
            this.btnEditDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditDept.FlatAppearance.BorderSize = 0;
            this.btnEditDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDept.Image = global::eattendance_desktop.Properties.Resources.edit_dept;
            this.btnEditDept.Location = new System.Drawing.Point(46, -2);
            this.btnEditDept.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditDept.Name = "btnEditDept";
            this.btnEditDept.Size = new System.Drawing.Size(20, 20);
            this.btnEditDept.TabIndex = 6;
            this.btnEditDept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnEditDept, "Edit Department");
            this.btnEditDept.UseVisualStyleBackColor = true;
            this.btnEditDept.Click += new System.EventHandler(this.btnEditDept_Click);
            // 
            // btnRemoveDept
            // 
            this.btnRemoveDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveDept.FlatAppearance.BorderSize = 0;
            this.btnRemoveDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDept.Image = global::eattendance_desktop.Properties.Resources.delete_dept;
            this.btnRemoveDept.Location = new System.Drawing.Point(23, -2);
            this.btnRemoveDept.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveDept.Name = "btnRemoveDept";
            this.btnRemoveDept.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveDept.TabIndex = 6;
            this.btnRemoveDept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnRemoveDept, "Remove Department");
            this.btnRemoveDept.UseVisualStyleBackColor = true;
            this.btnRemoveDept.Click += new System.EventHandler(this.btnRemoveDept_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDept.FlatAppearance.BorderSize = 0;
            this.btnAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDept.Image = global::eattendance_desktop.Properties.Resources.add_dept;
            this.btnAddDept.Location = new System.Drawing.Point(0, -2);
            this.btnAddDept.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(20, 20);
            this.btnAddDept.TabIndex = 6;
            this.btnAddDept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnAddDept, "Add Department");
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // dataGridStaffs
            // 
            this.dataGridStaffs.AllowUserToAddRows = false;
            this.dataGridStaffs.AllowUserToDeleteRows = false;
            this.dataGridStaffs.AllowUserToOrderColumns = true;
            this.dataGridStaffs.AllowUserToResizeRows = false;
            this.dataGridStaffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStaffs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStaffs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNumber,
            this.name,
            this.privilege,
            this.cardNumber,
            this.email,
            this.department_id,
            this.contact,
            this.gender,
            this.address,
            this.title,
            this.post,
            this.nationality,
            this.homeAddress,
            this.officeTel,
            this.homeTel,
            this.mobile1,
            this.mobile2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStaffs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStaffs.Location = new System.Drawing.Point(143, 0);
            this.dataGridStaffs.MultiSelect = false;
            this.dataGridStaffs.Name = "dataGridStaffs";
            this.dataGridStaffs.ReadOnly = true;
            this.dataGridStaffs.RowTemplate.ReadOnly = true;
            this.dataGridStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStaffs.ShowEditingIcon = false;
            this.dataGridStaffs.Size = new System.Drawing.Size(641, 188);
            this.dataGridStaffs.TabIndex = 2;
            // 
            // accountNumber
            // 
            this.accountNumber.HeaderText = "Account No.";
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // privilege
            // 
            this.privilege.HeaderText = "Privilege";
            this.privilege.Name = "privilege";
            this.privilege.ReadOnly = true;
            // 
            // cardNumber
            // 
            this.cardNumber.HeaderText = "Card Number";
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // department_id
            // 
            this.department_id.HeaderText = "Department";
            this.department_id.Name = "department_id";
            this.department_id.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.HeaderText = "Contact";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // post
            // 
            this.post.HeaderText = "Post";
            this.post.Name = "post";
            this.post.ReadOnly = true;
            // 
            // nationality
            // 
            this.nationality.HeaderText = "Nationality";
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            // 
            // homeAddress
            // 
            this.homeAddress.HeaderText = "Home Address";
            this.homeAddress.Name = "homeAddress";
            this.homeAddress.ReadOnly = true;
            // 
            // officeTel
            // 
            this.officeTel.HeaderText = "Office Tel.";
            this.officeTel.Name = "officeTel";
            this.officeTel.ReadOnly = true;
            // 
            // homeTel
            // 
            this.homeTel.HeaderText = "Home Tel.";
            this.homeTel.Name = "homeTel";
            this.homeTel.ReadOnly = true;
            // 
            // mobile1
            // 
            this.mobile1.HeaderText = "Mobile1";
            this.mobile1.Name = "mobile1";
            this.mobile1.ReadOnly = true;
            // 
            // mobile2
            // 
            this.mobile2.HeaderText = "Mobile2";
            this.mobile2.Name = "mobile2";
            this.mobile2.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.buttonStaffImageInfo);
            this.groupBox3.Controls.Add(this.buttonClearImage);
            this.groupBox3.Controls.Add(this.buttonBrowseImage);
            this.groupBox3.Controls.Add(this.staffImage);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(368, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 200);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Photo";
            // 
            // buttonStaffImageInfo
            // 
            this.buttonStaffImageInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStaffImageInfo.FlatAppearance.BorderSize = 0;
            this.buttonStaffImageInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaffImageInfo.Image = global::eattendance_desktop.Properties.Resources.info;
            this.buttonStaffImageInfo.Location = new System.Drawing.Point(117, 16);
            this.buttonStaffImageInfo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStaffImageInfo.Name = "buttonStaffImageInfo";
            this.buttonStaffImageInfo.Size = new System.Drawing.Size(20, 20);
            this.buttonStaffImageInfo.TabIndex = 9;
            this.buttonStaffImageInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.buttonStaffImageInfo, "JPEG images less than 100 KB are preferred.");
            this.buttonStaffImageInfo.UseVisualStyleBackColor = true;
            // 
            // buttonClearImage
            // 
            this.buttonClearImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClearImage.FlatAppearance.BorderSize = 0;
            this.buttonClearImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearImage.Image = global::eattendance_desktop.Properties.Resources.trashcan;
            this.buttonClearImage.Location = new System.Drawing.Point(29, 16);
            this.buttonClearImage.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearImage.Name = "buttonClearImage";
            this.buttonClearImage.Size = new System.Drawing.Size(20, 20);
            this.buttonClearImage.TabIndex = 7;
            this.buttonClearImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.buttonClearImage, "Clear Image");
            this.buttonClearImage.UseVisualStyleBackColor = true;
            this.buttonClearImage.Click += new System.EventHandler(this.buttonClearImage_Click);
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBrowseImage.FlatAppearance.BorderSize = 0;
            this.buttonBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseImage.Image = global::eattendance_desktop.Properties.Resources.browse;
            this.buttonBrowseImage.Location = new System.Drawing.Point(6, 16);
            this.buttonBrowseImage.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(20, 20);
            this.buttonBrowseImage.TabIndex = 8;
            this.buttonBrowseImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.buttonBrowseImage, "Browse Image");
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // staffImage
            // 
            this.staffImage.BackColor = System.Drawing.Color.White;
            this.staffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.staffImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.staffImage.InitialImage = null;
            this.staffImage.Location = new System.Drawing.Point(3, 38);
            this.staffImage.Margin = new System.Windows.Forms.Padding(10);
            this.staffImage.Name = "staffImage";
            this.staffImage.Padding = new System.Windows.Forms.Padding(10);
            this.staffImage.Size = new System.Drawing.Size(134, 159);
            this.staffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staffImage.TabIndex = 0;
            this.staffImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.buttonFP4);
            this.groupBox2.Controls.Add(this.buttonFP3);
            this.groupBox2.Controls.Add(this.buttonFP2);
            this.groupBox2.Controls.Add(this.buttonFP1);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.comboFPDevices);
            this.groupBox2.Controls.Add(this.buttonFPConnect);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(508, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 200);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fingerprint";
            // 
            // buttonFP1
            // 
            this.buttonFP1.Image = global::eattendance_desktop.Properties.Resources.fingerprint_inactive;
            this.buttonFP1.Location = new System.Drawing.Point(61, 53);
            this.buttonFP1.Name = "buttonFP1";
            this.buttonFP1.Size = new System.Drawing.Size(60, 60);
            this.buttonFP1.TabIndex = 3;
            this.buttonFP1.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(155, 151);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Finger 4";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(155, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Finger 2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 151);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Finger 3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Finger 1";
            // 
            // comboFPDevices
            // 
            this.comboFPDevices.FormattingEnabled = true;
            this.comboFPDevices.Location = new System.Drawing.Point(6, 17);
            this.comboFPDevices.Name = "comboFPDevices";
            this.comboFPDevices.Size = new System.Drawing.Size(183, 21);
            this.comboFPDevices.TabIndex = 1;
            // 
            // buttonFPConnect
            // 
            this.buttonFPConnect.Location = new System.Drawing.Point(195, 16);
            this.buttonFPConnect.Name = "buttonFPConnect";
            this.buttonFPConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonFPConnect.TabIndex = 0;
            this.buttonFPConnect.Text = "Connect";
            this.buttonFPConnect.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 200);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Basic);
            this.tabControl1.Controls.Add(this.Additional);
            this.tabControl1.Controls.Add(this.Extras);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 181);
            this.tabControl1.TabIndex = 10;
            // 
            // Basic
            // 
            this.Basic.Controls.Add(this.tableLayoutPanelBasic);
            this.Basic.Location = new System.Drawing.Point(4, 22);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(3);
            this.Basic.Size = new System.Drawing.Size(355, 155);
            this.Basic.TabIndex = 1;
            this.Basic.Text = "Basic";
            this.Basic.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelBasic
            // 
            this.tableLayoutPanelBasic.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBasic.ColumnCount = 4;
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBasic.Controls.Add(this.dateTimeDOB, 3, 4);
            this.tableLayoutPanelBasic.Controls.Add(this.comboGender, 3, 2);
            this.tableLayoutPanelBasic.Controls.Add(this.textAddress, 3, 3);
            this.tableLayoutPanelBasic.Controls.Add(this.comboDepartment, 1, 4);
            this.tableLayoutPanelBasic.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.label10, 2, 4);
            this.tableLayoutPanelBasic.Controls.Add(this.textContact, 3, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.textName, 3, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.comboPrivilege, 1, 2);
            this.tableLayoutPanelBasic.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanelBasic.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanelBasic.Controls.Add(this.label5, 2, 3);
            this.tableLayoutPanelBasic.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanelBasic.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanelBasic.Controls.Add(this.textAccountNo, 1, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.textPassword, 1, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.textCardNo, 1, 3);
            this.tableLayoutPanelBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBasic.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBasic.Name = "tableLayoutPanelBasic";
            this.tableLayoutPanelBasic.RowCount = 5;
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBasic.Size = new System.Drawing.Size(349, 149);
            this.tableLayoutPanelBasic.TabIndex = 0;
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDOB.CustomFormat = "MM dd yyyy";
            this.dateTimeDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDOB.Location = new System.Drawing.Point(239, 123);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(107, 18);
            this.dateTimeDOB.TabIndex = 20;
            this.dateTimeDOB.Value = new System.DateTime(2016, 3, 10, 0, 0, 0, 0);
            this.dateTimeDOB.ValueChanged += new System.EventHandler(this.panelDirtied);
            // 
            // comboGender
            // 
            this.comboGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.comboGender.FormattingEnabled = true;
            this.comboGender.ItemHeight = 12;
            this.comboGender.Location = new System.Drawing.Point(239, 62);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(107, 20);
            this.comboGender.TabIndex = 16;
            this.comboGender.SelectedValueChanged += new System.EventHandler(this.panelDirtied);
            // 
            // textAddress
            // 
            this.textAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(239, 92);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(107, 18);
            this.textAddress.TabIndex = 18;
            this.textAddress.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // comboDepartment
            // 
            this.comboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.ItemHeight = 12;
            this.comboDepartment.Location = new System.Drawing.Point(71, 122);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(107, 20);
            this.comboDepartment.TabIndex = 19;
            this.comboDepartment.SelectedValueChanged += new System.EventHandler(this.panelDirtied);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Acount No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(184, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 33);
            this.label10.TabIndex = 40;
            this.label10.Text = "DOB";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textContact
            // 
            this.textContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContact.Location = new System.Drawing.Point(239, 34);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(107, 18);
            this.textContact.TabIndex = 14;
            this.textContact.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(239, 5);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(107, 18);
            this.textName.TabIndex = 12;
            this.textName.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // comboPrivilege
            // 
            this.comboPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.comboPrivilege.FormattingEnabled = true;
            this.comboPrivilege.ItemHeight = 12;
            this.comboPrivilege.Location = new System.Drawing.Point(71, 62);
            this.comboPrivilege.Name = "comboPrivilege";
            this.comboPrivilege.Size = new System.Drawing.Size(107, 20);
            this.comboPrivilege.TabIndex = 15;
            this.comboPrivilege.SelectedValueChanged += new System.EventHandler(this.panelDirtied);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 29);
            this.label8.TabIndex = 37;
            this.label8.Text = "Gender";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Privilege";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Card No.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Contact";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 33);
            this.label9.TabIndex = 38;
            this.label9.Text = "Department";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAccountNo
            // 
            this.textAccountNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAccountNo.Location = new System.Drawing.Point(71, 5);
            this.textAccountNo.Name = "textAccountNo";
            this.textAccountNo.Size = new System.Drawing.Size(107, 18);
            this.textAccountNo.TabIndex = 11;
            this.textAccountNo.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPassword
            // 
            this.textPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(71, 34);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(107, 18);
            this.textPassword.TabIndex = 13;
            this.textPassword.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // textCardNo
            // 
            this.textCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardNo.Location = new System.Drawing.Point(71, 92);
            this.textCardNo.Name = "textCardNo";
            this.textCardNo.Size = new System.Drawing.Size(107, 18);
            this.textCardNo.TabIndex = 17;
            this.textCardNo.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // Additional
            // 
            this.Additional.Controls.Add(this.tableLayoutPanelAdditional);
            this.Additional.Location = new System.Drawing.Point(4, 22);
            this.Additional.Name = "Additional";
            this.Additional.Padding = new System.Windows.Forms.Padding(3);
            this.Additional.Size = new System.Drawing.Size(355, 155);
            this.Additional.TabIndex = 3;
            this.Additional.Text = "Additional";
            this.Additional.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelAdditional
            // 
            this.tableLayoutPanelAdditional.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelAdditional.ColumnCount = 4;
            this.tableLayoutPanelAdditional.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanelAdditional.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdditional.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelAdditional.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdditional.Controls.Add(this.textMobile1, 3, 3);
            this.tableLayoutPanelAdditional.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanelAdditional.Controls.Add(this.label12, 2, 4);
            this.tableLayoutPanelAdditional.Controls.Add(this.textOfficeTel, 3, 1);
            this.tableLayoutPanelAdditional.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanelAdditional.Controls.Add(this.textEmail, 3, 0);
            this.tableLayoutPanelAdditional.Controls.Add(this.label14, 2, 2);
            this.tableLayoutPanelAdditional.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanelAdditional.Controls.Add(this.label16, 2, 3);
            this.tableLayoutPanelAdditional.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanelAdditional.Controls.Add(this.label18, 2, 1);
            this.tableLayoutPanelAdditional.Controls.Add(this.label19, 0, 4);
            this.tableLayoutPanelAdditional.Controls.Add(this.textTitle, 1, 0);
            this.tableLayoutPanelAdditional.Controls.Add(this.label20, 2, 0);
            this.tableLayoutPanelAdditional.Controls.Add(this.textPost, 1, 1);
            this.tableLayoutPanelAdditional.Controls.Add(this.textNationality, 1, 3);
            this.tableLayoutPanelAdditional.Controls.Add(this.dateTimeDateOfEmployment, 1, 2);
            this.tableLayoutPanelAdditional.Controls.Add(this.textMobile2, 3, 4);
            this.tableLayoutPanelAdditional.Controls.Add(this.textHomeTel, 3, 2);
            this.tableLayoutPanelAdditional.Controls.Add(this.textHomeAddress, 1, 4);
            this.tableLayoutPanelAdditional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAdditional.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelAdditional.Name = "tableLayoutPanelAdditional";
            this.tableLayoutPanelAdditional.RowCount = 5;
            this.tableLayoutPanelAdditional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdditional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdditional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdditional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdditional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAdditional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAdditional.Size = new System.Drawing.Size(349, 149);
            this.tableLayoutPanelAdditional.TabIndex = 1;
            // 
            // textMobile1
            // 
            this.textMobile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textMobile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMobile1.Location = new System.Drawing.Point(239, 92);
            this.textMobile1.Name = "textMobile1";
            this.textMobile1.Size = new System.Drawing.Size(107, 18);
            this.textMobile1.TabIndex = 38;
            this.textMobile1.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Title";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(184, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 33);
            this.label12.TabIndex = 40;
            this.label12.Text = "Mobile2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textOfficeTel
            // 
            this.textOfficeTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textOfficeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOfficeTel.Location = new System.Drawing.Point(239, 34);
            this.textOfficeTel.Name = "textOfficeTel";
            this.textOfficeTel.Size = new System.Drawing.Size(107, 18);
            this.textOfficeTel.TabIndex = 34;
            this.textOfficeTel.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "Post";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textEmail
            // 
            this.textEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(239, 5);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(107, 18);
            this.textEmail.TabIndex = 32;
            this.textEmail.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(182, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 29);
            this.label14.TabIndex = 37;
            this.label14.Text = "Home Tel.";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 58);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 29);
            this.label15.TabIndex = 30;
            this.label15.Text = "Date of Employment";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(184, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 29);
            this.label16.TabIndex = 32;
            this.label16.Text = "Mobile1";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 29);
            this.label17.TabIndex = 29;
            this.label17.Text = "Nationality";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(182, 29);
            this.label18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 29);
            this.label18.TabIndex = 35;
            this.label18.Text = "Office Tel.";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 33);
            this.label19.TabIndex = 38;
            this.label19.Text = "Home Address";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textTitle
            // 
            this.textTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Location = new System.Drawing.Point(71, 5);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(107, 18);
            this.textTitle.TabIndex = 31;
            this.textTitle.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(182, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 29);
            this.label20.TabIndex = 33;
            this.label20.Text = "Email";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPost
            // 
            this.textPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPost.Location = new System.Drawing.Point(71, 34);
            this.textPost.Name = "textPost";
            this.textPost.Size = new System.Drawing.Size(107, 18);
            this.textPost.TabIndex = 33;
            this.textPost.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // textNationality
            // 
            this.textNationality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNationality.Location = new System.Drawing.Point(71, 92);
            this.textNationality.Name = "textNationality";
            this.textNationality.Size = new System.Drawing.Size(107, 18);
            this.textNationality.TabIndex = 37;
            this.textNationality.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // dateTimeDateOfEmployment
            // 
            this.dateTimeDateOfEmployment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDateOfEmployment.CustomFormat = "MM dd yyyy";
            this.dateTimeDateOfEmployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDateOfEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDateOfEmployment.Location = new System.Drawing.Point(71, 63);
            this.dateTimeDateOfEmployment.Name = "dateTimeDateOfEmployment";
            this.dateTimeDateOfEmployment.Size = new System.Drawing.Size(107, 18);
            this.dateTimeDateOfEmployment.TabIndex = 35;
            this.dateTimeDateOfEmployment.Value = new System.DateTime(2016, 3, 10, 0, 0, 0, 0);
            this.dateTimeDateOfEmployment.ValueChanged += new System.EventHandler(this.panelDirtied);
            // 
            // textMobile2
            // 
            this.textMobile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textMobile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMobile2.Location = new System.Drawing.Point(239, 123);
            this.textMobile2.Name = "textMobile2";
            this.textMobile2.Size = new System.Drawing.Size(107, 18);
            this.textMobile2.TabIndex = 40;
            this.textMobile2.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // textHomeTel
            // 
            this.textHomeTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textHomeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHomeTel.Location = new System.Drawing.Point(239, 63);
            this.textHomeTel.Name = "textHomeTel";
            this.textHomeTel.Size = new System.Drawing.Size(107, 18);
            this.textHomeTel.TabIndex = 36;
            this.textHomeTel.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // textHomeAddress
            // 
            this.textHomeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHomeAddress.Location = new System.Drawing.Point(71, 123);
            this.textHomeAddress.Name = "textHomeAddress";
            this.textHomeAddress.Size = new System.Drawing.Size(107, 18);
            this.textHomeAddress.TabIndex = 39;
            this.textHomeAddress.TextChanged += new System.EventHandler(this.panelDirtied);
            // 
            // Extras
            // 
            this.Extras.Controls.Add(this.dataGridViewExtras);
            this.Extras.Location = new System.Drawing.Point(4, 22);
            this.Extras.Name = "Extras";
            this.Extras.Padding = new System.Windows.Forms.Padding(3);
            this.Extras.Size = new System.Drawing.Size(355, 155);
            this.Extras.TabIndex = 2;
            this.Extras.Text = "Extras";
            this.Extras.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExtras
            // 
            this.dataGridViewExtras.AllowUserToResizeRows = false;
            this.dataGridViewExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewExtras.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewExtras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExtras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExtrasColumnKey,
            this.ExtrasColumnValue});
            this.dataGridViewExtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExtras.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewExtras.Name = "dataGridViewExtras";
            this.dataGridViewExtras.Size = new System.Drawing.Size(349, 149);
            this.dataGridViewExtras.TabIndex = 0;
            this.dataGridViewExtras.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.panelDirtied);
            // 
            // ExtrasColumnKey
            // 
            this.ExtrasColumnKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExtrasColumnKey.Frozen = true;
            this.ExtrasColumnKey.HeaderText = "Key";
            this.ExtrasColumnKey.Name = "ExtrasColumnKey";
            this.ExtrasColumnKey.Width = 50;
            // 
            // ExtrasColumnValue
            // 
            this.ExtrasColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExtrasColumnValue.HeaderText = "Value";
            this.ExtrasColumnValue.Name = "ExtrasColumnValue";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.mainSplitContainer.Panel1.Controls.Add(this.btnBatch);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnSave);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnRemove);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnAdd);
            this.mainSplitContainer.Panel1MinSize = 65;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.mainSplitContainer.Panel2.Controls.Add(this.tablesSplitContainer);
            this.mainSplitContainer.Panel2MinSize = 100;
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 461);
            this.mainSplitContainer.SplitterDistance = 65;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // btnBatch
            // 
            this.btnBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBatch.FlatAppearance.BorderSize = 0;
            this.btnBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatch.Image = global::eattendance_desktop.Properties.Resources.batch;
            this.btnBatch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBatch.Location = new System.Drawing.Point(168, 3);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnBatch.Size = new System.Drawing.Size(55, 60);
            this.btnBatch.TabIndex = 3;
            this.btnBatch.Text = "Batch";
            this.btnBatch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnBatch, "Add Staff in Batch");
            this.btnBatch.UseVisualStyleBackColor = true;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::eattendance_desktop.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(113, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(55, 60);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSave, "Save Staff");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::eattendance_desktop.Properties.Resources.remove;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.Location = new System.Drawing.Point(58, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnRemove.Size = new System.Drawing.Size(55, 60);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnRemove, "Remove Staff");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::eattendance_desktop.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(55, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnAdd, "Add Staff");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // buttonFP2
            // 
            this.buttonFP2.Image = global::eattendance_desktop.Properties.Resources.fingerprint_active;
            this.buttonFP2.Location = new System.Drawing.Point(210, 53);
            this.buttonFP2.Name = "buttonFP2";
            this.buttonFP2.Size = new System.Drawing.Size(60, 60);
            this.buttonFP2.TabIndex = 4;
            this.buttonFP2.UseVisualStyleBackColor = true;
            // 
            // buttonFP3
            // 
            this.buttonFP3.Image = global::eattendance_desktop.Properties.Resources.fingerprint_inactive;
            this.buttonFP3.Location = new System.Drawing.Point(61, 127);
            this.buttonFP3.Name = "buttonFP3";
            this.buttonFP3.Size = new System.Drawing.Size(60, 60);
            this.buttonFP3.TabIndex = 5;
            this.buttonFP3.UseVisualStyleBackColor = true;
            // 
            // buttonFP4
            // 
            this.buttonFP4.Image = global::eattendance_desktop.Properties.Resources.fingerprint_inactive;
            this.buttonFP4.Location = new System.Drawing.Point(210, 127);
            this.buttonFP4.Name = "buttonFP4";
            this.buttonFP4.Size = new System.Drawing.Size(60, 60);
            this.buttonFP4.TabIndex = 6;
            this.buttonFP4.UseVisualStyleBackColor = true;
            // 
            // StaffsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.mainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "StaffsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staffs";
            this.Load += new System.EventHandler(this.StaffsWindow_Load);
            this.tablesSplitContainer.Panel1.ResumeLayout(false);
            this.tablesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablesSplitContainer)).EndInit();
            this.tablesSplitContainer.ResumeLayout(false);
            this.panelDepartment.ResumeLayout(false);
            this.panelDepartmentControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaffs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Basic.ResumeLayout(false);
            this.tableLayoutPanelBasic.ResumeLayout(false);
            this.tableLayoutPanelBasic.PerformLayout();
            this.Additional.ResumeLayout(false);
            this.tableLayoutPanelAdditional.ResumeLayout(false);
            this.tableLayoutPanelAdditional.PerformLayout();
            this.Extras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtras)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer tablesSplitContainer;
        private System.Windows.Forms.Button btnBatch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.DataGridView dataGridStaffs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Basic;
        private System.Windows.Forms.TabPage Extras;
        private System.Windows.Forms.DataGridView dataGridViewExtras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBasic;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboPrivilege;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textAccountNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textCardNo;
        private System.Windows.Forms.TabPage Additional;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdditional;
        private System.Windows.Forms.TextBox textMobile1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textOfficeTel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textPost;
        private System.Windows.Forms.TextBox textNationality;
        private System.Windows.Forms.DateTimePicker dateTimeDateOfEmployment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtrasColumnKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtrasColumnValue;
        private System.Windows.Forms.TextBox textMobile2;
        private System.Windows.Forms.TextBox textHomeTel;
        private System.Windows.Forms.TextBox textHomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn post;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile2;
        private System.Windows.Forms.Panel panelDepartment;
        private System.Windows.Forms.TreeView treeViewDepartments;
        private System.Windows.Forms.Panel panelDepartmentControls;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnEditDept;
        private System.Windows.Forms.Button btnRemoveDept;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox staffImage;
        private System.Windows.Forms.Button buttonClearImage;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.Button buttonStaffImageInfo;
        private System.Windows.Forms.Button buttonFP1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboFPDevices;
        private System.Windows.Forms.Button buttonFPConnect;
        private System.Windows.Forms.Button buttonFP4;
        private System.Windows.Forms.Button buttonFP3;
        private System.Windows.Forms.Button buttonFP2;
    }
}