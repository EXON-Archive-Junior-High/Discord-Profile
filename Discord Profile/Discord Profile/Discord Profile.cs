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
            Id.IdGrabber();
            IP.GetInternalIP();
            IP.GetExternalIP();

            labToken.Text = Data.token;
            labId.Text = Data.id;
            labInternalIP.Text = Data.internalIP;
            labExternalIP.Text = Data.ExternalIP;


            //끄읕
            Console.WriteLine("----------End----------");
        }

        private void butTokenCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Data.token);
        }

        private void butIdCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Data.id);
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
            Clipboard.SetText(Data.ExternalIP);
        }
    }
}
