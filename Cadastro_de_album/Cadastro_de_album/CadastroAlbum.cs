using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_album
{
    internal class CadastroAlbum
    {
        public static void CadAlbum()
        {
            Console.Write("Digite o nome do álbum: ");
            string nomeAlbum = Console.ReadLine();

            Console.Write($"Quantas músicas deseja cadastrar no álbum '{nomeAlbum}'? ");
            int numMusicas = int.Parse(Console.ReadLine());

            List<string> musicas = new List<string>();

        }
    }
}
