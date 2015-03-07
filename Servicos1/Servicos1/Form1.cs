using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using Microsoft.Win32;

namespace Servicos1
{
    public partial class Form1 : Form
    {
        #region Atributos
        IEnumerable<ServiceController> servicos;
        ServiceController servico_atual;
        //enum Inicializacao_Servico { Automático = 2, Manual = 3, Desativado = 4 };
        enum COMANDOS { INICIAR, PAUSAR, CONTINUAR, PARAR, REINICIAR };
        const String CAMINHO_HKEY_LOCAL_MACHINE = "HKEY_LOCAL_MACHINE\\";
        const String CAMINHO_REG_SERVICOS = @"SYSTEM\CurrentControlSet\Services\";
        struct Inicializacao_Servico
        {
            int _valor;
            String _nome;
            public int valor
            {
                get
                {
                    return _valor;
                }
                set
                {
                    _valor = value;
                }
            }
            public String nome
            {
                get
                {
                    return _nome;
                }
                set
                {
                    _nome = value;
                }
            }
            public Inicializacao_Servico(int valor, String nome)
            {
                _valor = valor;
                _nome = nome;
            }
        }
        Inicializacao_Servico[] metodos_inicializacao = new Inicializacao_Servico[]
        {
            new Inicializacao_Servico(2,"Automático"),
            new Inicializacao_Servico(3,"Manual"),
            new Inicializacao_Servico(4,"Desativado"),
            new Inicializacao_Servico(201,"Automático (Atraso na Inicialização)")//2 com DelayedAutostart = 1
        };
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            servicos = ServiceController.GetServices().OrderBy(s => s.DisplayName);
            foreach (ServiceController servico in servicos)
                listBox1.Items.Add(servico.DisplayName);
            //foreach (Inicializacao_Servico i in Enum.GetValues(typeof(Inicializacao_Servico)))
            //    comboBox1.Items.Add(i);
            comboBox1.DataSource = metodos_inicializacao;
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "valor";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencheInformacoes(listBox1.SelectedIndex);
            AjustaSplitter();
        }

