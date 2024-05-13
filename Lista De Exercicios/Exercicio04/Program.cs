using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro lado do triângulo: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nInforme o segundo lado do triângulo: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nInforme o terceiro lado do triângulo: ");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            double perimetro = CalcularPerimetroDoTriangulo(ladoA, ladoB, ladoC);

            Console.WriteLine($"\nO perímetro do triângulo é: {perimetro}");

            Console.ReadKey();
        }

        private static double CalcularPerimetroDoTriangulo(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA + ladoB + ladoC);
        }
    }
}
