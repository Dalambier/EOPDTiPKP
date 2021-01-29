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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            NameLabel.Text = DB.FirstName + " " + DB.LastName + " " + DB.MiddleName;
            IDLabel.Text = DB.IDUser;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            HelperForm HelpForm = new HelperForm();
            HelpForm.ShowDialog();
        }

        private void DateTestingButton_Click(object sender, EventArgs e)
        {
            TestingViewForm TestViewForm = new TestingViewForm();
            TestViewForm.Show();
        }

        private void Test1_button_Click(object sender, EventArgs e)
        {
            Test1.Test1_1 Lest1 = new Test1.Test1_1();
            Lest1.Show();
        }

        private void Test_Results_Click(object sender, EventArgs e)
        {
            ResultTesting resTst = new ResultTesting();
            resTst.Show();
        }

        private void Test2_button_Click(object sender, EventArgs e)
        {
            Test2.Test2_1 Lest2 = new Test2.Test2_1();
            Lest2.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recommend rec = new Recommend();
            rec.Show();
        }
    }
}
