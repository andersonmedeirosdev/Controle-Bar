using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.WriteLine("--MENU DE OPÇÕES--");
            Console.WriteLine("[1] PARA MENU GARÇONS");
            Console.WriteLine("[2] PARA MENU PRODUTOS");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
