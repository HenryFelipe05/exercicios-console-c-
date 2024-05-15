using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Program
	{
		static void Main(string[] args)
		{
			var carrinho = new Dictionary<Pizza, int>();
			var totalPedido = 0.0;

			List<Pizza> pizzas = new List<Pizza>();
			pizzas.Add(new Pizza("Mussarela", 25));
			pizzas.Add(new Pizza("Frango", 28));
			pizzas.Add(new Pizza("Calabreza", 23));

			int opcaoSelecionada = 0;

			do
			{
				Console.Clear();
				Console.WriteLine("\t\t\t\t\t\t\tBem-vindo à Pizzaria!\n");
				Console.WriteLine("Nossos sabores disponíveis são:\n");

				foreach (var pizza in pizzas)
				{
					int i = pizzas.IndexOf(pizza) + 1;
					Console.WriteLine($"{i} - {pizza.Sabor} R${pizza.Preco}");
				}
				Console.WriteLine("");

				Console.Write("Selecione o sabor (ou digite 0 para finalizar o pedido): ");
				opcaoSelecionada = int.Parse(Console.ReadLine());

				if (opcaoSelecionada > 0 && opcaoSelecionada <= pizzas.Count)
				{
					var pizzaSelecionada = pizzas[opcaoSelecionada - 1];
					if (carrinho.ContainsKey(pizzaSelecionada))
					{
						carrinho[pizzaSelecionada]++;
					}
					else
					{
						carrinho.Add(pizzaSelecionada, 1);
					}
					totalPedido += pizzaSelecionada.Preco;
					Console.Clear();
					Console.WriteLine($"Pizza {pizzaSelecionada.Sabor} adicionada ao carrinho.");
					Thread.Sleep(1000);
				}
				else if (opcaoSelecionada != 0)
				{
					Console.Clear();
					Console.WriteLine("Opção inválida. Por favor, selecione novamente.");
					Console.ReadKey();
				}

			} while (opcaoSelecionada != 0);

			Console.Clear();
			Console.WriteLine("\nItens do seu pedido:");

			foreach (var item in carrinho)
			{
				Console.WriteLine($"{item.Value}x {item.Key.Sabor} - R${item.Key.Preco}");
			}

			Console.WriteLine($"\nTotal do pedido: R${totalPedido}");

			Console.ReadKey();
		}
	}
}
