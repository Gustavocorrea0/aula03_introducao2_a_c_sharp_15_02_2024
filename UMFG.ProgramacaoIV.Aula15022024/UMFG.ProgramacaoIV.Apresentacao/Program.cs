using UMFG.ProgramacaoIV.Dominio.Entidades;
using UMFG.ProgramacaoIV.Dominio.Extensoes.Servico;
using UMFG.ProgramacaoIV.Dominio.Extensoes.Servicoes;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Program
    {

        // _ ANTES DE VARIAVEIS DE ESCOPO GLOBAL

        private const string C_USUARIO_PADRAO = "padrao@umfg.edu.br";

        private static IClienteServico _servico = new ClienteServico();

        static void Main(string[] args)
        {
            
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|              Menu             |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("| 1 - Cadastrar Cliente         |");
            Console.WriteLine("| 2 - Listar Clientes           |");
            Console.WriteLine("| 3 - Consultar Cliente por CPF |");
            Console.WriteLine("| 4 - Sair                      |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("| > Qual opção desejada:        ");
            var operacao = Console.ReadLine();

            switch (operacao.ToString()) 
            {
                case "1":
                    try
                    {
                        Console.WriteLine("+-----------------------------+");
                        Console.WriteLine("| > Informe o nome do Cliente: ");
                        var nome = Console.ReadLine();

                        Console.WriteLine("+-----------------------------+");
                        Console.WriteLine("| > Informe o CPF do Cliente:");
                        var cpf = Console.ReadLine();

                        var cliente = new Cliente(nome, cpf, C_USUARIO_PADRAO, C_USUARIO_PADRAO);
                        _servico.adicionar(cliente);

                        Console.WriteLine("+-------------------------------+");
                        Console.WriteLine("|      CADASTRO CONFIRMADO      |");
                        Console.WriteLine("+-------------------------------+");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "2":
                    try 
                    {
                        foreach (var item in _servico.obterTodos()) ;
                        Console.WriteLine("+-------------------------------+");
                        Console.WriteLine("|          CLIENTES             |");
                        Console.WriteLine(_servico.ToString);

                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    } finally
                    {
                        
                    }
                    break; 
                case "3":
                    try
                    {
                        Console.WriteLine("+-----------------------------+");
                        Console.WriteLine("| > Informe o CPF do Cliente:");
                        var cpf = Console.ReadLine();
                        Console.WriteLine(_servico.ObterCpf(Console.ReadLine())) ;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("+-----------------------------+");
                        Console.WriteLine("|       Voltando ao menu      |");
                    }
                    break;
                case "4":
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("|           Até mais          |");
                    break;
                default:
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("|  Opção inválida! Verifique  |");
                    break;
            }


        }
    }
}