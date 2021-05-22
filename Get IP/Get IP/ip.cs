using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_IP
{
    public partial class ip : Form
    {
        public ip()
        {
            InitializeComponent();
        }

        private void ip_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "IP Address: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "IP Address: " + new WebClient().DownloadString("http://ipv4bot.whatismyipaddress.com/")
;        } // get tsl error? i dont give a fuck.
    }
}
