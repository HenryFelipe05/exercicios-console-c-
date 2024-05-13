using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número e veja o seu sucessor: ");
            long numeroEscolhido = Convert.ToInt64(Console.ReadLine());

            long sucessorDoNumeroEscolhido = AcharNumeroSucessor(numeroEscolhido);

            Console.Clear();

            Console.WriteLine($"O sucessor de {numeroEscolhido} é {sucessorDoNumeroEscolhido}");

            Console.ReadKey();
        }

        private static long AcharNumeroSucessor(long numeroEscolhido)
        {
            return numeroEscolhido + 1;
        }
    }
}
