using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco1
{
    class CidadeVO
    {
        private int cid_cod;
        private String cid_nom;
        private EstadoVO estado;

        public CidadeVO(int cid_cod, String cid_nom, EstadoVO estado)
        {
            Cid_cod = cid_cod;
            Cid_nom = cid_nom;
            Estado = estado;
        }

        public int Cid_cod
        {
            get { return cid_cod; }
            set { cid_cod = value; }
        }

        public String Cid_nom
        {
            get { return cid_nom; }
            set { cid_nom = value; }
        }

        internal EstadoVO Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
    static class CidadeDAO
    {
        public static List<CidadeVO> ListarCidades(int est_cod)
        {
            List<CidadeVO> retorno = new List<CidadeVO>();
            SqlCommand c = new SqlCommand("select cid_cod,cid_nom from cidade where est_cod = @p1", BD.getConnection());
            c.Parameters.AddWithValue("@p1", est_cod);
            DataTable temp = new DataTable();
            new SqlDataAdapter(c).Fill(temp);
            foreach (DataRow linha in temp.Rows)
                retorno.Add(new CidadeVO(Convert.ToInt32(linha["cid_cod"])
                    , linha["cid_nom"].ToString()
                    , new EstadoVO(est_cod, "")));
            c.Connection.Close();
            return retorno;
        }
    }
}
