using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Cadastrofornecedor
    {
        public static void Cadfornecedor()
        {
            Console.WriteLine("\nCadastro de Fornecedor");
            Console.Write("Dígite o código do Fornecedor: ");
            int fornecedor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Fornecedor {fornecedor} cadastrado com sucesso!");
        }
    }
}
