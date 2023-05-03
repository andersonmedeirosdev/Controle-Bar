using ControleBar.ConsoleApp.ModuloGarçom;
using ControleBar.ConsoleApp.ModuloCompartilhado;
using ControleBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ControleBar.ConsoleApp.ModuloConta
{
    internal class Conta : EntidadeBase
    {
        public DateTime data;
        public DateTime hoje = DateTime.Now;
        public double total;
        public Mesa mesa;
        public Garcom garcom;
        public bool emAberto;
        public double valorParcial { get => ObterValorParcial(); }

        public Conta(Mesa mesa, Garcom garcom)
        {
            this.mesa = mesa;
            this.garcom = garcom;
            this.emAberto = true;
            this.data = DateTime.Today;
            this.mesa.AlterarStatusMesa();
        }

        ArrayList pedidos = new ArrayList();

        public override void Editar(EntidadeBase entidade)
        {
            Conta conta = (Conta) entidade;

            this.mesa = conta.mesa;
            this.garcom = conta.garcom;
        }

        public void AdicionarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        private double ObterValorParcial()
        {
            double valor = 0;

            foreach (Pedido item in pedidos)
            {
                valor += item.CalculoPedido();
            }
            return valor;
        }

        public void FinalizarConta()
        {
            foreach(Pedido item in pedidos)
            {
                this.total += item.CalculoPedido();
            }

            emAberto = false;

            this.mesa.AlterarStatusMesa();
        }

        public override string ToString()
        {
            return $"ID: {id} | DATA: {data} | MESA: {mesa.numero} | VALOR: {valorParcial} | CONTA: {(emAberto ? "aberta" : "fechada")}";
        }
    }
}
