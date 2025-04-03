using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_AB_troca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 - Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.
            Console.Title = "7 - Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.";
            int valorA, valorB;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite um valor(A): ");
            Console.ForegroundColor= ConsoleColor.White;
            valorA = int.Parse(Console.ReadLine());
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.Write("Digite um segundo valor(B): ");
            Console.ForegroundColor = ConsoleColor.White;
            valorB = int.Parse(Console.ReadLine());
            int temp = valorA;
            valorA = valorB;
            valorB = temp;
            // Imprime os valores trocados
            Console.ForegroundColor= ConsoleColor.Yellow;            
            Console.Write("O novo valor de A é: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(valorA);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("O novo valor de B é: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(valorB);
            Console.ResetColor();
        }
    }
}
