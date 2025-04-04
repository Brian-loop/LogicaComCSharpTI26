using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sistema_de_hospedagem_de_hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um sistema de hospedagem onde o cliente pode escolher entre três tipos de acomodações: Suíte de Luxo, Suíte Comum e Suíte Básica.
            //O sistema deve ser capaz de receber a escolha do cliente,validar a opção selecionada e calcular o valor total da estadia com base na opção escolhida e no número de noites.
            //Cálculo do Valor da Estadia: O valor da diária pode ser definido como:
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Suíte de Luxo: R$ 500,00 por noite.
            //Suíte Comum: R$ 200,00 por noite.
            //Suíte Básica: R$ 100,00 por noite.
            //O cliente deverá informar o número de noites que ficará hospedado.
            //(o programa nao deve fechar caso o cliente escolha uma opção que nao exista)
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Title = "Hotel";
            int noites;
            double suiteLuxo = 500.00, suiteComum = 200.00, suiteBasica = 100.00;             
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--ESCOLHA O QUARTO QUEIRA SE HOSPEDAR--");
            Console.WriteLine("Tabela de preços:");
            Console.Write("■ Suite de Luxo = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("R$500.00");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("■ Suite Comum = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("R$200.00");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("■ Suite Básica = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("R$100.00");
            while (true) {
            Console.ResetColor();
            Console.WriteLine("Digite L para a Suíte de Luxo");
            Console.WriteLine("Digite C para a Suíte Comum");
            Console.WriteLine("Digite B para a Suíte Basica:");
                string tipoSuite;
                tipoSuite = Console.ReadLine();
                if (tipoSuite == "L") {                
                    Console.WriteLine("Quantas noites deseja se hospedar");
                noites = int.Parse(Console.ReadLine()
                    double total = noites * suiteLuxo);
                Console.Write(noites + "noite(s) darão" + total.T)               

                
                else {
                    if (tipoSuite == "B")
        }
    }
}
