using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGShoutBoxPub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean Switch = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Decimal TimerMS = (trackBar1.Value * 60) * 1000;
            timer1.Interval = (int)TimerMS;
            if (button1.Text.Equals("Start"))
            {
                timer1.Start();
                button1.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                button1.Text = "Start";
            }
        }

        private void SendMsg()
        {
            String msg1 = ":espion: Stats⇋Full Unlock⇋Tenues Modded⇋Drop Cash Bonjour les Lobby's Rapide, Facile & Complet Grand Theft Auto V Online à portée de tous!☆[url='https://realitygaming.fr/threads/518402/'][↪GTA Advanced Recovery Tool][/url]:espion:";
            String msg2 = ":espion: 3ans d'experience et de Qualité pour vous, le Launcher Ultime reconnus pour tout les CoD, Facile et Rapide il est fait pour Vous!☆[url='https://realitygaming.fr/threads/314874/'][↪CoD Unknauwn Launcher][/url]:espion:";

            if (Switch)
            {
                webBrowser1.Document.GetElementById("taigachat_message").SetAttribute("value", msg1);
                webBrowser1.Document.GetElementById("taigachat_send").InvokeMember("click");
                Switch = false;
            }
            else if (!Switch)
            {
                webBrowser1.Document.GetElementById("taigachat_message").SetAttribute("value", msg2);
                webBrowser1.Document.GetElementById("taigachat_send").InvokeMember("click");
                Switch = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendMsg();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Text = "RGShoutBoxPub | " + trackBar1.Value.ToString() + "mn";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMsg();
        }
    }
}
