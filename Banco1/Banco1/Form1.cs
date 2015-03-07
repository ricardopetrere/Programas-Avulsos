using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco1
{
    public partial class frCad_Pes : Form
    {
        public frCad_Pes()
        {
            InitializeComponent();
        }

        private void frCad_Pes_Load(object sender, EventArgs e)
        {
            //Inicialização dos textos da tela
            this.Text = BD.GetTexto(1);
            lblPes_nom.Text = BD.GetTexto(2) + ":";
            lblPes_ida.Text = BD.GetTexto(3) + ":";
            btnSalvar.Text = BD.GetTexto(11);
            grpEndereco.Text = BD.GetTexto(15) + ":";
            lblEstado.Text = BD.GetTexto(10) + ":";
            lblCidade.Text = BD.GetTexto(9) + ":";
            lblRua.Text = BD.GetTexto(4) + ":";
            lblNumero.Text = BD.GetTexto(5) + ":";
            lblComplemento.Text = BD.GetTexto(6) + ":";
            lblBairro.Text = BD.GetTexto(7) + ":";
            lblCEP.Text = BD.GetTexto(8) + ":";

            //DataSource da combobox de Estado
            List<EstadoVO> estados = EstadoDAO.ListarEstados();
            estados.Insert(0, new EstadoVO(-1, "Selecione um estado."));
            cbEstado.DataSource = estados;
            cbEstado.DisplayMember = "Est_nom";
            cbEstado.ValueMember = "Est_cod";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EnderecoVO end = new EnderecoVO(txtRua.Text, Convert.ToInt32(txtNumero.Text), txtComplemento.Text, txtBairro.Text, txtCEP.Text, (CidadeVO) cbCidade.SelectedItem);
            PessoaVO p = new PessoaVO(txtPes_nom.Text, Convert.ToInt32(numPes_ida.Value), end);
            String[] msgSalvar = new String[2];
            int pessoa_inserida = -1;
            int msg = PessoaDAO.Insert(p, out pessoa_inserida);
            msgSalvar = BD.GetTexto(msg).Split('|');
            if (pessoa_inserida > 0)
                msgSalvar[0] = msgSalvar[0] + "\nCódigo: " + pessoa_inserida;
            MessageBox.Show(msgSalvar[0], msgSalvar[1]);
        }

        private void cbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedItem == null || cbEstado.ValueMember.Equals(""))
                return;
            cbCidade.DataSource = CidadeDAO.ListarCidades(Convert.ToInt32(cbEstado.SelectedValue)).ToArray();
            cbCidade.DisplayMember = "Cid_nom";
            cbCidade.ValueMember = "Cid_cod";
        }
    }
}