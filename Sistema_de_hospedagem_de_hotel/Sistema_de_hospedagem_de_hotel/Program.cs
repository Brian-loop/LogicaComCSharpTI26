﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sistema_de_hospedagem_de_hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exibe boas-vindas e chama a função principal
            Console.WriteLine("Bem-vindo ao sistema de hospedagem!");

            // Obtém a escolha do cliente
            string opcaoEscolhida = ObterOpcaoCliente();

            // Obtém o número de noites
            int numeroNoites = ObterNumeroNoites();

            // Calcula o valor total da estadia
            double valorTotal = CalcularValor(opcaoEscolhida, numeroNoites);

            // Exibe o valor total
            Console.WriteLine($"O valor total da sua estadia é: R$ {valorTotal:F2}");
        }

        // Função para exibir o menu e obter a escolha do cliente
        static string ObterOpcaoCliente()
        {
            while (true)
            {
                Console.WriteLine("Escolha o tipo de acomodação:");
                Console.WriteLine("1 - Suíte de Luxo (R$ 500,00 por noite)");
                Console.WriteLine("2 - Suíte Comum (R$ 200,00 por noite)");
                Console.WriteLine("3 - Suíte Básica (R$ 100,00 por noite)");

                string opcao = Console.ReadLine();
                if (opcao == "1" || opcao == "2" || opcao == "3")
                {
                    return opcao;
                }
                else
                {
                    Console.WriteLine("Opção inválida! Por favor, escolha uma das opções válidas.");
                }
            }
        }

        // Função para obter o número de noites
        static int ObterNumeroNoites()
        {
            while (true)
            {
                Console.Write("Quantas noites você deseja ficar hospedado? ");
                if (int.TryParse(Console.ReadLine(), out int noites) && noites > 0)
                {
                    return noites;
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido de noites (maior que zero).");
                }
            }
        }

        // Função para calcular o valor total da estadia com base na opção e nas noites
        static double CalcularValor(string estadia, int noites)
        {
            double valorDiaria = 0;

            switch (estadia)
            {
                case "1": // Suíte de Luxo
                    valorDiaria = 500.00;
                    break;
                case "2": // Suíte Comum
                    valorDiaria = 200.00;
                    break;
                case "3": // Suíte Básica
                    valorDiaria = 100.00;
                    break;
            }

            return valorDiaria * noites;
        }
    }
}




