using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class Livro
    {
        public Autor Autor { get; set; }
        public string ISBN { get; set; }
        public string NomeLivro { get; set; }
        public string IdiomaLivro { get; set; }
        public int Edicao { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
