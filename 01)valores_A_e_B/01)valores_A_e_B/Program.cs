using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_valores_A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um algoritimo que leia dois valores inteiros A e B, se os valores de A e B forem iguais,
            //deverá somar valores, caso contrario deve multiplicar A por B. Ao final qualquer um dos cálculos
            //deve se atribuir o resultado a uma variavel C e imprimir o valor na tela.
            int numA, numB, numC;
            Console.Write("Digite seu primeiro número: ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo número:");
            numB = int.Parse(Console.ReadLine());
            if (numA == numB)
            {
                numC = numA + numB;
            }
                else
            {
                numC = numA * numB;
            }
            Console.WriteLine("O resultado é: " + numC);
        }
    }
}
