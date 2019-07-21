using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AcessoDados
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
               
                
            }
            streamReader.Close();

            return linhas;


        }

            public void Deletar(string nome)
            {
                List<string> linhas = Ler();
                List<string> linhas2 = new List<string>();

                foreach (var item in linhas)
                {
                    if (!item.Contains(nome))
                    {
                        linhas2.Add(item);
                    }
                }

                GravarDelete(linhas2);

            }

        private void GravarDelete(List<string> linhas)
        {
            System.IO.File.Delete(caminhoArquivo + nomeArquivo);
            streamWhiter = File.AppendText(caminhoArquivo + nomeArquivo);
            foreach (var item in linhas)
            {
                streamWhiter.WriteLine(item);
            }
            streamWhiter.Close();
        }
        #endregion
    }
}
