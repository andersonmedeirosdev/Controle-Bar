using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloCompartilhado
{
    public abstract class TelaBase
    {
        public RepositorioBase repositorioBase = null!;

        public abstract string nomeEntidade { get; set; }


        public abstract EntidadeBase ObterRegistro();

        public abstract void MostrarTabela(ArrayList registros, bool mostrarCabecalho);

        public void MostrarTexto(string texto)
        {
            Console.Clear();
            Console.WriteLine(texto);
        }

        public void MostrarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }
        public void Cadastrar()
        {
            MostrarTexto("CADASTRAR");

            EntidadeBase entidade = ObterRegistro();

            repositorioBase.Adicionar(entidade);

            MostrarMensagem("Registro cadastrado com sucesso...", ConsoleColor.Green);
        }

        public virtual void VisualizarRegistros()
        {
            MostrarTexto($"LISTAR REGISTROS {nomeEntidade}s");

            ArrayList registros = repositorioBase.BuscarTodos();

            if (registros.Count == 0)
            {
                MostrarMensagem("Nenhum registro cadastrado...", ConsoleColor.Yellow);
                Console.ReadLine();
                return;
            }

            MostrarTabela(registros, true);
        }

        public virtual void Editar()
        {
            MostrarTexto($"EDITAR REGISTRO {nomeEntidade}");

            VisualizarRegistros();

            ArrayList registros = repositorioBase.BuscarTodos();

            Console.WriteLine("Informe o id para editar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            EntidadeBase entidadeModificada = ObterRegistro();
            repositorioBase.Editar(id, entidadeModificada);

            MostrarMensagem("Registro editado com sucesso...", ConsoleColor.Green);
        }

        public void Excluir()
        {
            MostrarTexto($"EXCLUIR REGISTRO {nomeEntidade}");

            ArrayList registros = repositorioBase.BuscarTodos();

            Console.WriteLine("Informe o id para excluir: ");
            int id = Convert.ToInt32(Console.ReadLine());

            repositorioBase.Excluir(id);

            MostrarMensagem("Registro excluído com sucesso", ConsoleColor.Red);
        }

        public virtual string MostrarMenu()
        {
            MostrarTexto($"MENU {nomeEntidade}s");
            Console.WriteLine("[1] PARA CADASTRAR");
            Console.WriteLine("[2] PARA VISUALIAR");
            Console.WriteLine("[3] PARA EDITAR");
            Console.WriteLine("[4] PARA EXCLUIR");
            Console.WriteLine("[9] PARA VOLTAR");

            return Console.ReadLine();
        }

        public virtual void RenderizarTabela(ArrayList lista, bool esperarTecla)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            if (esperarTecla)
            {
                Console.ReadLine();
            }
        }
    }
}
