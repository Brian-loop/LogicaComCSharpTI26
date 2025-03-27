using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_numeros_Mostre__qual__é_o_maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3)Escreva um programa que leia um conjunto de 20 números inteiros e mostre qual foi o maior valor fornecido pelo usuário.
            int num, contador, maiornum;
            maiornum = -999999;
            for(contador = 1; contador <= 20; contador++) {   //for = para
            Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                // int.Parse(Console.ReadLine()) = leia (portugol)
            if (num > maiornum) {    //if = se
            maiornum = num;
            }
            }
            Console.Write("Entre esses 20 números o maior é: ");
            Console.WriteLine(maiornum);
        }
    }
}
