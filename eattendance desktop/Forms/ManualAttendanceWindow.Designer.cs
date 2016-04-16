namespace eattendance_desktop
{
    partial class ManualAttendanceWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualAttendanceWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerAttendanceTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxUserID = new System.Windows.Forms.ComboBox();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the account with its ID or Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select the Date and Time for the Missed Attendance";
            // 
            // dateTimePickerAttendanceTime
            // 
            this.dateTimePickerAttendanceTime.CustomFormat = "hh:mm tt";
            this.dateTimePickerAttendanceTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAttendanceTime.Location = new System.Drawing.Point(255, 96);
            this.dateTimePickerAttendanceTime.Name = "dateTimePickerAttendanceTime";
            this.dateTimePickerAttendanceTime.ShowUpDown = true;
            this.dateTimePickerAttendanceTime.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerAttendanceTime.TabIndex = 4;
            // 
            // dateTimePickerAttendanceDate
            // 
            this.dateTimePickerAttendanceDate.CustomFormat = "MMM dd, yyyy";
            this.dateTimePickerAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAttendanceDate.Location = new System.Drawing.Point(63, 96);
            this.dateTimePickerAttendanceDate.Name = "dateTimePickerAttendanceDate";
            this.dateTimePickerAttendanceDate.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerAttendanceDate.TabIndex = 3;
            this.dateTimePickerAttendanceDate.Value = new System.DateTime(2016, 3, 10, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date";
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUserName.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(63, 40);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(126, 21);
            this.comboBoxUserName.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(397, 130);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(70, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(311, 130);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(70, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxUserID
            // 
            this.comboBoxUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserID.FormattingEnabled = true;
            this.comboBoxUserID.Location = new System.Drawing.Point(255, 40);
            this.comboBoxUserID.Name = "comboBoxUserID";
            this.comboBoxUserID.Size = new System.Drawing.Size(126, 21);
            this.comboBoxUserID.TabIndex = 2;
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxUserImage.ErrorImage = null;
            this.pictureBoxUserImage.InitialImage = global::eattendance_desktop.Properties.Resources.profile_user_outline;
            this.pictureBoxUserImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxUserImage.Size = new System.Drawing.Size(62, 68);
            this.pictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserImage.TabIndex = 10;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxUserImage);
            this.panel1.Location = new System.Drawing.Point(397, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(70, 76);
            this.panel1.TabIndex = 11;
            // 
            // ManualAttendanceWindow
            // 
            this.AcceptButton = this.buttonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(479, 165);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBoxUserID);
            this.Controls.Add(this.comboBoxUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerAttendanceDate);
            this.Controls.Add(this.dateTimePickerAttendanceTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualAttendanceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manual Attendance";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerAttendanceTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerAttendanceDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxUserName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxUserID;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.Panel panel1;
    }
}