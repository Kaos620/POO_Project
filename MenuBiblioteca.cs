using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class MenuBiblioteca
    {
        Biblioteca biblioteca = new Biblioteca();

        public void BibliotecaMenu()
        {
            Console.WriteLine("-------Menu da Biblioteca-------" +
            "\n Selecione a opção desejada \n" +
            "[A] Adicionar livro\n" +
            "[B] Remover livro\n" +
            "[C] Listar livros\n" +
            "[D] Listar livros em Ordem Alfabetica\n" +
            "[E] Listar livros por Idioma\n");

            char menuBilioteca = char.ToUpper(char.Parse(Console.ReadLine()));

            switch (menuBilioteca)
            {
                case 'A':
                    {
                        Registrador registrador = new Registrador();
                        Console.WriteLine("Quantos Livros deseja adicionar ? \n");
                        int contador = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < contador; i++)
                        {
                            registrador.RegistrarLivro(biblioteca);
                        }
                        break;
                    }
                case 'B':
                    {
                        Console.WriteLine("Qual o ISBN do Livro que voce gostaria de remover? \n");
                        string ISBN = Console.ReadLine();
                        biblioteca.RemoverLivro(ISBN);
                        break;
                    }
                case 'C':
                    {
                        break;
                    }
                case 'D': 
                    {
                        break;
                    }
                case 'E':
                    {
                        break;
                    }
            }
        }
    }
}
