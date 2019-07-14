using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class AcessoDados
    {
        #region CamposPrivados
        private StreamWriter streamWhiter;
        private StreamReader streamReader;
        private string caminhoArquivo;
        private string nomeArquivo;
        #endregion

        #region Propriedades

            

        #endregion
        
        #region Construtor
        public AcessoDados(string arquivo)
        {
            caminhoArquivo = @"\\svprwy001\Alunos\AlunosMelhorLinguagem\";
            nomeArquivo = arquivo;
        }
        #endregion

        #region Metodos
        public void Gravar(string linha)
        {
            streamWhiter = File.AppendText( caminhoArquivo + nomeArquivo);
            streamWhiter.WriteLine(linha);
            streamWhiter.Close();
        }

        public List<string> Ler()
        {
            List<string> linhas = new List<string>();
;

            streamReader = File.OpenText(caminhoArquivo + nomeArquivo);
            while (streamReader.EndOfStream != true)
            {
                string linha = streamReader.ReadLine();
                linhas.Add(linha);


                
                Pessoa pessoa = new Pessoa();
                
            }
            streamReader.Close();

            return linhas;


        }
        #endregion
    }
}
