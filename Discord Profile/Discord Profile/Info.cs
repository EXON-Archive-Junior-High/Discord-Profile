using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Discord_Profile
{
    class Info
    {
        public static void GetInfo()
        {
            string url = "https://discord.com/api/v7/users/@me";
            string responseText = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Timeout = 30 * 1000;
            request.Headers.Add("authorization", Data.token);

            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                Console.WriteLine(status);  // 정상이면 "OK"

                Stream respStream = resp.GetResponseStream();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                }
            }

            Console.WriteLine(responseText);

            responseText = responseText.Replace("{","");
            responseText = responseText.Replace("}", "");

            string[] apiText1 = new string[12];
            int i = 0;

            foreach (string text in responseText.Split(','))
            {
                apiText1[i] = text;
                i++;
            }

            i = 0;
            string[] apiText2 = new string[12];

            foreach(string text in apiText1)
            {
                apiText2[i] = text.Split(':')[1];
                i++;
            }

            i = 0;
            string[] apiText3 = new string[12];

            foreach (string a in apiText2)
            {
                apiText3[i] = apiText2[i].Replace("\"", "");
                i++;
            }

            foreach (string a in apiText3)
            {
                Console.WriteLine($"{a}");

            }

            Data.info = apiText3;





        }
    }
}
