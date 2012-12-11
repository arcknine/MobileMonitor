namespace CitomMobileMonitor
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuLicense = new System.Windows.Forms.MenuItem();
            this.mnuCar = new System.Windows.Forms.MenuItem();
            this.mnuIssuance = new System.Windows.Forms.MenuItem();
            this.mnuAccount = new System.Windows.Forms.MenuItem();
            this.mnuLogin = new System.Windows.Forms.MenuItem();
            this.mnuLogout = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuClose = new System.Windows.Forms.MenuItem();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuFile);
            // 
            // mnuFile
            // 
            this.mnuFile.MenuItems.Add(this.mnuLicense);
            this.mnuFile.MenuItems.Add(this.mnuCar);
            this.mnuFile.MenuItems.Add(this.mnuIssuance);
            this.mnuFile.MenuItems.Add(this.mnuAccount);
            this.mnuFile.MenuItems.Add(this.mnuLogin);
            this.mnuFile.MenuItems.Add(this.mnuLogout);
            this.mnuFile.MenuItems.Add(this.mnuHelp);
            this.mnuFile.MenuItems.Add(this.mnuClose);
            this.mnuFile.Text = "File";
            // 
            // mnuLicense
            // 
            this.mnuLicense.Text = "License";
            // 
            // mnuCar
            // 
            this.mnuCar.Text = "Car";
            // 
            // mnuIssuance
            // 
            this.mnuIssuance.Text = "Issuance";
            // 
            // mnuAccount
            // 
            this.mnuAccount.Text = "My Account";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Text = "Logout";
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
            // picBack
            // 
            this.picBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(0, 0);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(240, 294);
            // 
            // txtAbout
            // 
            this.txtAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbout.Location = new System.Drawing.Point(15, 69);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.ReadOnly = true;
            this.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAbout.Size = new System.Drawing.Size(211, 183);
            this.txtAbout.TabIndex = 1;
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblAbout.Location = new System.Drawing.Point(15, 50);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(100, 20);
            this.lblAbout.Text = "About";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(154, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 20);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.picBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mnuMain;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.TextBox txtAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuLicense;
        private System.Windows.Forms.MenuItem mnuCar;
        private System.Windows.Forms.MenuItem mnuIssuance;
        private System.Windows.Forms.MenuItem mnuAccount;
        private System.Windows.Forms.MenuItem mnuLogin;
        private System.Windows.Forms.MenuItem mnuLogout;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuClose;
        private System.Windows.Forms.Button btnClose;
    }
}