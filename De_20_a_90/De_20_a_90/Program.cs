using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_20_a_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construa um algoritimo que indique se um número digitado está compreendido entre 20 e 90 ou não(20 e 90 estão na faixa de valores).
            int numero;
            Console.Write("Digite um numero entre 20 e 90: ");
            numero = int.Parse(Console.ReadLine());
            if (numero > 20 && numero < 90)
            {
                //if = se(portugol)
                //&& = e
                Console.Write("este numero esta dentro do compreendido de 20 e 90 ");

                //else = senao(portugol)
            }
            else
            {
                Console.Write("O numero não esta dentro do compreendido de 20 e 90");
            }

        }
    }
}
            

