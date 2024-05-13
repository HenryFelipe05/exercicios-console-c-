using System;

namespace ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            RealizarReajusteSalarial();
        }

        public static void RealizarReajusteSalarial()
        {
            double salarioAtual = RecuperarSalario();
            double salarioReajustado;

            if (salarioAtual < 1700)
            {
                salarioReajustado = salarioAtual + 300;
            }
            else
            {
                salarioReajustado = salarioAtual + 200;
            }

            ExibirSalarioReajustado(salarioReajustado);
        }

        public static double RecuperarSalario()
        {
            Console.Clear();

            Console.Write("Informe o slário atual: ");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());

            return salarioAtual;
        }

        public static void ExibirSalarioReajustado(double salarioReajustado)
        {
            Console.WriteLine($"\nO salario reajustado é de {salarioReajustado}");

            Console.ReadKey();
        }
    }
}
