﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOPDTiPKP.Test1
{
    public partial class Test1_7 : Form
    {
        public Test1_7()
        {
            InitializeComponent();
        }

        private void Test1_7_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
        public int TimerTick = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = (--TimerTick).ToString();
            if (TimerTick < 0)
            {
                timer1.Stop();
                Test1_8 nexttext = new Test1_8();
                nexttext.Show();
                this.Close();
            }
        }

        private void DateTestingButton_Click(object sender, EventArgs e)
        {
            Test1_8 nexttext = new Test1_8();
            nexttext.Show();
            this.Close();
        }

        private void StartTesting_Click(object sender, EventArgs e)
        {
            Test1_8 nexttext = new Test1_8();
            nexttext.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test1_8 nexttext = new Test1_8();
            nexttext.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestingInfo TestingInfo = new TestingInfo();
            TestingInfo.Score++;
            Test1_8 nexttext = new Test1_8();
            nexttext.Show();
            this.Close();
        }
    }
}
