using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contatos : EntidadeBase
    {
        [Display(Name = "Telefone" )]
        public string NumeroTelefone { get; set; }
        public string NumeroTelefoneResidencal { get; set; }
        public string EMail { get; set; }
        public string Skype { get; set; }
    }
}
