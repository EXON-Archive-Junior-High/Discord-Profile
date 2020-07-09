using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Discord_Profile
{
    class Info
    {
        public static string[] GetInfo(string token)
        {
            //api
            string url = "https://discordapp.com/api/users/@me";
            string responseText = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Timeout = 30 * 1000;
            request.Headers.Add("authorization", token);


            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                Console.WriteLine(status);  // 정상이면 "OK"

                Stream respStream = resp.GetResponseStream();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                }

                resp.Close();
            }


            //api 받은거 로동으로 ㅠㅠ
            Console.WriteLine(responseText);

            responseText = responseText.Replace("{", "");
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

            foreach (string text in apiText1)
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

            return apiText3;





        }
    }
}
