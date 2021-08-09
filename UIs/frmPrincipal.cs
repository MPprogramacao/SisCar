using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UIs
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string usuario;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Bem-vindo " + usuario + "!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Data: " + DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = "Hora: " + DateTime.Now.ToShortTimeString();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void consultaDetranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "www.detran.sp.gov.br");
        }

        private void exibirBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exibirBarraToolStripMenuItem.Checked)
                toolStrip1.Show();
            else
                toolStrip1.Hide();
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            this.BackgroundImage = null;
        }

        private void papelDeParedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Title = "Selecione a figura para o fundo";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de imagem |(*.bmp;*.jpg,*.gif) | Todos os arquivos | *.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
