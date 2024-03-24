using System;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        // Initialize hours,minutes and second
        int h = 0;
        int m = 0;
        int s = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // increment second and update time
            s++;
            if(s == 60)
            {
                s = 0;
                m++;
            }
            if(m == 60)
            {
                m = 0;
                h++;
            }
            if(h == 24)
            {
                h = 0;
            }
            UpdateTime();
        }
        private void UpdateTime()
        {
            // update labels with loading zeros
            labelHours.Text = h.ToString("00") + ":";
            labelMinutes.Text = m.ToString("00") + ":";
            labelSecond.Text = s.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // start stopwatch
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // stop stopwatch
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // reset stopwatch
            h = 0;
            m = 0;
            s = 0;
            timer1.Enabled = false;
            timer1.Stop();
            UpdateTime();
        }
    }
}
