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
    public partial class CarSearchForm : Form
    {
        public CarSearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = Program.base_url + "/car.php";
            string param = "plate=" + txtPlateNo.Text;
            string username = Program.username;
            string password = Program.password;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                Car response = MobileAppXmlParser.processCarSearchResult(ServerCommunicator.getSyncResponse(url, param, username, password));
                //if car found
                if (response != null)
                {
                    Cursor.Current = Cursors.Default;

                    Program.current_car = response;

                    Program.OpenCarInfoForm();
                    this.Hide();
                }
                //if driver not found
                else
                {
                    Cursor.Current = Cursors.Default;
                    Program.current_car = null;
                    MessageBox.Show("Invalid plate number / not found in database");
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