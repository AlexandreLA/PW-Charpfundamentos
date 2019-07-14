using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lista de Alunos");

            Pessoa pessoa = new Pessoa();

            Console.Write("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite o telefone: ");
            pessoa.NumeroTelefone = Console.ReadLine();

            string dados = pessoa.DadosPessoa();
            Console.WriteLine(dados);

            pessoa.Gravar(pessoa);

            //List<Pessoa> pessoas = pessoa.Ler();
            //foreach (Pessoa p in pessoas)
            //{
            //    Console.WriteLine(p.DadosPessoa());
            //}

            Console.ReadLine();
        }
    }
}
