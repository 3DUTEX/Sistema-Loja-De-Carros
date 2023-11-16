using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLojaDeCarros
{
    public class Banco
    {
        Conexao con = new Conexao();

        public MySqlDataReader select(string strCmd)
        {

            MySqlCommand select = new MySqlCommand(strCmd, con.MyConnectarBD());

            return select.ExecuteReader();
        }

        public bool ExecuteNonQuery(string strCmd)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strCmd, con.MyConnectarBD());
                cmd.ExecuteNonQuery();
                con.MyDesConnectionBD();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public string ExecuteScalar(string strCmd)
        {
            string resultScalar = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand(strCmd, con.MyConnectarBD());
                resultScalar = cmd.ExecuteScalar().ToString();
                con.MyDesConnectionBD();
            }
            catch (Exception ex)
            {
                Util.exibeErro(ex.Message);
            }

            return resultScalar;
        }

        public DataTable selectDataTable(string strCmd)
        {
            try
            {
                con.MyConnectarBD();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strCmd;

                cmd.Connection = con.MyConnectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.MyDesConnectionBD();

                return dt;
            }
            catch (Exception ex)
            {
                Util.exibeErro(ex.Message);
                return null;
            }
        }
    }
}
