using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício1
{
    class Program
    {
        static void Main(string[] args)
        {int h;
         int b;
         int resultado;

          h = 1;
          b = 1;
          resultado = 1;

          Console.Write("Digite a altura: ");
          h = int.Parse(Console.ReadLine());

          Console.Write("Digite a base: ");
          b = int.Parse(Console.ReadLine());

          resultado = h * b;
          Console.Write("A área do retangulo é igual a: " + resultado.ToString());
          Console.ReadKey();
        }
    }
}
