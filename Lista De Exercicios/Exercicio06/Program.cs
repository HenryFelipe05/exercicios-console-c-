using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro número: ");
            double primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInforme o segundo número: ");
            double segundoNumero = Convert.ToInt32(Console.ReadLine());

            double quociente = CalcularQuociente(primeiroNumero, segundoNumero);
            double resto = CalcularResto(primeiroNumero, segundoNumero);

            Console.Clear();

            Console.WriteLine($"Quociente: {quociente}");
            Console.WriteLine($"Resto: {resto}");

            Console.ReadKey();
        }

        private static double CalcularQuociente(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }

        private static double CalcularResto(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero % segundoNumero;
        }
    }
}
