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

        private void AvailableQua_Button_Click(object sender, EventArgs e)
        {
            AvailableQuaForm AvaForm = new AvailableQuaForm();
            AvaForm.Show();
        }

        private void SendQua_Button_Click(object sender, EventArgs e)
        {
            QuaSendForm QuaSendF = new QuaSendForm();
            QuaSendF.Show();
        }

        private void HaveQua_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Вы ещё не получили ни одной спецификации!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void DateTestingButton_Click(object sender, EventArgs e)
        {
            TestingViewForm TestViewForm = new TestingViewForm();
            TestViewForm.Show();
        }
    }
}
