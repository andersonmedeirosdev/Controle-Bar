using ControleBar.ConsoleApp.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloGarçom
{
    public class TelaGarcom : TelaBase
    {
        public TelaGarcom(RepositorioGarcom repositorioGarcom) { 
            repositorioBase = repositorioGarcom;
        }
        public override string nomeEntidade { get; set; } = "Garçom";

        public override void MostrarTabela(ArrayList registros, bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                Console.WriteLine($"{"ID:",-5} | {"NOME:",-20} | {"CPF:",-15}");

            Console.WriteLine("---------------------------------------");

            foreach (Garcom item in repositorioBase.BuscarTodos())
            {
                Console.WriteLine($"{item.ObterId(),-5} {item.nomeGarcom,-20} {item.cpf,-15}");
            }

            Console.ReadLine();
        }

        public override EntidadeBase ObterRegistro()
        {
            MostrarTexto("Informe o nome do garçom:");
            string nomeGarcom = Console.ReadLine();

            MostrarTexto("Informe o cpf do garçom:");
            string cpf = Console.ReadLine();

            return new Garcom(nomeGarcom, cpf);
        }
    }
}
