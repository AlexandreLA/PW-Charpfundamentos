using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pessoa : EntidadeBase
    {
        public Pessoa()
        {
            Endereco = new Endereco();
            Contatos = new Contatos();
        }

        #region Propriedades

        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        public Contatos Contatos { get; set; }


        #endregion
        #region Metodos

        public string DadosPessoa()
        {
            string pessoaDados = $"{ Id}-{ Nome}-{ Contatos.NumeroTelefone}-{ Contatos.Skype}-{ Endereco.Cidade}-{ Endereco.Numero}";

            return pessoaDados;
        }
        #endregion
    }
}
