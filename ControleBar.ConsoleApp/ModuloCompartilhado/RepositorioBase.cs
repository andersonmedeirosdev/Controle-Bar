using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloCompartilhado
{
    public class RepositorioBase
    {
        protected ArrayList registros = new ArrayList();

        private int contadorId = 1;

        public virtual void Adicionar(EntidadeBase entidade)
        {
            entidade.AtribuirId(contadorId++);
            this.registros.Add(entidade);
        }

        public virtual EntidadeBase BuscarPorId(int id)
        {
            ArrayList registros = BuscarTodos();

            EntidadeBase entidade = null!;

            foreach (EntidadeBase item in registros)
            {
                if (item.ObterId() == id)
                {
                    entidade = item;
                    break;
                }
            }
            return entidade;
        }

        public ArrayList BuscarTodos()
        {
            return registros;
        }

        public void Editar(int id, EntidadeBase entidadeModificada)
        {
            EntidadeBase entidadeSolicitada = BuscarPorId(id);

            entidadeSolicitada.Editar(entidadeModificada);
        }

        public void Excluir(int id)
        {
            EntidadeBase entidadeSolicitada = BuscarPorId(id);

            registros.Remove(entidadeSolicitada);
        }

    }
}
