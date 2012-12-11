using System;
using System.Collections.Generic;
using System.Text;

namespace CitomMobileMonitor.classes
{
    public class Driver
    {
        private int driver_id;

        private string license_number;
        private string firstname;
        private string middlename;
        private string lastname;

        private string address;
        private string restrictions;

        private int gender;
        private string nationality;
        private DateTime birthdate;
        private int license_status;

        public Driver()
        {
            //nothing lang sah
        }

        public int DriverId
        {
            get
            {
                return this.driver_id;
            }

            set
            {
                this.driver_id = value;
            }

        }

        public string LicenceNumber
        {
            get
            {
                return this.license_number;
            }

            set
            {
                this.license_number = value;
            }

        }

        public string FirstName
        {
            get
            {
                return this.firstname;
            }

            set
            {
                this.firstname = value;
            }

        }

        public string MiddleName
        {
            get
            {
                return this.middlename;
            }

            set
            {
                this.middlename = value;
            }

        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }

            set
            {
                this.lastname = value;
            }

        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.address = value;
            }

        }

        public string Restrictions
        {
            get
            {
                return this.restrictions;
            }

            set
            {
                this.restrictions = value;
            }

        }

        public int Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;
            }

        }

        public string Nationality
        {
            get
            {
                return this.nationality;
            }

            set
            {
                this.nationality = value;
            }

        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthdate;
            }

            set
            {
                this.birthdate = value;
            }

        }

        public int LicenseStatus
        {
            get
            {
                return this.license_status;
            }

            set
            {
                this.license_status = value;
            }

        }
    }
}
