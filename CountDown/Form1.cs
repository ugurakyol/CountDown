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
        //DateTime MstartTime;
        DateTime durationtime = DateTime.Parse("00:02:00");
        Boolean isrunning = false;
        int saniye=1;
        private readonly Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private readonly Dictionary<Control, float> originalFontSizes = new Dictionary<Control, float>();
        private Size originalClientSize;

        public Form1()
        {
            InitializeComponent();

            labelDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            labelDate.TextAlign = ContentAlignment.TopRight;
            //MstartTime = DateTime.Now;
            labelHour.Text = DateTime.Now.ToString("HH:mm:ss");
            //textBoxSure.Text = durationtime.ToString("HH:mm");            
            dateTimePicker1.Value = durationtime;
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.MouseWheel += new MouseEventHandler(dateTimePicker1_MouseWheel);
            dateTimePicker1.KeyDown += new KeyEventHandler(dateTimePicker1_KeyDown);
            dateTimePicker1.GotFocus += new EventHandler(dateTimePicker1_GotFocus);
            timer1 = new Timer
            {
                Interval = 500
            };
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;
            BackgroundImageLayout = ImageLayout.Stretch;

            InitializeResponsiveLayout();


        }

        private void InitializeResponsiveLayout()
        {
            originalClientSize = ClientSize;
            StoreOriginalLayout(this);
            Resize += Form1_Resize;
        }

        private void StoreOriginalLayout(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                originalControlBounds[control] = control.Bounds;
                originalFontSizes[control] = control.Font.Size;

                if (control.HasChildren)
                {
                    StoreOriginalLayout(control);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (originalClientSize.Width == 0 || originalClientSize.Height == 0)
            {
                return;
            }

            float scaleX = (float)ClientSize.Width / originalClientSize.Width;
            float scaleY = (float)ClientSize.Height / originalClientSize.Height;
            float scale = Math.Min(scaleX, scaleY);
            int offsetX = (int)Math.Round((ClientSize.Width - (originalClientSize.Width * scale)) / 2f);
            int offsetY = (int)Math.Round((ClientSize.Height - (originalClientSize.Height * scale)) / 2f);

            SuspendLayout();
            ResizeControls(this, scale, offsetX, offsetY);
            ResumeLayout();
        }

        private void ResizeControls(Control parent, float scale, int offsetX, int offsetY)
        {
            foreach (Control control in parent.Controls)
            {
                Rectangle originalBounds = originalControlBounds[control];
                float originalFontSize = originalFontSizes[control];

                control.Location = new Point(
                    offsetX + (int)Math.Round(originalBounds.X * scale),
                    offsetY + (int)Math.Round(originalBounds.Y * scale));

                if (!control.AutoSize)
                {
                    control.Size = new Size(
                        Math.Max(1, (int)Math.Round(originalBounds.Width * scale)),
                        Math.Max(1, (int)Math.Round(originalBounds.Height * scale)));
                }

                float newFontSize = Math.Max(6f, originalFontSize * scale);
                if (Math.Abs(control.Font.Size - newFontSize) > 0.1f)
                {
                    control.Font = new Font(control.Font.FontFamily, newFontSize, control.Font.Style);
                }

                if (control.HasChildren)
                {
                    ResizeControls(control, scale, offsetX, offsetY);
                }
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
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
                    Playaudio();
                    //SystemSounds.Hand.Play();
                    labelduration.Visible = true;
                    labelduration.ForeColor = Color.White;
                }
                    
                
            }

        }

        private void Playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(CountDown.Properties.Resources.alert); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            labelduration.Visible = true;
            isrunning = false;
            labelduration.Text = "00:00:00";

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            labelduration.Visible = true;
            isrunning = true;
            if (labelduration.Text == "00:00:00") labelduration.Text = durationtime.ToString("HH:mm:ss");

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            labelduration.Visible = true;
            isrunning = false;

        }

        private void BtnAddTime_Click(object sender, EventArgs e)
        {
            labelduration.Visible = true;
            labelduration.Text = DateTime.Parse(labelduration.Text).AddMinutes(1).ToString("HH:mm:ss");
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnSetDuration.Visible)
            {
                //textBoxSure.Visible = false;
                dateTimePicker1.Value = durationtime;
                dateTimePicker1.Visible = false;
                btnSetDuration.Visible = false;
            }
            else
            {
                //textBoxSure.Visible = true;
                dateTimePicker1.Value = durationtime;
                dateTimePicker1.Visible = true;
                btnSetDuration.Visible = true;
            }
        }

        private void BtnSetDuration_Click(object sender, EventArgs e)
        {
            //durationtime = DateTime.Parse(textBoxSure.Text);
            durationtime = dateTimePicker1.Value;
        }


        void dateTimePicker1_GotFocus(object sender, EventArgs e)
        {
            SendKeys.Send("{right}");
        }


        void dateTimePicker1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(1);
            else
                dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(-1);
        }

        void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 38)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(1);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyValue == 40)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(-1);
                e.SuppressKeyPress = true;
            }
        }
    }
}
