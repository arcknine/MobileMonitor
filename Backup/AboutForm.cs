using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CitomMobileMonitor.classes;

namespace CitomMobileMonitor
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            Program.OpenLoginForm();
            this.Hide();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            //get text file here
            try
            {
                //get path of application
                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                //text file should be at the same folder as app...
                StreamReader file_reader = new StreamReader(path + "\\about.txt");                
                txtAbout.Text = file_reader.ReadToEnd();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            Program.OpenHelpForm();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Program.OpenStartOrMainForm();
            this.Hide();
        }
    }
}