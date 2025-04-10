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
                        CadastrarCliente.CadCliente();   //função escondida , agora ta ativada
                       
                        break;  //break = pare 
                    case 2:
                        Cadastrofornecedor.Cadfornecedor();                        
                        break;
                    case 3:
                        CadastrarFuncionario.CadFuncionario();                        
                        break;
                    case 4:
                        Produto.Produt();                        
                        break;
                    case 5:
                        Pedido.Pedid();                        
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
    }
}
