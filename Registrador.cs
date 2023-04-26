using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trabalho_Robinho
{
    internal class Registrador
    {
        public void RegistrarLivro(Biblioteca biblioteca)
        {
            Autor autor = new Autor();          

            Console.WriteLine("Digite o nome do Autor: \n");
            autor.NomeAutor = Console.ReadLine();

            Console.WriteLine("Digite o pais de origem do autor: \n");
            autor.PaisAutor = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento do Autor: \n");
            autor.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite a Linguagem Original do Autor: \n");
            autor.LinguagemOrigem = Console.ReadLine();

            Livro livro = new Livro();

            Console.WriteLine("Digite o ISBN do Livro: \n");
            livro.ISBN = Console.ReadLine();

            Console.WriteLine("Digite o Nome do Livro: \n");
            livro.NomeLivro = Console.ReadLine();

            Console.WriteLine("Digite a Linguagem do Livro: \n");
            livro.IdiomaLivro = Console.ReadLine();

            Console.WriteLine("Digite a edicao do Livro: \n");
            livro.Edicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Data de Lancamento do Livro: \n");
            livro.DataLancamento = Convert.ToDateTime(Console.ReadLine());

            livro.Autor = autor;

            biblioteca.AdicionarLivros(livro);

        }
    }
}
