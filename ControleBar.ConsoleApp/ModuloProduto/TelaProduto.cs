using ControleBar.ConsoleApp.ModuloCompartilhado;
using ControleBar.ConsoleApp.ModuloGarçom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto) { 
            this.repositorioBase = repositorioProduto;
        }
        public override string nomeEntidade { get; set; } = "Produto";

        public override void MostrarTabela(ArrayList registros, bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                Console.WriteLine($"{"ID:",-5} | {"PRODUTO:",-20} | {"PREÇO:",-15}");

            Console.WriteLine("---------------------------------------");

            foreach (Produto item in repositorioBase.BuscarTodos())
            {
                Console.WriteLine($"{item.ObterId(),-5} {item.nomeProduto,-20} {item.preco,-15}");
            }

            Console.ReadLine();
        }

        public override EntidadeBase ObterRegistro()
        {
            MostrarTexto("Informe o nome do produto:");
            string nomeProduto = Console.ReadLine();

            MostrarTexto("Informe o preço:");
            double preco = Convert.ToDouble(Console.ReadLine());

            return new Produto(nomeProduto, preco);
        }
    }
}
