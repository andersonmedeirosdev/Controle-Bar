using ControleBar.ConsoleApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloGarçom
{
    public class Garcom : EntidadeBase
    {
        public string nomeGarcom;
        public string cpf;

        public Garcom(string nomeGarcom, string cpf)
        {
            this.nomeGarcom = nomeGarcom;
            this.cpf = cpf;
        }

        public override void Editar(EntidadeBase entidade)
        {
            Garcom garcom = (Garcom) entidade;

            this.nomeGarcom = garcom.nomeGarcom;
            this.cpf = garcom.cpf;
        }
    }
}
