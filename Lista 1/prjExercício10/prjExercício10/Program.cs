using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício10
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            double F;

            C = 1;
            F = 1;

            Console.Write("Digite a temperatura em graus Celsius: ");
                C = int.Parse(Console.ReadLine());

                F = C * 1.8 + 32;
                Console.Write("A sua temperatura em graus Fahrenheit é de: " + F.ToString());
            Console.ReadKey();




        }
    }
}
