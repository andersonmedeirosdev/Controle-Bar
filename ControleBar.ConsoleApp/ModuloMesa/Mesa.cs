using ControleBar.ConsoleApp.ModuloCompartilhado;
using ControleBar.ConsoleApp.ModuloConta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.ConsoleApp.ModuloCompartilhado;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public bool disponivel;
        public string numero;

        public Mesa(string numero)
        {
            this.numero = numero;
            this.disponivel = true;
        }

        public void AlterarStatusMesa()
        {
            this.disponivel = !this.disponivel;
        }
        
        public override void Editar(EntidadeBase entidade)
        {
            Mesa mesa = (Mesa) entidade;
            this.numero = mesa.numero;
        }
    }
}
