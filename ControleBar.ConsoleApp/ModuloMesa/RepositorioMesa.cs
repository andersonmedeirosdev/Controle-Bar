using ControleBar.ConsoleApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class RepositorioMesa : RepositorioBase
    {
        public override Mesa BuscarPorId(int id)
        {
            return(Mesa)base.BuscarPorId(id);
        }
    }
}
