using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFG_BD_XML;

namespace Banco2_Server
{
    static class ConfiguracaoDAO
    {
        public static int Insere(ConfiguracaoVO vo)
        {
            throw new InvalidOperationException("É proibido inserir uma configuração!");
        }

        public static int Altera(ConfiguracaoVO vo)
        {
            String sql = "update " + CONSTANTES.TABELAS.CONFIGURACAO + " set " +
                CONSTANTES.CONFIGURACAO.CFG_TCPIP_IP + "=" + vo.Cfg_Tcpip_Ip + "," +
                CONSTANTES.CONFIGURACAO.CFG_TCPIP_PRT + "=" + vo.Cfg_Tcpip_Prt;
            return BD_SQL.ExecutaSQL(sql);
        }

        public static int Exclui(ConfiguracaoVO vo)
        {
            throw new InvalidOperationException("É proibido deletar uma configuração!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ConfiguracaoVO Consulta()
        {
            ConfiguracaoVO retorno = new ConfiguracaoVO();
            String sql = "select " + CONSTANTES.CONFIGURACAO.CFG_TCPIP_IP + "," +
                CONSTANTES.CONFIGURACAO.CFG_TCPIP_PRT + " from " + CONSTANTES.TABELAS.CONFIGURACAO;
            retorno = MontaVO(BD_SQL.ExecutaSelect(sql).Rows[0]);
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public static ConfiguracaoVO MontaVO(DataRow registro)
        {
            return new ConfiguracaoVO
            {
                Cfg_Tcpip_Ip = registro[CONSTANTES.CONFIGURACAO.CFG_TCPIP_IP].ToString(),
                Cfg_Tcpip_Prt = (int)registro[CONSTANTES.CONFIGURACAO.CFG_TCPIP_PRT]
            };
        }
    }
}
