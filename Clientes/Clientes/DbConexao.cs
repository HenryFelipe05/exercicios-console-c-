using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    public static class DbConexao
    {
        public static SqlConnection AbrirConexao(string stringDeConexao)
        {
            var conexao = new SqlConnection(stringDeConexao);
            conexao.Open();
            return conexao;
        }
    }
}
