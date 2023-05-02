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
        public bool status;
        public string numero;

        public Mesa(bool status, string numero)
        {
            this.status = status;
            this.numero = numero;
        }
        
        public override void Editar(EntidadeBase entidade)
        {
            Mesa mesa = (Mesa) entidade;

            this.status = mesa.status;
            this.numero = mesa.numero;
        }
    }
}
