using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        const double pi = Math.PI;

        static void Main(string[] args)
        {
            Console.Write("Informe o raio da circunferência: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double area = CalcularAreaDoRaio(raio);

            double perimetro = CalcularPerimetroDoRaio(raio);

            Console.WriteLine($"\nA área do quadrado é: {area}");
            Console.WriteLine($"\nO perímetro do quadrado é: {perimetro}");

            Console.ReadKey();
        }

        private static double CalcularAreaDoRaio(double raio)
        {
            return pi * Math.Pow(raio, 2);
        }

        private static double CalcularPerimetroDoRaio(double raio)
        {
            return 2 * pi * raio;
        }
    }
}
