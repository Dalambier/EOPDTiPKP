﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EOPDTiPKP
{
    class DB
    {
        //Подключение к базе данных
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;username=root;password=admin;database=eopdtipkp");
        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }
        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return Connection;
        }
        //Сохраняемые данные о пользователе
        public static string FirstName, LastName, MiddleName = "", IDUser;
    }
}
