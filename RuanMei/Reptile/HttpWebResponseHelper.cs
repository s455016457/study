using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Reptile
{
    public class HttpWebResponseHelper
    {
        private static HttpWebResponseHelper responseHelper;

        private static Object lock_response = new Object();
        public static HttpWebResponseHelper HttpRequestHelper()
        {
            if (responseHelper == null)
            {
                lock (lock_response)
                {
                    if (responseHelper == null)
                    {
                        responseHelper = new HttpWebResponseHelper();
                    }
                }
            }
            return responseHelper;
        }

        public String GetContext(WebResponse response)
        {
            Stream responseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            responseStream.Close();

            return retString;
        }
    }
}
