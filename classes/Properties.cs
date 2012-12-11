using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CitomMobileMonitor.classes
{
    /*
     * Properties Class
     * function:
     *  reads properties files. these files are 
     *  key-value pairs that are grouped by lines.
     * */
    class Properties
    {
        private string file_path;
        public Properties(string file_path)
        {
            this.file_path = file_path;
        }

        public Properties()
        {
            this.file_path = "";
        }

        public string getProperty(string key, string file_path)
        {
            this.file_path = file_path;
            return this.getProperty(key);
        }

        public string getProperty(string key)
        {
            StreamReader file_reader = new StreamReader(file_path);
            string line;
            //find key by iterating through the lines
            while ((line = file_reader.ReadLine()) != null)
            {
                int index = line.IndexOf("=");
                if (index >= 0)
                {
                    string line_key = line.Substring(0, index);
                    if (String.Compare(line_key, key, true) == 0)
                    {
                        return line.Substring(index + 1);
                    }
                }
            }
            return null;
        }
    }
}
