namespace CitomMobileMonitor
{
    partial class CarResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarResultForm));
            this.picBack = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuClose = new System.Windows.Forms.MenuItem();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.lblRegTo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCarInfo = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.lblModel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabCarInfo.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(0, 0);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(240, 294);
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
            // lblPlateNumber
            // 
            this.lblPlateNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlateNumber.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPlateNumber.Location = new System.Drawing.Point(8, 57);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(78, 20);
            this.lblPlateNumber.Text = "YCB-197";
            // 
            // label0
            // 
            this.label0.Location = new System.Drawing.Point(8, 40);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(78, 17);
            this.label0.Text = "Plate Number";
            // 
            // lblRegTo
            // 
            this.lblRegTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblRegTo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRegTo.Location = new System.Drawing.Point(8, 95);
            this.lblRegTo.Name = "lblRegTo";
            this.lblRegTo.Size = new System.Drawing.Size(209, 33);
            this.lblRegTo.Text = "Risty C. de la Calzada";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.Text = "Registered To";
            // 
            // lblRegDate
            // 
            this.lblRegDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblRegDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRegDate.Location = new System.Drawing.Point(101, 57);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(125, 20);
            this.lblRegDate.Text = "07/8/2007";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(101, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.Text = "Registration Date";
            // 
            // tabCarInfo
            // 
            this.tabCarInfo.Controls.Add(this.tabInfo);
            this.tabCarInfo.Controls.Add(this.tabStatus);
            this.tabCarInfo.Dock = System.Windows.Forms.DockStyle.None;
            this.tabCarInfo.Location = new System.Drawing.Point(14, 131);
            this.tabCarInfo.Name = "tabCarInfo";
            this.tabCarInfo.SelectedIndex = 0;
            this.tabCarInfo.Size = new System.Drawing.Size(209, 121);
            this.tabCarInfo.TabIndex = 39;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.Bisque;
            this.tabInfo.Controls.Add(this.lblModel);
            this.tabInfo.Controls.Add(this.label12);
            this.tabInfo.Controls.Add(this.lblSeries);
            this.tabInfo.Controls.Add(this.label10);
            this.tabInfo.Controls.Add(this.lblMake);
            this.tabInfo.Controls.Add(this.label8);
            this.tabInfo.Location = new System.Drawing.Point(0, 0);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(209, 98);
            this.tabInfo.Text = "Info";
            // 
            // lblModel
            // 
            this.lblModel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblModel.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblModel.Location = new System.Drawing.Point(59, 59);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(143, 20);
            this.lblModel.Text = "2005";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.Text = "Model";
            // 
            // lblSeries
            // 
            this.lblSeries.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblSeries.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSeries.Location = new System.Drawing.Point(59, 39);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(143, 20);
            this.lblSeries.Text = "Crosswind";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.Text = "Series";
            // 
            // lblMake
            // 
            this.lblMake.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMake.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMake.Location = new System.Drawing.Point(59, 19);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(143, 20);
            this.lblMake.Text = "Isuzu";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.Text = "Make";
            // 
            // tabStatus
            // 
            this.tabStatus.BackColor = System.Drawing.Color.Bisque;
            this.tabStatus.Controls.Add(this.lblStatus);
            this.tabStatus.Controls.Add(this.label6);
            this.tabStatus.Controls.Add(this.lblDescription);
            this.tabStatus.Controls.Add(this.label5);
            this.tabStatus.Location = new System.Drawing.Point(0, 0);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Size = new System.Drawing.Size(201, 95);
            this.tabStatus.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblStatus.Location = new System.Drawing.Point(54, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(148, 20);
            this.lblStatus.Text = "GHZ-342";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.Text = "Status";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDescription.Location = new System.Drawing.Point(7, 43);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(196, 48);
            this.lblDescription.Text = "ambrooot ambrooot";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(151, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 20);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CarResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabCarInfo);
            this.Controls.Add(this.lblRegDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.picBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mnuMain;
            this.MinimizeBox = false;
            this.Name = "CarResultForm";
            this.Text = "Car";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabCarInfo.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuClose;
        public System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label label0;
        public System.Windows.Forms.Label lblRegTo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabControl tabCarInfo;
        public System.Windows.Forms.TabPage tabInfo;
        public System.Windows.Forms.TabPage tabStatus;
        public System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
    }
}