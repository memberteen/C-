using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
        public static Boolean bools = false;
        public Form1()
        {
            InitializeComponent();
        }
       
        string muzica;
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            
        }
        private void btnSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Sound Files (.mp3,.wav)|*.mp3;*wav";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                muzica = open.FileName;
                txtName.Text = open.SafeFileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rdbShutdown.Checked == true)
            {
                frm2.ShowDialog();
            }
            else if (rdbAlarm.Checked == true)
            {
                frm3.ShowDialog();
            }
        }
        public static string Getclock = "";
        public static void getTime(string time)
        {
            Form1.Getclock = time;
            bools = false;
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rdbAlarm.Checked == true)
            {
                if (Getclock == label1.Text)
                {

                    if (bools == false)
                    {
                        bools = true;
                        axWindowsMediaPlayer1.URL = muzica;

                        MessageBox.Show("ตื่นๆๆๆๆๆๆ");
                    }

                }
            }
            else if (rdbShutdown.Checked == true)
            {
                if (Getclock == label1.Text)
                {

                    if (bools == false)
                    {
                        bools = true;
                        Process.Start("shutdown", "/s /t 1");
                    }

                }
            }
        }

        
    }
}
