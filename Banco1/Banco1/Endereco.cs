using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco1
{
    class EnderecoVO
    {
        private int end_cod;
        private String end_rua;
        private int end_num;
        private String end_cpl;
        private String end_bro;
        private String end_cep;
        private CidadeVO cidade;

        public EnderecoVO(String end_rua,int end_num,String end_cpl,String end_bro,String end_cep,CidadeVO cidade)
        {
            End_rua = end_rua;
            End_num = end_num;
            End_cpl = end_cpl;
            End_bro = end_bro;
            End_cep = end_cep;
            Cidade = cidade;
        }

        public int End_cod
        {
            get { return end_cod; }
            set { end_cod = value; }
        }

        public String End_rua
        {
            get { return end_rua; }
            set { end_rua = value; }
        }

        public int End_num
        {
            get { return end_num; }
            set { end_num = value; }
        }

        public String End_cpl
        {
            get { return end_cpl; }
            set { end_cpl = value; }
        }

        public String End_bro
        {
            get { return end_bro; }
            set { end_bro = value; }
        }

        public String End_cep
        {
            get { return end_cep; }
            set { end_cep = value; }
        }

        public CidadeVO Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
    }
    static class EnderecoDAO
    {

    }
}
