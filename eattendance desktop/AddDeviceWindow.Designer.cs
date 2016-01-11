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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeviceRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.txtDeviceIP = new System.Windows.Forms.MaskedTextBox();
            this.txtDevicePort = new System.Windows.Forms.NumericUpDown();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(97, 17);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(196, 20);
            this.txtDeviceName.TabIndex = 1;
            this.txtDeviceName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeviceName_Validating);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // txtDeviceRemarks
            // 
            this.txtDeviceRemarks.Location = new System.Drawing.Point(97, 95);
            this.txtDeviceRemarks.Name = "txtDeviceRemarks";
            this.txtDeviceRemarks.Size = new System.Drawing.Size(196, 20);
            this.txtDeviceRemarks.TabIndex = 7;
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
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 147);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(277, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Attempt Connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiscard.Location = new System.Drawing.Point(158, 177);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(135, 23);
            this.btnDiscard.TabIndex = 9;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
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
            // txtDeviceIP
            // 
            this.txtDeviceIP.Location = new System.Drawing.Point(97, 44);
            this.txtDeviceIP.Mask = "###.###.###.###";
            this.txtDeviceIP.Name = "txtDeviceIP";
            this.txtDeviceIP.Size = new System.Drawing.Size(196, 20);
            this.txtDeviceIP.TabIndex = 12;
            this.txtDeviceIP.Text = "1921681100";
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
            this.txtDevicePort.TabIndex = 13;
            this.txtDevicePort.Value = new decimal(new int[] {
            4370,
            0,
            0,
            0});
            // 
            // AddDeviceWindow
            // 
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
        private System.Windows.Forms.MaskedTextBox txtDeviceIP;
        private System.Windows.Forms.NumericUpDown txtDevicePort;
    }
}