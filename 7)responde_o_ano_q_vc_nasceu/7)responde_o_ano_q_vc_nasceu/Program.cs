using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_responde_o_ano_q_vc_nasceu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7)Programa que pergunte sua idade e responda o ano que você
            //nasceu. O programa deverá permanecer perguntando idades
            //até que o usuário digite como a idade o número 0 (zero)                         
                int idade = 1, anoAtual = 2025, anoNascimento = 0;
                while (idade != 0) 
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                anoNascimento = anoAtual - idade;
                Console.WriteLine($"Ano de nascimento: {anoNascimento}");
                break;
            }
            Console.WriteLine("Programa finalizado.");
        }
    }
}
