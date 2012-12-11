using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.IO;

namespace CitomMobileMonitor.classes
{
    class ServerCommunicator
    {
        //ref
        //http://msdn2.microsoft.com/en-us/library/system.net.webrequest.begingetresponse(VS.71).aspx
        public static ManualResetEvent process_done = new ManualResetEvent(false);
        const int BUFFER_SIZE = 1024;

        public ServerCommunicator()
        {
            //nothing lang po
        }

        //Synchronously...
        public static string getSyncResponse(string url, string paramstring, string username, string password)
        {
            try
            {
                //create server connection
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //set up necessary properties and data to pass to server
                request.Credentials = new NetworkCredential(username, password);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                ASCIIEncoding encoding = new ASCIIEncoding();
                //make sure it's not null;
                string param_str = paramstring + "";
                //if there is already some value in it then add an ampersand lng para
                //malain ang user na key value pair. ok ok?
                if (String.Compare(param_str, "") != 0)
                {
                    param_str = param_str + "&";   
                }

                byte[] data = encoding.GetBytes(param_str + "user=" + username + "&pass=" + password);
                request.ContentLength = data.Length;
                Stream request_stream = request.GetRequestStream();
                if (data.Length > 0)
                {
                    request_stream.Write(data, 0, data.Length);
                }
                request_stream.Close();

                //start server connection
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                Stream response_stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(response_stream);

                string response_string = "";
                //get response string
                response_string = reader.ReadToEnd();

                //close connections and streams
                reader.Close();
                response_stream.Close();
                response.Close();

                reader = null;
                response_stream = null;
                data = null;
                encoding = null;
                request = null;

                return response_string;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        //Assynchronously... later
        public static void getAsyncResponse(string url, string paramstring)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(paramstring);

            request.ContentLength = data.Length;

            Stream request_stream = request.GetRequestStream();
            request_stream.Write(data, 0, data.Length);
            request_stream.Close();

            //associate our request with a request_state object
            RequestState request_state = new RequestState();
            request_state.request = request;

            IAsyncResult asyncResult = (IAsyncResult)request.BeginGetResponse(new AsyncCallback(RespCallback), request_state);
            process_done.WaitOne();

            request_state.response.Close();
        }




        private static void RespCallback(IAsyncResult asynchResult)
        {
            try
            {
                RequestState request_state = (RequestState)asynchResult.AsyncState;
                WebRequest request = request_state.request;
                request_state.response = request.EndGetResponse(asynchResult);
                Stream response_stream = request_state.response.GetResponseStream();
                request_state.response_stream = response_stream;
                IAsyncResult asynchronousResultRead = response_stream.BeginRead(request_state.buffer_read, 0, BUFFER_SIZE, new AsyncCallback(ReadCallBack), request_state);

            }
            catch (WebException err)
            {
                string error_msg = "";
                error_msg = err.Message;
                //Console.WriteLine("WebException raised!");
                //Console.WriteLine("\n{0}", e.Message);
                //Console.WriteLine("\n{0}", e.Status);
            }
            catch (Exception err)
            {
                string error_msg = "";
                error_msg = err.Message;
                //Console.WriteLine("Exception raised!");
                //Console.WriteLine("Source : " + e.Source);
                //Console.WriteLine("Message : " + e.Message);
            }
        }

        private static void ReadCallBack(IAsyncResult asyncResult)
        {
            try
            {
                RequestState request_state = (RequestState)asyncResult.AsyncState;
                Stream response_stream = request_state.response_stream;
                int read = response_stream.EndRead(asyncResult);
                if (read > 0)
                {
                    request_state.request_data.Append(Encoding.ASCII.GetString(request_state.buffer_read, 0, read));
                    IAsyncResult asynchronousResult = response_stream.BeginRead(request_state.buffer_read, 0, BUFFER_SIZE, new AsyncCallback(ReadCallBack), request_state);
                }
                else
                {
                    if (request_state.request_data.Length > 1)
                    {
                        string string_content;
                        string_content = request_state.request_data.ToString();
                        Console.WriteLine(string_content);
                    }
                    response_stream.Close();
                    process_done.Set();
                }
            }
            catch (WebException err)
            {
                string error_msg = "";
                error_msg = err.Message;
                //Console.WriteLine("WebException raised!");
                //Console.WriteLine("\n{0}", e.Message);
                //Console.WriteLine("\n{0}", e.Status);
            }
            catch (Exception err)
            {
                string error_msg = "";
                error_msg = err.Message;
                //Console.WriteLine("Exception raised!");
                //Console.WriteLine("Source : {0}", e.Source);
                //Console.WriteLine("Message : {0}", e.Message);
            }

        }
    }
}
