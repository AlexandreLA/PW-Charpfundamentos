using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string NumeroTelefone { get; set; }
        public string Arquivo { get; set; }

        public Pessoa()
        {
            Arquivo = @"\\svprwy001\Alunos\AlunosMelhorLinguagem\ListaDeContatos.txt";
        }

        public string DadosPessoa()
        {
            string pessoaDados = Nome + "-" + NumeroTelefone;

            return pessoaDados;
        }

        public void Gravar(Pessoa p)
        {
            StreamWriter stream;
            stream = File.AppendText(Arquivo);
            stream.WriteLine( p.DadosPessoa() );
            stream.Close();
        }

        public List<Pessoa> Ler()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            StreamReader stream;
            stream = File.OpenText(Arquivo);
            while (stream.EndOfStream != true)
            {
                string linha = stream.ReadLine();
                string[] pessoaLinha = linha.Split('-');
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = pessoaLinha[0];
                pessoa.NumeroTelefone = pessoaLinha[1];
                pessoas.Add(pessoa);
            }
            stream.Close();
            return pessoas;

            //File.OpenText(Arquivo);


            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.Nome = "João";
            //pessoa1.NumeroTelefone = "9999-9999";

            //Pessoa pessoa2 = new Pessoa();
            //pessoa2.Nome = "Maria";
            //pessoa2.NumeroTelefone = "5555-5555";

            //pessoas.Add(pessoa1);
            //pessoas.Add(pessoa2);

            //return pessoas;
        }


    }
}
