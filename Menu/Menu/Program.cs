using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um sistema de menu em cada opção cadastre um item, controlando o acesso do teclado.

            int opcao = 1;                  //escolhemso o valor para a variante para que funcione com o "while"

            while (opcao != 0) {            //Criação do laço de repetição infinita
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\r\n███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗" +
                                  $"\r\n████╗░████║██╔════╝████╗░██║██║░░░██║" +
                                  $"\r\n██╔████╔██║█████╗░░██╔██╗██║██║░░░██║" +
                                  $"\r\n██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║" +
                                  $"\r\n██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝" +
                                  $"\r\n╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");
                Console.ResetColor();
                Console.WriteLine("\n Menu de Cadastro\n");
                Console.WriteLine("1 - Cadastro de Cliente");
                Console.WriteLine("2 - Cadastro de Fornecedor");
                Console.WriteLine("3 - Cadastro de Funcionários");
                Console.WriteLine("4 - Cadastro de Produtos");
                Console.WriteLine("5 - Cadastro de Pedidos");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha umas das opções: ");
                // out = usamos para dar uma função ao "...TryParse(Console.ReadLine()"  
                //  || = e
                // !int.TryParse = usado para verificar se a palavra certa
                // ! = 
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                {
                    Console.WriteLine("Opção Invalidade, Dígite Novamente");
                }
                switch (opcao)
                {
                    // case = caso
                    case 1:
                        CadastrarCliente();   //função escondida , agora ta ativada
                        Console.WriteLine("\nCadastro de Cliente");
                        Console.Write("Dígite o nome do cliente: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine($"Cliente {nome} cadastrado com sucesso!");  // colocamos o "$" para podermos colocar a variante "nome" no texto.
                        break;  //break = pare 
                    case 2:
                        Cadastrofornecedor();
                        Console.WriteLine("\nCadastro de Fornecedor");
                        Console.Write("Dígite o código do Fornecedor: ");
                        int fornecedor = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Fornecedor {fornecedor} cadastrado com sucesso!");
                        break;
                    case 3:
                        CadastrarFuncionario();
                        Console.WriteLine("\nCadastro do Funcionário");
                        Console.Write("Dígite o nome do Funcionário: ");
                        string funcionario = Console.ReadLine();
                        Console.WriteLine($"Fucionário {funcionario} cadastrado com sucesso!");
                        break;
                    case 4:
                        Produto();
                        Console.WriteLine("\nCadastro do Produto");
                        Console.Write("Dígite o código do Produto: ");
                        int produto = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Produto {produto} cadastrado com sucesso!");
                        break;
                    case 5:
                        Pedido();
                        Console.WriteLine("\nCadastro do Pedido");
                        Console.Write("Dígite o código do Pedido: ");
                        int pedido = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Pedido {pedido} cadastrado com sucesso!");
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Saindo...");
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Tente Novamente");
                        break;
                }
                if(opcao != 0)
                {
                    Console.WriteLine("\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey(); // ReadKey = absorve a tecla escolhida.
                }
            }// fim da chave = "while (opcao != 0){   "
        }






    //agora realizaremos uma nova função 
    static void CadastrarCliente()
        {
            Console.WriteLine("\nCadastro de Cliente");
            Console.Write("Dígite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Cliente {nome} cadastrado com sucesso!");
        }
    static void Cadastrofornecedor()
        {
            Console.WriteLine("\nCadastro de Fornecedor");
            Console.Write("Dígite o código do Fornecedor: ");
            int fornecedor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Fornecedor {fornecedor} cadastrado com sucesso!");
        }
    static void CadastrarFuncionario()
        {
            Console.WriteLine("\nCadastro do Funcionário");
            Console.Write("Dígite o nome do Funcionário: ");
            string funcionario = Console.ReadLine();
            Console.WriteLine($"Fucionário {funcionario} cadastrado com sucesso!");
        }
        static void Produto()
        {
            Console.WriteLine("\nCadastro do Produto");
            Console.Write("Dígite o código do Produto: ");
            int produto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Produto {produto} cadastrado com sucesso!");
        }
        static void Pedido()
        {
            Console.WriteLine("\nCadastro do Pedido");
            Console.Write("Dígite o código do Pedido: ");
            int pedido = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pedido {pedido} cadastrado com sucesso!");
        }
    }
}
