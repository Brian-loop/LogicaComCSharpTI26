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
            Console.Write("Digite o ano do seu nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o mês do seu nascimento (1-12): ");
            int mesNascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o dia do seu nascimento: ");
            int diaNascimento = int.Parse(Console.ReadLine());

            // Criar o objeto de data a partir das entradas
            DateTime dataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento);

            // Calcular a idade
            DateTime hoje = DateTime.Today;
            int idadeAnos = hoje.Year - dataNascimento.Year;
            int idadeMeses = hoje.Month - dataNascimento.Month;
            int idadeDias = hoje.Day - dataNascimento.Day;

            // Ajustar se o mês ou o dia for negativo
            if (idadeMeses < 0)
            {
                idadeAnos--;
                idadeMeses += 12;
            }

            if (idadeDias < 0)
            {
                idadeMeses--;
                // Ajusta os dias considerando um mês médio de 30 dias
                idadeDias += DateTime.DaysInMonth(hoje.Year, hoje.Month - 1);
            }

            // Exibir o resultado
            Console.WriteLine($"Você tem {idadeAnos} anos, {idadeMeses} meses e {idadeDias} dias.");
        }
    }
}
