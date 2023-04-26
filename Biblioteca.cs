using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class Biblioteca

    {
        List<Livro> listaLivros = new List<Livro>();
        public void AdicionarLivros(Livro livro)
        {
            listaLivros.Add(livro);
        }
        public void RemoverLivro(string ISBN)
        {
            Livro livroRemovido = listaLivros.Find(livroExpecifico => livroExpecifico.ISBN == ISBN);
            if (livroRemovido != null)
            {
                listaLivros.Remove(livroRemovido);
            }
            else
            {
                Console.WriteLine($"Livro de ISBN {ISBN} nao encontrado:");
            }
        }
    }
}
