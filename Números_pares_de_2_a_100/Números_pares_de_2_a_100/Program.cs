using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números_pares_de_2_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //numeros pares de 2 a 100.
            int contador;
            for (contador = 2; contador <= 100; contador++)
            {
                if (contador % 2 == 0)
                {
                 Console.Write(contador + "\n");

                    }
                }
            }
        }
    }
            
        
     

