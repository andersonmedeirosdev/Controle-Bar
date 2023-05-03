using ControleBar.ConsoleApp.ModuloConta;
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
            RepositorioConta repositorioConta = new RepositorioConta();
            TelaConta telaConta = new TelaConta(repositorioConta, repositorioMesa, repositorioGarcom, repositorioProduto);

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
                else if (opcao == "2")
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
                else if (opcao == "3")
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
                else if (opcao == "4")
                {
                    string subMenu = telaConta.MostrarMenu();
                    {
                        if (subMenu == "1")
                        {
                            telaConta.Cadastrar();
                        }
                        else if (subMenu == "2")
                        {
                            telaConta.RealizarPedido();
                        }
                        else if (subMenu == "3")
                        {
                            telaConta.VisualizarRegistros();
                        }
                        else if (subMenu == "4")
                        {
                            telaConta.VisualizarFaturamento();
                        }
                        else if (subMenu == "5")
                        {
                            telaConta.FecharConta();
                        }
                        continue;
                    }
                }
            }
        }
    }
}