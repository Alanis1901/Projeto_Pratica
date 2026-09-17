using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//O banco utilizado foi o MySQL.

namespace Projeto_Pratica
{
    internal class Banco
    {
        public static MySqlConnection Abrir()
        {
            string strCnn = "Server=localhost;Database=bancofolha;User ID=root;Password=Alanis!123;";

            MySqlConnection conn = new MySqlConnection(strCnn);
            conn.Open();
            return conn;
        }
    }
}
