using System;
using System.Collections.Generic;
using System.Text;

namespace CitomMobileMonitor.classes
{
    class Issuance
    {
        private int issuance_id;
        private string issuance_receipt_no;
        private int issuing_officer_id;

        private DateTime issuance_date;

        private Officer officer;
        private Driver driver;
        private Violation[] violations;

        public Issuance()
        {
            //nothing
            this.driver = null;
            this.issuance_date = new DateTime();
        }

        public int IssuanceId
        {
            get
            {
                return this.issuance_id;
            }
            set
            {
                this.issuance_id = value;
            }
        }

        public string ReceiptNo
        {
            get
            {
                return this.issuance_receipt_no;
            }
            set
            {
                this.issuance_receipt_no = value;
            }
        }

        public int IssuingOfficerId
        {
            set
            {
                this.issuing_officer_id = value;
            }
            get
            {
                return this.issuing_officer_id;
            }
        }

        public DateTime IssuanceDate
        {
            get
            {
                return this.issuance_date;
            }

            set
            {
                this.issuance_date = value;
            }
        }

        public Driver IssuedDriver
        {
            get
            {
                if (this.driver == null)
                {
                    //get driver somehow
                }
                else
                {
                    
                }
                return this.driver;
            }
            set
            {
                this.driver = value;
            }
        }

        public int ViolationCount
        {
            get
            {
                return this.violations.Length;
            }
        }

        public Violation GetViolation(int index)
        {
            if (violations.Length > 0)
            {
                if (index >= violations.GetLowerBound(0) && index <= violations.GetUpperBound(0))
                {
                    return this.violations[index];
                }
            }
            return null;
        }

        public Violation[] GetAllViolations()
        {
            return this.violations;
        }


    }
}
