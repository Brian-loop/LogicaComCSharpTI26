using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarFuncionario
    {
        public static void CadFuncionario()
        {
            Console.WriteLine("\nCadastro do Funcionário");
            Console.Write("Dígite o nome do Funcionário: ");
            string funcionario = Console.ReadLine();
            Console.WriteLine($"Fucionário {funcionario} cadastrado com sucesso!");
        }
    }
}
