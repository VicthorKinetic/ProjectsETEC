using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício9
{
    class Program
    {
        static void Main(string[] args)
        {
            int I;
            int R;
            int V;

            I = 1;
            R = 1;
            V = 1;

            Console.Write("Digite o valor da resistência : ");
            R = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da corrente elétrica : ");
            I = int.Parse(Console.ReadLine());

            V = I * R;

            Console.Write("O valor da tensão é igual a: " + V.ToString());
            Console.ReadKey();
        }
    }
}
