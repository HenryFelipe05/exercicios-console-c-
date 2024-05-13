using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho do lado do quadrado: ");
            double ladoDoQuadrado = Convert.ToDouble(Console.ReadLine());

            double area = CalcularAreaDoQuadrado(ladoDoQuadrado);

            double perimetro = CalcularPerimetroDoQuadrado(ladoDoQuadrado);

            Console.WriteLine($"\nA área do quadrado é: {area}");
            Console.WriteLine($"\nO perímetro do quadrado é: {perimetro}");

            Console.ReadKey();
        }

        private static double CalcularAreaDoQuadrado(double ladoDoQuadrado)
        {
            return Math.Pow(ladoDoQuadrado, 2);
        }

        private static double CalcularPerimetroDoQuadrado(double ladoDoQuadrado)
        {
            return 4 * ladoDoQuadrado;
        }
    }
}
