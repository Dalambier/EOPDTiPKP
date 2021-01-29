using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOPDTiPKP
{
    public partial class Recommend : Form
    {
        public Recommend()
        {
            InitializeComponent();
        }

        private void DateTestingButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://fgos.ru/");
        }

        private void StartTesting_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Федеральный_государственный_образовательный_стандарт_(Россия)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.consultant.ru/document/cons_doc_LAW_142304/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://fgosreestr.ru/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.zoom.us/hc/ru/articles/203650445-Чат-в-конференции");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://distant.itmo.ru/zoom_questions");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.zoom.us/ru/zoom-for-education-top-10-frequently-asked-questions/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://social.hse.ru/data/2020/03/27/1553734999/Инструкция%20по%20работе%20с%20Zoom%20для%20преподавателей.pdf");
        }
    }
}
