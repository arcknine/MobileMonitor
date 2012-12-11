using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CitomMobileMonitor
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenAboutForm();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OpenHelpForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            OpenAboutForm();
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            OpenHelpForm();
        }

        //form open functions
        private void OpenLoginForm()
        {
            if (Program.login_form == null)
            {
                Program.login_form = new LoginForm();
            }
            Program.login_form.Show();
            this.Hide();
        }

        private void OpenAboutForm()
        {
            if (Program.about_form == null)
            {
                Program.about_form = new AboutForm();
            }
            Program.about_form.Show();
            this.Hide();
        }

        private void OpenHelpForm()
        {
            if (Program.help_form == null)
            {
                Program.help_form = new HelpForm();
            }
            Program.help_form.Show();
            this.Hide();
        }

    }
}