using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace CitomMobileMonitor.classes
{
    class RequestState
    {
        // This class stores the state of the request.
        const int BUFFER_SIZE = 1024;
        public StringBuilder request_data;
        public byte[] buffer_read;
        public WebRequest request;
        public WebResponse response;
        public Stream response_stream;
        public RequestState()
        {
            buffer_read = new byte[BUFFER_SIZE];
            request_data = new StringBuilder("");
            request = null;
            response_stream = null;
        }
    }
}
