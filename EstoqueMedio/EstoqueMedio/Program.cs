using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            DefinirQuantidadeEstoque();
        }

        public static void DefinirQuantidadeEstoque()
        {
            Console.Write("Informe a quantidade miníma do estoque: ");
            double quantidadeMinima = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nInforme a quantidade máxima do estoque: ");
            double quantidadeMaxima = Convert.ToDouble(Console.ReadLine());

            CalcularEstoqueMedio(quantidadeMinima, quantidadeMaxima);
        }

        public static void CalcularEstoqueMedio(double quantidadeMinima, double quantidadeMaxima)
        {
            Console.Clear();

            double estoqueMedio;
            estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;

            Console.WriteLine($"Estoque Médio: {estoqueMedio}");

            Console.ReadKey();
        }
    }
}
