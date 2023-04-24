using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class Menu
    {
        public static void MenuExercicios()
        {
            Console.WriteLine("Escolha uma das Opções: ");
            Console.WriteLine("\n[1] = Exercicio 1\n[2] = Exercicio 2\n[3] = Exercicio 3\n[4] = Exercicio 4 \n[9] = Exercício 9");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Aluno aluno = new Aluno();

                aluno.ReceberDados();
                aluno.CalcularMedia();

                if (aluno.CalcularNotaFinal())
                {
                    Console.WriteLine($"O aluno {aluno.Nome} foi aprovado com nota {aluno.NotaFinal}.");
                }
                else
                {
                    decimal notaNecessaria = Math.Ceiling((10.0M - aluno.NotaFinal) * 2.0M);

                    Console.WriteLine($"Aluno {aluno.Nome} reprovado com nota final: {aluno.NotaFinal}");
                    Console.WriteLine($"O aluno precisa tirar no mínimo {notaNecessaria} na prova final.");
                }

                aluno.ImprimirNotaFinal();
            }

            else if (opcao == 2)
            {
                Calculo calculo = new Calculo();
            }

            else if (opcao == 3)
            {
                ManipularArquivo arquivo = new ManipularArquivo();
                arquivo.Conteudo = "Exemplo de conteúdo a ser salvo em arquivo.";
                arquivo.EnderecoNomeArquivo = @"C:\Users\Public\Desktop\TesteSalvarArquivo.txt";

                if (arquivo.SalvarDadosArquivo())
                {
                    Console.WriteLine("Conteúdo salvo.");
                }
                else
                {
                    Console.WriteLine("Não foi possível salvar conteúdo.");
                }

                string conteudoArquivo = arquivo.PesquisarConteudoArquivo(arquivo.EnderecoNomeArquivo);
                if (conteudoArquivo != "")
                {
                    Console.WriteLine("Conteúdo do arquivo:");
                    Console.WriteLine(conteudoArquivo);
                }
                else
                {
                    Console.WriteLine("Não foi possível encontrar o conteúdo.");
                }

                Console.Read();
            }

            else if (opcao == 4)
            {
                List<Aluno> listaAlunos = new List<Aluno>();

                Console.WriteLine("Quantos alunos serão informados?");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantidade; i++)
                {
                    Aluno aluno = new Aluno();

                    aluno.ReceberDados();
                    listaAlunos.Add(aluno);

                    aluno.CalcularMedia();

                    bool aprovado = aluno.CalcularNotaFinal();
                    if (aprovado)
                    {
                        foreach (Aluno item in listaAlunos)
                        {
                            Console.WriteLine($"\nO aluno {item.Nome} foi aprovado com nota {item.NotaFinal}.");
                        }

                    }
                    else
                    {
                        foreach (var item in listaAlunos)
                        {
                            decimal notaNecessaria = Math.Ceiling((10.0M - item.NotaFinal) * 2.0M);

                            Console.WriteLine($"Aluno {item.Nome} reprovado com nota final: {item.NotaFinal}");
                            Console.WriteLine($"\nO aluno precisa tirar no mínimo {notaNecessaria} na prova final.");
                        }

                    }

                    aluno.ImprimirNotaFinal();
                }
            }
            else
            {
                Biblioteca biblioteca = new Biblioteca();
                biblioteca.MenuBiblioteca();
                biblioteca.RegistrarLivro();
                
            }
        }
    }
}

