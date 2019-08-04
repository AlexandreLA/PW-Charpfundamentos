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
        public DbSet<Pessoa> Pessoa { get; set; }

        public ContextoProway():base("server=mysql.topskills.study;user id=topskills03;database=topskills03; Password=Alexandre2019; persistsecurityinfo=True")
        {

        }
    }
}
