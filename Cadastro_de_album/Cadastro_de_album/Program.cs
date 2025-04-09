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
            int musica = 1;
            while (musica != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀▀   █▀ █░█ ▄▀█   █▀▄▀█ █░█ █▀ █ █▀▀ ▄▀█   █
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ ██▄   ▄█ █▄█ █▀█   █░▀░█ █▄█ ▄█ █ █▄▄ █▀█   ▄");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Dígite o nome da música: ");
                string NomeMusica = Console.ReadLine();
                Console.WriteLine($"Música {NomeMusica} cadastrada com sucesso!!!");


                  
            }
        }
    }
}
