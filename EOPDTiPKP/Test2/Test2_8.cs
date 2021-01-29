using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOPDTiPKP.Test2
{
    public partial class Test2_8 : Form
    {
        public Test2_8()
        {
            InitializeComponent();
        }
        public int TimerTick = 60;
        private void Test2_8_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = (--TimerTick).ToString();
            if (TimerTick < 0)
            {
                timer1.Stop();
                Test2_2 nexttext = new Test2_2();
                nexttext.Show();
                this.Close();
            }
        }

        private void DateTestingButton_Click(object sender, EventArgs e)
        {
            Test2_9 nexttext = new Test2_9();
            nexttext.Show();
            this.Close();
        }

        private void StartTesting_Click(object sender, EventArgs e)
        {
            TestingInfo TestingInfo = new TestingInfo();
            TestingInfo.Score++;
            Test2_9 nexttext = new Test2_9();
            nexttext.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test2_9 nexttext = new Test2_9();
            nexttext.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test2_9 nexttext = new Test2_9();
            nexttext.Show();
            this.Close();
        }
    }
}
