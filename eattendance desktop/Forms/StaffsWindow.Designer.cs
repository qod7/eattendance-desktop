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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffsWindow));
            this.tablesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridStaffs = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.tablesSplitContainer)).BeginInit();
            this.tablesSplitContainer.Panel1.SuspendLayout();
            this.tablesSplitContainer.Panel2.SuspendLayout();
            this.tablesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaffs)).BeginInit();
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
            // dataGridStaffs
            // 
            this.dataGridStaffs.AllowUserToAddRows = false;
            this.dataGridStaffs.AllowUserToDeleteRows = false;
            this.dataGridStaffs.AllowUserToOrderColumns = true;
            this.dataGridStaffs.AllowUserToResizeRows = false;
            this.dataGridStaffs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStaffs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStaffs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStaffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStaffs.Location = new System.Drawing.Point(0, 0);
            this.dataGridStaffs.MultiSelect = false;
            this.dataGridStaffs.Name = "dataGridStaffs";
            this.dataGridStaffs.ReadOnly = true;
            this.dataGridStaffs.RowTemplate.ReadOnly = true;
            this.dataGridStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStaffs.ShowEditingIcon = false;
            this.dataGridStaffs.Size = new System.Drawing.Size(784, 188);
            this.dataGridStaffs.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(334, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 200);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Photo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(534, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 200);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fingerprint";
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
            this.groupBox1.Size = new System.Drawing.Size(337, 200);
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
            this.tabControl1.Size = new System.Drawing.Size(331, 181);
            this.tabControl1.TabIndex = 10;
            // 
            // Basic
            // 
            this.Basic.Controls.Add(this.tableLayoutPanelBasic);
            this.Basic.Location = new System.Drawing.Point(4, 22);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(3);
            this.Basic.Size = new System.Drawing.Size(323, 155);
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
            this.tableLayoutPanelBasic.Size = new System.Drawing.Size(317, 149);
            this.tableLayoutPanelBasic.TabIndex = 0;
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDOB.CustomFormat = "MM dd yyyy";
            this.dateTimeDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDOB.Location = new System.Drawing.Point(223, 123);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(91, 18);
            this.dateTimeDOB.TabIndex = 20;
            this.dateTimeDOB.Value = new System.DateTime(2016, 3, 10, 0, 0, 0, 0);
            // 
            // comboGender
            // 
            this.comboGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.comboGender.FormattingEnabled = true;
            this.comboGender.ItemHeight = 12;
            this.comboGender.Location = new System.Drawing.Point(223, 62);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(91, 20);
            this.comboGender.TabIndex = 16;
            // 
            // textAddress
            // 
            this.textAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(223, 92);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(91, 18);
            this.textAddress.TabIndex = 18;
            // 
            // comboDepartment
            // 
            this.comboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.ItemHeight = 12;
            this.comboDepartment.Location = new System.Drawing.Point(71, 122);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(91, 20);
            this.comboDepartment.TabIndex = 19;
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
            this.label10.Location = new System.Drawing.Point(168, 116);
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
            this.textContact.Location = new System.Drawing.Point(223, 34);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(91, 18);
            this.textContact.TabIndex = 14;
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
            this.textName.Location = new System.Drawing.Point(223, 5);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(91, 18);
            this.textName.TabIndex = 12;
            // 
            // comboPrivilege
            // 
            this.comboPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.comboPrivilege.FormattingEnabled = true;
            this.comboPrivilege.ItemHeight = 12;
            this.comboPrivilege.Location = new System.Drawing.Point(71, 62);
            this.comboPrivilege.Name = "comboPrivilege";
            this.comboPrivilege.Size = new System.Drawing.Size(91, 20);
            this.comboPrivilege.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 58);
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
            this.label5.Location = new System.Drawing.Point(168, 87);
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
            this.label7.Location = new System.Drawing.Point(168, 29);
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
            this.textAccountNo.Size = new System.Drawing.Size(91, 18);
            this.textAccountNo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 0);
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
            this.textPassword.Size = new System.Drawing.Size(91, 18);
            this.textPassword.TabIndex = 13;
            // 
            // textCardNo
            // 
            this.textCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardNo.Location = new System.Drawing.Point(71, 92);
            this.textCardNo.Name = "textCardNo";
            this.textCardNo.Size = new System.Drawing.Size(91, 18);
            this.textCardNo.TabIndex = 17;
            // 
            // Additional
            // 
            this.Additional.Controls.Add(this.tableLayoutPanelAdditional);
            this.Additional.Location = new System.Drawing.Point(4, 22);
            this.Additional.Name = "Additional";
            this.Additional.Padding = new System.Windows.Forms.Padding(3);
            this.Additional.Size = new System.Drawing.Size(323, 155);
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
            this.tableLayoutPanelAdditional.Size = new System.Drawing.Size(317, 149);
            this.tableLayoutPanelAdditional.TabIndex = 1;
            // 
            // textMobile1
            // 
            this.textMobile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textMobile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMobile1.Location = new System.Drawing.Point(223, 92);
            this.textMobile1.Name = "textMobile1";
            this.textMobile1.Size = new System.Drawing.Size(91, 18);
            this.textMobile1.TabIndex = 38;
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
            this.label12.Location = new System.Drawing.Point(168, 116);
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
            this.textOfficeTel.Location = new System.Drawing.Point(223, 34);
            this.textOfficeTel.Name = "textOfficeTel";
            this.textOfficeTel.Size = new System.Drawing.Size(91, 18);
            this.textOfficeTel.TabIndex = 34;
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
            this.textEmail.Location = new System.Drawing.Point(223, 5);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(91, 18);
            this.textEmail.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(166, 58);
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
            this.label16.Location = new System.Drawing.Point(168, 87);
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
            this.label18.Location = new System.Drawing.Point(166, 29);
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
            this.textTitle.Size = new System.Drawing.Size(91, 18);
            this.textTitle.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(166, 0);
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
            this.textPost.Size = new System.Drawing.Size(91, 18);
            this.textPost.TabIndex = 33;
            // 
            // textNationality
            // 
            this.textNationality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNationality.Location = new System.Drawing.Point(71, 92);
            this.textNationality.Name = "textNationality";
            this.textNationality.Size = new System.Drawing.Size(91, 18);
            this.textNationality.TabIndex = 37;
            // 
            // dateTimeDateOfEmployment
            // 
            this.dateTimeDateOfEmployment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDateOfEmployment.CustomFormat = "MM dd yyyy";
            this.dateTimeDateOfEmployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDateOfEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDateOfEmployment.Location = new System.Drawing.Point(71, 63);
            this.dateTimeDateOfEmployment.Name = "dateTimeDateOfEmployment";
            this.dateTimeDateOfEmployment.Size = new System.Drawing.Size(91, 18);
            this.dateTimeDateOfEmployment.TabIndex = 35;
            this.dateTimeDateOfEmployment.Value = new System.DateTime(2016, 3, 10, 0, 0, 0, 0);
            // 
            // textMobile2
            // 
            this.textMobile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textMobile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMobile2.Location = new System.Drawing.Point(223, 123);
            this.textMobile2.Name = "textMobile2";
            this.textMobile2.Size = new System.Drawing.Size(91, 18);
            this.textMobile2.TabIndex = 40;
            // 
            // textHomeTel
            // 
            this.textHomeTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textHomeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHomeTel.Location = new System.Drawing.Point(223, 63);
            this.textHomeTel.Name = "textHomeTel";
            this.textHomeTel.Size = new System.Drawing.Size(91, 18);
            this.textHomeTel.TabIndex = 36;
            // 
            // textHomeAddress
            // 
            this.textHomeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHomeAddress.Location = new System.Drawing.Point(71, 123);
            this.textHomeAddress.Name = "textHomeAddress";
            this.textHomeAddress.Size = new System.Drawing.Size(91, 18);
            this.textHomeAddress.TabIndex = 39;
            // 
            // Extras
            // 
            this.Extras.Controls.Add(this.dataGridViewExtras);
            this.Extras.Location = new System.Drawing.Point(4, 22);
            this.Extras.Name = "Extras";
            this.Extras.Padding = new System.Windows.Forms.Padding(3);
            this.Extras.Size = new System.Drawing.Size(323, 155);
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
            this.dataGridViewExtras.Size = new System.Drawing.Size(317, 149);
            this.dataGridViewExtras.TabIndex = 0;
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
            this.btnBatch.UseVisualStyleBackColor = true;
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
            this.btnSave.UseVisualStyleBackColor = true;
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
            this.btnRemove.UseVisualStyleBackColor = true;
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
            this.btnAdd.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaffs)).EndInit();
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
    }
}