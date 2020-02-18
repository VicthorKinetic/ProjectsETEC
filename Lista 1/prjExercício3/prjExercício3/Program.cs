using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício3
{
    class Program
    {
        static void Main(string[] args)
        {double d;
         double resultado;

         d = 1;
         resultado = 1;

         Console.Write("Digite a diagonal: ");
         d = int.Parse(Console.ReadLine ());
         resultado = (d * d)/2;
         Console.Write("A área do quadrado é: " + resultado.ToString());
         Console.ReadKey();
        }
    }
}
