using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Reptile
{
    public class HttpWebRequestHelper
    {
        private static HttpWebRequestHelper requestHelper;

        private static Object lock_request = new Object();
        public static HttpWebRequestHelper HttpRequestHelper()
        {
            if (requestHelper == null) {
                lock (lock_request) {
                    if (requestHelper == null) {
                        requestHelper = new HttpWebRequestHelper();
                    }
                }
            }
            return requestHelper;
        }

        private HttpWebRequestHelper() { }

        public WebResponse GetResponse(String Url)
        {
            var request = CreatedRequest(Url);
            return request.GetResponse();
        }

        public HttpWebRequest CreatedRequest(String Url)
        {
            var request = (HttpWebRequest)WebRequest.Create(Url);
            return request;
        }
    }
}
