using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício17
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double x;

            a = 1;
            x = 1;

            Console.Write("Insira um número para ser a base da potência: ");
                a = double.Parse (Console.ReadLine());

                Console.Write("Insira o número que a base sera elevada: ");
                x = double.Parse(Console.ReadLine());

                Console.Write("O resultado será igual a: " + Math.Pow(a, x).ToString());
           Console.ReadKey();




        }
    }
}
