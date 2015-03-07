using CFG_BD_XML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    public class PerifericoDAO
    {
        public static int Insere(PerifericoVO vo)
        {
            String sql = "insert into " + CONSTANTES.TABELAS.PERIFERICO +
                "(" + CONSTANTES.PERIFERICO.PFE_COD + "," +
                CONSTANTES.PERIFERICO.PFE_NOM + "," +
                CONSTANTES.PERIFERICO.PFE_TIP + "," +
                CONSTANTES.PERIFERICO.PFE_TIP_COM + "," +
                CONSTANTES.PERIFERICO.PFE_IP + "," +
                CONSTANTES.PERIFERICO.PFE_PRT + "," +
                CONSTANTES.PERIFERICO.PFE_BAUD_RATE + "," +
                CONSTANTES.PERIFERICO.PFE_DATA_BITS + "," +
                CONSTANTES.PERIFERICO.PFE_PAR + "," +
                CONSTANTES.PERIFERICO.PFE_STOP_BITS + ")values('" +
                vo.Pfe_Cod + "','" + vo.Pfe_Nom + "'," + vo.Pfe_Tip + "," +
                vo.Pfe_Tip_Com + ",'" + vo.Pfe_IP + "'," + vo.Pfe_Prt + "," + vo.Pfe_Baud_Rate + "," +
                vo.Pfe_Data_Bits + "," + vo.Pfe_Par + "," + vo.Pfe_Stop_Bits + ")";
            return BD_SQL.ExecutaSQL(sql);
        }
        public static int Altera(PerifericoVO vo)
        {
            String sql = "update " + CONSTANTES.TABELAS.PERIFERICO + " set " +
                CONSTANTES.PERIFERICO.PFE_NOM + "='" + vo.Pfe_Nom + "'," +
                CONSTANTES.PERIFERICO.PFE_TIP + "=" + vo.Pfe_Tip + "," +
                CONSTANTES.PERIFERICO.PFE_TIP_COM + "=" + vo.Pfe_Tip_Com + "," +
                CONSTANTES.PERIFERICO.PFE_IP + "='" + vo.Pfe_IP + "'," +
                CONSTANTES.PERIFERICO.PFE_PRT + "=" + vo.Pfe_Prt + "," +
                CONSTANTES.PERIFERICO.PFE_BAUD_RATE + "=" + vo.Pfe_Baud_Rate + "," +
                CONSTANTES.PERIFERICO.PFE_DATA_BITS + "=" + vo.Pfe_Data_Bits + "," +
                CONSTANTES.PERIFERICO.PFE_PAR + "=" + vo.Pfe_Par + "," +
                CONSTANTES.PERIFERICO.PFE_STOP_BITS + "=" + vo.Pfe_Stop_Bits + "," +
                " where " + CONSTANTES.PERIFERICO.PFE_COD + "='" + vo.Pfe_Cod + "'";
            return BD_SQL.ExecutaSQL(sql);
        }
        public static int Exclui(PerifericoVO vo)
        {
            String sql = "delete from " + CONSTANTES.TABELAS.PERIFERICO +
                " where " + CONSTANTES.PERIFERICO.PFE_COD + "='" + vo.Pfe_Cod + "'";
            return BD_SQL.ExecutaSQL(sql);
        }
        public static PerifericoVO Consulta(String Pfe_Cod)
        {
            String sql = "select " +
                CONSTANTES.PERIFERICO.PFE_COD + "," +
                CONSTANTES.PERIFERICO.PFE_NOM + "," +
                CONSTANTES.PERIFERICO.PFE_TIP + "," +
                CONSTANTES.PERIFERICO.PFE_TIP_COM + "," +
                CONSTANTES.PERIFERICO.PFE_IP + "," +
                CONSTANTES.PERIFERICO.PFE_PRT + "," +
                CONSTANTES.PERIFERICO.PFE_BAUD_RATE + "," +
                CONSTANTES.PERIFERICO.PFE_DATA_BITS + "," +
                CONSTANTES.PERIFERICO.PFE_PAR + "," +
                CONSTANTES.PERIFERICO.PFE_STOP_BITS + " from " + CONSTANTES.TABELAS.PERIFERICO +
                " where " + CONSTANTES.PERIFERICO.PFE_COD + "='" + Pfe_Cod + "'";
            DataTable registro = BD_SQL.ExecutaSelect(sql);
            if (registro.Rows.Count == 1)
                return MontaVO(registro.Rows[0]);
            return null;
        }
        public static List<PerifericoVO> Listar()
        {
            String sql = "select " +
                CONSTANTES.PERIFERICO.PFE_COD + "," +
                CONSTANTES.PERIFERICO.PFE_NOM + "," +
                CONSTANTES.PERIFERICO.PFE_TIP + "," +
                CONSTANTES.PERIFERICO.PFE_TIP_COM + "," +
                CONSTANTES.PERIFERICO.PFE_IP + "," +
                CONSTANTES.PERIFERICO.PFE_PRT + "," +
                CONSTANTES.PERIFERICO.PFE_BAUD_RATE + "," +
                CONSTANTES.PERIFERICO.PFE_DATA_BITS + "," +
                CONSTANTES.PERIFERICO.PFE_PAR + "," +
                CONSTANTES.PERIFERICO.PFE_STOP_BITS + " from " + CONSTANTES.TABELAS.PERIFERICO;
            List<PerifericoVO> retorno = new List<PerifericoVO>();
            DataTable consulta = BD_SQL.ExecutaSelect(sql);
            foreach (DataRow registro in consulta.Rows)
                retorno.Add(MontaVO(registro));
            return retorno;
        }
        public static PerifericoVO MontaVO(DataRow registro)
        {
            PerifericoVO retorno = new PerifericoVO();
            retorno.Pfe_Cod = registro[CONSTANTES.PERIFERICO.PFE_COD].ToString();
            retorno.Pfe_Nom = registro[CONSTANTES.PERIFERICO.PFE_NOM].ToString();
            retorno.Pfe_Tip = (int)registro[CONSTANTES.PERIFERICO.PFE_TIP];
            retorno.Pfe_Tip_Com = (int)registro[CONSTANTES.PERIFERICO.PFE_TIP_COM];
            retorno.Pfe_IP = registro[CONSTANTES.PERIFERICO.PFE_IP].ToString();
            retorno.Pfe_Prt = (int)registro[CONSTANTES.PERIFERICO.PFE_PRT];
            retorno.Pfe_Baud_Rate = (int)registro[CONSTANTES.PERIFERICO.PFE_BAUD_RATE];
            retorno.Pfe_Data_Bits = (int)registro[CONSTANTES.PERIFERICO.PFE_DATA_BITS];
            retorno.Pfe_Par = (int)registro[CONSTANTES.PERIFERICO.PFE_PAR];
            retorno.Pfe_Stop_Bits = (int)registro[CONSTANTES.PERIFERICO.PFE_STOP_BITS];
            return retorno;
        }
    }
}
