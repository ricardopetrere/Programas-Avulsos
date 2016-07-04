using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotifyIcon1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            INSTANCIA = this;
        }
        private static Form1 _i;
        public static Form1 INSTANCIA
        {
            get
            {
                if (_i == null)
                {
                    _i = new Form1();
                }
                return _i;
            }
            set
            {
                _i = value;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            INSTANCIA.Show();
            INSTANCIA.Activate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!notifyIcon1.Visible)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {

        }
    }
}
