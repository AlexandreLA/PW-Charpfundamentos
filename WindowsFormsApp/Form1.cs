using Dominio;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        Pessoa p = new Pessoa();
        PessoaService ps = new PessoaService();

        public Form1()
        {
            InitializeComponent();
            CarregarPessoas();
        }

        private void CarregarPessoas()
        {
            dgvPessoas.DataSource = ps.Ler();
        }

        private void LimparForm()
        {
            txbTelefone.Text = string.Empty;
            txbNome.Text = string.Empty;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            p.Nome = txbNome.Text;
            p.NumeroTelefone = txbTelefone.Text;
            ps.Gravar(p);
            LimparForm();
            CarregarPessoas();
        }
    }
}
