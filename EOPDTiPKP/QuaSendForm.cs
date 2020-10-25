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
    public partial class QuaSendForm : Form
    {
        public QuaSendForm()
        {
            InitializeComponent();
        }

        private void SendQua_Button_Click(object sender, EventArgs e)
        {
            //объявление класса DB
            DB db = new DB();
            //Выполнение sql команды для ввода значений в таблицу
            MySqlCommand command = new MySqlCommand("INSERT INTO `eopdtipkp`.`sending_qua` (`IdUser`, `IdQua`) VALUES (@IUser, @IQua);", db.GetConnection());
            command.Parameters.Add("@IUser", MySqlDbType.VarChar).Value = DB.IDUser;
            command.Parameters.Add("@IQua", MySqlDbType.VarChar).Value = IdQuaField.Text;

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
