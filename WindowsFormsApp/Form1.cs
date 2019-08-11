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
            dgvPessoas.Rows.Clear();
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = ps.Ler();

            foreach (var item in pessoas)
            {
                string[] row = new string[3];
                row[0] = item.Id.ToString();
                row[1] = item.Nome;
                row[2] = item.Contatos.NumeroTelefone;

                dgvPessoas.Rows.Add(row);
            }
            if (dgvPessoas.Columns.Count==3)
            {
                dgvPessoas.Columns.Add ( addBntExcluir() );
            }
        }

        private DataGridViewButtonColumn addBntExcluir()
        {
            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn();
            colBtn.HeaderText = "";
            colBtn.Text = "Excluir";
            colBtn.Name = "btnExcluir";
            colBtn.UseColumnTextForButtonValue = true;
            return colBtn;
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
            p.Contatos.NumeroTelefone = txbTelefone.Text;
            ps.Gravar(p);
            LimparForm();
            CarregarPessoas();
        }

        private void DgvPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.ColumnIndex;
            if (index == 3)
            { 
                int indexLinha = e.RowIndex;
                int id = Convert.ToInt32 (dgvPessoas.Rows[indexLinha].Cells[0].Value);
                ps.Deletar(id);
                CarregarPessoas();
            }
        }
    }
}
