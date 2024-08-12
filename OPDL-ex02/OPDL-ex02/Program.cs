using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDL_ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2;

            Console.WriteLine("digite abaixo os valores que deseja comparar.");

            Console.WriteLine("Digite o primeiro valor");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            valor2 = double.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("O primeiro valor é maior!");

            }
            else
            if (valor2 > valor1) 
            {
                Console.WriteLine("O segundo valor é maior");
         
            }
            else 
            {
                Console.WriteLine("Os numeros são iguais");

            }

            Console.ReadKey();

           





        }
    }
}
