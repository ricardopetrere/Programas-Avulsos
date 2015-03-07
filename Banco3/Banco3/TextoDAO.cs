using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFG_BD_XML;

namespace Banco3
{
    public static class TextoDAO
    {
        public static TextoVO Consulta(int tex_num)
        {
            String sql = "select " + CONSTANTES.TEXTO.TEX_NUM + "," +
                CONSTANTES.TEXTO.TEX_TEX + "," + CONSTANTES.TEXTO.TEX_REF +
                " from " + CONSTANTES.TABELAS.TEXTO +
                " where " + CONSTANTES.TEXTO.TEX_NUM + "=" + tex_num;
            DataTable consulta = BD_SQL.ExecutaSelect(sql);
            if (consulta.Rows.Count == 1)
                return MontaVO(consulta.Rows[0]);
            return null;
        }
        public static TextoVO MontaVO(DataRow registro)
        {
            TextoVO retorno = new TextoVO();
            retorno.Tex_Num = (int)registro[CONSTANTES.TEXTO.TEX_NUM];
            retorno.Tex_Tex = registro[CONSTANTES.TEXTO.TEX_TEX].ToString();
            retorno.Tex_Ref = (int)registro[CONSTANTES.TEXTO.TEX_REF];
            return retorno;
        }
    }
}