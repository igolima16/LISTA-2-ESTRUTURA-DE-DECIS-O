using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDL_ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, relação;

            Console.WriteLine("Digite sua altura");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso");
            peso = double.Parse(Console.ReadLine());

            relação = altura / (peso * peso);

            if (relação < 20)
            {
                Console.WriteLine("abaixo do peso");
            }
            else if (relação >= 20 && relação < 25)
            {
                Console.WriteLine("peso ideal");
            }
            else
            {
                Console.WriteLine("acima do peso");
            }

            Console.ReadKey();  
        }
    }
}
