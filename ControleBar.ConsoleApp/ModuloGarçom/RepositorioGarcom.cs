using ControleBar.ConsoleApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloGarçom
{
    public class RepositorioGarcom : RepositorioBase
    {
        public override Garcom BuscarPorId(int id)
        {
            return(Garcom)base.BuscarPorId(id);
        }
    }
}
