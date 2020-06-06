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
            label12.Text = Data.info[Convert.ToInt32(InfoNum.avatar)];
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
    }
}
