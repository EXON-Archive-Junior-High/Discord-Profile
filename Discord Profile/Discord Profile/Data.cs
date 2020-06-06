using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Profile
{
    class Data
    {
        public static string token { get; set; }

        public static string id { get; set; } //처리

        public static string internalIP { get; set; }

        public static string externalIP { get; set; }

        public static string[] info = new string[12];
    }

    enum InfoNum
    {
        id, username, avatar, tag, public_flags, flags, email, verified, locale, nsfw_allowed, mfa_enabled, phone
    }
}
