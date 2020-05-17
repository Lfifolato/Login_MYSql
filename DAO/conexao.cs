using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login_sql.DAO
{
    public class conexao
    {
        #region Parãmetros De Conecxão

        private static string Server = "localhost";
        private static string DataBase = "web_session";
        private static string User = "root";
        private static string Passoword = "root";
        private static string connectionString = $@"Server={Server};Database={DataBase};
                                Uid={User};Pwd={Passoword};SslMode=none;charset=utf8;";


        public static MySqlConnection connection = new MySqlConnection(connectionString);


        #endregion

        #region Conectar
        public static void Conectar()
        {

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();

            }

        }
        #endregion

        #region Desconectar 

        public static void Desconectar()
        {

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }

        #endregion

    }
}