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
        public double total;
        public Mesa mesa;
        public Garcom garcom;

        public Conta(Mesa mesa, Garcom garcom, double total)
        {
            this.mesa = mesa;
            this.garcom = garcom;
            this.total = total;
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
    }
}
