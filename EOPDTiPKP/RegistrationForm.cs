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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            //объявление класса DB
            DB db = new DB();
            //Выполнение sql команды для ввода значений в таблицу
            MySqlCommand command = new MySqlCommand("INSERT INTO `eopdtipkp`.`teachers` (`First_Name`, `Last_Name`, `Middle_Name`, `Login`, `Password`) VALUES (@FName, @LName, @MName, @Login, @Pass);", db.GetConnection());
            command.Parameters.Add("@FName", MySqlDbType.VarChar).Value = FirstNameField.Text;
            command.Parameters.Add("@LName", MySqlDbType.VarChar).Value = LastNameField.Text;
            command.Parameters.Add("@MName", MySqlDbType.VarChar).Value = MidleNameField.Text;
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PasswordField.Text;

            //Открытие соединения
            db.OpenConnection();

            //Проверка на отправку данных
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(
                "Аккаунт успешно зарегистрирован в системе!",
                "Отлично",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                "Аккаунт не был зарегистрирован! Проверьте подключение к интернету",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            //Закрытие соединения
            db.CloseConnection();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                {
                RegistrationButton.Enabled = true;
            }
            else
            {
                RegistrationButton.Enabled = false;
            }
        }
    }
}
