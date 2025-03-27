using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_Multiplicação_divisão_de_dois_números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que solicite dois números ao usuário e exiba a soma, subtração, multiplicação e divisão desses números.
            double numero1, numero2, soma, subtracao, divisao, multiplicacao; //double = é o equivalente ao "real" do portugol
            Console.Write("Digite seu primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("Digite seu segundo número: ");
            numero2 = double.Parse(Console.ReadLine());
            soma = numero1 + numero2;
            Console.Write("\nSeus dois números somados seriam: "), soma;
            subtracao = numero1 - numero2;
            Console.Write("\nSeus dois números subtraidos seriam: ", subtracao);
            multiplicacao = numero1 * numero2;
            Console.Write("\nSeus dois números multiplicados seriam: ", multiplicacao);
            divisao = numero1 / numero2;
            Console.Write("\nSeus dois números dividos seriam: ", divisao);
        }
    }
}
