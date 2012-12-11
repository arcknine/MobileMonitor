namespace CitomMobileMonitor
{
    partial class DriverInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverInfoForm));
            this.picBack = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuClose = new System.Windows.Forms.MenuItem();
            this.label0 = new System.Windows.Forms.Label();
            this.lblLicenseNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabDriverInfo = new System.Windows.Forms.TabControl();
            this.tabInfo1 = new System.Windows.Forms.TabPage();
            this.lblNationality = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabInfo2 = new System.Windows.Forms.TabPage();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabOthers = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRestriction = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabDriverInfo.SuspendLayout();
            this.tabInfo1.SuspendLayout();
            this.tabInfo2.SuspendLayout();
            this.tabOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(0, 0);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(240, 294);
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuFile);
            // 
            // mnuFile
            // 
            this.mnuFile.MenuItems.Add(this.mnuAbout);
            this.mnuFile.MenuItems.Add(this.mnuHelp);
            this.mnuFile.MenuItems.Add(this.mnuClose);
            this.mnuFile.Text = "File";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Text = "Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // label0
            // 
            this.label0.Location = new System.Drawing.Point(13, 43);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(78, 17);
            this.label0.Text = "License No.";
            // 
            // lblLicenseNo
            // 
            this.lblLicenseNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicenseNo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblLicenseNo.Location = new System.Drawing.Point(84, 43);
            this.lblLicenseNo.Name = "lblLicenseNo";
            this.lblLicenseNo.Size = new System.Drawing.Size(144, 20);
            this.lblLicenseNo.Text = "G01-01-280328";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblName.Location = new System.Drawing.Point(13, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(209, 33);
            this.lblName.Text = "Risty C. de la Calzada";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.Text = "Driver Name";
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(72, 261);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(72, 20);
            this.btnIssue.TabIndex = 37;
            this.btnIssue.Text = "Issue";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 20);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabDriverInfo
            // 
            this.tabDriverInfo.Controls.Add(this.tabInfo1);
            this.tabDriverInfo.Controls.Add(this.tabInfo2);
            this.tabDriverInfo.Controls.Add(this.tabOthers);
            this.tabDriverInfo.Dock = System.Windows.Forms.DockStyle.None;
            this.tabDriverInfo.Location = new System.Drawing.Point(13, 117);
            this.tabDriverInfo.Name = "tabDriverInfo";
            this.tabDriverInfo.SelectedIndex = 0;
            this.tabDriverInfo.Size = new System.Drawing.Size(209, 138);
            this.tabDriverInfo.TabIndex = 38;
            // 
            // tabInfo1
            // 
            this.tabInfo1.BackColor = System.Drawing.Color.Bisque;
            this.tabInfo1.Controls.Add(this.lblNationality);
            this.tabInfo1.Controls.Add(this.label13);
            this.tabInfo1.Controls.Add(this.lblAge);
            this.tabInfo1.Controls.Add(this.label11);
            this.tabInfo1.Controls.Add(this.lblBDate);
            this.tabInfo1.Controls.Add(this.label9);
            this.tabInfo1.Controls.Add(this.lblGender);
            this.tabInfo1.Controls.Add(this.label7);
            this.tabInfo1.Location = new System.Drawing.Point(0, 0);
            this.tabInfo1.Name = "tabInfo1";
            this.tabInfo1.Size = new System.Drawing.Size(209, 115);
            this.tabInfo1.Text = "Info 1";
            // 
            // lblNationality
            // 
            this.lblNationality.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblNationality.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNationality.Location = new System.Drawing.Point(5, 66);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(197, 20);
            this.lblNationality.Text = "Filipino";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(5, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.Text = "Nationality";
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblAge.Location = new System.Drawing.Point(168, 29);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(34, 20);
            this.lblAge.Text = "23";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(168, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.Text = "Age";
            // 
            // lblBDate
            // 
            this.lblBDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblBDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblBDate.Location = new System.Drawing.Point(71, 29);
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(98, 20);
            this.lblBDate.Text = "06/08/1984";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(71, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.Text = "BDate";
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblGender.Location = new System.Drawing.Point(5, 29);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(50, 20);
            this.lblGender.Text = "Male";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.Text = "Gender";
            // 
            // tabInfo2
            // 
            this.tabInfo2.BackColor = System.Drawing.Color.Bisque;
            this.tabInfo2.Controls.Add(this.lblAddress);
            this.tabInfo2.Controls.Add(this.label5);
            this.tabInfo2.Location = new System.Drawing.Point(0, 0);
            this.tabInfo2.Name = "tabInfo2";
            this.tabInfo2.Size = new System.Drawing.Size(201, 112);
            this.tabInfo2.Text = "Info 2";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblAddress.Location = new System.Drawing.Point(5, 30);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(198, 48);
            this.lblAddress.Text = "379 Cebu South Road Basak Pardo Cebu City Philippines sdgfs  sgdfg  sgdf gsdfg";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.Text = "Address";
            // 
            // tabOthers
            // 
            this.tabOthers.BackColor = System.Drawing.Color.Bisque;
            this.tabOthers.Controls.Add(this.lblStatus);
            this.tabOthers.Controls.Add(this.label17);
            this.tabOthers.Controls.Add(this.lblRestriction);
            this.tabOthers.Controls.Add(this.label15);
            this.tabOthers.Location = new System.Drawing.Point(0, 0);
            this.tabOthers.Name = "tabOthers";
            this.tabOthers.Size = new System.Drawing.Size(201, 112);
            this.tabOthers.Text = "Others";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblStatus.Location = new System.Drawing.Point(113, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 20);
            this.lblStatus.Text = "Ok";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(113, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 17);
            this.label17.Text = "Status";
            // 
            // lblRestriction
            // 
            this.lblRestriction.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblRestriction.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRestriction.Location = new System.Drawing.Point(7, 28);
            this.lblRestriction.Name = "lblRestriction";
            this.lblRestriction.Size = new System.Drawing.Size(100, 20);
            this.lblRestriction.Text = "1234";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(7, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.Text = "Restriction";
            // 
            // DriverInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.tabDriverInfo);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLicenseNo);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.picBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mnuMain;
            this.Name = "DriverInfoForm";
            this.Text = "Driver";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabDriverInfo.ResumeLayout(false);
            this.tabInfo1.ResumeLayout(false);
            this.tabInfo2.ResumeLayout(false);
            this.tabOthers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuClose;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblLicenseNo;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblBDate;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TabControl tabDriverInfo;
        public System.Windows.Forms.TabPage tabInfo2;
        public System.Windows.Forms.TabPage tabInfo1;
        private System.Windows.Forms.TabPage tabOthers;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label lblRestriction;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label5;
    }
}