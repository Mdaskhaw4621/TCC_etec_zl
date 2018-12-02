using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Conexao
    {
        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=bd_volta.accdb";
        public static OleDbConnection conn = null;

        public static OleDbConnection obterConexao()
        {
            conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                conn = null;
                MessageBox.Show("Conexão não Estabelecida!!" + e);
            }
            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
