using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_album
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um sistema de cadastro de albuns de um artista/banda em que será possivel cadastrar um número X de músicas informada 
            //pelo usuário. Crie um menu de opções para isso.
            int opcao = 1;
            while (opcao != 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@" 
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀▀   █▀ █░█ ▄▀█   █▀▄▀█ █░█ █▀ █ █▀▀ ▄▀█   █
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ ██▄   ▄█ █▄█ █▀█   █░▀░█ █▄█ ▄█ █ █▄▄ █▀█   ▄");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Digite 1 para Cadastrar um album ");
                Console.WriteLine("Digite 2 para Mostrar albuns e música ");
                Console.Write("Digite 3 para ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SAIR");
                Console.ResetColor();
                Console.Write("Qual é sua opção: ");
                while (!int.TryParse(Console.ReadLine(), out opcao || opcao < 0 || opcao > 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opção não correspondente, dígite novamente !");
                    Console.ResetColor();
                }
                switch (opcao)
                {

                    case 1 :
                        
                        break;
                    case 2 :

                        break;
                    case 3 :

                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }                
    
    }
}
