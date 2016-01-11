namespace eattendance_desktop
{
    partial class AddDeviceWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeviceWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDevicePort = new System.Windows.Forms.NumericUpDown();
            this.txtDeviceIP = new IPAddressControlLib.IPAddressControl();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDeviceRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDevicePort)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDevicePort);
            this.panel1.Controls.Add(this.txtDeviceIP);
            this.panel1.Controls.Add(this.lblDeviceStatus);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnDiscard);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txtDeviceRemarks);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDeviceName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 215);
            this.panel1.TabIndex = 0;
            // 
            // txtDevicePort
            // 
            this.txtDevicePort.Location = new System.Drawing.Point(97, 71);
            this.txtDevicePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtDevicePort.Name = "txtDevicePort";
            this.txtDevicePort.Size = new System.Drawing.Size(196, 20);
            this.txtDevicePort.TabIndex = 3;
            this.txtDevicePort.Value = new decimal(new int[] {
            4370,
            0,
            0,
            0});
            // 
            // txtDeviceIP
            // 
            this.txtDeviceIP.AllowInternalTab = false;
            this.txtDeviceIP.AutoHeight = true;
            this.txtDeviceIP.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeviceIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDeviceIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeviceIP.Location = new System.Drawing.Point(97, 44);
            this.txtDeviceIP.MinimumSize = new System.Drawing.Size(87, 20);
            this.txtDeviceIP.Name = "txtDeviceIP";
            this.txtDeviceIP.ReadOnly = false;
            this.txtDeviceIP.Size = new System.Drawing.Size(196, 20);
            this.txtDeviceIP.TabIndex = 2;
            this.txtDeviceIP.Text = "192.168.1.100";
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDeviceStatus.Location = new System.Drawing.Point(94, 125);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(79, 13);
            this.lblDeviceStatus.TabIndex = 11;
            this.lblDeviceStatus.Text = "Not Connected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Device Status";
            // 
            // btnDiscard
            // 
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiscard.Location = new System.Drawing.Point(158, 177);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(135, 23);
            this.btnDiscard.TabIndex = 7;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 147);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(277, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Attempt Connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // txtDeviceRemarks
            // 
            this.txtDeviceRemarks.Location = new System.Drawing.Point(97, 95);
            this.txtDeviceRemarks.Name = "txtDeviceRemarks";
            this.txtDeviceRemarks.Size = new System.Drawing.Size(196, 20);
            this.txtDeviceRemarks.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Remarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(97, 17);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(196, 20);
            this.txtDeviceName.TabIndex = 1;
            this.txtDeviceName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeviceName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // AddDeviceWindow
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDiscard;
            this.ClientSize = new System.Drawing.Size(310, 215);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 254);
            this.MinimumSize = new System.Drawing.Size(326, 254);
            this.Name = "AddDeviceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Device";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDevicePort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtDeviceRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label label1;
        private IPAddressControlLib.IPAddressControl txtDeviceIP;
        private System.Windows.Forms.NumericUpDown txtDevicePort;
    }
}