using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Aprovado_ou_reprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //4)  Uma fábrica tem uma linha de produção capaz de produzir 400 peças/dia. Um funcionário controla a qualidade,
        //cadastrando o número da peça e o seu estado (aprovado ou reprovado). Criar um programa para cadastrar o
        //controle de qualidade e imprimir o total de peças aprovadas e reprovadas no final do dia.
        int contador, reprovado, aprovado, estado;
        aprovado = 0;
        reprovado = 0;
        for(contador = 1; contador <= 10; contador++) {
        Console.Write("PEÇA ","\n");
                Console.WriteLine(contador);
        Console.Write("Digite 1 para APROVADA ou 2 para REPROVADA: ","\n");
        estado = int.Parse(Console.ReadLine()); 
        if(estado == 1) {
        aprovado = aprovado + 1;
        }
        else if(estado == 2) {
        reprovado = reprovado + 1;
        }
        else {
        Console.Write("\n");
        Console.Write("Estado inválido! Digite 1 ou 2.\n");
        contador = contador - 1;
        }
        }
        Console.Write("Quantidade de peças aprovadas: ","\n");
        Console.WriteLine(aprovado);
        Console.Write("Quantidade de peças reprovadas: ","\n");
        Console.WriteLine(reprovado);
        }
    }
}
