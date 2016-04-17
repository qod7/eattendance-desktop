namespace eattendance_desktop.Forms
{
    partial class FingerprintWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerprintWindow));
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fpProgress1 = new System.Windows.Forms.PictureBox();
            this.fpProgress2 = new System.Windows.Forms.PictureBox();
            this.fpProgress3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpProgress1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpProgress2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpProgress3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(20, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(18, 15);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(217, 37);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Please place your finger on the device three times.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::eattendance_desktop.Properties.Resources.fingerprint_window_progress;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(20, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eattendance_desktop.Properties.Resources.fingerprint_window_bg;
            this.pictureBox1.Location = new System.Drawing.Point(252, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 151);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // fpProgress1
            // 
            this.fpProgress1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fpProgress1.ErrorImage = null;
            this.fpProgress1.InitialImage = null;
            this.fpProgress1.Location = new System.Drawing.Point(24, 68);
            this.fpProgress1.Name = "fpProgress1";
            this.fpProgress1.Size = new System.Drawing.Size(66, 15);
            this.fpProgress1.TabIndex = 4;
            this.fpProgress1.TabStop = false;
            this.fpProgress1.Visible = false;
            // 
            // fpProgress2
            // 
            this.fpProgress2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fpProgress2.ErrorImage = null;
            this.fpProgress2.InitialImage = null;
            this.fpProgress2.Location = new System.Drawing.Point(94, 68);
            this.fpProgress2.Name = "fpProgress2";
            this.fpProgress2.Size = new System.Drawing.Size(66, 15);
            this.fpProgress2.TabIndex = 4;
            this.fpProgress2.TabStop = false;
            this.fpProgress2.Visible = false;
            // 
            // fpProgress3
            // 
            this.fpProgress3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fpProgress3.ErrorImage = null;
            this.fpProgress3.InitialImage = null;
            this.fpProgress3.Location = new System.Drawing.Point(164, 68);
            this.fpProgress3.Name = "fpProgress3";
            this.fpProgress3.Size = new System.Drawing.Size(66, 15);
            this.fpProgress3.TabIndex = 4;
            this.fpProgress3.TabStop = false;
            this.fpProgress3.Visible = false;
            // 
            // FingerprintWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.fpProgress3);
            this.Controls.Add(this.fpProgress2);
            this.Controls.Add(this.fpProgress1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FingerprintWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fingerprint Entry";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FingerprintWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpProgress1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpProgress2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpProgress3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox fpProgress1;
        private System.Windows.Forms.PictureBox fpProgress2;
        private System.Windows.Forms.PictureBox fpProgress3;
    }
}