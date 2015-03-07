using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PainelInferior;

namespace Banco3
{
    public partial class frCadPfe : Form
    {
        public frCadPfe()
        {
            InitializeComponent();
        }

        private void gridPerifericos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index_periferico = e.RowIndex;
            PerifericoVO registro = PerifericoDAO.MontaVO(gridPerifericos.Rows[index_periferico].DataBoundItem as DataRow);
            if (registro.Pfe_Tip_Com == (int)CONSTANTES.PERIFERICO.TIPOS_COMUNICACAO.ETHERNET)
            {

            }
        }

        private void cbPfe_Tip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPfe_Tip_Com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
