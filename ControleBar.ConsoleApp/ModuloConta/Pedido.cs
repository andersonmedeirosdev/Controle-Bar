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

        public Pedido(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;
        }
        public double CalculoPedido()
        {
            return produto.preco * quantidade;
        }
        public override void Editar(EntidadeBase entidade)
        {
            throw new NotImplementedException();
        }
    }
}
