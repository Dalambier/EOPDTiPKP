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

        [Obsolete]
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Объявление строк ввода логина и пароля, переменными
            String LoginUser = LoginField.Text;
            String PasswordUser = PasswordField.Text;

            //объявление класса DB
            DB db = new DB();
            //Открытие соединения
            db.OpenConnection();

            //объявление виртуальной таблицы
            DataTable table = new DataTable();

            //Объявление адаптера
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // Получение имени компьютера.
            String host = System.Net.Dns.GetHostName();
            // Получение ip-адреса.
            System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[0];

            //Узнать дату и время на устройстве
            string TimeforDB = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");

            //Выполнение sql команды для поиска совместимых значений
            MySqlCommand command = new MySqlCommand("SELECT * FROM `teachers` WHERE `login` = @UsL AND `password` = @UsP; INSERT INTO `eopdtipkp`.`logging` (`Login`, `Password`, `IpLog`, `TimeLog`) VALUES (@LoginLog, @passLog, @ipLog, @timeLog);", db.GetConnection()) ;
            //добавление "заглушек"
            command.Parameters.Add("@UsL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@UsP", MySqlDbType.VarChar).Value = PasswordUser;

            command.Parameters.Add("@LoginLog", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@passLog", MySqlDbType.VarChar).Value = PasswordUser;
            command.Parameters.Add("@ipLog", MySqlDbType.VarChar).Value = ip;
            command.Parameters.Add("@timeLog", MySqlDbType.VarChar).Value = TimeforDB;

            //Выбор выполняемой sql команды
            adapter.SelectCommand = command;
            //Заполнение таблицы
            adapter.Fill(table);

            //Ввод значений в таблицу
            //dataGridView1.DataSource = table;
            //labelPassword.Text = dataGridView1[3, 0].Value.ToString();

            //Проверка правильности введёных данных
            if (table.Rows.Count > 0)
            {
                //При нахождении совпадения
                MessageBox.Show("Совпадение найдено");
                dataGridView1.DataSource = table;
                DB.FirstName = dataGridView1[0, 0].Value.ToString();
                labelLogin.Text = DB.FirstName;

            }
            else
            {
                //При отсутствия совпадения в БД
                MessageBox.Show(
                                "Не удаётся войти",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void Information_Click(object sender, EventArgs e)
        {
            //Показ формы с информацией
            InformationForm I_Form = new InformationForm();
            I_Form.Show();
        }

        private void ProblemLogin_Click(object sender, EventArgs e)
        {
            //Показ формы с решением проблемы
            this.TopMost = false;
            ProblemForm P_form = new ProblemForm();
            P_form.ShowDialog();
            this.TopMost = true;
        }
    }
}
