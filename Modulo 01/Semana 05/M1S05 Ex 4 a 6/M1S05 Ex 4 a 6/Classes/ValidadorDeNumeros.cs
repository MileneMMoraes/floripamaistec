using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Semana 05 - Exercício 6:

namespace M1S05_Ex_4_a_6.Classes
{
    public static class ValidadorDeNumeros
    {
        /// <summary>
        /// Verifica se um número é primo
        /// </summary>
        public static bool EhNumeroPrimo(int numero)
        {
            int contador = 1;

            for (int n = 1; n < numero; n++)
            {
                if (numero % n == 0)
                {
                    contador = contador + 1;
                }
            }

            if (contador == 2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Retorna se um número é par ou ímpar
        /// </summary>
        public static string ParOuImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                return "Par";
            }

            return "Impar";
        }

        /// <summary>
        /// Verifica se um número é divisível por outro
        /// </summary>
        public static bool EhDivisivelPor(int dividendo, int divisor)
        {
            if (dividendo % divisor == 0)
            {
                return true;
            }

            return false;
        }
    }
}
