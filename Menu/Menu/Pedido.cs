using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Pedido
    {
        public static void Pedid()
        {
            Console.WriteLine("\nCadastro do Pedido");
            Console.Write("Dígite o código do Pedido: ");
            int pedido = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pedido {pedido} cadastrado com sucesso!");
        }
    }
}
