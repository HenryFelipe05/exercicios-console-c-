using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pizza
    {
        public string Sabor { get; set; }
        public double Preco { get; set; }

        public Pizza(string sabor, double preco)
        {
            Sabor = sabor;
            Preco = preco;  
        }
    }
}
