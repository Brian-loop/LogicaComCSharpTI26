using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarCliente
    {
        public static void CadCliente() //colocamos o "public void " para que este arquivo seja compratilhado com o principal
        {
            Console.WriteLine("\nCadastro de Cliente");
            Console.Write("Dígite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Cliente {nome} cadastrado com sucesso!");// colocamos o "$" para podermos colocar a variante "nome" no texto.
        }
    }
}
