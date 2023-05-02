using ControleBar.ConsoleApp.ModuloCompartilhado;
using ControleBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloConta 
{
    public class Pedido : EntidadeBase
    {
        public Produto produto;
        public int quantidade;
        public double total;

        public Pedido(Produto produto, int quantidade, double total)
        {
            this.produto = produto;
            this.quantidade = quantidade;
            this.total = total;
        }
        public void CalculoPedido()
        {
            total = produto.preco * quantidade;
        }
        public override void Editar(EntidadeBase entidade)
        {
            throw new NotImplementedException();
        }
    }
}
