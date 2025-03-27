using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_numero_impares_1_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2)Mostre somente números impares de 1 a 100.
            int contadorPares = 0;
            Console.WriteLine("Números impares de 1 a 100: ");
            while (contadorPares <= 100) // enquanto(portugol) = white
            {
                if (contadorPares % 2 - 1 == 0)//if = para
                {
                Console.WriteLine(contadorPares);
                }
                contadorPares++;
            }
        }
    }
}
