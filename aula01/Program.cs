using Dominio;
using Service;
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
            Pessoa pessoa = new Pessoa();
            PessoaService ps = new PessoaService();
            
            Console.WriteLine("Lista de Alunos");


            Console.Write("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite o telefone: ");
            pessoa.NumeroTelefone = Console.ReadLine();

            ps.Gravar(pessoa);

            List<Pessoa> pessoas = ps.Ler();
            Console.WriteLine("***** Lista Pessoas *****");
            foreach (var p in pessoas)
            {
                Console.WriteLine("Nome: " + p.Nome + " - " + p.NumeroTelefone);
            }

            Console.ReadLine();

            
        }
    }
}
