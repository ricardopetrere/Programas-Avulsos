using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Banco1
{
    class EstadoVO
    {
        private int est_cod;
        private String est_nom;
        
        public EstadoVO(int est_cod, String est_nom)
        {
            Est_cod = est_cod;
            Est_nom = est_nom;
        }

        public int Est_cod
        {
          get { return est_cod; }
          set { est_cod = value; }
        }

        public String Est_nom
        {
          get { return est_nom; }
          set { est_nom = value; }
        }
    }
    static class EstadoDAO
    {
        public static List<EstadoVO> ListarEstados()
        {
            List<EstadoVO> retorno = new List<EstadoVO>();
            String sql = "select est_cod,est_nom from Estado";
            DataTable temp = BD.ExecutaSelect(sql);
            foreach (DataRow linha in temp.Rows)
                retorno.Add(new EstadoVO(Convert.ToInt16(linha["est_cod"])
                    , linha["est_nom"].ToString()));
            return retorno;
        }
    }
}
