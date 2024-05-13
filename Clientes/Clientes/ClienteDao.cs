using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    public class ClienteDao
    {
        public void ConsultarTodosOsClientes(SqlConnection conexao)
        {
            #region [ Comando Consulta ]
            var comando = "SELECT * FROM Cliente";
            #endregion

            var clientes = conexao.Query<Cliente>(comando).ToList();

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Id: {cliente.IdCliente}");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.CPF}");
                Console.WriteLine($"Telefone: {cliente.Telefone}");
                Console.WriteLine($"Email: {cliente.Email}");
                Console.WriteLine("---------------------");
            }
        }

        public void ConsultarClientePorId(SqlConnection conexao, int idCliente)
        {
            #region [ Comando Consulta ]
            var comando = "SELECT TOP(1) * FROM Cliente WHERE IdCliente = @idCliente";
            #endregion

            var cliente = conexao.QueryFirstOrDefault<Cliente>(comando, new { idCliente });

            if (cliente != null)
            {
                Console.WriteLine($"Id: {cliente.IdCliente}");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.CPF}");
                Console.WriteLine($"Telefone: {cliente.Telefone}");
                Console.WriteLine($"Email: {cliente.Email}");
                Console.WriteLine("---------------------");
            }
            else
            {
                Console.WriteLine($"Cliente com o ID [{idCliente}] não foi encontrado em nosso banco de dados.");
            }
        }

        public void AdicionarNovoCliente(SqlConnection conexao, Cliente cliente)
        {
            #region [ Comando Insert ]
            conexao.Insert(new Cliente
            {
                Nome = cliente.Nome,
                CPF = cliente.CPF,
                Telefone = cliente.Telefone,
                Email = cliente.Email
            });
            #endregion 
        }

        public void AtualizarClienteExistente(SqlConnection conexao, Cliente cliente, int idCliente)
        {
            #region [ Comando Update ]
            conexao.Update(new Cliente
            {
                IdCliente = idCliente,
                Nome = cliente.Nome,
                CPF = cliente.CPF,
                Telefone = cliente.Telefone,
                Email = cliente.Email
            });
            #endregion
        }

        public void DeletarClienteExistente(SqlConnection conexao, int idCliente)
        {
            #region [ Comando Delete ]
            conexao.Delete(new Cliente
            {
                IdCliente = idCliente
            });
            #endregion
        }

        public bool IdExiste(SqlConnection conexao, int idCliente)
        {
            #region [ Comando Consulta ]
            var comando = "SELECT COUNT(*) FROM Cliente WHERE IdCliente = @idCliente";
            #endregion

            int count = conexao.ExecuteScalar<int>(comando, new { idCliente });

            bool resposta = count > 0;

            return resposta;
        }
    }
}
