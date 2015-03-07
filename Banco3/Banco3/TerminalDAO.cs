using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFG_BD_XML;

namespace Banco3
{
    public class TerminalDAO
    {
        public static int Insere(TerminalVO vo)
        {
            String sql = "insert into " + CONSTANTES.TABELAS.TERMINAL +
                "(" + CONSTANTES.TERMINAL.TRM_IDT + "," +
                CONSTANTES.TERMINAL.TRM_NOM + "," +
                CONSTANTES.TERMINAL.TRM_DMN + "," +
                CONSTANTES.TERMINAL.TRM_TIP + "," +
                CONSTANTES.TERMINAL.PFE_COD1 + "," +
                CONSTANTES.TERMINAL.PFE_COD2 + "," +
                CONSTANTES.TERMINAL.PFE_COD3 + "," +
                CONSTANTES.TERMINAL.PFE_COD4 + "," +
                CONSTANTES.TERMINAL.PFE_COD5 + "," +
                CONSTANTES.TERMINAL.PFE_COD6 + "," +
                CONSTANTES.TERMINAL.PFE_COD7 + "," +
                CONSTANTES.TERMINAL.PFE_COD8 + ")values(" +
                vo.Trm_Idt + ",'" + vo.Trm_Nom + "','" + vo.Trm_Dmn + "'," + vo.Trm_Tip + ",'" +
                vo.Pfe_Cod1 + "','" + vo.Pfe_Cod2 + "','" + vo.Pfe_Cod3 + "','" + vo.Pfe_Cod4 + "','" +
                vo.Pfe_Cod5 + "','" + vo.Pfe_Cod6 + "','" + vo.Pfe_Cod7 + "','" + vo.Pfe_Cod8 + "')";
            return BD_SQL.ExecutaSQL(sql);
        }
        public static int Altera(TerminalVO vo)
        {
            String sql = "update " + CONSTANTES.TABELAS.TERMINAL + " set " +
                CONSTANTES.TERMINAL.TRM_NOM + "='" + vo.Trm_Nom + "'," +
                CONSTANTES.TERMINAL.TRM_DMN + "='" + vo.Trm_Dmn + "'," +
                CONSTANTES.TERMINAL.TRM_TIP + "=" + vo.Trm_Tip + "," +
                CONSTANTES.TERMINAL.PFE_COD1 + "='" + vo.Pfe_Cod1 + "'," +
                CONSTANTES.TERMINAL.PFE_COD2 + "='" + vo.Pfe_Cod2 + "'," +
                CONSTANTES.TERMINAL.PFE_COD3 + "='" + vo.Pfe_Cod3 + "'," +
                CONSTANTES.TERMINAL.PFE_COD4 + "='" + vo.Pfe_Cod4 + "'," +
                CONSTANTES.TERMINAL.PFE_COD5 + "='" + vo.Pfe_Cod5 + "'," +
                CONSTANTES.TERMINAL.PFE_COD6 + "='" + vo.Pfe_Cod6 + "'," +
                CONSTANTES.TERMINAL.PFE_COD7 + "='" + vo.Pfe_Cod7 + "'," +
                CONSTANTES.TERMINAL.PFE_COD8 + "='" + vo.Pfe_Cod8 + "'," +
                " where " + CONSTANTES.TERMINAL.TRM_IDT + "=" + vo.Trm_Idt;
            return BD_SQL.ExecutaSQL(sql);
        }
        public static int Exclui(TerminalVO vo)
        {
            String sql = "delete from " + CONSTANTES.TABELAS.TERMINAL +
                " where " + CONSTANTES.TERMINAL.TRM_IDT + "=" + vo.Trm_Idt;
            return BD_SQL.ExecutaSQL(sql);
        }
        public static TerminalVO Consulta(int Trm_Idt)
        {
            String sql = "select " + CONSTANTES.TERMINAL.TRM_IDT + "," +
                CONSTANTES.TERMINAL.TRM_NOM + "," +
                CONSTANTES.TERMINAL.TRM_DMN + "," +
                CONSTANTES.TERMINAL.TRM_TIP + "," +
                CONSTANTES.TERMINAL.PFE_COD1 + "," +
                CONSTANTES.TERMINAL.PFE_COD2 + "," +
                CONSTANTES.TERMINAL.PFE_COD3 + "," +
                CONSTANTES.TERMINAL.PFE_COD4 + "," +
                CONSTANTES.TERMINAL.PFE_COD5 + "," +
                CONSTANTES.TERMINAL.PFE_COD6 + "," +
                CONSTANTES.TERMINAL.PFE_COD7 + "," +
                CONSTANTES.TERMINAL.PFE_COD8 + " from " + CONSTANTES.TABELAS.TERMINAL +
                " where " + CONSTANTES.TERMINAL.TRM_IDT + "=" + Trm_Idt;
            DataTable registro = BD_SQL.ExecutaSelect(sql);
            if (registro.Rows.Count == 1)
                return MontaVO(registro.Rows[0]);
            return null;
        }
        public static TerminalVO Consulta(String Trm_Dmn)
        {
            String sql = "select " + CONSTANTES.TERMINAL.TRM_IDT + "," +
                CONSTANTES.TERMINAL.TRM_NOM + "," +
                CONSTANTES.TERMINAL.TRM_DMN + "," +
                CONSTANTES.TERMINAL.TRM_TIP + "," +
                CONSTANTES.TERMINAL.PFE_COD1 + "," +
                CONSTANTES.TERMINAL.PFE_COD2 + "," +
                CONSTANTES.TERMINAL.PFE_COD3 + "," +
                CONSTANTES.TERMINAL.PFE_COD4 + "," +
                CONSTANTES.TERMINAL.PFE_COD5 + "," +
                CONSTANTES.TERMINAL.PFE_COD6 + "," +
                CONSTANTES.TERMINAL.PFE_COD7 + "," +
                CONSTANTES.TERMINAL.PFE_COD8 + " from " + CONSTANTES.TABELAS.TERMINAL +
                " where " + CONSTANTES.TERMINAL.TRM_DMN + "='" + Trm_Dmn + "'";
            DataTable registro = BD_SQL.ExecutaSelect(sql);
            if (registro.Rows.Count == 1)
                return MontaVO(registro.Rows[0]);
            return null;
        }
        public static List<TerminalVO> Listar()
        {
            String sql = "select " + CONSTANTES.TERMINAL.TRM_IDT + "," +
                CONSTANTES.TERMINAL.TRM_NOM + "," +
                CONSTANTES.TERMINAL.TRM_DMN + "," +
                CONSTANTES.TERMINAL.TRM_TIP + "," +
                CONSTANTES.TERMINAL.PFE_COD1 + "," +
                CONSTANTES.TERMINAL.PFE_COD2 + "," +
                CONSTANTES.TERMINAL.PFE_COD3 + "," +
                CONSTANTES.TERMINAL.PFE_COD4 + "," +
                CONSTANTES.TERMINAL.PFE_COD5 + "," +
                CONSTANTES.TERMINAL.PFE_COD6 + "," +
                CONSTANTES.TERMINAL.PFE_COD7 + "," +
                CONSTANTES.TERMINAL.PFE_COD8 + " from " + CONSTANTES.TABELAS.TERMINAL;
            List<TerminalVO> retorno = new List<TerminalVO>();
            DataTable consulta = BD_SQL.ExecutaSelect(sql);
            foreach (DataRow registro in consulta.Rows)
                retorno.Add(MontaVO(registro));
            return retorno;
        }
        public static TerminalVO MontaVO(DataRow registro)
        {
            TerminalVO retorno = new TerminalVO();
            retorno.Trm_Idt = (int)registro[CONSTANTES.TERMINAL.TRM_IDT];
            retorno.Trm_Nom = registro[CONSTANTES.TERMINAL.TRM_NOM].ToString();
            retorno.Trm_Dmn = registro[CONSTANTES.TERMINAL.TRM_DMN].ToString();
            retorno.Trm_Tip = (int)registro[CONSTANTES.TERMINAL.TRM_TIP];
            retorno.Pfe_Cod1 = registro[CONSTANTES.TERMINAL.PFE_COD1].ToString();
            retorno.Pfe_Cod2 = registro[CONSTANTES.TERMINAL.PFE_COD2].ToString();
            retorno.Pfe_Cod3 = registro[CONSTANTES.TERMINAL.PFE_COD3].ToString();
            retorno.Pfe_Cod4 = registro[CONSTANTES.TERMINAL.PFE_COD4].ToString();
            retorno.Pfe_Cod5 = registro[CONSTANTES.TERMINAL.PFE_COD5].ToString();
            retorno.Pfe_Cod6 = registro[CONSTANTES.TERMINAL.PFE_COD6].ToString();
            retorno.Pfe_Cod7 = registro[CONSTANTES.TERMINAL.PFE_COD7].ToString();
            retorno.Pfe_Cod8 = registro[CONSTANTES.TERMINAL.PFE_COD8].ToString();
            return retorno;
        }
    }
}
