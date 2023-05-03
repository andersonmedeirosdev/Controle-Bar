using ControleBar.ConsoleApp.ModuloGarçom;
using ControleBar.ConsoleApp.ModuloCompartilhado;
using ControleBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections;
using System.Xml.Schema;
using ControleBar.ConsoleApp.ModuloProduto;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace ControleBar.ConsoleApp.ModuloConta
{
    internal class TelaConta : TelaBase
    {
        RepositorioMesa repositorioMesa;
        RepositorioGarcom repositorioGarcom;
        RepositorioConta repositorioConta;
        RepositorioProduto repositorioProduto;
        public TelaConta(RepositorioConta repositorioConta, RepositorioMesa repositorioMesa, RepositorioGarcom repositorioGarcom, RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioConta;
            this.repositorioConta = repositorioConta;
            this.repositorioMesa = repositorioMesa;
            this.repositorioGarcom = repositorioGarcom;
            this.repositorioProduto = repositorioProduto;
        }
        public override string nomeEntidade { get; set; } = "Conta";

        public override void MostrarTabela(ArrayList registros, bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                Console.WriteLine("CONTAS");

            Console.WriteLine("---------------------------------------------");

            foreach (Conta item in repositorioBase.BuscarTodos())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public override string MostrarMenu()
        {
            MostrarTexto($"MENU {nomeEntidade}s");
            Console.WriteLine("[1] ABRIR CONTA");
            Console.WriteLine("[2] INCLUIR PEDIDO");
            Console.WriteLine("[3] VISUALIZAR CONTA");
            Console.WriteLine("[4] FATURAMENTO DIÁRIO");
            Console.WriteLine("[5] FECHAR CONTA");

            return Console.ReadLine();
        }

        public override EntidadeBase ObterRegistro()
        {
            ArrayList mesas = repositorioMesa.BuscarTodos();
            Console.WriteLine("ID - DISPONÍVEL - NÚMERO");
            foreach (Mesa item in mesas)
            {
                Console.WriteLine($"{item.id} {(item.disponivel ? "disponível - sim" : "disponível - não")} {item.numero}");
            }
            Console.WriteLine("Informe o id da mesa:");
            int id = Convert.ToInt32(Console.ReadLine());
            Mesa mesa = repositorioMesa.BuscarPorId(id);

            ArrayList garcons = repositorioGarcom.BuscarTodos();
            Console.WriteLine("ID - GARÇOM");
            foreach (Garcom item in garcons)
            {
                Console.WriteLine($"{item.id} {item.nomeGarcom}");
            }
            Console.WriteLine("Informe o id do garçom:");
            int idGarcom = Convert.ToInt32(Console.ReadLine());
            Garcom garcom = repositorioGarcom.BuscarPorId(idGarcom);

            return new Conta(mesa, garcom);
        }

        public void FecharConta()
        {
            ArrayList contas = repositorioConta.BuscarTodos();
            foreach(Conta conta in contas)
            {
                if(conta.emAberto)
                {
                    Console.WriteLine($"ID: {conta.id} | Mesa: {conta.mesa.numero} | Garçom: {conta.garcom.nomeGarcom} | Valor parcial: {conta.valorParcial}");
                }
            }
            Console.WriteLine("Informe o ID da conta que deseja fechar:");
            int idConta = Convert.ToInt32(Console.ReadLine());

            Conta contaSelecionada = (Conta)repositorioConta.BuscarPorId(idConta);
            if(contaSelecionada != null && contaSelecionada.emAberto)
            {
                contaSelecionada.FinalizarConta();
            }
        }
        
        public void VisualizarFaturamento()
        {
            ArrayList contas = repositorioConta.BuscarTodos();

            double faturamentoDia = 0;

            foreach(Conta conta in contas)
            {
                if(conta.data == DateTime.Today)
                {
                    faturamentoDia += conta.valorParcial;
                }
            }

            Console.WriteLine($"O faturamento diário é {faturamentoDia}");
            Console.ReadLine();
        }

        public void RealizarPedido()
        {
            ArrayList contas = repositorioConta.BuscarTodos();

            foreach(Conta item in contas)
            {
                if(item.emAberto == true)
                {
                    Console.WriteLine($"{item.id} {item.mesa.numero}");
                }
            }
            Console.WriteLine("Infome o id da conta:");
            int id = Convert.ToInt32(Console.ReadLine());

            ArrayList produtos = repositorioProduto.BuscarTodos();

            foreach(Produto item in produtos)
            {
                Console.WriteLine($"{item.id} {item.nomeProduto} {item.preco}");
            }
            Console.WriteLine("Informe o id do produto:");
            int idProduto = Convert.ToInt32(Console.ReadLine());
            Produto produto = repositorioProduto.BuscarPorId(idProduto);

            Console.WriteLine("Informe a quantidade:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Pedido pedido = new Pedido(produto, quantidade);

            repositorioConta.AdicionarPedido(id, pedido);
        }
    }
}
