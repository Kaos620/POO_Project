using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class Biblioteca : Livro
    {
        public void MenuBiblioteca()
        {
                    Console.WriteLine("-------Menu da Biblioteca-------" +
            "\n Selecione a opção desejada \n" +
            "[A] Adicionar livro\n" +
            "[B] Remover livro\n" +
            "[C] Listar livros\n" +
            "[D] Listar livros em Ordem Alfabetica\n" +
            "[E] Listar livros por Idioma\n");
        }
        public void Livros()
        {
            List<string> listaLivros = new List<string>();
            char menuBiblioteca = ' ';
            char menuBilioteca = char.Parse(Console.ReadLine());

            if (menuBiblioteca == 'a') 
            {
                Console.WriteLine("Quantos Livros deseja adicionar ? \n");
                int contador = 0;
                Livro livro = new Livro();
                contador = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < contador; i++) 
                {
                    livro.RegistrarLivro();
                }

            }

        }
    }
}
