using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexto
{
    public class ContextoProway : DbContext
    {
        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Contatos> Contatos { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public ContextoProway():base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65946\Documents\Prowaycsharp\PW-Charpfundamentos\Data\DbLocal\Database.mdf;Integrated Security=True")
        {

        }
    }
}
