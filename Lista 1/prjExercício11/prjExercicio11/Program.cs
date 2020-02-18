using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double d;
            double a;

            a = 1; r = 1; d = 1;

            Console.Write("Insira o diâmetro: ");
            d = double.Parse(Console.ReadLine());
            r = d/2;

            a = 3.14 * r * r;

            Console.Write("A área do círculo é igual a: " + a.ToString());
            Console.ReadKey();

        }
    }
}
