namespace CitomMobileMonitor
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.picSplashBack = new System.Windows.Forms.PictureBox();
            this.lblAnnounce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // picSplashBack
            // 
            this.picSplashBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSplashBack.Image = ((System.Drawing.Image)(resources.GetObject("picSplashBack.Image")));
            this.picSplashBack.Location = new System.Drawing.Point(0, 0);
            this.picSplashBack.Name = "picSplashBack";
            this.picSplashBack.Size = new System.Drawing.Size(240, 294);
            this.picSplashBack.Click += new System.EventHandler(this.picSplashBack_Click);
            // 
            // lblAnnounce
            // 
            this.lblAnnounce.Location = new System.Drawing.Point(-3, 170);
            this.lblAnnounce.Name = "lblAnnounce";
            this.lblAnnounce.Size = new System.Drawing.Size(240, 20);
            this.lblAnnounce.Text = "Done... Click to continue.";
            this.lblAnnounce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.lblAnnounce);
            this.Controls.Add(this.picSplashBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mnuMain;
            this.Name = "SplashForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSplashBack;
        private System.Windows.Forms.Label lblAnnounce;

    }
}