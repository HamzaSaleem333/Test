using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player;
System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void setTime_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player =  new System.Media.SoundPlayer(@"C:\Users\Taha\Desktop\Twin-bell-alarm-clock-ringing-short.wav");
            

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {    DateTime currentTime =DateTime.Now;
            DateTime datePickerTime=dateTimePicker1.Value;
             if(currentTime.Hour== datePickerTime.Hour&&
                currentTime.Minute==datePickerTime.Minute&&
                currentTime.Second==datePickerTime.Second)
            {
                MessageBox.Show("Alarm!");

                //player.PlayLooping();
                timer.Stop();
            }
        }
    }
}
