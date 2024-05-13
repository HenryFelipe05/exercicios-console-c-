using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoDeComissao
{
    class Program
    {
        static void Main(string[] args)
        {
            RecuperarDadosPecaVendedor();
        }

        public static void RecuperarDadosPecaVendedor()
        {
            Console.Clear();

            Console.Write("Informe o nome do vendedor: ");
            string nomeVendedor = Console.ReadLine();

            Console.Write("Informe o código da peça: ");
            ushort codigoPeca = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Informe o preço unitario da peça: ");
            double precoUnitarioPeca = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a quantidade de peças vendidas: ");
            ushort quantidadeDePecasVendidas = Convert.ToUInt16(Console.ReadLine());

            CalcularComissao(codigoPeca, precoUnitarioPeca, quantidadeDePecasVendidas);
        }

        public static void CalcularComissao(ushort codigoPeca, double precoUnitarioPeca, ushort quantidadeDePecasVendidas)
        {
            double totalDaVenda = (quantidadeDePecasVendidas * precoUnitarioPeca);

            double valorComissao = (totalDaVenda * 0.05);

            ExibirDados(totalDaVenda, valorComissao);
        }

        public static void ExibirDados(double totalDaVenda, double valorComissao)
        {
            Console.Clear();

            Console.WriteLine($"Valor total da venda: {totalDaVenda.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Valor da comissão: {valorComissao.ToString("C", CultureInfo.CurrentCulture)}");

            Console.ReadKey();
        }
    }
}
