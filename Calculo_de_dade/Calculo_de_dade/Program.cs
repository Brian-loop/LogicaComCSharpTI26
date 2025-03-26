using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_dade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano_nascimento, ano_atual, idade;
            Console.Write("Digite o ano de seu nascimento: "); //Console.Write("")  = é o equivalente a "escreva" do portugol.
            ano_nascimento = int.Parse(Console.ReadLine()); //int.Parse(Console.ReadLine())  = é usado para ler numeros.
            Console.Write("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
            idade = ano_atual - ano_nascimento;
            Console.Write("sua idade é: " + idade + " anos");
        }
    }
}
