using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "0.1";
            string text2 = "";
            WebRequest webRequest;
            byte[] bytes;
            checked
            {
                webRequest = WebRequest.Create("http://v-samp.com/?m=launcher&a=play");
                string s = string.Concat(new string[]
				{
					@"data=\anim|\audio|\data|\models|\movies|\SAMP|\scripts|\templates|\text|\bass.dll|\eax.dll|\gtaweap3.ttf|\gta_sa.exe|\gta_sa.nfo|\Launcher.exe|\libsquish.dll|\mouse.png|\ogg.dll|\PaulpBaker.COM.PNG|\rcon.exe|\samp-license.txt|\samp.dll|\samp.exe|\samp.saa|\sampaux3.ttf|\sampgui.png|\SAMPUninstall.exe|\samp_debug.exe|\SF Readme.txt|\stream.ini|\trainer.exe|\vorbis.dll|\vorbisFile.dll|\vorbisHooked.dll|",
					text2,
					"&version=",
					text,
					"&username=",
					this.textBox1.Text
				});
                bytes = Encoding.UTF8.GetBytes(s);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
            }
            webRequest.ContentLength = (long)bytes.Length;
            Stream requestStream = webRequest.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            MessageBox.Show("Bypass thành công ! xin mời vào game", "OK",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
