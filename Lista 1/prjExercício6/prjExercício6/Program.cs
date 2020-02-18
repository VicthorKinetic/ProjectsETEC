using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            double resultado;

            a = 0; b = 0; c = 0; d = 0; resultado = 0;

            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Digite o último número: ");
            d = int.Parse(Console.ReadLine());

            resultado = a + b + c + d;
            resultado = resultado / 2;
            Console.Write("Seu resultado será = " + resultado.ToString());

            Console.ReadKey();
        }
    }
}
