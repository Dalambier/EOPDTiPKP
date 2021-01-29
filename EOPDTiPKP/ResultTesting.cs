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
    public partial class ResultTesting : Form
    {
        public ResultTesting()
        {
            InitializeComponent();
        }

        private void ResultTesting_Load(object sender, EventArgs e)
        {
            //объявление класса DB
            DB db = new DB();
            //Открытие соединения
            db.OpenConnection();

            //объявление виртуальной таблицы
            DataTable table = new DataTable();

            //Объявление адаптера
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //Выполнение sql команды для поиска совместимых значений
            MySqlCommand command = new MySqlCommand("SELECT NameTesting, Score, TimeResult FROM eopdtipkp.resulttesting WHERE UserID = @idU;", db.GetConnection());
            command.Parameters.Add("@idU", MySqlDbType.VarChar).Value = DB.IDUser;
            //Выбор выполняемой sql команды
            adapter.SelectCommand = command;
            //Заполнение таблицы
            adapter.Fill(table);
            //dataGridView1.DataSource = table;
            dataGridView1.DataSource = table;
        }
    }
}
