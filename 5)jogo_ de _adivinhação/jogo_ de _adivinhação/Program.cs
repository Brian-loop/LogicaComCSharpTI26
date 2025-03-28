using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo__de__adivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5)Simular o jogo de adivinhação: o jogador 1 escolhe um número entre 1 e 10;
            //o jogador 2 insere números na tentativa de acertar o número escolhido pelo jogador 1.
            //Quando ele acertar, o algoritmo deve informar que ele acertou o número x (escolhido pelo jogador 1) em x tentativas (quantidade de tentativas do jogador 2).
            int num1, num2, contador = 0;
            Console.WriteLine("TENTE A ADIVINHAR O NÚMERO ESCOLHIDO PELO OUTRO JOGADOR!!");
            Console.Write("Digite um numero Jogador N'1 de 1 a 10: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();    // Console.Clear()  = limpa(portugol)
            Console.Write("Jogador N'2 adivinhe o numero escolhido pelo Jogador N'1: ");
            num2 = int.Parse(Console.ReadLine());
            while (num1 != num2) {
            contador = contador + 1;
            Console.Write("numero incorreto, digite numero novamente: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            }
            Console.WriteLine($"O número era {num1} ...Parabens voce acertou depois de: {contador} tentativas");
        }
    }
}
    
