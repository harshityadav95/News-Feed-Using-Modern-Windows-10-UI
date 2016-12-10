using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;

namespace news_feed_Ui
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            richTextBox1.Text = webClient.DownloadString("https://raw.githubusercontent.com/harshityadav95/exp_cmd/master/Rss%20feed.txt");

            //webBrowser1.Navigate("https://mobile.twitter.com/Lingayasuniv");
            webBrowser1.Navigate("http://lukeyscore.blogspot.in/?m=1");
            //http://go.microsoft.com/fwlink/?linkid=85889&clcid=409


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {
            metroProgressSpinner1.Speed = 30;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
