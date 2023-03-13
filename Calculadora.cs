using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class Calculadora
    {
        Calculo calculo = new Calculo();

        public void LerValores()
        {
            Console.WriteLine("Digite os valores de A e B"); ;
            calculo.ValorA = Convert.ToDouble(Console.ReadLine());
            calculo.ValorB = Convert.ToDouble(Console.ReadLine());
        }

        public void ExecutarCalculadora()
        {
            Console.WriteLine("Escolha o que deseja fazer: \n[1]Somar\n[2] Subtrair\n[3] Multiplicar\n [4] Dividir\n");
            int escolha = int.Parse(Console.ReadLine());
        
            LerValores();

            if (escolha == 1)
            {
                calculo.CalcularSoma();
                double resultado = calculo.ImprimirResultado();

                Console.WriteLine($"\nResultado: {resultado}");
            }

            else if (escolha == 2)
            {
                calculo.CalcularSubtracao();
                double resultado = calculo.ImprimirResultado();

                Console.WriteLine($"\nResultado: {resultado}");
            }

            else if (escolha == 3)
            {
                calculo.CalcularMultiplicacao();
                double resultado = calculo.ImprimirResultado();

                Console.WriteLine($"\nResultado: {resultado}");
            }

            else if (escolha == 4)
            {
                calculo.CalcularDivisao();
                double resultado = calculo.ImprimirResultado();

                Console.WriteLine($"\nResultado: {resultado}\n\n");
            }

            else if (escolha == 5)
            {
                double resultado = calculo.RetomarMaior();

                Console.WriteLine($"\nResultado: {resultado}\n\n");
            }

            else
            {
                Console.WriteLine("Fim do programa.");
            }
        }
    }
        
}
