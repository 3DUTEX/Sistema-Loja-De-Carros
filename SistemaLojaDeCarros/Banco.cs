﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}