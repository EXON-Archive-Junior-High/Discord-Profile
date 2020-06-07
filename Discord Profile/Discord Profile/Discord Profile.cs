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

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuVisible("Home", true);
            MenuVisible("Info", false);
            //시작
            Console.WriteLine("----------Start----------");

            Token.TokenGrabber();
            IP.GetInternalIP();
            IP.GetExternalIP();
            Info.GetInfo();

            labToken.Text = Data.token;

            labInternalIP.Text = Data.internalIP;
            labExternalIP.Text = Data.externalIP;

            labName.Text = Data.info[Convert.ToInt32(InfoNum.username)];
            label2.Text = Data.info[Convert.ToInt32(InfoNum.tag)];
            label4.Text = Data.info[Convert.ToInt32(InfoNum.id)];
            label6.Text = Data.info[Convert.ToInt32(InfoNum.email)];
            label8.Text = Data.info[Convert.ToInt32(InfoNum.locale)];
            label10.Text = Data.info[Convert.ToInt32(InfoNum.verified)];
            label12.Text = Data.info[Convert.ToInt32(InfoNum.phone)];
            label14.Text = Data.info[Convert.ToInt32(InfoNum.avatar)];
            label16.Text = $"{Data.info[Convert.ToInt32(InfoNum.flags)]} / {Data.info[Convert.ToInt32(InfoNum.public_flags)]}";
            label18.Text = Data.info[Convert.ToInt32(InfoNum.mfa_enabled)];
            label20.Text = Data.info[Convert.ToInt32(InfoNum.nsfw_allowed)];
            //끄읕
            Console.WriteLine("----------End----------");
        }

        private void butTokenCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Data.token);
        }

        private void butIdCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Data.info[Convert.ToInt32(InfoNum.username)]);
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
                    label21.Visible = visible;
                    label22.Visible = visible;
                    label22.Text = "프로그래밍을 좋아하는 학생 엑슨입니다.\nDiscord : EXON#002\nMail : exon.indiv@gmail.com\nGithub : https://github.com/1-EXON";
                    break;


            }
        }
        private void HomeMenu_Click(object sender, EventArgs e)
        {
            MenuVisible("Home", true);
            MenuVisible("Info", false);
        }

        private void InfoMenu_Click(object sender, EventArgs e)
        {
            MenuVisible("Home", false);
            MenuVisible("Info", true);
        }
    }
}
