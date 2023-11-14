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
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Initial Catalog=dbLojaDeCarros; User ID=root; Password=");
        public static string msg;
        public MySqlConnection MyConnectarBD()
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

        public MySqlConnection MyDesConnectionBD()
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