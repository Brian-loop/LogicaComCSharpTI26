
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_salario_minimo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2- Faça um algoritimo que leia o valor do sálario mínimo e o valor do sálario de um usuário,
            //calcule quantos sálarios esse usuário ganha e imprima na tela o resultado. (Base para o sálario mínimo R$ 1518,00).

            Console.Title = "Salario minimo";
            Console.ForegroundColor = ConsoleColor.Yellow;
            



            double salarioMinimo = 1518.00;
            // Lendo o valor do salário do usuário
            Console.Write("Digite o valor do seu salário: R$ ");
            double salarioUsuario = Convert.ToDouble(Console.ReadLine());
            // Calculando quantos salários mínimos o usuário ganha
            double quantidadeSalarial = salarioUsuario / salarioMinimo;            
            Console.WriteLine($"Você ganha {quantidadeSalarial:F2} a mais de salários mínimos.");
        }
    }
}
