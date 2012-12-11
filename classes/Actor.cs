using System;
using System.Collections.Generic;
using System.Text;

namespace CitomMobileMonitor.classes
{
    /*
     *  Actor Class
     *  function:
     *      holds actor values.
     *  note:
     *      an actor means a user of the system
     *      in this case, either an officer or admin
     * */
    class Actor
    {
        private int actor_id;
        private string firstname;
        private string middlename;
        private string lastname;

        protected string username;
        protected string password;

        public Actor()
        {
            //nothing
        }

        public int ActorId
        {
            get
            {
                return this.actor_id;
            }
            set
            {
                this.actor_id = value;
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

        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
    }
}
