using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco3
{
    namespace CONSTANTES
    {
        public enum MENSAGENS
        {
            DESEJA_CONFIGURAR_ACESSO_BANCO
        }
        public static class TABELAS
        {
            public const String TERMINAL = "Terminal";
            public const String PERIFERICO = "Periferico";
            public const String TERMINAL_PERIFERICO = "TerminalPeriferico";
            public const String TEXTO = "Texto";
        }
        public static class TERMINAL
        {
            public const String TRM_IDT = "Trm_Idt";
            public const String TRM_DMN = "Trm_Dmn";
            public const String TRM_NOM = "Trm_Nom";
            public const String TRM_TIP = "Trm_Tip";
            public const String PFE_COD1 = "Pfe_Cod1";
            public const String PFE_COD2 = "Pfe_Cod2";
            public const String PFE_COD3 = "Pfe_Cod3";
            public const String PFE_COD4 = "Pfe_Cod4";
            public const String PFE_COD5 = "Pfe_Cod5";
            public const String PFE_COD6 = "Pfe_Cod6";
            public const String PFE_COD7 = "Pfe_Cod7";
            public const String PFE_COD8 = "Pfe_Cod8";

            public enum TIPOS { PC };
        }
        public static class PERIFERICO
        {
            public const String PFE_COD = "Pfe_Cod";
            public const String PFE_NOM = "Pfe_Nom";
            public const String PFE_TIP = "Pfe_Tip";
            public const String PFE_TIP_COM = "Pfe_Tip_Com";
            public const String PFE_IP = "Pfe_IP";
            public const String PFE_PRT = "Pfe_Prt";
            public const String PFE_BAUD_RATE = "Pfe_Baud_Rate";
            public const String PFE_DATA_BITS = "Pfe_Data_Bits";
            public const String PFE_PAR = "Pfe_Par";
            public const String PFE_STOP_BITS = "Pfe_Stop_Bits";

            public enum TIPOS { LEITOR, ETIQUETADOR, BALANÇA };
            public enum TIPOS_COMUNICACAO { SERIAL, ETHERNET };
            public enum PARIDADES { PAR, IMPAR, NENHUM };
        }
        public static class TERMINALPERIFERICO
        {
            public const String TRM_IDT = "Trm_Idt";
            public const String PFE_COD = "Pfe_Cod";
        }
        public static class TEXTO
        {
            public const String TEX_NUM = "Tex_Num";
            public const String TEX_TEX = "Tex_Tex";
            public const String TEX_REF = "Tex_Ref";
        }
    }
}
