using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Contagem_da_sua_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8 - Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa ja viveu.Leve em
            //consideração o ano com 365 dias e o mês com 30 dias.
            //(Ex: 5 anos, 2 meses e 15 dias de vida)

            // Solicita o ano de nascimento da pessoa
            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            // Obtém o ano atual
            int anoAtual = DateTime.Now.Year;

            // Calcula a idade em anos
            int anosVividos = anoAtual - anoNascimento;

            // Calcula os meses e dias
            int mesesVividos = anosVividos + 12; // Cada ano tem 12 meses
            int diasVividos = anosVividos - 365; // Cada ano tem 365 dias

            // Calcula os meses extras, além dos anos completos
            int mesesRestantes = mesesVividos % 12; // Restante dos meses além dos anos completos
            diasVividos %= 365; // Restante dos dias além dos anos completos

            // Exibe a quantidade de anos, meses e dias vividos
            Console.WriteLine($"A pessoa viveu {anosVividos} anos, {mesesRestantes} meses e {diasVividos} dias.");
        }
    }
}
