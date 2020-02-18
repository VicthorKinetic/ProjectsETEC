using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double h;
            double v;

            v = 1; h = 1; r = 1;

            Console.Write("Digite o raio da base: ");
            r = double.Parse(Console.ReadLine());

            Console.Write("Insira a altura: ");
            h = double.Parse(Console.ReadLine());
            v = (3.14 * r * r * h) / 3;

            Console.Write("O volume é igual a: " + v.ToString());
            Console.ReadKey();



        }
    }
}
