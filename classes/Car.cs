using System;
using System.Collections.Generic;
using System.Text;

namespace CitomMobileMonitor.classes
{
    /*
     *  Car class
     *  function:
     *      holds car values
     **/
    class Car
    {
        private int car_registration_id;
        private string plate_number;
        private string make;
        private string series;
        private string model;
        private DateTime registration_date;
        private string registered_to;
        private int car_status;
        private string car_status_info;

        public Car()
        {
            //nothing lng muna;
        }

        public int RegistrationId
        {
            get
            {
                return this.car_registration_id;
            }
            set
            {
                this.car_registration_id = value;
            }
        }

        public string PlateNumber
        {
            get
            {
                return this.plate_number;
            }
            set
            {
                this.plate_number = value;
            }
        }

        public string CarMake
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }

        public string CarSeries
        {
            get
            {
                return this.series;
            }
            set
            {
                this.series = value;
            }
        }

        public string CarModel
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public DateTime RegistrationDate
        {
            get
            {
                return this.registration_date;
            }
            set
            {
                this.registration_date = value;
            }
        }

        public string RegisteredTo
        {
            get
            {
                return this.registered_to;
            }
            set
            {
                this.registered_to = value;
            }
        }

        public int Status
        {
            get
            {
                return this.car_status;
            }
            set
            {
                this.car_status = value;
            }
        }

        public string StatusInfo
        {
            get
            {
                return this.car_status_info;
            }
            set
            {
                this.car_status_info = value;
            }
        }
    }
}
