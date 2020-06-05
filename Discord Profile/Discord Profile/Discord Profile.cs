using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            labToken.Text = Data.token;
            labId.Text = Data.id;



            //끄읕
            Console.WriteLine("----------End----------");
            Console.ReadLine();
        }
    }
}
