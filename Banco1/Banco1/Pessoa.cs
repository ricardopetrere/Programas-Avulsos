using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Banco1
{
    class PessoaVO
    {
        private int pes_cod;
        private String pes_nom;
        private int pes_ida;
        private EnderecoVO endereco;


        public PessoaVO(String pes_nom, int pes_ida, EnderecoVO endereco)
        {
            Pes_nom = pes_nom;
            Pes_ida = pes_ida;
            Endereco = endereco;
        }

        public int Pes_cod
        {
            get { return pes_cod; }
        }

        public String Pes_nom
        {
            get { return pes_nom; }
            set { pes_nom = value; }
        }

        public int Pes_ida
        {
            get { return pes_ida; }
            set { pes_ida = value; }
        }

        public EnderecoVO Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

    }

    static class PessoaDAO
    {
        /// <summary>
        /// Insere a pessoa (e seu endereço) no banco de dados
        /// Se for retornado pes_cod < 0, significa que deu falha
        /// </summary>
        /// <param name="p">Pessoa a ser inserida</param>
        /// <param name="pes_cod">Código da pessoa recém-inserida</param>
        /// <returns>Identificador de sucesso da inserção (13 - sucesso, 14 - falha)</returns>
        public static int Insert(PessoaVO p,out int pes_cod)
        {
            SqlCommand c = new SqlCommand("declare @p1 int,@p10 int\nset @p1 = 0\nset @p10 = 0" +
                "\nexec spInserePessoaEndereco @Pes_Cod=@p1 output,@Pes_nom=@p2,@Pes_ida=@p3" +
                ",@End_rua=@p4,@End_num=@p5,@End_cpl=@p6,@End_bro=@p7,@End_cep=@p8,@Cid_cod=@p9,@Msg=@p10 output\nselect @p1,@p10"
                , BD.getConnection());
            c.Parameters.AddWithValue("@p2", p.Pes_nom);
            c.Parameters.AddWithValue("@p3", p.Pes_ida);
            c.Parameters.AddWithValue("@p4", p.Endereco.End_rua);
            c.Parameters.AddWithValue("@p5", p.Endereco.End_num);
            c.Parameters.AddWithValue("@p6", p.Endereco.End_cpl);
            c.Parameters.AddWithValue("@p7", p.Endereco.End_bro);
            c.Parameters.AddWithValue("@p8", p.Endereco.End_cep);
            c.Parameters.AddWithValue("@p9", p.Endereco.Cidade.Cid_cod);
            DataTable dt = new DataTable();
            new SqlDataAdapter(c).Fill(dt);
            c.Connection.Close();
            pes_cod = (int)dt.Rows[0][0];
            return (int)dt.Rows[0][1];
        }
    }
}
