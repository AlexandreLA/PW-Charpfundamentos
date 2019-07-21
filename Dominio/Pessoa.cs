using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pessoa
    {
        #region CamposPrivados

            private AcessoDados acessoDados;
            private string nomeArquivo;       
        #endregion
        #region Propriedades
        public string Nome { get; set; }
            public string NumeroTelefone { get; set; }
            #endregion
            #region Construtor
            public Pessoa()
            {
                nomeArquivo = "pessoa.txt";
                acessoDados = new AcessoDados(nomeArquivo);
            }
            #endregion
            #region Metodos

                public string DadosPessoa()
                {
                    string pessoaDados = Nome + "-" + NumeroTelefone;

                    return pessoaDados;
                }

                public void Gravar()
                {
                    string pessoaLinha = DadosPessoa();

                    acessoDados.Gravar(pessoaLinha);
            
                }

                public List<Pessoa> Ler()
                {
                    List<Pessoa> pessoas = new List<Pessoa>();

                    List<string> pessoasLinhas = acessoDados.Ler();

                    foreach (var linha in pessoasLinhas)
                    {
                    string[] pessoaLinha = linha.Split('-');
                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = pessoaLinha[0];
                    pessoa.NumeroTelefone = pessoaLinha[1];
                    pessoas.Add(pessoa);
                    }

                    return pessoas;

                }

                public void Deletar(string nome)
                {
                    acessoDados.Deletar(nome);
                }
                 #endregion
        }
}
