using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peso_e__sobra_peixe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, sobra; // double = é igual ao "real" do portugol
            Console.Write("Digite o peso pescado: "); //Console.Write("")  = é o equivalente a "escreva" do portugol.
            peso = int.Parse(Console.ReadLine()); //int.Parse(Console.ReadLine())  = é usado para ler numeros.
            sobra = (peso - 50) * 4;
            Console.Write(sobra);
        }
    }
}
