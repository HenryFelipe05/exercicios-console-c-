using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularBaseDoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o comprimento do retângulo: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite a altura do retângulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = CalcularAreaDoRetangulo(comprimento, altura);

            Console.WriteLine($"\nA área do retangulo é: {area}");

            Console.ReadLine();
        }

        private static double CalcularAreaDoRetangulo(double comprimento, double altura)
        {
            return comprimento * altura;
        }
    }
}
