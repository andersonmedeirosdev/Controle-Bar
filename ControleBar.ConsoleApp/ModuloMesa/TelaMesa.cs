using ControleBar.ConsoleApp.ModuloCompartilhado;
using ControleBar.ConsoleApp.ModuloConta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            this.repositorioBase = repositorioMesa;
        }
        public override string nomeEntidade { get; set; } = "Mesa";


        public override void MostrarTabela(ArrayList registros, bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                Console.WriteLine($"{"ID:",-5} | {"STATUS:",-20} | {"NUMERO:",-15}");

            Console.WriteLine("---------------------------------------------");

            foreach (Mesa item in repositorioBase.BuscarTodos())
            {
                Console.WriteLine($"{item.ObterId(),-5} {item.status,-20} {item.numero,-15}");
            }

            Console.ReadLine();
        }

        public override EntidadeBase ObterRegistro()
        {
            MostrarTexto("Informe o status da mesa:");
            bool status = Convert.ToBoolean(Console.ReadLine());

            MostrarTexto("Informe o número da mesa:");
            string numero = Console.ReadLine();


            return new Mesa(status, numero);
        }
    }
}
