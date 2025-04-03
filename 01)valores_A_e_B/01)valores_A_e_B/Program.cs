using System;

namespace _01_valores_A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um algoritimo que leia dois valores inteiros A e B, se os valores de A e B forem iguais,
            //deverá somar valores, caso contrario deve multiplicar A por B. Ao final qualquer um dos cálculos
            //deve se atribuir o resultado a uma variavel C e imprimir o valor na tela.
//▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
            Console.Title = "SENAC";    //comando para mudar o nome da janela
            Console.ForegroundColor = ConsoleColor.Red;   //este comando faz dar cor a partir da linha abaixo.
            // colocamos (@) para as letra ficar da foram que a gente copiou e não em uma linha só.
            Console.WriteLine("       ╔═════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(@"       ║                                                                                                         ║
       ║   ██▒   █▓ ▄▄▄       ██▓     ▒█████   ██▀███      ██▓ ███▄    █ ▄▄▄█████▓▓█████  ██▓ ██▀███   ▒█████    ║
       ║  ▓██░   █▒▒████▄    ▓██▒    ▒██▒  ██▒▓██ ▒ ██▒   ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▓██▒▓██ ▒ ██▒▒██▒  ██▒  ║
       ║   ▓██  █▒░▒██  ▀█▄  ▒██░    ▒██░  ██▒▓██ ░▄█ ▒   ▒██▒▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ▒██▒▓██ ░▄█ ▒▒██░  ██▒  ║
       ║    ▒██ █░░░██▄▄▄▄██ ▒██░    ▒██   ██░▒██▀▀█▄     ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ░██░▒██▀▀█▄  ▒██   ██░  ║
       ║     ▒▀█░   ▓█   ▓██▒░██████▒░ ████▓▒░░██▓ ▒██▒   ░██░▒██░   ▓██░  ▒██▒ ░ ░▒████▒░██░░██▓ ▒██▒░ ████▓▒░  ║
       ║     ░ ░░    ▒   ▒▒ ░░ ░ ▒  ░  ░ ▒ ▒░   ░▒ ░ ▒░    ▒ ░░ ░░   ░ ▒░    ░     ░ ░  ░ ▒ ░  ░▒ ░ ▒░  ░ ▒ ▒░   ║
       ║     ░ ▐░   ▒▒   ▓▒█░░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░   ░▓  ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░░▓  ░ ▒▓ ░▒▓░░ ▒░▒░▒░   ║
       ║       ░░    ░   ▒     ░ ░   ░ ░ ░ ▒    ░░   ░     ▒ ░   ░   ░ ░   ░         ░    ▒ ░  ░░   ░ ░ ░ ░ ▒    ║
       ║        ░        ░  ░    ░  ░    ░ ░     ░         ░           ░             ░  ░ ░     ░         ░ ░    ║
       ║       ░                                                                                                 ║
       ║                                                                                                         ║");
            Console.Write("       ╚═════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;  //este comando faz dar cor a partir da linha abaixo.
            Console.WriteLine(" 1 - Faça um algoritimo que leia dois valores inteiros A e B, se os valores de A e B forem iguais,deverá somar valores, caso contrario deve multiplicar A por B. Ao final qualquer um dos cálculos\r\ndeve se atribuir o resultado a uma variavel C e imprimir o valor na tela.");
            Console.ResetColor();   //comando para a parar de dar cor.
            int numA, numB, numC;

            Console.WriteLine();
            Console.Write("Digite seu primeiro número: ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo número:");
            numB = int.Parse(Console.ReadLine());
            if (numA == numB)
            {
                numC = numA + numB;
            }
            else
            {
                numC = numA * numB;
            }
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("O resultado é: " + numC);
            Console.ResetColor();
        }
    }
}
