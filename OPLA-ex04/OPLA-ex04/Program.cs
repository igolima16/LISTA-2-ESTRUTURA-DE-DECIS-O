using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPLA_ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseret, alturaret, arearet;

            Console.WriteLine("Digite a base do retangulo: ");
            baseret = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retangulo: ");
            alturaret = double.Parse(Console.ReadLine());

            arearet = baseret*alturaret;

            if (arearet > 100)
            {
                Console.WriteLine("O terreno é grande");

            }

            else
            {
                Console.WriteLine("O terreno é pequeno");
            }

            Console.ReadKey();
        }
    }
}
