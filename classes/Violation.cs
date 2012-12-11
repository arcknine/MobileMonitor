using System;
using System.Collections.Generic;
using System.Text;

namespace CitomMobileMonitor.classes
{
    class Violation
    {
        private int violation_id;
        private string violation;
        private string desc;
        private decimal price;
        private DateTime last_mod;

        public Violation()
        {
            //nothing
        }

        public int ViolationId
        {
            get
            {
                return this.violation_id;
            }
            set
            {
                this.violation_id = value;
            }
        }

        public string ViolationName
        {
            get
            {
                return this.violation;
            }
            set
            {
                this.violation = value;
            }
        }

        public string Description
        {
            get
            {
                return this.desc;
            }
            set
            {
                this.desc = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public DateTime LastModified
        {
            get
            {
                return this.last_mod;
            }
            set
            {
                this.last_mod = value;
            }
        }
    }
}
