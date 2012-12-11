using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace CitomMobileMonitor.classes
{
    class MobileAppXmlParser
    {
        /*
         *  <xml>
         *      <result>value(true or false)</result>
         *      <user>
         *          <id>432</id>
         *          <fn>albin</fn>
         *          <mn>gabiana</mn>
         *          <ln>suson!!!</ln>
         *      </user>
         *  </xml>
         * */

        public static Officer processLoginResult(string xml_str)
        {
            TextReader str_reader = new StringReader(xml_str);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;

            try
            {
                XmlReader reader = XmlReader.Create(str_reader, settings);
                Officer result = null;
                reader.Read();
                reader.Read();
                if (String.Compare(reader.ReadString(), "true") == 0)
                {
                    result = new Officer();

                    //get user (officer) details here
                    //user tag
                    reader.Read();
                    //id tag
                    reader.Read();
                    result.ActorId = reader.ReadElementContentAsInt();
                    result.FirstName = reader.ReadElementContentAsString();
                    result.MiddleName = reader.ReadElementContentAsString();
                    result.LastName = reader.ReadElementContentAsString();
                }
                str_reader.Close();
                return result;
            }
            catch (Exception err)
            {
                string error_msg = "";
                str_reader.Close();
                error_msg = err.Message;
                return null;
            }
        }


        /*
         *  <xml>
         *      <result>value(true or false)</result>
         *      <driver>
         *          <id>value</id>
         *          <no>value</no>
         *          <fn>value</fn>
         *          <mn>value</mn>
         *          <ln>value</ln>
         *          <add>value</add>
         *          <res>value</res>
         *          <sex>value</sex>
         *          <nat>value</nat>
         *          <bd>value</bd>
         *          <stat>value</stat>
         *      </driver>
         *  </xml>
         * */

        public static Driver processLicenseResult(string xml_str)
        {
            TextReader str_reader = new StringReader(xml_str);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;

            try
            {
                XmlReader reader = XmlReader.Create(str_reader, settings);
                Driver result;
                //xml tag
                reader.Read();
                //result tag
                reader.Read();
                //if found
                if (String.Compare(reader.ReadString(), "true") == 0)
                {
                    result = new Driver();
                    //driver tag
                    reader.Read();
                    //id tag
                    reader.Read();

                    //get driver information values
                    try
                    {
                        result.DriverId = reader.ReadElementContentAsInt();
                    }
                    catch (Exception err)
                    {
                        string msg = err.Message;
                        result.DriverId = -1;
                    }
                    result.LicenceNumber = reader.ReadElementContentAsString();
                    result.FirstName = reader.ReadElementContentAsString();
                    result.MiddleName = reader.ReadElementContentAsString();
                    result.LastName = reader.ReadElementContentAsString();
                    result.Address = reader.ReadElementContentAsString();
                    result.Restrictions = reader.ReadElementContentAsString();

                    try
                    {
                        result.Gender = reader.ReadElementContentAsInt();
                    }
                    catch (Exception err)
                    {
                        //default male if walay gibutang
                        string msg = err.Message;
                        result.Gender = 1;
                    }
                    result.Nationality = reader.ReadElementContentAsString();
                    try
                    {
                        result.BirthDate = DateTime.Parse(reader.ReadElementContentAsString());
                    }
                    catch (Exception err)
                    {
                        string msg = err.Message;
                        result.BirthDate = new DateTime();
                    }
                    try
                    {
                        result.LicenseStatus = reader.ReadElementContentAsInt();
                    }
                    catch (Exception err)
                    {
                        string msg = err.Message;
                        result.LicenseStatus = -1;
                    }
                }
                //if not found or result is false
                else
                {
                    result = null;
                }
                str_reader.Close();
                return result;
            }
            catch (Exception err)
            {
                string error_msg = "";
                str_reader.Close();
                error_msg = err.Message;
                return null;
            }
        }

        /*
         *  <xml>
         *      <result>value(true or false)</result>
         *      <car>
         *          <id>789</id>
         *          <plate>value</plate>
         *          <make>value</make>
         *          <series>value</series>
         *          <model>value</model>
         *          <regdate>value</regdate>
         *          <regto>value</regto>
         *          <stat>value</stat>
         *          <info>value</info>
         *      </car>
         *  </xml>
         * */

        public static Car processCarSearchResult(string xml_str)
        {
            TextReader str_reader = new StringReader(xml_str);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;

            try
            {
                XmlReader reader = XmlReader.Create(str_reader, settings);
                Car result;
                //xml tag
                reader.Read();
                //result tag
                reader.Read();
                //if found
                if (String.Compare(reader.ReadString(), "true") == 0)
                {
                    result = new Car();
                    //driver tag
                    reader.Read();
                    //id tag
                    reader.Read();

                    //get car information values
                    try
                    {
                        result.RegistrationId = reader.ReadElementContentAsInt();
                    }
                    catch (Exception err)
                    {
                        string msg = err.Message;
                        result.RegistrationId = -1;
                    }
                    result.PlateNumber = reader.ReadElementContentAsString();
                    result.CarMake = reader.ReadElementContentAsString();
                    result.CarSeries = reader.ReadElementContentAsString();
                    result.CarModel = reader.ReadElementContentAsString();
                    try
                    {
                        result.RegistrationDate = DateTime.Parse(reader.ReadElementContentAsString());
                    }
                    catch (Exception err)
                    {
                        string msg = err.Message;
                        result.RegistrationDate = DateTime.Now;
                    }
                    result.RegisteredTo = reader.ReadElementContentAsString();
                    try
                    {
                        result.Status = reader.ReadElementContentAsInt();
                    }
                    catch (Exception err)
                    {
                        string msg = err.Message;
                        result.Status = -1;
                    }
                    result.StatusInfo = reader.ReadElementContentAsString();
                }
                //if not found or result is false
                else
                {
                    result = null;
                }
                str_reader.Close();
                return result;
            }
            catch (Exception err)
            {
                string error_msg = "";
                str_reader.Close();
                error_msg = err.Message;
                return null;
            }
        }
    }
}