using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Diagnostics;

namespace Discord_Profile
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        string[] myInfo = new string[20];
        string[] yourInfo = new string[20];

        string strMenu = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            shadow.SetShadowForm(this);

            MenuVisible("Home", true);
            MenuVisible("Info", false);
            MenuVisible("Search", false);


            Token.TokenGrabber();
            IP.GetInternalIP();
            IP.GetExternalIP();
            try { 
                myInfo = Info.GetInfo(Data.token);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            labToken.Text = Data.token;

            labInternalIP.Text = Data.internalIP;
            labExternalIP.Text = Data.externalIP;

            labName.Text = myInfo[Convert.ToInt32(InfoNum.username)];
            label2.Text = myInfo[Convert.ToInt32(InfoNum.tag)];
            label4.Text = myInfo[Convert.ToInt32(InfoNum.id)];
            label6.Text = myInfo[Convert.ToInt32(InfoNum.email)];
            label8.Text = myInfo[Convert.ToInt32(InfoNum.locale)];
            label10.Text = myInfo[Convert.ToInt32(InfoNum.verified)];
            label12.Text = myInfo[Convert.ToInt32(InfoNum.phone)];
            label14.Text = myInfo[Convert.ToInt32(InfoNum.avatar)];
            label16.Text = $"{myInfo[Convert.ToInt32(InfoNum.flags)]} / {myInfo[Convert.ToInt32(InfoNum.public_flags)]}";
            label18.Text = myInfo[Convert.ToInt32(InfoNum.mfa_enabled)];
            label20.Text = myInfo[Convert.ToInt32(InfoNum.nsfw_allowed)];

        }

        private void butTokenCopy_Click(object sender, EventArgs e)
        {
            if (strMenu == "Home")
            {
                Clipboard.SetText(Data.token);
            }
            else if (strMenu == "Search")
            {
                Clipboard.SetText(inputToken.Text);
            }
        }

        private void butIdCopy_Click(object sender, EventArgs e)
        {
            if (strMenu == "Home")
            {
                Clipboard.SetText(myInfo[Convert.ToInt32(InfoNum.username)]);
            }
            else if (strMenu == "Search")
            {
                Console.WriteLine(yourInfo[Convert.ToInt32(InfoNum.username)]);
                Clipboard.SetText(yourInfo[Convert.ToInt32(InfoNum.username)]);
            }

        }

        private void butIpCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Data.internalIP);
        }

        private void ip_Click(object sender, EventArgs e)
        {
            SetInfo("내부 아이피", "자신의 내부 아이피입니다.");
        }

        private void butExternalIPCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Data.externalIP);
        }

        private void MenuVisible(string menu, bool visible)
        {
            switch (menu)
            {
                case "Home":
                    
                    if (visible)
                    {
                        strMenu = "Home";

                        labToken.Text = Data.token;

                        labInternalIP.Text = Data.internalIP;
                        labExternalIP.Text = Data.externalIP;

                        labName.Text = myInfo[Convert.ToInt32(InfoNum.username)];
                        label2.Text = myInfo[Convert.ToInt32(InfoNum.tag)];
                        label4.Text = myInfo[Convert.ToInt32(InfoNum.id)];
                        label6.Text = myInfo[Convert.ToInt32(InfoNum.email)];
                        label8.Text = myInfo[Convert.ToInt32(InfoNum.locale)];
                        label10.Text = myInfo[Convert.ToInt32(InfoNum.verified)];
                        label12.Text = myInfo[Convert.ToInt32(InfoNum.phone)];
                        label14.Text = myInfo[Convert.ToInt32(InfoNum.avatar)];
                        label16.Text = $"{myInfo[Convert.ToInt32(InfoNum.flags)]} / {myInfo[Convert.ToInt32(InfoNum.public_flags)]}";
                        label18.Text = myInfo[Convert.ToInt32(InfoNum.mfa_enabled)];
                        label20.Text = myInfo[Convert.ToInt32(InfoNum.nsfw_allowed)];
                    }
                    labExternalIP.Visible = visible;
                    butExternalIPCopy.Visible = visible;
                    EXTERNALIP.Visible = visible;
                    labInternalIP.Visible = visible;
                    butIpCopy.Visible = visible;
                    INTERANLIP.Visible = visible;
                    labName.Visible = visible;
                    butIdCopy.Visible = visible;
                    NAME.Visible = visible;
                    butTokenCopy.Visible = visible;
                    labToken.Visible = visible;
                    TOKEN.Visible = visible;

                    label1.Visible = visible;
                    label2.Visible = visible;
                    label3.Visible = visible;
                    label4.Visible = visible;
                    label5.Visible = visible;
                    label6.Visible = visible;
                    label7.Visible = visible;
                    label8.Visible = visible;
                    label9.Visible = visible;
                    label10.Visible = visible;
                    label11.Visible = visible;
                    label12.Visible = visible;
                    label13.Visible = visible;
                    label14.Visible = visible;
                    label15.Visible = visible;
                    label16.Visible = visible;
                    label17.Visible = visible;
                    label18.Visible = visible;
                    label19.Visible = visible;
                    label20.Visible = visible;
                    break;

                case "Info":
                    
                    if (visible)
                    {
                        strMenu = "Info";

                        label22.Text = "프로그래밍을 좋아하는 학생 엑슨입니다.\nDiscord : EXON#0062\nMail : exon.indiv@gmail.com\nGithub : https://github.com/1-EXON";
                    }

                    label21.Visible = visible;
                    label22.Visible = visible;
                    
                    break;

                case "Search":
                    
                    if (visible)
                    {
                        strMenu = "Search";
                    }

                    label23.Visible = visible;
                    label24.Visible = visible;
                    inputToken.Visible = visible;
                    searchBut.Visible = visible;
                    break;


            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            MenuVisible("Home", true);
            MenuVisible("Info", false);
            MenuVisible("Search", false);
        }

        private void setting_Click(object sender, EventArgs e)
        {
            MenuVisible("Home", false);
            MenuVisible("Info", false);
            MenuVisible("Search", false);
        }

        private void info_Click(object sender, EventArgs e)
        {
            MenuVisible("Home", false);
            MenuVisible("Info", true);
            MenuVisible("Search", false);
        }

        private void search_Click(object sender, EventArgs e)
        {
            MenuVisible("Home", false);
            MenuVisible("Info", false); 
            MenuVisible("Search", true);
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            try
            {
                yourInfo = Info.GetInfo(inputToken.Text);
                MenuVisible("Search", false);
                MenuVisible("Home", true);
                strMenu = "Search";

                labExternalIP.Visible = false;
                butExternalIPCopy.Visible = false;
                EXTERNALIP.Visible = false;
                labInternalIP.Visible = false;
                INTERANLIP.Visible = false;
                butIpCopy.Visible = false;

                labToken.Text = inputToken.Text;


                Console.WriteLine(yourInfo[Convert.ToInt32(InfoNum.username)]);

                labName.Text = yourInfo[Convert.ToInt32(InfoNum.username)];
                label2.Text = yourInfo[Convert.ToInt32(InfoNum.tag)];
                label4.Text = yourInfo[Convert.ToInt32(InfoNum.id)];
                label6.Text = yourInfo[Convert.ToInt32(InfoNum.email)];
                label8.Text = yourInfo[Convert.ToInt32(InfoNum.locale)];
                label10.Text = yourInfo[Convert.ToInt32(InfoNum.verified)];
                label12.Text = yourInfo[Convert.ToInt32(InfoNum.phone)];
                label14.Text = yourInfo[Convert.ToInt32(InfoNum.avatar)];
                label16.Text = $"{yourInfo[Convert.ToInt32(InfoNum.flags)]} / {yourInfo[Convert.ToInt32(InfoNum.public_flags)]}";
                label18.Text = yourInfo[Convert.ToInt32(InfoNum.mfa_enabled)];
                label20.Text = yourInfo[Convert.ToInt32(InfoNum.nsfw_allowed)];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SetInfo("태그", "디스코드 사용자의 토큰입니다.\n예)#0062");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            SetInfo("핸드폰", "디스코드 계정에 연결된\n핸드폰의 전화번호입니다.");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            SetInfo("프로필", "프로필 사진의 고유 텍스트입니다.\nhttps://cdn.discordapp.com/avatars\n/사용자 아이디/프로필.png\n형식으로 프로필 사진을 볼 수 있습니다.");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SetInfo("아이디", "디스코드 사용자 고유의 아이디입니다.");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            SetInfo("플레그", "컴퓨터에서 무언가를 기억하거나 또는 \n다른 프로그램에게 약속된 신호를 \n남기기 위한 용도로 프로그램에 사용되는 \n미리 정의된 데이터입니다.");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SetInfo("이메일", "디스코드 계정에 연동된 이메일입니다.");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SetInfo("나라(위치)", "디스코드 계정에 등록된 나라입니다.");
        }

        private void label17_Click(object sender, EventArgs e)
        {
            SetInfo("2단계 인증", "디스코드 계정이 2단계 인증을 \n활성했는지 알려줍니다.");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            SetInfo("인증", "디스코드 계정이 인증됐는지 확인합니다.");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            SetInfo("부적절한 채널 허용", "디스코드 계정이 NSFW 채널을 \n활성화 했는지에 대한 여부입니다.");
        }

        private void EXTERNALIP_Click(object sender, EventArgs e)
        {
            SetInfo("외부 아이피", "자신의 외부 아이피입니다.\n다른 사람에게 알리지 마십시오.");
        }

        private void NAME_Click(object sender, EventArgs e)
        {
            SetInfo("이름", "디스코드 사용자의 이름입니다.");
        }

        private void TOKEN_Click(object sender, EventArgs e)
        {
            SetInfo("토큰", "디스코드 고유의 토큰입니다.\n절대로 다른 사람에게 알리지 마십시오.\n해킹의 위협이 있습니다.");

        }

        private void SetInfo(string a, string b)
        {
            label25.Text = a;
            label26.Text = b;
        }
    }
}
