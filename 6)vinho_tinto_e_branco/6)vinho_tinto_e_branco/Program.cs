using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_vinho_tinto_e_branco
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //6)  Construa um programa que permita fazer o levantamento do estoque de vinhos de uma adega, tendo como dados de entrada tipos de vinho,
        //sendo: "t" para tinto e "b" para branco. Como a quantidade de vinhos é desconhecida,
        //utilize a letra "f" para finalizar. Após finalizar o programa deve mostrar a quantidade de cada vinho na adega.
        int tinto = 0, branco = 0;
        string tipo_vinho;            //string = cadeia(portugol)
        while(true){                 //while = enquanto(portugol), enquanto(verdadeiro) = while(true)
        Console.Write("Digite o tipo de vinho (t para tinto, b para branco, f para finalizar): ");
        tipo_vinho = Console.ReadLine();   // aqui não podia usar a palavra "int" para ler a varíavel por conta do comando "string"
        if(tipo_vinho == "f"){
        break;      //break = pare/interrompa (portugol)
        }
        else{
        if(tipo_vinho == "t"){
        tinto++;
        }
        else{
        if(tipo_vinho == "b"){
        branco++;
        }
        else{
        Console.Write("Tipo ínvalido! Digite novamente. \n");
        }
        }
        }
        }
        Console.WriteLine($"Quantidade de vinhos tintos: {tinto}");
        Console.WriteLine($"Quantidade de vinhos brancos: {branco}");

        }
    }
}
