using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Teste
    {
        public enum TesteEnum{A,B,C}
        public int Numero { get; set; }
        public String Texto { get; set; }
        public TesteEnum Enum { get; set; }
        public Teste()
        {
            new Teste(0, "", TesteEnum.A);
        }
        public Teste(int _numero,String _texto,TesteEnum _enum)
        {
            Numero = _numero;
            Texto = _texto;
            Enum = _enum;
        }
    }
}