        private void splitContainer1_SizeChanged(object sender, EventArgs e)
        {
            AjustaSplitter();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ExecutarComando(COMANDOS.INICIAR);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            ExecutarComando(COMANDOS.PARAR);
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            ExecutarComando(COMANDOS.PAUSAR);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            ExecutarComando(COMANDOS.CONTINUAR);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ExecutarComando(COMANDOS.REINICIAR);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!btnSalvar.Enabled)
            {
                MessageBox.Show("Ops! Não era pra acontecer");
                return;
            }
            //int inicializacao = (int)comboBox1.SelectedItem;
            int inicializacao = (int)comboBox1.SelectedValue;
            if (inicializacao == 201)
            {
                Registry.SetValue(CAMINHO_HKEY_LOCAL_MACHINE + CAMINHO_REG_SERVICOS + servico_atual.ServiceName, "Start", 2);
                Registry.SetValue(CAMINHO_HKEY_LOCAL_MACHINE + CAMINHO_REG_SERVICOS + servico_atual.ServiceName, "DelayedAutostart", 1);
            }
            else
            {
                Registry.SetValue(CAMINHO_HKEY_LOCAL_MACHINE + CAMINHO_REG_SERVICOS + servico_atual.ServiceName, "Start", inicializacao);
                Registry.SetValue(CAMINHO_HKEY_LOCAL_MACHINE + CAMINHO_REG_SERVICOS + servico_atual.ServiceName, "DelayedAutostart", 0);
            }
            PreencheInformacoes(listBox1.SelectedIndex);
        }

        private void AjustaSplitter()
        {
            if (!splitContainer1.Panel2Collapsed && splitContainer1.Width > 260)
                splitContainer1.SplitterDistance = splitContainer1.Width - 260;
        }

        void PreencheInformacoes(int index_atual)
        {
            splitContainer1.Panel2Collapsed = index_atual < 0;
            if (index_atual < 0)
                return;
            btnSalvar.Enabled = false;
            servico_atual = servicos.ElementAt<ServiceController>(index_atual);
            int inicializacao_servico_atual = (int)Registry.GetValue(CAMINHO_HKEY_LOCAL_MACHINE + CAMINHO_REG_SERVICOS + servico_atual.ServiceName, "Start", 0);
            int usa_atraso_inicio_automatico = (int)Registry.GetValue(CAMINHO_HKEY_LOCAL_MACHINE + CAMINHO_REG_SERVICOS + servico_atual.ServiceName, "DelayedAutostart", 0);
            lblServiceName.Text = servico_atual.ServiceName;
            //No momento, não utilizado (devido à traduções automáticas que o Windows faz ao ler a Value "Description")
            //lblDisplayName.Text = (r.GetValue("Description") != null ? r.GetValue("Description").ToString() : "");
            grpStatus.Text = "Status: " + servico_atual.Status.ToString();
            btnIniciar.Enabled =
                (servico_atual.Status != ServiceControllerStatus.Running &&
                servico_atual.Status != ServiceControllerStatus.Paused &&
                //inicializacao_servico_atual != (int)Inicializacao_Servico.Desativado);
                inicializacao_servico_atual != 4);
            btnParar.Enabled =
                (servico_atual.Status != ServiceControllerStatus.Stopped &&
                //inicializacao_servico_atual != (int)Inicializacao_Servico.Desativado);
                inicializacao_servico_atual != 4);
            btnPausar.Enabled =
                (servico_atual.Status != ServiceControllerStatus.Paused &&
                servico_atual.Status != ServiceControllerStatus.Stopped &&
                //inicializacao_servico_atual != (int)Inicializacao_Servico.Desativado);
                inicializacao_servico_atual != 4);
            btnContinuar.Enabled =
                (servico_atual.Status != ServiceControllerStatus.Running &&
                servico_atual.Status != ServiceControllerStatus.Stopped &&
                //inicializacao_servico_atual != (int)Inicializacao_Servico.Desativado);
                inicializacao_servico_atual != 4);
            btnReiniciar.Enabled =
                (servico_atual.Status != ServiceControllerStatus.Stopped &&
                //inicializacao_servico_atual != (int)Inicializacao_Servico.Desativado);
                inicializacao_servico_atual != 4);
            //comboBox1.SelectedItem = ((Inicializacao_Servico)inicializacao_servico_atual);
            if (inicializacao_servico_atual == 2 && usa_atraso_inicio_automatico == 1)
                comboBox1.SelectedValue = 201;
            else
                comboBox1.SelectedValue = inicializacao_servico_atual;
        }

        void ExecutarComando(COMANDOS comando)
        {
            switch (comando)
            {
                case COMANDOS.INICIAR:
                    servico_atual.Start();
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    servico_atual.WaitForStatus(ServiceControllerStatus.Running);
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    break;
                case COMANDOS.PARAR:
                    servico_atual.Stop();
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    servico_atual.WaitForStatus(ServiceControllerStatus.Stopped);
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    break;
                case COMANDOS.PAUSAR:
                    servico_atual.Pause();
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    servico_atual.WaitForStatus(ServiceControllerStatus.Paused);
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    break;
                case COMANDOS.CONTINUAR:
                    servico_atual.Continue();
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    servico_atual.WaitForStatus(ServiceControllerStatus.Running);
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    break;
                case COMANDOS.REINICIAR:
                    servico_atual.Stop();
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    servico_atual.WaitForStatus(ServiceControllerStatus.Stopped);
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    servico_atual.Start();
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    servico_atual.WaitForStatus(ServiceControllerStatus.Running);
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
                    break;
            }
            PreencheInformacoes(listBox1.SelectedIndex);
        }
    }
}