using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace API_KiluninaAA.classes
{
    public class Common
    {
        public static string HttpQuery(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse HttpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader sr = new StreamReader(HttpWebResponse.GetResponseStream());
            return sr.ReadToEnd();
        }
    }
}
