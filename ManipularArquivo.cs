using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class ManipularArquivo
    {
        public string Conteudo;
        public string EnderecoNomeArquivo;

        public bool SalvarDadosArquivo()
        {
            try
            {
                File.WriteAllText(EnderecoNomeArquivo, Conteudo);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string PesquisarConteudoArquivo(string endereco)
        {
            try
            {
                return File.ReadAllText(endereco);
            }
            catch
            {
                return "";
            }
        }

    }
}
