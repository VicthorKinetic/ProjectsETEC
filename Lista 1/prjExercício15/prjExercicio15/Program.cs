using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar;
            double real;

            dolar = 1; real = 1;

            Console.Write("Digite a quantidade de dolares: ");
            dolar = double.Parse(Console.ReadLine());

            real = dolar / 3.49;

            Console.Write("A quantidade em real é: " + real.ToString());
            Console.ReadKey();

        }
    }
}
