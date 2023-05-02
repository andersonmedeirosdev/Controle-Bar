using ControleBar.ConsoleApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        public override EntidadeBase BuscarPorId(int id)
        {
            return(Conta)base.BuscarPorId(id);
        }

        public void AdicionarPedido(int idConta, Pedido pedido)
        {
            Conta conta = (Conta)base.BuscarPorId(idConta);

            conta.AdicionarPedido(pedido);
        }
    }
}
