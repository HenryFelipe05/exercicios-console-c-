using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos -> 10s = 10 segundos");
            Console.WriteLine("M - Minutos -> 10m = 10 minutos");
            Console.WriteLine("0 - Sair");
            Console.Write("\nDigite o tempo que deseja contar: ");

            string dados = Console.ReadLine().ToLower();

            char tipo = Convert.ToChar(dados.Substring(dados.Length - 1, 1));

            int tempo = Convert.ToInt32(dados.Substring(0, dados.Length - 1));

            int multiplicador = 1;

            if (tipo == 'm')
                multiplicador = 60;

            if (tempo == 0)
                System.Environment.Exit(0);

            PreInicio(tempo * multiplicador);
        }

        static void PreInicio(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Pontos...");
            Thread.Sleep(1000);
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Iniciando Cronômetro...");
            Thread.Sleep(2000);

            Inicio(tempo);
        }

        static void Inicio(int tempo)
        {
            int currentTime = 0;

            while (currentTime != tempo + 1)
            {
                Console.Clear();

                Console.WriteLine($"Cronômetro: {currentTime}");
                currentTime++;

                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("\nCronômetro finalizado...");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
