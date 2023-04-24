using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class Livro : Autor
    {
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string Language { get; set; }
        public int Edition { get; set; }
        public DateTime ReleaseDate { get; set; }

        public void RegistrarLivro()
        {
            Console.WriteLine("Digite o nome: \n");
            Name = Console.ReadLine();
            
            Console.WriteLine("Digite o pais de origem do autor: \n");
            HomeCountry = Console.ReadLine();
            
            Console.WriteLine("Digite a data de nascimento do autor: \n");
            BirthDate = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Digite a Linguagem Original do Autor: \n");
            HomeLanguage = Console.ReadLine();
            
            Console.WriteLine("Digite o ISBN do Livro: \n");
            ISBN = Console.ReadLine();
            
            Console.WriteLine("Digite o Nome do Livro: \n");
            BookName = Console.ReadLine();
            
            Console.WriteLine("Digite a Linguagem do Livro: \n");
            Language = Console.ReadLine();
            
            Console.WriteLine("Digite a edicao do Livro: \n");
            Edition = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite a Data de Lancamento do Livro: \n");
            ReleaseDate = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
