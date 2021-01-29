using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace EOPDTiPKP
{
    class TestingInfo
    {
        public static int Score = 0;

        public void clear()
        {
            Score = 0;
        }

        public void EndTesting(string nameSpec)
        {
            //объявление класса DB
            DB db = new DB();
            //Открытие соединения
            db.OpenConnection();

            //объявление виртуальной таблицы
            DataTable table = new DataTable();

            //Объявление адаптера
            MySqlDataAdapter adapter = new MySqlDataAdapter();


            //Узнать дату и время на устройстве
            string TimeforDB = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
            //Выполнение sql команды для поиска совместимых значений

            MySqlCommand command = new MySqlCommand("INSERT INTO `eopdtipkp`.`resulttesting` (`NameTesting`, `UserID`, `Score`, `TimeResult`) VALUES (@NameTest, @UsID, @Scoree, @TimeRes);", db.GetConnection());
            //добавление "заглушек"
            command.Parameters.Add("@NameTest", MySqlDbType.VarChar).Value = nameSpec;
            command.Parameters.Add("@UsID", MySqlDbType.VarChar).Value = DB.IDUser;
            command.Parameters.Add("@Scoree", MySqlDbType.VarChar).Value = TestingInfo.Score.ToString() + "/10" ;
            command.Parameters.Add("@TimeRes", MySqlDbType.VarChar).Value = TimeforDB;

            //Проверка на отправку данных
            if (command.ExecuteNonQuery() == 1)
            {
                //Прекрасно!
            }
            else
            {
                MessageBox.Show(
                "Результаты тестирования не были отправлены! Проверьте подключение к интернету",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            //Закрытие соединения
            db.CloseConnection();
        }

        public void info(int Score)
        {
            if (Score == 10)
            {
                MessageBox.Show("Тест выполнен идеально!");
            }
            else if (Score == 9)
            {
                MessageBox.Show("Тестирование пройдено хорошо, для достижения лучшего результата советуем повторить рекомендуемые материалы");
            }
            else if (Score == 8)
            {
                MessageBox.Show("Тестирование пройдено хорошо, для достижения лучшего результата советуем повторить рекомендуемые материалы");
            }
            else if (Score == 7)
            {
                MessageBox.Show("Тестирование пройдено удовлетворительно, настоятельно советуем повторить рекомендуемые материалы");
            }
            else if (Score == 6)
            {
                MessageBox.Show("Тестирование пройдено удовлетворительно, настоятельно советуем повторить рекомендуемые материалы");
            }
            else if (Score == 5)
            {
                MessageBox.Show("Тестирование пройдено удовлетворительно, настоятельно советуем повторить рекомендуемые материалы");
            }
            else if (Score == 4)
            {
                MessageBox.Show("Тестирование пройдено неудовлетворительно, советуем ознакомиться с рекомендуемыми материалами");
            }
            else if (Score == 3)
            {
                MessageBox.Show("Тестирование пройдено неудовлетворительно, советуем ознакомиться с рекомендуемыми материалами");
            }
            else if (Score == 2)
            {
                MessageBox.Show("Тестирование пройдено неудовлетворительно, советуем ознакомиться с рекомендуемыми материалами");
            }
            else if (Score == 1)
            {
                MessageBox.Show("Тестирование пройдено неудовлетворительно, советуем ознакомиться с рекомендуемыми материалами");
            }
            else if (Score == 0)
            {
                MessageBox.Show("Вы не прошли тестирование, советуем ознакомиться с рекомендуемыми материалами");
            }
        }
    }
}
