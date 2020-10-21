using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EOPDTiPKP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String LoginUser = LoginField.Text;
            String PasswordUser = PasswordField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `teachers` WHERE `login` = @UsL AND `password` = @UsP", db.GetConnection());
            command.Parameters.Add("@UsL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@UsP", MySqlDbType.VarChar).Value = PasswordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Совпадение найдено");
                dataGridView1.DataSource = table;
                labelLogin.Text = dataGridView1[3, 0].Value.ToString();
            }
            else
            {
                DB.FirstName = "123";
                labelLogin.Text = DB.FirstName;
                MessageBox.Show(
                                "Не удаётся войти",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Information_Click(object sender, EventArgs e)
        {
            InformationForm I_Form = new InformationForm();
            I_Form.Show();
        }

        private void ProblemLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "При возникновений проблем к своему личному кабинету, обращаться к администратору",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
