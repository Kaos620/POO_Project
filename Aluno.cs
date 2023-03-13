using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class Aluno
    {
        public string RA;
        public string Nome;
        public decimal NotaProva;
        public decimal NotaTrabalho;
        public decimal NotaFinal;

        public void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabalho) / 2;
        }

        public bool CalcularNotaFinal()
        {
            if (NotaFinal >= 7.0M)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"\nA nota final é {NotaFinal}");
        }

        public void ReceberDados()
        {
            Console.Write("\nQual o RA do aluno? ");
            RA = Console.ReadLine();

            Console.Write("\nQual o nome do aluno? ");
            Nome = Console.ReadLine();

            Console.Write("\nQual foi a nota da prova dele? ");
            NotaProva = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nQual foi a nota do trabalho dele? ");
            NotaTrabalho = Convert.ToDecimal(Console.ReadLine());

            NotaFinal = NotaProva + NotaTrabalho;

        }

    }
}
