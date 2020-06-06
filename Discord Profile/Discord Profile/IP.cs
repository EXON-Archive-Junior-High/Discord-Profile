using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Discord_Profile
{
    class IP
    {
        public static void GetInternalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string ClientIP = string.Empty;

            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    ClientIP = host.AddressList[i].ToString();
                }
            }

            Data.internalIP = ClientIP;
            Console.WriteLine(Data.internalIP);
        }

        public static void GetExternalIP()
        {
            string searchIpFromUrl = new System.Net.WebClient().DownloadString(("http://checkip.dyndns.org"));
            string EtcIpInfo = searchIpFromUrl.Substring(searchIpFromUrl.IndexOf("</body>"), searchIpFromUrl.Length - searchIpFromUrl.IndexOf("</body>"));

            string ExternalIp = searchIpFromUrl.Substring(searchIpFromUrl.IndexOf(":") + 1, searchIpFromUrl.Length - searchIpFromUrl.IndexOf(":") - EtcIpInfo.Length - 1).Trim();

            Data.ExternalIP = ExternalIp;
            Console.WriteLine(Data.ExternalIP);

        }
    }
}
