using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    class Program
    {
        const string stringDeConexao = "Data Source=192.168.1.10;Initial Catalog=ClientesDapperTeste;Persist Security Info=True;User ID=sa;Password=projet@ftech;MultipleActiveResultSets=True;Max Pool Size=400;";
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("1 - Exibir clientes cadastrados");
                Console.WriteLine("2 - Cadastrar novo cliente");
                Console.WriteLine("3 - Atualizar cliente cadastrado");
                Console.WriteLine("4 - Deletar cliente cadastrado");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("--------------------------");
                Console.Write("\nSelecione uma opção: ");

                ushort opcao = Convert.ToUInt16(Console.ReadLine());

                switch (opcao)
                {
                    case 1: ExibirClientesCadastrados(); break;

                    case 2: CadastrarNovoCliente(); break;

                    case 3: AtualizarClienteCadastrado(); break;

                    case 4: DeletarClienteCadastrado(); break;

                    case 5: System.Environment.Exit(0); break;

                    default: Menu(); break;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Erro: {ex.Message}");
                Console.ReadKey();

                Menu();
            }
        }

        static void CadastrarNovoCliente()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\tAdicionar Novo CLiente");
                Console.WriteLine("\t----------------------");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("\nCPF: ");
                string cpf = Console.ReadLine();

                Console.Write("\nTelefone: ");
                string telefone = Console.ReadLine();

                Console.Write("\nEmail: ");
                string email = Console.ReadLine();

                Cliente cliente = new Cliente
                {
                    Nome = nome,
                    CPF = cpf,
                    Telefone = telefone,
                    Email = email
                };

                AdicionarCliente(cliente);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Erro: {ex.Message}");
                Console.ReadKey();

                Menu();
            }
        }

        static void ExibirClientesCadastrados()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Clientes Cadastrados");
                Console.WriteLine("---------------------");

                ExibirClientes();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Erro: {ex.Message}");
                Console.ReadKey();

                Menu();
            }
        }

        static void AtualizarClienteCadastrado()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\tAtualizar Cliente");
                Console.WriteLine("\t----------------------");

                Console.Write("Digite o ID do cliente que deseja alterar: ");
                int idCliente = Convert.ToInt32(Console.ReadLine());

                if (!VerificarSeIdExiste(idCliente))
                {
                    Console.Clear();
                    Console.WriteLine($"Cliente com o ID [{idCliente}] não foi encontrado em nosso banco de dados.");
                    Console.ReadKey();

                    Menu();
                }

                Console.Clear();
                Console.WriteLine("Dados do cliente");
                Console.WriteLine("----------------------");
                ExibirClientePorId(idCliente);

                Console.Write("\nNome: ");
                string nome = Console.ReadLine();

                Console.Write("\nCPF: ");
                string cpf = Console.ReadLine();

                Console.Write("\nTelefone: ");
                string telefone = Console.ReadLine();

                Console.Write("\nEmail: ");
                string email = Console.ReadLine();

                Cliente cliente = new Cliente
                {
                    Nome = nome,
                    CPF = cpf,
                    Telefone = telefone,
                    Email = email
                };

                AtualizarCliente(cliente, idCliente);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Erro: {ex.Message}");
                Console.ReadKey();

                Menu();
            }
        }
        
        static void DeletarClienteCadastrado()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\tDeletar Cliente");
                Console.WriteLine("\t----------------------");

                Console.Write("Digite o ID do cliente que deseja deletar: ");
                int idCliente = Convert.ToInt32(Console.ReadLine());

                if (!VerificarSeIdExiste(idCliente))
                {
                    Console.Clear();
                    Console.WriteLine($"Cliente com o ID [{idCliente}] não foi encontrado em nosso banco de dados.");
                    Console.ReadKey();

                    Menu();
                }

                Console.Clear();
                Console.WriteLine("Dados do cliente");
                Console.WriteLine("----------------------");
                ExibirClientePorId(idCliente);

                Console.Write("\nDeseja deletar o cliente? [s/n]: ");
                char opcao = Convert.ToChar(Console.ReadLine().ToLower());

                switch (opcao)
                {
                    case 's': DeletarCliente(idCliente); break;

                    case 'n': Menu(); break;

                    default: DeletarClienteCadastrado(); break;
                }
            }
            catch ( Exception ex )
            {
                Console.Clear();
                Console.WriteLine($"Erro: {ex.Message}");
                Console.ReadKey();

                Menu();
            }
        }

        public static void ExibirClientes()
        {
            ClienteDao clienteDao = new ClienteDao();

            using (SqlConnection conexao = DbConexao.AbrirConexao(stringDeConexao))
            {
                try
                {
                    clienteDao.ConsultarTodosOsClientes(conexao);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.ReadKey();

                    Menu();
                }
            }

            Console.ReadKey();

            Menu();
        }

        public static void ExibirClientePorId(int idCliente)
        {
            ClienteDao clienteDao = new ClienteDao();

            using (SqlConnection conexao = DbConexao.AbrirConexao(stringDeConexao))
            {
                try
                {
                    clienteDao.ConsultarClientePorId(conexao, idCliente);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.ReadKey();

                    Menu();
                }
            }
        }

        public static void AdicionarCliente(Cliente cliente)
        {
            ClienteDao clienteDao = new ClienteDao();

            using (SqlConnection conexao = DbConexao.AbrirConexao(stringDeConexao))
            {
                try
                {
                    clienteDao.AdicionarNovoCliente(conexao, cliente);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.ReadKey();

                    Menu();
                }
            }

            Console.Clear();
            Console.WriteLine("Cliente cadastrado com sucesso!");
            Console.ReadKey();

            Menu();
        }

        public static void AtualizarCliente(Cliente cliente, int idCliente)
        {
            ClienteDao clienteDao = new ClienteDao();

            using (SqlConnection conexao = DbConexao.AbrirConexao(stringDeConexao))
            {
                try
                {
                    clienteDao.AtualizarClienteExistente(conexao, cliente, idCliente);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.ReadKey();

                    Menu();
                }
            }

            Console.Clear();
            Console.WriteLine("Cliente atualizado com sucesso!");
            Console.ReadKey();

            Menu();
        }

        public static void DeletarCliente(int idCliente)
        {
            ClienteDao clienteDao = new ClienteDao();

            using (SqlConnection conexao = DbConexao.AbrirConexao(stringDeConexao))
            {
                try
                {
                    clienteDao.DeletarClienteExistente(conexao, idCliente);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.ReadKey();

                    Menu();
                }
            }

            Console.Clear();
            Console.WriteLine("Cliente deletado com sucesso!");
            Console.ReadKey();
            Menu();
        }

        public static bool VerificarSeIdExiste(int idCliente)
        {
            bool resposta = false;

            ClienteDao clienteDao = new ClienteDao();

            using (SqlConnection conexao = DbConexao.AbrirConexao(stringDeConexao))
            {
                try
                {
                    if(clienteDao.IdExiste(conexao, idCliente))
                        resposta = true;
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.ReadKey();

                    Menu();
                }
            }

           return resposta;
        }
    }
}
