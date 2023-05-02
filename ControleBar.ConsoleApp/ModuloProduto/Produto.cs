using ControleBar.ConsoleApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string nomeProduto;
        public double preco;

        public Produto(string nomeProduto, double preco)
        {
            this.nomeProduto = nomeProduto;
            this.preco = preco;
        }

        public override void Editar(EntidadeBase entidade)
        {
            Produto produto = (Produto)entidade;

            this.nomeProduto = produto.nomeProduto;
            this.preco = produto.preco;
        }
    }
}
