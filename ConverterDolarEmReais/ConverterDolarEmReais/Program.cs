using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterDolarEmReais
{
    class Program
    {
        static void Main(string[] args)
        {
            LerCotacaoValorDolar();
        }

        public static void LerCotacaoValorDolar()
        {
            Console.Write("Informe a cotação do Dolar $ ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Informe um valor em Dolar $ ");
            double valorEmoDolar = Convert.ToDouble(Console.ReadLine());

            ConverterDolarEmReais(cotacaoDolar, valorEmoDolar);
        }

        public static void ConverterDolarEmReais(double cotacaoDolar, double valorEmDolar)
        {
            double valorConvertidoEmReais;

            valorConvertidoEmReais = valorEmDolar * cotacaoDolar;

            ExibirResultados(cotacaoDolar, valorEmDolar, valorConvertidoEmReais);
        }

        public static void ExibirResultados(double cotacaoDolar, double valorEmDolar, double valorConvertidoEmReais)
        {
            Console.Clear();

            NumberFormatInfo culturaAmericanaFormato = new CultureInfo("en-US", false).NumberFormat;

            Console.WriteLine($"Cotação atual do Dolar: $1.00 = {cotacaoDolar.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Valor em Dolar: {valorEmDolar.ToString("C", culturaAmericanaFormato)}");
            Console.WriteLine($"Valor convertido para Reais: {valorConvertidoEmReais.ToString("C", CultureInfo.CurrentCulture)}");

            Console.ReadKey();
        }
    }
}
