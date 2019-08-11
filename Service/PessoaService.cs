using Data;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PessoaService

    {
        private AcessoDados acessoDados;
        private string nomeArquivo;

        public PessoaService()
        {
            nomeArquivo = "pessoa.txt";
            acessoDados = new AcessoDados(nomeArquivo);
        }

        //public void Gravar(Pessoa p)
        //{
        //    SalvarEmArquivo(p);
        //}

        public void Gravar(Pessoa p)
        {
            new AcessoDB().Create(p);
        }

        //public List<Pessoa> Ler()
        //{
        //    List<Pessoa> pessoas = new List<Pessoa>();
        //    pessoas = LerEmArquivo();
        //    return pessoas;
        //}

        public List<Pessoa> Ler()
        {
            return new AcessoDB().LerTodos();
        }

        //public void Deletar(string nome)
        //{
        //    DeletarEmArquivo(nome);
        //}

        public void Deletar(int id)
        {
            new AcessoDB().Delete(id);
        }

        //========== Operação em arquivo na rede
        private void DeletarEmArquivo(string nome)
        {
            acessoDados.Deletar(nome);
        }

        private void SalvarEmArquivo(Pessoa p)
        {
            string pessoaLinha = p.DadosPessoa();
            acessoDados.Gravar(pessoaLinha);
        }

        private List<Pessoa> LerEmArquivo()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            List<string> pessoasLinhas = acessoDados.Ler();

            foreach (var linha in pessoasLinhas)
            {
                string[] pessoaLinha = linha.Split('-');
                Pessoa pessoa = new Pessoa();
                pessoa.Id = Convert.ToInt32( pessoaLinha[0] );
                pessoa.Nome = pessoaLinha[1];
                pessoa.Contatos.NumeroTelefone = pessoaLinha[2];
                pessoas.Add(pessoa);
            }
            return pessoas;
        }
    }
}
