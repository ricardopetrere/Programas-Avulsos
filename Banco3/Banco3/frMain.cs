using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CFG_BD_XML;

namespace Banco3
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
            if (!BD_Connection.LeuBDXML())
            {
                Application.Exit();
                return;
            }
            toolStripStatusLabelTerminalCadastrado.Text = toolStripStatusLabelTerminalCadastrado.Text
                .Replace("xxxxx", RetornaTrmNom());
        }

        private string RetornaTrmNom()
        {
            String retorno = "";
            return retorno;
        }

        private void btnCadPfe_Click(object sender, EventArgs e)
        {
            periféricosToolStripMenuItem_Click(sender, e);
        }

        private void btnCadTrm_Click(object sender, EventArgs e)
        {
            terminaisToolStripMenuItem_Click(sender, e);
        }

        private void periféricosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frCadPfe().ShowDialog();
        }

        private void terminaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frCadTrm().ShowDialog();
        }

        private void acessoAoBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] msg = new string[] { "Deseja configurar o acesso ao banco de dados?", "Atenção." };
            if (MessageBox.Show(msg[0], msg[1], MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            switch (new frConexaoBD().ShowDialog())
            {
                case DialogResult.Abort:
                    Application.Exit();
                    return;
                case DialogResult.OK:
                    Application.Restart();
                    return;
            }
        }
    }
}
