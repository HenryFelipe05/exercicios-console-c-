using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int idadeEmMeses = ConverterIdadeEmMeses(idade);
            int idadeEmDias = ConverterIdadeEmDias(idade);

            Console.Clear();

            Console.WriteLine($"Idade em anos: {idade} anos");
            Console.WriteLine($"Idade em anos: {idadeEmMeses} meses");
            Console.WriteLine($"Idade em anos: {idadeEmDias} dias");

            Console.ReadKey();
        }

        private static int ConverterIdadeEmMeses(int idade)
        {
            int idadeEmMeses = (idade * 12);

            return idadeEmMeses;
        }

        private static int ConverterIdadeEmDias(int idade)
        {
            int idadeEmDias = (idade * 365);

            return idadeEmDias;
        }
    }
}
