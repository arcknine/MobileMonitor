using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CitomMobileMonitor.classes;

namespace CitomMobileMonitor
{
    static class Program
    {   
        //important variables
        public static string base_url;
        public static Driver current_driver;
        public static Car current_car;
        public static Officer current_user;

        public static DatabaseHandler db_handler;
        
        //keep form references here
        public static SplashForm splash_form;
        public static LoginForm login_form;
        public static AboutForm about_form;
        public static HelpForm help_form;
        public static StartForm start_form;
        public static MainForm main_form;
        public static LicenseForm license_form;
        public static DriverInfoForm driver_info_form;
        public static CarSearchForm car_search_form;
        public static CarResultForm car_result_form;

        //take note of the login credentials and login status here
        public static bool is_logged_in;
        public static string username;
        public static string password;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        //open form functions to be called by the other forms
        public static void OpenLoginForm()
        {
            if (Program.login_form == null)
            {
                Program.login_form = new LoginForm();
            }
            Program.login_form.Show();
        }

        public static void OpenAboutForm()
        {
            if (Program.about_form == null)
            {
                Program.about_form = new AboutForm();
            }
            Program.about_form.Show();
        }

        public static void OpenHelpForm()
        {
            if (Program.help_form == null)
            {
                Program.help_form = new HelpForm();
            }
            Program.help_form.Show();
        }

        public static void OpenStartForm()
        {
            if (Program.start_form == null)
            {
                Program.start_form = new StartForm();
            }
            Program.start_form.Show();
        }

        public static void OpenMainForm()
        {
            if (Program.main_form == null)
            {
                Program.main_form = new MainForm();
            }
            Program.main_form.Show();
        }

        public static void OpenStartOrMainForm()
        {
            if (Program.is_logged_in == false)
            {
                OpenStartForm();
            }
            else
            {
                OpenMainForm();
            }
        }

        public static void OpenLicenseForm()
        {
            if (Program.license_form == null)
            {
                Program.license_form = new LicenseForm();
            }
            Program.license_form.Show();
        }

        public static void OpenDriverInfoForm()
        {
            if (Program.driver_info_form == null)
            {
                Program.driver_info_form = new DriverInfoForm();
            }

            if (Program.current_driver != null)
            {
                Program.driver_info_form.lblLicenseNo.Text = Program.current_driver.LicenceNumber;
                Program.driver_info_form.lblName.Text = Program.current_driver.FirstName + " " +
                                                        Program.current_driver.MiddleName + " " +
                                                        Program.current_driver.LastName;

                Program.driver_info_form.lblGender.Text = Program.current_driver.Gender == 0 ? "Male" : "Female";
                Program.driver_info_form.lblBDate.Text = Program.current_driver.BirthDate.ToShortDateString();

                Program.driver_info_form.lblAge.Text = (DateTime.Now.Year - Program.current_driver.BirthDate.Year) + "";

                Program.driver_info_form.lblAddress.Text = Program.current_driver.Address;
                Program.driver_info_form.lblRestriction.Text = Program.current_driver.Restrictions;
                Program.driver_info_form.lblStatus.Text = Program.current_driver.LicenseStatus + "";
            }
            else
            {
                Program.driver_info_form.lblLicenseNo.Text = "";
                Program.driver_info_form.lblName.Text = "";

                Program.driver_info_form.lblGender.Text = "";
                Program.driver_info_form.lblBDate.Text = "";

                Program.driver_info_form.lblAge.Text = "";

                Program.driver_info_form.lblAddress.Text = "";
                Program.driver_info_form.lblRestriction.Text = "";
                Program.driver_info_form.lblStatus.Text = "";
            }

            Program.driver_info_form.Show();
        }

        public static void OpenCarInfoForm()
        {
            if (Program.car_result_form == null)
            {
                Program.car_result_form = new CarResultForm();
            }

            if (Program.current_car != null)
            {
                Program.car_result_form.lblPlateNumber.Text = Program.current_car.PlateNumber;

                Program.car_result_form.lblRegDate.Text = Program.current_car.RegistrationDate.ToShortDateString();
                Program.car_result_form.lblRegTo.Text = Program.current_car.RegisteredTo;

                Program.car_result_form.lblMake.Text = Program.current_car.CarMake;
                Program.car_result_form.lblSeries.Text = Program.current_car.CarSeries;
                Program.car_result_form.lblModel.Text = Program.current_car.CarModel;

                Program.car_result_form.lblStatus.Text = Program.current_car.Status + "";
                Program.car_result_form.lblDescription.Text = Program.current_car.StatusInfo;
            }
            else
            {
                Program.car_result_form.lblPlateNumber.Text = "";

                Program.car_result_form.lblRegDate.Text = "";
                Program.car_result_form.lblRegTo.Text = "";

                Program.car_result_form.lblMake.Text = "";
                Program.car_result_form.lblSeries.Text = "";
                Program.car_result_form.lblModel.Text = "";

                Program.car_result_form.lblStatus.Text = "";
                Program.car_result_form.lblDescription.Text = "";
            }

            Program.car_result_form.Show();
        }

        public static void OpenCarSearchForm()
        {
            if (Program.car_search_form == null)
            {
                Program.car_search_form = new CarSearchForm();
            }
            Program.car_search_form.Show();
        }

        //common functions that other forms will call
        public static void LogOut()
        {
            Program.is_logged_in = false;
            Program.username = "";
            Program.password = "";
        }

        [MTAThread]
        static void Main()
        {
            //initialize variables;
            is_logged_in = false;
            username = "";
            password = "";

            db_handler = new DatabaseHandler();
            
            //initialize splash form
            splash_form = new SplashForm();

            //read application properties file

            //run splash now
            Application.Run(splash_form);
        }
    }
}