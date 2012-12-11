namespace CitomMobileMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mnuMain;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuClose = new System.Windows.Forms.MenuItem();
            this.btnCarRegistration = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDriversLicense = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.mnuAbout);
            this.menuItem1.MenuItems.Add(this.mnuHelp);
            this.menuItem1.MenuItems.Add(this.mnuClose);
            this.menuItem1.Text = "File";
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
            // btnCarRegistration
            // 
            this.btnCarRegistration.Location = new System.Drawing.Point(57, 134);
            this.btnCarRegistration.Name = "btnCarRegistration";
            this.btnCarRegistration.Size = new System.Drawing.Size(123, 20);
            this.btnCarRegistration.TabIndex = 2;
            this.btnCarRegistration.Text = "Car Registration";
            this.btnCarRegistration.Click += new System.EventHandler(this.btnCarRegistration_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(57, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 20);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDriversLicense
            // 
            this.btnDriversLicense.Location = new System.Drawing.Point(57, 108);
            this.btnDriversLicense.Name = "btnDriversLicense";
            this.btnDriversLicense.Size = new System.Drawing.Size(123, 20);
            this.btnDriversLicense.TabIndex = 1;
            this.btnDriversLicense.Text = "Driver\'s License";
            this.btnDriversLicense.Click += new System.EventHandler(this.btnDriversLicense_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(57, 160);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 20);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picBack
            // 
            this.picBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(0, 0);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(240, 294);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDriversLicense);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCarRegistration);
            this.Controls.Add(this.picBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "LoginForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarRegistration;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem mnuClose;
        private System.Windows.Forms.Button btnDriversLicense;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picBack;
    }
}