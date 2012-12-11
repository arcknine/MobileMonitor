using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace CitomMobileMonitor.classes
{
    class OfficerImplementor:Implementor
    {
        public OfficerImplementor()
        {
            //nothing
        }

        //add officer
        public bool addOfficer(Officer officer)
        {
            //connect using httpwebrequest
            string url = this.base_url + "/add_url.php";
            HttpWebRequest http_req = (HttpWebRequest)WebRequest.Create(url);
            http_req.Credentials = new NetworkCredential("username","password");

            http_req.Method = "POST";

            //create passed_parameter_string
            ASCIIEncoding encoding = new ASCIIEncoding();
            string param_string = "";

            //basic info
            param_string = "&fn=" + officer.FirstName;
            param_string += "&mn=" + officer.MiddleName;
            param_string += "&ln=" + officer.LastName;
            //credentials
            param_string += "&code=" + officer.OfficerCode;
            param_string += "&pass=" + officer.Password;

            byte[] parameter = encoding.GetBytes(param_string);

            //http_req.Headers.Add("Accept-Encoding", "gzip");
            http_req.ContentType = "application/x-www-form-urlencoded";
            http_req.ContentLength = parameter.Length;

            Stream req_stream = http_req.GetRequestStream();
            req_stream.Write(parameter, 0, parameter.Length);
            req_stream.Close();

            HttpWebResponse http_res = (HttpWebResponse) http_req.GetResponse();

            Stream res_stream = http_res.GetResponseStream();
            StreamReader reader = new StreamReader(res_stream);
                        
            string response_string = reader.ReadToEnd();

            return true;

            /*
            if(String.Compare(http_res.ContentEncoding,"gzip",true) == 0)
            {
                //unzip here first
            }
            */

            //process response here



            /*
             * 
             * 
             * 
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

                req.Method = "GET";

                HttpWebResponse res = (HttpWebResponse)req.GetResponse();

                Stream answer = res.GetResponseStream();
                StreamReader result = new StreamReader(answer);
                txtData.Text = result.ReadToEnd();

                String ret = processReturn(txtData.Text);
                MessageBox.Show(ret);
            }
            catch (WebException wer)
            {
                MessageBox.Show("Cannot connect to site. Please make sure you are connected. (" + wer.Status + ")");
            }
             * */
        }
        //edit officer
        //delete officer

        //getOfficer
        //getAllOfficers
        //getSomeOfficers
        
        //issue receipt (add)
        //edit? allow this?
        //delete receipt? allow this?

        //view driver info
        //view driver receipts or violations
        
        //search car (using platenum?)
    }
}
