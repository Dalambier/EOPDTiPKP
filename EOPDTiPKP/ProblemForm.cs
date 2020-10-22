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
    public partial class ProblemForm : Form
    {
        public ProblemForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //Узнать дату и время на устройстве
            string TimeforDB = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");

            //объявление класса DB
            DB db = new DB();
            //Выполнение sql команды для ввода значений в таблицу
            MySqlCommand command = new MySqlCommand("INSERT INTO `eopdtipkp`.`problemdata` (`FirstName`, `LastName`, `Email`, `Description`, `TimeSending`) VALUES (@FName, @LName, @Email, @Dscrp, @Time);", db.GetConnection());
            command.Parameters.Add("@FName", MySqlDbType.VarChar).Value = FirstNameField.Text;
            command.Parameters.Add("@LName", MySqlDbType.VarChar).Value = LastNameField.Text;
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailField.Text;
            command.Parameters.Add("@Dscrp", MySqlDbType.VarChar).Value = DescriptoinField.Text;
            command.Parameters.Add("@Time", MySqlDbType.VarChar).Value = TimeforDB;

            //Открытие соединения
            db.OpenConnection();

            //Проверка на отправку данных
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(
                "Заявка успешно отправлена!",
                "Отлично",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                "Заявка не была отправлена! Проверьте подключение к интернету",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            //Закрытие соединения
            db.CloseConnection();
        }
    }
}
