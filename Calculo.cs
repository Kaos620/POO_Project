using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Robinho
{
    internal class Calculo
    {
        public double Resultado;
        public double ValorA;
        public double ValorB;

        public void CalcularSoma()
        {
            Resultado = ValorA + ValorB;
        }

        public void CalcularSubtracao()
        {
            Resultado = ValorA - ValorB; 
        }

        public void CalcularMultiplicacao()
        {
            Resultado = ValorA * ValorB;
        }

        public void CalcularDivisao()
        {
            Resultado = ValorA / ValorB;
        }

        public double RetomarMaior()
        {
            if (ValorA > ValorB)
            {
                return ValorA;
            }
            else if (ValorA < ValorB)
            {
                return ValorB;
            }
            else
            {
                return ValorA;
            }
        }

        public double ImprimirResultado()
        {
            return Resultado;
        }
    }
}
