using ControleBar.ConsoleApp.ModuloGarçom;
using ControleBar.ConsoleApp.ModuloCompartilhado;
using ControleBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections;
using System.Xml.Schema;

namespace ControleBar.ConsoleApp.ModuloConta
{
    internal class TelaConta : TelaBase
    {
        RepositorioMesa repositorioMesa;
        RepositorioGarcom repositorioGarcom;
        RepositorioConta repositorioConta;
        public TelaConta(RepositorioConta repositorioConta, RepositorioMesa repositorioMesa, RepositorioGarcom repositorioGarcom)
        {
            repositorioBase = repositorioConta;
            repositorioConta = repositorioConta;
            repositorioMesa = repositorioMesa;
            repositorioGarcom = repositorioGarcom;
        }
        public override string nomeEntidade { get; set; } = "Conta";

        public override void MostrarTabela(ArrayList registros, bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                Console.WriteLine($"{"ID:",-5} | {"MESA:",-20} | {"GARÇOM:",-15}");

            Console.WriteLine("---------------------------------------------");

            foreach (Conta item in repositorioBase.BuscarTodos())
            {
                Console.WriteLine($"{item.ObterId(),-5} {item.mesa.numero,-20} {item.garcom.nomeGarcom,-15}");
            }

            Console.ReadLine();
        }

        public override EntidadeBase ObterRegistro()
        {
            ArrayList mesas = repositorioMesa.BuscarTodos();
            foreach (Mesa item in mesas)
            {
                Console.WriteLine($"{item.id} {item.status} {item.numero}");
            }
            Console.WriteLine("Informe o id da mesa:");
            int id = Convert.ToInt32(Console.ReadLine());
            Mesa mesa = repositorioMesa.BuscarPorId(id);

            ArrayList garcons = repositorioGarcom.BuscarTodos();
            foreach (Garcom item in garcons)
            {
                Console.WriteLine($"{item.id} {item.nomeGarcom}");
            }
            Console.WriteLine("Informe o id da conta:");
            int idGarcom = Convert.ToInt32(Console.ReadLine());
            Garcom garcom = repositorioGarcom.BuscarPorId(id);

            double total = 0;

            return new Conta(mesa, garcom, total);
        }

        public void RealizarPedido()
        {
            
        }
    }
}
