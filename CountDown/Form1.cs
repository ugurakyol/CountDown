using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class Form1 : Form
    {
        DateTime MstartTime;
        DateTime durationtime = DateTime.Parse("00:02:00");
        Boolean isrunning = false;
        int saniye=1;
        public Form1()
        {
            InitializeComponent();

            labelDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            labelDate.TextAlign = ContentAlignment.TopRight;
            MstartTime = DateTime.Now;
            labelHour.Text = DateTime.Now.ToString("HH:mm:ss");
            textBoxSure.Text = durationtime.ToString("HH:mm");
            timer1 = new Timer();
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.ToString("HH:mm:ss");
            //TimeSpan time = DateTime.Now.Subtract(MstartTime);
            //labeltimepassed.Text = time.ToString(@"hh\:mm\:ss");
            if (isrunning)
            {
                if (saniye != DateTime.Now.Second)
                {
                    labelduration.Text = DateTime.Parse(labelduration.Text).Subtract(DateTime.Parse("00:00:01")).ToString(@"hh\:mm\:ss");
                    //Console.WriteLine(DateTime.Parse(labelduration.Text).Second);
                    saniye = DateTime.Now.Second;
                }


                if (DateTime.Parse(labelduration.Text) <= DateTime.Parse("00:00:15"))
                {
                    labelduration.ForeColor = Color.Red;

                    if (labelduration.Visible)
                    {
                        labelduration.Visible = false;
                    }
                    else
                    {
                        labelduration.Visible = true;
                    } 
                }
                if (labelduration.Text == "00:00:00")
                {
                    isrunning = false;
                    playaudio();
                    //SystemSounds.Hand.Play();
                    labelduration.Visible = true;
                    labelduration.ForeColor = Color.White;
                }
                    
                
            }

        }

        private void playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(CountDown.Properties.Resources.alert); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelduration.Visible = true;
            isrunning = false;
            labelduration.Text = "00:00:00";

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            labelduration.Visible = true;
            isrunning = true;
            if (labelduration.Text == "00:00:00") labelduration.Text = durationtime.ToString("HH:mm:ss");

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            labelduration.Visible = true;
            isrunning = false;

        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            labelduration.Visible = true;
            labelduration.Text = DateTime.Parse(labelduration.Text).AddMinutes(1).ToString("HH:mm:ss");
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (textBoxSure.Visible)
            {
                textBoxSure.Visible = false;
                btnSetDuration.Visible = false;
            }
            else
            {
                textBoxSure.Visible = true;
                btnSetDuration.Visible = true;
            }
        }

        private void btnSetDuration_Click(object sender, EventArgs e)
        {
            durationtime = DateTime.Parse(textBoxSure.Text);
        }
    }
}
