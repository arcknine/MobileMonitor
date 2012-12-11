using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CitomMobileMonitor.classes;

namespace CitomMobileMonitor
{
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.OpenStartOrMainForm();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = Program.base_url + "/driver.php";
            string param = "license=" + txtLicenseNo.Text;
            string username = Program.username;
            string password = Program.password;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                Driver response = MobileAppXmlParser.processLicenseResult(ServerCommunicator.getSyncResponse(url, param, username, password));
                //if driver found
                if (response != null)
                {
                    Cursor.Current = Cursors.Default;
                    Program.current_driver = response;
                    Program.OpenDriverInfoForm();
                    this.Hide();
                }
                //if driver not found
                else
                {
                    Cursor.Current = Cursors.Default;
                    Program.current_driver = null;
                    MessageBox.Show("Invalid license number / not found in database");
                }
            }
            catch (Exception err)
            {
                string error_msg = "";
                error_msg = err.Message;

                Cursor.Current = Cursors.Default;

                MessageBox.Show("Please make sure that you are connected to the internet");
            }
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
    }
}