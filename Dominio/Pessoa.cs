using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pessoa
    {

      
        #region Propriedades
        public string Nome { get; set; }
            public string NumeroTelefone { get; set; }
            #endregion
            #region Metodos

                public string DadosPessoa()
                {
                    string pessoaDados = Nome + "-" + NumeroTelefone;

                    return pessoaDados;
                }
                 #endregion
        }
}
