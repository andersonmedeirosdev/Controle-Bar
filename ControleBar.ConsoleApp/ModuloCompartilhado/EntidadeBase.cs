using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloCompartilhado
{
    public abstract class EntidadeBase
    {
        public int id;

        public void AtribuirId(int numero)
        {
            this.id = numero;
        }

        public int ObterId()
        {
            return this.id;
        }

        public abstract void Editar(EntidadeBase entidade);
    }
}
