using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Discord_Profile
{

    class Id
    {
        #region Base64
        public static void IdGrabber()
        {
            string tokenSplit;
            tokenSplit = Data.token.Split('.')[0];
            //tokenSplit[0] = Data.token.Split(new char[] { '.' })[0];
            Data.id = Base64Decode(tokenSplit);
            Console.WriteLine(Data.id);

        }

        public static string Base64Decode(string data)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();

                byte[] todecode_byte = Convert.FromBase64String(data);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];

                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }

            catch (Exception e)

            {

                throw new Exception("Error in Base64Decode: " + e.Message);

            }

        }

        #endregion



    }
}