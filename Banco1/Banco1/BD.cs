using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco1
{
    static class BD
    {
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(ReadBDXML());
            conn.Open();
            return conn;
        }

        private static string ReadBDXML()
        {
            return "Data Source=localhost;Initial Catalog=Banco1;User ID=sa;Password=123";
            //Data Source=localhost;Initial Catalog=Banco1;Persist Security Info=True;User ID=sa;Password=123
        }

        public static string GetTexto(int tex_cod)
        {
            String sql = String.Format("select tex_tex from Texto where tex_cod = {0}", tex_cod);
            return ExecutaSelect(sql).Rows[0]["tex_tex"].ToString();
        }

        public static int ExecutaSQL(String sql)
        {
            SqlConnection c = getConnection();
            int r = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, c);
                r = int.Parse(cmd.ExecuteScalar().ToString());
            }
            finally
            {
                c.Close();
            }
            return r;
        }

        public static DataTable ExecutaSelect(String sql)
        {
            SqlConnection c = getConnection();
            DataTable retorno = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c);
                adapter.Fill(retorno);
            }
            finally
            {
                c.Close();
            }
            return retorno;
        }

        
    }
}
