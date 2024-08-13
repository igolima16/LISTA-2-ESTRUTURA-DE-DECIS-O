using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDL_ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double arearet, baseret, alturaret;

            Console.WriteLine("Digite a base do retangulo");
            baseret = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retangulo");
            alturaret = double.Parse(Console.ReadLine());

            arearet = baseret * alturaret;

            if (arearet > 100)
            { 
                Console.WriteLine("O terreno é grande pois o valor da area é de: "+ arearet);
            }
            else
            {
                Console.WriteLine("O terreno é pequeno pois o valor da area é de: " + arearet);
            }

            Console.ReadKey();
        }
    }
}
