using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaLojaDeCarros
{
    internal class Conexao
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Initial Catalog=bdpizzaria; User ID=root; Password=12345678");
        public static string msg;
        public MySqlConnection MyConnetarBD()
        {

            try
            {
                con.Open();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar: " + erro.Message;
            }
            return con;
        }

        public MySqlConnection MyDeConnectionBD()
        {
            try
            {
                con.Close();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se desconectar: " + erro.Message;
            }
            return con;
        }
    }
}