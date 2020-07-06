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

        private void Form1_Load(object sender, EventArgs e)
        {
            shadow.SetShadowForm(this);

            MenuVisible("Home", true);
            MenuVisible("Info", false);
            MenuVisible("Search", false);


            Token.TokenGrabber();
            IP.GetInternalIP();
            IP.GetExternalIP();
            myInfo = Info.GetInfo(Data.token);

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
            Clipboard.SetText(Data.token);
        }

        private void butIdCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(myInfo[Convert.ToInt32(InfoNum.username)]);
        }

        private void butIpCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Data.internalIP);
        }

        private void ip_Click(object sender, EventArgs e)
        {

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
                        label22.Text = "프로그래밍을 좋아하는 학생 엑슨입니다.\nDiscord : EXON#002\nMail : exon.indiv@gmail.com\nGithub : https://github.com/1-EXON";
                    }

                    label21.Visible = visible;
                    label22.Visible = visible;
                    
                    break;

                case "Search":
                    if (visible)
                    {

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
    }
}
