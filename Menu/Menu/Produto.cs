using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Produto
    {
        public static void Produt()
        {
            Console.WriteLine("\nCadastro do Produto");
            Console.Write("Dígite o código do Produto: ");
            int produto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Produto {produto} cadastrado com sucesso!");
        }
    }
}
