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
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string url = Program.base_url + "/login.php";
            string param = "";
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                Officer response = MobileAppXmlParser.processLoginResult(ServerCommunicator.getSyncResponse(url, param, username, password));
                if (response != null)
                {
                    //if credential is good then save credentials to our variables
                    Program.username = txtUserName.Text;
                    Program.password = txtPassword.Text;

                    //set as logged_in;
                    Program.is_logged_in = true;

                    //set officer variable for later use...
                    Program.current_user = response;
                    Program.current_user.Username = Program.username;
                    Program.current_user.Password = Program.password;

                    //MessageBox.Show("" + Program.current_user.ActorId);
                    //MessageBox.Show("" + Program.current_user.FirstName);
                    //MessageBox.Show("" + Program.current_user.MiddleName);
                    //MessageBox.Show("" + Program.current_user.LastName);

                    Cursor.Current = Cursors.Default;

                    Program.OpenMainForm();
                    this.Hide();
                }
                else
                {
                    //if credential is bad...
                    Program.username = "";
                    Program.password = "";

                    //set as not logged_in;
                    Program.is_logged_in = false;

                    //unset officer variable
                    Program.current_user = null;

                    Cursor.Current = Cursors.Default;

                    MessageBox.Show("Invalid username/password");
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

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}