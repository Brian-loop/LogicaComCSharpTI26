using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_numeros_determine_qual_o_maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)Dado 3 números determine qual é o maior deles:  ...
            int num1, num2, num3;
            Console.Write("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite um tercer número: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("O maior número é" + num1);
            }
            else if (num2 >= num3 && num2 >= num3)
            {
                Console.WriteLine("O maior número é o " + num2);
            }
            else {
                Console.WriteLine("O maior número é o " + num3);
            }
        }
    }
}
