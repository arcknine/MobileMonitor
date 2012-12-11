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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            this.TopMost = true;

            //get base url from properties file
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path + "\\app.properties";

            try
            {
                Properties prop = new Properties(path);

                path = prop.getProperty("base_url");

                Program.base_url = path;
            }
            catch (Exception err)
            {
                //para walay warning... samok man gud.
                string msg;
                msg = err.Message;

                msg = "A required file is missing. This program may not work as intended. Please contact administrator. Thank you.";
                MessageBox.Show(msg);
            }

            Program.db_handler.checkAndCreateDBAvailability();
        }

        private void picSplashBack_Click(object sender, EventArgs e)
        {
            Program.OpenStartForm();
            this.Hide();
        }
    }
}