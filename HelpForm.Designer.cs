namespace CitomMobileMonitor
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuLicense = new System.Windows.Forms.MenuItem();
            this.mnuCar = new System.Windows.Forms.MenuItem();
            this.mnuIssuance = new System.Windows.Forms.MenuItem();
            this.mnuAccount = new System.Windows.Forms.MenuItem();
            this.mnuLogin = new System.Windows.Forms.MenuItem();
            this.mnuLogout = new System.Windows.Forms.MenuItem();
            this.mnuClose = new System.Windows.Forms.MenuItem();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.lblHelp = new System.Windows.Forms.Label();
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
            // txtHelp
            // 
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Location = new System.Drawing.Point(15, 69);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHelp.Size = new System.Drawing.Size(211, 178);
            this.txtHelp.TabIndex = 1;
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblHelp.Location = new System.Drawing.Point(15, 50);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(100, 20);
            this.lblHelp.Text = "How to";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(154, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 20);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.picBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mnuMain;
            this.Name = "HelpForm";
            this.Text = "AboutForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuLicense;
        private System.Windows.Forms.MenuItem mnuCar;
        private System.Windows.Forms.MenuItem mnuIssuance;
        private System.Windows.Forms.MenuItem mnuAccount;
        private System.Windows.Forms.MenuItem mnuLogin;
        private System.Windows.Forms.MenuItem mnuLogout;
        private System.Windows.Forms.MenuItem mnuClose;
        private System.Windows.Forms.Button btnClose;
    }
}