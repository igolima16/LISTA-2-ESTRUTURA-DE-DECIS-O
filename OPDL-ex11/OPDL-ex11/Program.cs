using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDL_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite a nota da P1: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            double mediaAprovacao = 5.0;
          
            double p2Necessaria = (3 * mediaAprovacao - p1) / 2;
           
            Console.WriteLine($"Para ser aprovado, você precisa tirar pelo menos {p2Necessaria:F2} na P2.");

            Console.ReadKey();
        }
    }
}
