using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Reajuste_de_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3- Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajsute de 5%.
            double valor, valorReajustado;
            Console.Write("Digite um valor: ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor normal: " + valor);
            valorReajustado = (valor * 0.05) + valor;
            Console.WriteLine("Valor reajustado: " + valorReajustado);        
        }
    }
}
