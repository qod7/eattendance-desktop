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
            this.attendancesGroupBox = new System.Windows.Forms.GroupBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.btnBatch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridDevices = new System.Windows.Forms.DataGridView();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablesSplitContainer)).BeginInit();
            this.tablesSplitContainer.Panel1.SuspendLayout();
            this.tablesSplitContainer.Panel2.SuspendLayout();
            this.tablesSplitContainer.SuspendLayout();
            this.attendancesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // tablesSplitContainer
            // 
            this.tablesSplitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.tablesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.tablesSplitContainer.Margin = new System.Windows.Forms.Padding(3, 105, 3, 3);
            this.tablesSplitContainer.Name = "tablesSplitContainer";
            this.tablesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tablesSplitContainer.Panel1
            // 
            this.tablesSplitContainer.Panel1.Controls.Add(this.dataGridDevices);
            this.tablesSplitContainer.Panel1MinSize = 66;
            // 
            // tablesSplitContainer.Panel2
            // 
            this.tablesSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tablesSplitContainer.Panel2.Controls.Add(this.attendancesGroupBox);
            this.tablesSplitContainer.Panel2MinSize = 100;
            this.tablesSplitContainer.Size = new System.Drawing.Size(784, 377);
            this.tablesSplitContainer.SplitterDistance = 120;
            this.tablesSplitContainer.TabIndex = 3;
            // 
            // attendancesGroupBox
            // 
            this.attendancesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.attendancesGroupBox.Controls.Add(this.groupBox3);
            this.attendancesGroupBox.Controls.Add(this.groupBox2);
            this.attendancesGroupBox.Controls.Add(this.groupBox1);
            this.attendancesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.attendancesGroupBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.attendancesGroupBox.Name = "attendancesGroupBox";
            this.attendancesGroupBox.Size = new System.Drawing.Size(784, 253);
            this.attendancesGroupBox.TabIndex = 1;
            this.attendancesGroupBox.TabStop = false;
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
            this.mainSplitContainer.Panel1MinSize = 80;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.mainSplitContainer.Panel2.Controls.Add(this.tablesSplitContainer);
            this.mainSplitContainer.Panel2MinSize = 100;
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 461);
            this.mainSplitContainer.SplitterDistance = 80;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // btnBatch
            // 
            this.btnBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBatch.FlatAppearance.BorderSize = 0;
            this.btnBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatch.Image = global::eattendance_desktop.Properties.Resources.batch;
            this.btnBatch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBatch.Location = new System.Drawing.Point(246, 3);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnBatch.Size = new System.Drawing.Size(75, 74);
            this.btnBatch.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(168, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(75, 74);
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
            this.btnRemove.Location = new System.Drawing.Point(90, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnRemove.Size = new System.Drawing.Size(75, 74);
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
            this.btnAdd.Location = new System.Drawing.Point(12, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(75, 74);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridDevices
            // 
            this.dataGridDevices.AllowUserToAddRows = false;
            this.dataGridDevices.AllowUserToDeleteRows = false;
            this.dataGridDevices.AllowUserToOrderColumns = true;
            this.dataGridDevices.AllowUserToResizeRows = false;
            this.dataGridDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDevices.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDevices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceName,
            this.DeviceStatus,
            this.DeviceNumber,
            this.DeviceIPAddress,
            this.DevicePort,
            this.DeviceRemark});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDevices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDevices.Location = new System.Drawing.Point(0, 0);
            this.dataGridDevices.MultiSelect = false;
            this.dataGridDevices.Name = "dataGridDevices";
            this.dataGridDevices.ReadOnly = true;
            this.dataGridDevices.RowTemplate.ReadOnly = true;
            this.dataGridDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDevices.ShowEditingIcon = false;
            this.dataGridDevices.Size = new System.Drawing.Size(784, 120);
            this.dataGridDevices.TabIndex = 2;
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeviceName.FillWeight = 80F;
            this.DeviceName.Frozen = true;
            this.DeviceName.HeaderText = "Name";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            this.DeviceName.Width = 168;
            // 
            // DeviceStatus
            // 
            this.DeviceStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeviceStatus.FillWeight = 50F;
            this.DeviceStatus.HeaderText = "Status";
            this.DeviceStatus.Name = "DeviceStatus";
            this.DeviceStatus.ReadOnly = true;
            this.DeviceStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DeviceStatus.Width = 105;
            // 
            // DeviceNumber
            // 
            this.DeviceNumber.FillWeight = 50F;
            this.DeviceNumber.HeaderText = "Device Number";
            this.DeviceNumber.Name = "DeviceNumber";
            this.DeviceNumber.ReadOnly = true;
            this.DeviceNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeviceIPAddress
            // 
            this.DeviceIPAddress.FillWeight = 50F;
            this.DeviceIPAddress.HeaderText = "IPAddress";
            this.DeviceIPAddress.Name = "DeviceIPAddress";
            this.DeviceIPAddress.ReadOnly = true;
            this.DeviceIPAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DevicePort
            // 
            this.DevicePort.FillWeight = 30F;
            this.DevicePort.HeaderText = "Port";
            this.DevicePort.Name = "DevicePort";
            this.DevicePort.ReadOnly = true;
            this.DevicePort.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeviceRemark
            // 
            this.DeviceRemark.FillWeight = 80F;
            this.DeviceRemark.HeaderText = "Remarks";
            this.DeviceRemark.Name = "DeviceRemark";
            this.DeviceRemark.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(531, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fingerprint";
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(331, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 234);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Photo";
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
            this.tablesSplitContainer.Panel1.ResumeLayout(false);
            this.tablesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablesSplitContainer)).EndInit();
            this.tablesSplitContainer.ResumeLayout(false);
            this.attendancesGroupBox.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer tablesSplitContainer;
        private System.Windows.Forms.GroupBox attendancesGroupBox;
        private System.Windows.Forms.Button btnBatch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.DataGridView dataGridDevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicePort;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceRemark;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}