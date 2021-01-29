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
    public partial class Test2_10 : Form
    {
        public Test2_10()
        {
            InitializeComponent();
        }
        public int TimerTick = 60;
        private void Test2_10_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = (--TimerTick).ToString();
            if (TimerTick == 0)
            {
                timer1.Stop();
                TestingInfo TestingInfo = new TestingInfo();
                TestingInfo.info(TestingInfo.Score);
                TestingInfo.EndTesting("Навыки работы с программой ZOOM");
                this.Close();
            }
        }

        private void DateTestingButton_Click(object sender, EventArgs e)
        {
            TestingInfo TestingInfo = new TestingInfo();
            TestingInfo.info(TestingInfo.Score);
            TestingInfo.EndTesting("Навыки работы с программой ZOOM");
            this.Close();
        }

        private void StartTesting_Click(object sender, EventArgs e)
        {
            TestingInfo TestingInfo = new TestingInfo();
            TestingInfo.info(TestingInfo.Score);
            TestingInfo.EndTesting("Навыки работы с программой ZOOM");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestingInfo TestingInfo = new TestingInfo();
            TestingInfo.Score++;
            TestingInfo.info(TestingInfo.Score);
            TestingInfo.EndTesting("Навыки работы с программой ZOOM");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestingInfo TestingInfo = new TestingInfo();
            TestingInfo.info(TestingInfo.Score);
            TestingInfo.EndTesting("Навыки работы с программой ZOOM");
            this.Close();
        }
    }
}
