using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDL_ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu sexo (M = Masculino e F = Feminino: ");
            char sexo = Char.ToUpper(Console.ReadLine()[0]);

            double R = peso / (altura * altura);

            if (sexo == 'F')
            {
                if (R < 19)
                    Console.WriteLine("Abaixo do peso");
                else if (R >= 19 && R < 24)
                    Console.WriteLine("Peso ideal");
                else
                    Console.WriteLine("Acima do peso");        
            }
            else if (sexo == 'M')
            {
                if (R < 20)
                    Console.WriteLine("Abaixo do peso");
                else if (R >= 20 && R < 25)
                    Console.WriteLine("Peso ideal");
                else
                    Console.WriteLine("Acima do peso");

            }
            else
            {
                Console.WriteLine("Sexo invalido");
            }
            Console.ReadKey();
               



            





        }
    }
}
