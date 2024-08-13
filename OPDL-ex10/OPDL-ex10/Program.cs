using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDL_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite a nota da P1: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da P2: ");
            double p2 = Convert.ToDouble(Console.ReadLine());

            
            double media = (p1 + 2 * p2) / 3;

            
            Console.WriteLine($"Média do aluno: {media:F2}");

            
            if (media >= 5.0)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
            }
        }
    }
}
