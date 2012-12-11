using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CitomMobileMonitor
{
    public partial class CarResultForm : Form
    {
        public CarResultForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.OpenStartOrMainForm();
            this.Hide();
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

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}