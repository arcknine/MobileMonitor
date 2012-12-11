using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CitomMobileMonitor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            Program.OpenAboutForm();
            this.Hide();
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            Program.OpenHelpForm();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.LogOut();
            Program.OpenStartForm();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDriversLicense_Click(object sender, EventArgs e)
        {
            Program.OpenLicenseForm();
            this.Hide();
        }

        private void btnCarRegistration_Click(object sender, EventArgs e)
        {
            Program.OpenCarSearchForm();
            this.Hide();
        }
    }
}