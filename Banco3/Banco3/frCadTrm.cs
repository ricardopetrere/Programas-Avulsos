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
    public partial class frCadTrm : Form
    {
        public frCadTrm()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {

        }

        private void cbTipoPeriferico1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTestarCOM1_Click(object sender, EventArgs e)
        {

        }

        private void btnAssociarTodos_Click(object sender, EventArgs e)
        {

        }

        private void btnAssociarUm_Click(object sender, EventArgs e)
        {

        }

        private void btnDesassociarUm_Click(object sender, EventArgs e)
        {

        }

        private void btnDesassociarTodos_Click(object sender, EventArgs e)
        {

        }

        private void gridDesassociados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnPageTerminaisAnterior_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabTerminais1);
            tabControl1.TabPages.Remove(tabTerminais2);
            btnPageTerminaisProximo.Focus();
        }

        private void btnPageTerminaisProximo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabTerminais1);
            tabControl1.TabPages.Add(tabTerminais2);
            btnPageTerminaisAnterior.Focus();
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