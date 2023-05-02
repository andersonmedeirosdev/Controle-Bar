using ControleBar.ConsoleApp.ModuloGarçom;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.ModuloProduto;

namespace ControleBar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom();
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            RepositorioProduto repositorioProduto = new RepositorioProduto();
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            RepositorioMesa repositorioMesa = new RepositorioMesa();
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);

            while(true)
            {
                Console.Clear();
                string opcao = telaPrincipal.ApresentarMenu();

                if (opcao == "s")
                {
                    break;
                }

                if (opcao == "1")
                {
                    string subMenu = telaGarcom.MostrarMenu();
                    {
                        if (subMenu == "1")
                        {
                            telaGarcom.Cadastrar();
                        }
                        else if (subMenu == "2")
                        {
                            telaGarcom.VisualizarRegistros();
                        }
                        else if (subMenu == "3")
                        {
                            telaGarcom.Editar();
                        }
                        else if (subMenu == "4")
                        {
                            telaGarcom.Excluir();
                        }
                        continue;
                    }
                }
                if (opcao == "2")
                {
                    string subMenu = telaProduto.MostrarMenu();
                    {
                        if (subMenu == "1")
                        {
                            telaProduto.Cadastrar();
                        }
                        else if (subMenu == "2")
                        {
                            telaProduto.VisualizarRegistros();
                        }
                        else if (subMenu == "3")
                        {
                            telaProduto.Editar();
                        }
                        else if (subMenu == "4")
                        {
                            telaProduto.Excluir();
                        }
                        continue;
                    }
                }
                if (opcao == "3")
                {
                    string subMenu = telaMesa.MostrarMenu();
                    {
                        if (subMenu == "1")
                        {
                            telaMesa.Cadastrar();
                        }
                        else if (subMenu == "2")
                        {
                            telaMesa.VisualizarRegistros();
                        }
                        else if (subMenu == "3")
                        {
                            telaMesa.Editar();
                        }
                        else if (subMenu == "4")
                        {
                            telaMesa.Excluir();
                        }
                        continue;
                    }
                }
            }
        }
    }
}